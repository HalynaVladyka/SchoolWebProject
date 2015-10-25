using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolWebProject.Model
{
    public class Degree
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}