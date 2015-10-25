using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolWebProject.Models
{
    public class School
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Adress { get; set; }
        public int Phone { get; set; }

        public List<Announcement> Announcements { get; set; }
        public List<User> Users { get; set; }
        public List<Group> Groups { get; set; }
        public List<ClassRoom> ClassRooms { get; set; }
        public List<LessonDetail> LessonDetails { get; set; }
        public List<Schedule> Schedules { get; set; }
        public List<Mark> Marks { get; set; }
    }
}