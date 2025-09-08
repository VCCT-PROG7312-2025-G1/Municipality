using Municipality_ST10263992_PROG7312.Tools;
using System;
using System.Windows.Forms;

namespace Municipality_ST10263992_PROG7312.Forms.ReportIssue
{
    internal class Database
    {
        public static Database Instance { get; } = new Database();

        private LinkedList<Issue> issues = new LinkedList<Issue>();
        
        public LinkedList<Issue>GetIssues()
        {
            return issues;
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
    }
}
