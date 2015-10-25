using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolWebProject.Model
{
    public class ClassRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Schedule> Schedules { get; set; }
    }
}