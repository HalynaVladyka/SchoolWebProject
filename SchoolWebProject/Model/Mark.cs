using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolWebProject.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public int Value { get; set; }

        // public int PupilId { get; set; }
        public Pupil Pupil { get; set; }

       // public int ScheduleId { get; set; }
        public Schedule Schedule{ get; set; }
       
        // public int MarkTypeId { get; set; }
        public MarkType MarkType { get; set; }

        public DateTime Date { get; set; }

        // public int SchoolId { get; set; }
        public School SchoolId { get; set; }

     }
}