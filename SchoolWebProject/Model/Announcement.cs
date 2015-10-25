using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolWebProject.Model
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public string BriefDescription { get; set; }
        public string Details { get; set; }

     //   public string SchoolId { get; set; }
        public School School { get; set; }

     //   public string UserId { get; set; }
        public User User { get; set; }

     //   public DateTime DataPublished { get; set; }

    }
}