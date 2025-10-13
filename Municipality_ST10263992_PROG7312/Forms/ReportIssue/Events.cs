using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipality_ST10263992_PROG7312.Forms.Events
{
    internal class EventItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime EventDate { get; set; }
        public EventItem(string title, string description,string category, DateTime eventDate)
        {
            Title = title;
            Description = description;
            Category = category;
            EventDate = eventDate;
        }
        //public override string ToString()
        //{
        //    return $"Title: {Title}, Description: {Description}, Category: {Category}, Date: {EventDate}";
        //}
        public EventItem()
        {
        }
    }
}
