using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public interface IClassRoom
    {
        public string Name { get;  }
        public DateTime StartDate{ get;  }
        public List<IStudent> GetAllStudents();
        public IStudent GetStudent(string name);
        public void AddStudent(IStudent student);
        public void RemoveStudent(IStudent student);
        public void UpdateStudent(IStudent student);

    }
}
