using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolWebProject.Models
{
    public class Group        
    {
        public int Id{get;set;}
        public String Name { get; set; }

        public List<Pupil> Pupils { get; set; }

        public List<Schedule> Schedules { get; set; }

       // public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

       // public string SchoolId { get; set; }
        public School School { get; set; }
    }
}