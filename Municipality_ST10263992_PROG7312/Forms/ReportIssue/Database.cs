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

        // Add constructor to initialize sample events
        private Database()
        {
            // Add sample events
            AddEvent(new EventItem(
                "Community Clean-up Day",
                "Join us for a community-wide clean-up initiative. Bring gloves and wear comfortable clothing.",
                "Community Service",
                DateTime.Now.AddDays(7)
            ));

            AddEvent(new EventItem(
                "Town Hall Meeting",
                "Monthly town hall meeting to discuss local development plans and community concerns.",
                "Public Meeting",
                DateTime.Now.AddDays(14)
            ));

            AddEvent(new EventItem(
                "Water Infrastructure Maintenance",
                "Scheduled maintenance of water infrastructure in Central District. Temporary water interruption expected.",
                "Maintenance",
                DateTime.Now.AddDays(3)
            ));
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
            var current = issues.Head;
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
            var current = issues.Tail;
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
        }

        private string redOutLayout()
        {
            return @"========================================== 
                        UPCOMING EVENTS & ANNOUNCEMENTS"+"\n"+"==========================================";
        }

        public string PrintEvents()
        {
            string result = redOutLayout(); // Now calling the local method
            var current = events.Tail;
            int count = 0;
            while (current != null && count < RecentCount)
            {
                var eventItem = current.Value;
                result += $"\n\nTitle: {eventItem.Title}\nCategory: {eventItem.Category}\nDescription: {eventItem.Description}\nEvent Date: {eventItem.EventDate}\n";
                current = current.Previous;
                count++;
            }
            return result;
        }

    }
}
