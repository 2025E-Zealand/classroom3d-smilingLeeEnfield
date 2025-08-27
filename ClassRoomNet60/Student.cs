using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student: IStudent
    {
        public string Name{ get; private set; }
        public int Birtmonth{ get; private set; }
        public int Birthday { get; private set; }
        public Student(string name, int Bday, int Bmonth) 
        {
            Name=name;
            if (Bmonth < 13 && Bmonth > 0)
            {
                Birtmonth = Bmonth;
            }
            else 
            {
                Console.WriteLine(name+"s" +" birthmonth is incorrect");
            }

                Birthday = Bday;
        }

        public string BirthSeason() 
        {
            switch ((int)(Birtmonth/3)) 
            {
               case 1:
                    return "Spring";
               case 2:
                    return "Summer";
               case 3:
                    return "Fall";
               default:
                    return "Winter";
            }
        }

        public override string ToString()
        {
            
            return $"name is {Name} born in { (new DateTime(2010, Birtmonth, 1))
    .ToString("MMM", CultureInfo.InvariantCulture)} on the {Birthday}";
        }
    }
}
