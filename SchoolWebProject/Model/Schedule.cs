using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolWebProject.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        // public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        // public int GroupId { get; set; }
        public Group Group { get; set; }

        // public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int OrderNumber { get; set; }
        public int DayOfTheWeek { get; set; }

        // public int ClassRoomId { get; set; }
        public ClassRoom ClassRoom { get; set; }

        public List<LessonDetail> LessonsDetails { get; set; }

        // public int SchoolId { get; set; }
        public School SchoolId { get; set; }
    }
}