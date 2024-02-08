
using Intro_Camp.Business;
using Intro_Camp.Entity;

Course course1= new Course();
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

Course[] courses = { course1, course2, course3 };
for (int i = 0; i <courses.Length; i++)
{
    Console.WriteLine(courses[i].Name+"/ " + courses[i].Price);
}


CourseManager courseManager = new CourseManager();
Course[] courses2 =courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++) {

    Console.WriteLine(courses2[i].Id);

}