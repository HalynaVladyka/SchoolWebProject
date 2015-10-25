using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolWebProject.Models
{
    public class Subject
    {
        public int Id {get;set;}
        public List<Teacher> Teachers { get; set; }
        public string Name { get; set; }
    }
}