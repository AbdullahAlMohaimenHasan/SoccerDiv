//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoccerDiv.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Event
    {
        public int Event_ID { get; set; }
        public int Sports_ID { get; set; }
        public int Tournament_ID { get; set; }
        public int First_Team { get; set; }
        public int Second_Team { get; set; }
        public int Venue_ID { get; set; }

        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Event_Date { get; set; }

        [DataType(DataType.Time)]
        public Nullable<System.TimeSpan> Event_Time { get; set; }
        public string Event_Details { get; set; }
    
        public virtual Team Team { get; set; }
        public virtual Team Team1 { get; set; }
        public virtual Sport Sport { get; set; }
        public virtual Tournamnet Tournamnet { get; set; }
        public virtual Venue Venue { get; set; }
    }
}
