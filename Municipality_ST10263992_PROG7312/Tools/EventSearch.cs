using Municipality_ST10263992_PROG7312.Forms.Events;
using Municipality_ST10263992_PROG7312.Forms.ReportIssue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Municipality_ST10263992_PROG7312.Tools
{
    internal class EventSearch
    {
        private Dictionary<string, HashSet<EventItem>> categoryIndex;
        private SortedDictionary<DateTime, Queue<EventItem>> dateIndex;
        private Stack<string> searchHistory;
        private const int MAX_SEARCH_HISTORY = 10;

        public EventSearch()
        {
            categoryIndex = new Dictionary<string, HashSet<EventItem>>();
            dateIndex = new SortedDictionary<DateTime, Queue<EventItem>>();
            searchHistory = new Stack<string>();
        }

        public LinkedList<EventItem> SearchEvents(string searchTerm, EventCategory category, DateTime? searchDate = null)
        {
            //MessageBox.Show($"Searching for: '{searchTerm}', Category: '{category}', Date: '{searchDate}'");
            var results = new LinkedList<EventItem>();
            var eventItems = Database.Instance.GetEvents();
            
            // Normalize search term to lower case once
            string lowerSearchTerm = !string.IsNullOrWhiteSpace(searchTerm) 
                ? searchTerm.ToLower(): null;

            foreach (var item in eventItems)
            {
                bool matchesSearch = true;

                // Check search term if provided
                if (lowerSearchTerm != null)
                {
                    matchesSearch = item.Title.ToLower().Contains(lowerSearchTerm) ||
                                  item.Description.ToLower().Contains(lowerSearchTerm);
                }

                // Check category if provided
                if (matchesSearch && category!=EventCategory.None)
                {
                    matchesSearch = item.Category == category;
                }

                // Check date if provided
                if (matchesSearch && searchDate.HasValue)
                {
                    matchesSearch = item.EventDate.Date == searchDate.Value.Date;
                }

                // Add item if it matches all provided criteria
                if (matchesSearch)
                {
                    results.AddLast(item);
                }
            }

            // Update search history
            if (!string.IsNullOrEmpty(searchTerm))
            {
                if (searchHistory.Count >= MAX_SEARCH_HISTORY)
                {
                    searchHistory.Pop();
                }
                searchHistory.Push(searchTerm.ToLower());
            }

            return results;
        }
        // Google, 2025
        public LinkedList<EventItem> GetRecommendations()
        {
            var recommendations = new LinkedList<EventItem>();
            var tempSet = new HashSet<EventItem>();
            var allEvents = Database.Instance.GetEvents();

            // Use recent search history to recommend events
            foreach (var searchTerm in searchHistory)
            {
                foreach (var eventItem in allEvents)
                {
                    // Check if the event matches the search term, is in the future, and not already added
                    bool matches = eventItem.Title.ToLower().Contains(searchTerm) ||
                                   eventItem.Description.ToLower().Contains(searchTerm);

                    if (matches && eventItem.EventDate.Date >= DateTime.Now.Date && !tempSet.Contains(eventItem))
                    {
                        tempSet.Add(eventItem);
                        recommendations.AddLast(eventItem);
                    }
                }
            }

            // Limit to 5 recommendations
            var result = new LinkedList<EventItem>();
            var current = recommendations.First;
            int count = 0;
            while (current != null && count < 5)
            {
                result.AddLast(current.Value);
                current = current.Next;
                count++;
            }

            return result;
        }

        public LinkedList<EventItem> GetUpcomingEvents(int days)
        {
            var results = new LinkedList<EventItem>();
            var allEvents = Database.Instance.GetEvents();
            var today = DateTime.Now.Date;
            var endDate = today.AddDays(days);

            foreach (var eventItem in allEvents)
            {
                if (eventItem.EventDate.Date >= today && eventItem.EventDate.Date <= endDate)
                {
                    results.AddLast(eventItem);
                }
            }

            // Sort the results by date and add to a new LinkedList
            var sortedResults = new LinkedList<EventItem>();
            foreach (var item in results.OrderBy(e => e.EventDate))
            {
                sortedResults.AddLast(item);
            }
            return sortedResults;
        }
    }
}
 