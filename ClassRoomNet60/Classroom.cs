using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Classroom: IClassRoom
    {
        public string Name { get; private set; }
        public DateTime StartDate { get; private set; }
        
        public List<IStudent> students;
        public Classroom(string name, DateTime dt) 
        {
            Name = name;
            StartDate = dt;
            
            students = new List<IStudent>();
        }

        

        public void AddStudent(IStudent student)
        {
            if (GetStudent(student.Name) == null) students.Add(student);
        }

        public List<IStudent> GetAllStudents()
        {
            return students;
        }

        public IStudent GetStudent(string name)
        {
            return students.Find(i => i.Name == name);
        }

        public void RemoveStudent(IStudent student)
        {
            if (GetStudent(student.Name) != null) students.Remove(student);
        }

        public void UpdateStudent(IStudent student)
        {
            if (GetStudent(student.Name) != null) 
            {
                students.Remove(student);
                students.Add(student);
            } 
        }
    }

}
