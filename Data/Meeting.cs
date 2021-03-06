namespace r2bw.Data
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class Meeting
    {

        public Meeting() 
        {
            this.Attendance = new HashSet<Attendance>();
        }

        [Required]
        public int Id { get; set; }
        
        public string Name { get; set; }

        [DisplayName("Manual Headcount")]
        public int? ManualHeadcount { get; set; }

        [Required]
        [DisplayName("Date and Time")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:f}")]
        public DateTime Timestamp { get; set; }

        public bool Active { get; set; }

        [Required]
        public int GroupId { get; set; }

        public Group Group { get; set; }

        [DisplayName("Event")]
        public string DisplayName { get { return $"{Timestamp.ToString("g")} - {(Group == null ? "" : Group.Name)} - {Name}"; } }

        public ICollection<Attendance> Attendance { get; set; }

        public int Headcount { get { return this.Attendance.Where(a => a.Active).Count(); } }
    }
}