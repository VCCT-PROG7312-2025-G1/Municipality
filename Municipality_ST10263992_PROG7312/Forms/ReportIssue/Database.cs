using Municipality_ST10263992_PROG7312.Forms.Events;
using Municipality_ST10263992_PROG7312.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Municipality_ST10263992_PROG7312.Forms.ReportIssue
{
    internal class Database
    {
        private const int RecentCount = 3;
        public static Database Instance { get; } = new Database();

        private Tools.LinkedList<EventItem> events = new Tools.LinkedList<EventItem>();
        private Tools.LinkedList<Issue> issues = new Tools.LinkedList<Issue>();
        private AVLTree serviceRequests = new AVLTree();
        private MinHeap serviceRequestQueue = new MinHeap(); // Priority Queue for service requests
        private EventSearch eventSearch;

        // Graph-related fields
        private Graph serviceLocationGraph;
        private Dictionary<int, ServiceRequest> vertexToServiceRequestMap;
        private Dictionary<int, int> serviceRequestIdToVertexMap;

        
        private Database()
        {
            events = new Tools.LinkedList<EventItem>();
            issues = new Tools.LinkedList<Issue>();
            serviceRequests = new AVLTree();
            serviceRequestQueue = new MinHeap();
            eventSearch = new EventSearch();
            
            SampleEventData.Initialize(this);
            BuildServiceRequestGraph();
        }

        public void AddServiceRequest(ServiceRequest request)
        {
            serviceRequests.Insert(request);
            // Only add active requests to the priority queue
            if (request.Status != RequestStatus.Completed && request.Status != RequestStatus.Cancelled)
            {
                serviceRequestQueue.Insert(request);
            }
            BuildServiceRequestGraph(); // Rebuild graph when data changes
        }

        public ServiceRequest FindServiceRequestById(int id)
        {
            return serviceRequests.Search(id);
        }

        public void DeleteServiceRequest(int id)
        {
            var requestToRemove = serviceRequests.Search(id);
            if (requestToRemove != null)
            {
                serviceRequests.Delete(id);
                serviceRequestQueue.Remove(requestToRemove);
                BuildServiceRequestGraph(); // Rebuild graph when data changes
            }
        }

        /// <summary>
        /// Retrieves and removes the most urgent, active service request.
        /// </summary>
        /// <returns>The most urgent active ServiceRequest, or null if none are available.</returns>
        public ServiceRequest GetNextUrgentServiceRequest()
        {
            while (serviceRequestQueue.Count > 0)
            {
                var urgentRequest = serviceRequestQueue.ExtractMin();

                if (urgentRequest == null) continue; // Should not happen, but for safety

                // If the request is active, it's the one we want.
                if (urgentRequest.Status != RequestStatus.Completed && urgentRequest.Status != RequestStatus.Cancelled)
                {
                    // Also remove it from the main AVL tree to keep data consistent
                    serviceRequests.Delete(urgentRequest.Id);
                    BuildServiceRequestGraph(); // Rebuild graph
                    return urgentRequest;
                }
                // If the request was completed/cancelled, it's already removed from the heap.
                // The loop will continue to find the next most urgent active request.
            }

            return null; // No active service requests were found in the queue.
        }

        public Tools.LinkedList<ServiceRequest> GetAllServiceRequests()
        {
            var list = new Tools.LinkedList<ServiceRequest>();
            serviceRequests.InOrderTraversal(req => list.AddLast(req));
            return list;
        }

        /// <summary>
        /// Builds a graph where vertices are service requests and edges are weighted by random distances.
        /// </summary>
        private void BuildServiceRequestGraph()
        {
            var allRequests = new List<ServiceRequest>();
            var current = GetAllServiceRequests().First;
            while (current != null)
            {
                allRequests.Add(current.Value);
                current = current.Next;
            }

            int vertexCount = allRequests.Count;

            serviceLocationGraph = new Graph(vertexCount);
            vertexToServiceRequestMap = new Dictionary<int, ServiceRequest>();
            serviceRequestIdToVertexMap = new Dictionary<int, int>();

            // Map requests to vertices
            for (int i = 0; i < vertexCount; i++)
            {
                vertexToServiceRequestMap[i] = allRequests[i];
                serviceRequestIdToVertexMap[allRequests[i].Id] = i;
            }

            // Create a fully connected graph with random weights (distances)
            if (vertexCount > 1)
            {
                Random rand = new Random();
                for (int i = 0; i < vertexCount; i++)
                {
                    for (int j = i + 1; j < vertexCount; j++)
                    {
                        int distance = rand.Next(5, 100); // Random distance between 5 and 99
                        serviceLocationGraph.AddEdge(i, j, distance);
                    }
                }
            }
        }

        /// <summary>
        /// Gets the optimized route (Minimum Spanning Tree) for visiting all service request locations.
        /// </summary>
        /// <returns>A tuple containing the total distance and a list of edges in the route.</returns>
        public (int totalWeight, List<(ServiceRequest from, ServiceRequest to, int weight)> edges) GetOptimizedRoute()
        {
            if (serviceLocationGraph == null)
            {
                return (0, new List<(ServiceRequest from, ServiceRequest to, int weight)>());
            }

            var (totalWeight, mstEdges) = serviceLocationGraph.PrimMST();

            var resultEdges = new List<(ServiceRequest from, ServiceRequest to, int weight)>();
            foreach (var edge in mstEdges)
            {
                var fromRequest = vertexToServiceRequestMap[edge.u];
                var toRequest = vertexToServiceRequestMap[edge.v];
                resultEdges.Add((fromRequest, toRequest, edge.w));
            }

            return (totalWeight, resultEdges);
        }

        public Tools.LinkedList<Issue> GetIssues()
        {
            return issues;
        }

        public Tools.LinkedList<EventItem> GetEvents()
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
            return @"=================================== 
              UPCOMING EVENTS & ANNOUNCEMENTS" + "\n"+ "===================================";
        }

        public string PrintEvents()
        {
            string result = redOutLayout();
            var current = events.Last;
            while (current != null)
            {
                var eventItem = current.Value;
                result += $"\n\nTitle: {eventItem.Title}\nCategory: {eventItem.Category}\nDescription: {eventItem.Description}\nEvent Date: {eventItem.EventDate}\n";
                current = current.Previous;
            }
            return result;
        }

        public Tools.LinkedList<EventItem> SearchEvents(string searchTerm, EventCategory category, DateTime? searchDate = null)
        {
            return eventSearch.SearchEvents(searchTerm, category, searchDate);
        }

        public Tools.LinkedList<EventItem> GetRecommendations()
        {
            return eventSearch.GetRecommendations();
        }
        public Tools.LinkedList<EventItem> GetUpcomingEvents(int days)
        {
            return eventSearch.GetUpcomingEvents(days);
        }
        public string PrintUpcomingEvents(int days)
        {
            var upcomingEvents = GetUpcomingEvents(days);
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Upcoming Events:");
            result.AppendLine($"(Next {days} Days)");
            if (upcomingEvents.First == null)
            {
                result.AppendLine("\nNo upcoming events in this period.");
            }
            else
            {
                var current = upcomingEvents.First;
                while (current != null)
                {
                    var eventItem = current.Value;
                    result.AppendLine($"\nTitle: {eventItem.Title}");
                    result.AppendLine($"Date: {eventItem.EventDate:dd MMMM yyyy}");
                    current = current.Next;
                }
            }
            return result.ToString();
        }
        public string PrintServiceRequestSummary()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Active Service Requests:");

            var allRequests = new List<ServiceRequest>();
            var current = GetAllServiceRequests().First;
            while (current != null)
            {
                allRequests.Add(current.Value);
                current = current.Next;
            }

            var urgentRequests = allRequests
                .Where(r => r.Status == RequestStatus.Pending || r.Status == RequestStatus.InProgress)
                .OrderBy(r => r.Priority)
                .Take(RecentCount)
                .ToList();

            if (!urgentRequests.Any())
            {
                sb.AppendLine("\nNo active service requests.");
            }
            else
            {
                foreach (var request in urgentRequests)
                {
                    sb.AppendLine($"\nTitle: {request.Title}");
                    sb.AppendLine($"Location: {request.Location}");
                    //sb.AppendLine($"Priority: {request.Priority}");
                }
            }

            return sb.ToString();
        }
    }
    
}
