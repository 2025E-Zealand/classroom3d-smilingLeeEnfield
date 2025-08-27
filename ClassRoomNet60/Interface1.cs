using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public interface IStudent
    {
        public string Name { get; }
        public int Birtmonth { get;  }
        public int Birthday { get;  }

        public string BirthSeason();
    }
}
