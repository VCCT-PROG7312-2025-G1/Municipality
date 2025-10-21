using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipality_ST10263992_PROG7312.Forms.ReportIssue
{
    public enum RequestStatus { Submitted, Pending, InProgress, Completed, Cancelled }
    public class ServiceRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public DateTime SubmittedAt { get; set; }
        public int Priority { get; set; }        // lower = higher priority
        public RequestStatus Status { get; set; }
        //public string Notes { get; set; }

        public ServiceRequest(int id, string title, string category, string location, DateTime submittedAt, int priority)
        {
            Id = id;
            Title = title;
            Category = category;
            Location = location;
            SubmittedAt = submittedAt;
            Priority = priority;
            Status = RequestStatus.Submitted;
        }
        public ServiceRequest()
        {
        }
    }
}
