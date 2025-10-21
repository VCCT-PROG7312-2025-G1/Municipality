using Municipality_ST10263992_PROG7312.Forms.ReportIssue;
using System;

namespace Municipality_ST10263992_PROG7312.Forms.Events
{
    internal static class SampleEventData
    {
        public static void Initialize(Database database)
        {
            // Add sample events
            database.AddEvent(new EventItem(
                "Community Clean-up Day",
                "Join us for a community-wide clean-up initiative. Bring gloves and wear comfortable clothing.",
                EventCategory.Community,
                DateTime.Now.AddDays(7)
            ));

            database.AddEvent(new EventItem(
                "Town Hall Meeting",
                "Monthly town hall meeting to discuss local development plans and community concerns.",
                EventCategory.Community,
                DateTime.Now.AddDays(14)
            ));

            database.AddEvent(new EventItem(
                "Water Infrastructure Maintenance",
                "Scheduled maintenance of water infrastructure in Central District. Temporary water interruption expected.",
                EventCategory.Community,
                DateTime.Now.AddDays(3)
            ));

            // Add more sample events
            database.AddEvent(new EventItem(
                "Community Sports Day",
                "Annual sports event featuring various activities for all age groups. Registration required.",
                EventCategory.Recreational,
                DateTime.Now.AddDays(21)
            ));

            database.AddEvent(new EventItem(
                "Emergency Response Training",
                "Mandatory training session for community emergency response team volunteers.",
                EventCategory.Health,
                DateTime.Now.AddDays(5)
            ));

            database.AddEvent(new EventItem(
                "Park Renovation Project",
                "Public consultation meeting regarding the upcoming park renovation project.",
                EventCategory.Cultural,
                DateTime.Now.AddDays(10)
            ));

            // Add sample service requests
            database.AddServiceRequest(new ServiceRequest(101, "Pothole Repair", "Roads", "123 Main St", DateTime.Now.AddDays(-5), 2) { Status = RequestStatus.Pending });
            database.AddServiceRequest(new ServiceRequest(105, "Broken Streetlight", "Electricity", "Corner of Oak & Pine", DateTime.Now.AddDays(-2), 1) { Status = RequestStatus.InProgress });
            database.AddServiceRequest(new ServiceRequest(102, "Water Leak", "Water", "456 Maple Ave", DateTime.Now.AddDays(-10), 1) { Status = RequestStatus.Completed });
            database.AddServiceRequest(new ServiceRequest(108, "Fallen Tree Branch", "Parks", "City Park, near playground", DateTime.Now.AddDays(-1), 3) { Status = RequestStatus.Pending });
            database.AddServiceRequest(new ServiceRequest(104, "Missed Garbage Collection", "Sanitation", "789 Elm St", DateTime.Now.AddDays(-3), 2) { Status = RequestStatus.Completed });
        }
    }
}