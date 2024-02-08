using Intro_Camp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Intro_Camp.Business;

public class CourseManager
{
    Course[]Courses=new Course[3];
   public CourseManager()
    {
        Course course1 = new Course();
        course1.Name = "C# ";
        course1.Description = ".Net 8";
        course1.Id = 1;
        course1.Price = 122.1;

        Course course2 = new Course();
        course2.Name = "Java ";
        course2.Description = "  ";
        course2.Id = 2;
        course2.Price = 128.1;

        Course course3 = new Course();
        course3.Name = "php ";
        course3.Description = " ";
        course3.Id = 3;
        course3.Price = 130.1;

        Courses[0]=course1;
        Courses[1]=course2;
        Courses[2]=course3;
        
    }
    public Course[] GetAll()
    {
        return Courses;
    }
}
