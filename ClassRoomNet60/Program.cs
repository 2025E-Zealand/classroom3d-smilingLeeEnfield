using ClassRoomNet60;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Classroom classroom = new Classroom("d1", DateTime.Now);
        Student s1 = new Student("peter", 23, 1);
        Student s2 = new Student("peter2", 25, 7);
        Student s3 = new Student("peter3", 27, 12);
        Student s4 = new Student("peter4", 27, 13);
        classroom.AddStudent(s1);
        classroom.AddStudent(s2);
        classroom.AddStudent(s3);
        
        foreach (IStudent IS in classroom.students) 
        {
            Console.WriteLine(IS.ToString());
            Console.WriteLine(IS.BirthSeason());

        }
        Console.WriteLine("Winter");
        IEnumerable<IStudent> IE =
            from IStudent in classroom.students where IStudent.BirthSeason() == "Winter"select IStudent;
        foreach (IStudent IS in IE) 
        {
            Console.WriteLine(IS.ToString());
        }
        Console.WriteLine("Spring");
         IE =
            from IStudent in classroom.students where IStudent.BirthSeason() == "Spring" select IStudent;
        foreach (IStudent IS in IE)
        {
            Console.WriteLine(IS.ToString());
        }
        Console.WriteLine("Summer");
         IE =
            from IStudent in classroom.students where IStudent.BirthSeason() == "Summer" select IStudent;
        foreach (IStudent IS in IE)
        {
            Console.WriteLine(IS.ToString());
        }
        Console.WriteLine("Fall");
        IE =
            from IStudent in classroom.students where IStudent.BirthSeason() == "Fall" select IStudent;
        foreach (IStudent IS in IE)
        {
            Console.WriteLine(IS.ToString());
        }



    }

   
}