using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolWebProject.Model
{
    public class User
    {
        public int Id { get; set; }
      //  public int RoleId { get; set; }
        public String Login { get; set; }
        public String PasswordSalt { get; set; }
        public String PasswordHash { get; set; }
        public String FirstName { get; set;}
        public String LastName { get; set; }
        public byte[] Image { get; set; }

      //  public int SchoolId { get; set; }
        public School School { get; set; }
    }

    public class Pupil : User
    {
        
      //  public int GroupId { get; set; }
        public Group Group { get; set; }

        public List<Mark> Marks { get; set; }
    }

    public class Teacher : User
    {
      //  public string CategoryId { get; set; }
        public Category Category  { get; set; }

      //  public string DegreeId { get; set; }
        public Degree Degree { get; set; }

        public DateTime WorkBegin { get; set; }

        public List<Subject> Subjects { get; set; }
        public List<Schedule> Schedules { get; set; }

    }

    public class Parent : User
    {
        public List<Pupil> Children { get; set; }
    }
}