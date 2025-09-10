using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipality_ST10263992_PROG7312.Forms.ReportIssue
{
    // This class represents a municipal issue/complaint reported by users
    internal class Issue
    {
        // The location where the issue was reported
        public string Location { get; set; }

        // The type/category of the issue (e.g., "Water", "Electricity", etc.)
        public string Category { get; set; }

        // Detailed description of the issue
        public string Description { get; set; }

        // File path to any attached evidence (like photos)
        public string AttachmentPath { get; set; }

        // Date and time when the issue was reported
        public DateTime ReportedAt { get; set; }

        // Constructor with parameters to create a new issue with all details
        public Issue(string location, string category, string description, string attachmentPath)
        {
            Location = location;
            Category = category;
            Description = description;
            AttachmentPath = attachmentPath;
            ReportedAt = DateTime.Now;  // Automatically sets to current date/time
        }

        // Default constructor (empty) for when you need to create an issue without initial values
        public Issue() {
            
        }
    }
}
