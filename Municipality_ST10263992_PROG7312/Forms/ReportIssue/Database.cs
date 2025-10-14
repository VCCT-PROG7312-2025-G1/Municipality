using Municipality_ST10263992_PROG7312.Forms.Events;
using Municipality_ST10263992_PROG7312.Tools;
using System;
using System.Windows.Forms;

namespace Municipality_ST10263992_PROG7312.Forms.ReportIssue
{
    internal class Database
    {
        private const int RecentCount = 3;
        public static Database Instance { get; } = new Database();

        private LinkedList<EventItem> events = new LinkedList<EventItem>();
        private LinkedList<Issue> issues = new LinkedList<Issue>();
        private EventSearch eventSearch;

        // Add constructor to initialize sample events
        private Database()
        {
            events = new LinkedList<EventItem>();
            issues = new LinkedList<Issue>();
            eventSearch = new EventSearch();
            
            // Add sample events
            SampleEventData.Initialize(this);
        }

        public LinkedList<Issue> GetIssues()
        {
            return issues;
        }

        public LinkedList<EventItem> GetEvents()
        {
            return events;
        }

        public void AddIssue(Issue issue)
        {
            issues.AddLast(issue);
        }
        public override string ToString()
        {
            string result = "Reported Issues:\n";
            var current = issues.First;
            while (current != null)
            {
                var issue = current.Value;
                result += $"Location: {issue.Location}, Category: {issue.Category}, Description: {issue.Description}, Reported At: {issue.ReportedAt}\n";
                current = current.Next;
            }
            return result;
        }
        public string PrintRecentIssues()
        {
            string result = "Recent Issues:\n";
            var current = issues.Last;
            int count = 0;
            while (current != null && count < RecentCount)
            {
                var issue = current.Value;
                result += $"\n\nLocation: {issue.Location}\nCategory: {issue.Category}\nDescription: {issue.Description}\nReported At: {issue.ReportedAt}\n";
                current = current.Previous;
                count++;
            }
            return result;
        }

        public void AddEvent(EventItem eventItem)
        {
            events.AddLast(eventItem);
            //eventSearch.IndexEvent(eventItem);
        }

        private string redOutLayout()
        {
            return @"======================================================== 
                                         UPCOMING EVENTS & ANNOUNCEMENTS" + "\n"+ "========================================================";
        }

        public string PrintEvents()
        {
            string result = redOutLayout(); // Now calling the local method
            var current = events.Last;
            while (current != null)
            {
                var eventItem = current.Value;
                result += $"\n\nTitle: {eventItem.Title}\nCategory: {eventItem.Category}\nDescription: {eventItem.Description}\nEvent Date: {eventItem.EventDate}\n";
                current = current.Previous;
            }
            return result;
        }

        public LinkedList<EventItem> SearchEvents(string searchTerm, EventCategory category, DateTime? searchDate = null)
        {
            return eventSearch.SearchEvents(searchTerm, category, searchDate);
        }

        public LinkedList<EventItem> GetRecommendations()
        {
            return eventSearch.GetRecommendations();
        }
    }
}
