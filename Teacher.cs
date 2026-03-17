using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace TankunGrade
{
    public class Teacher : Person
    {
        public Teacher(string n) : base(n)
        {
        }

        public override void show()
        {
            Console.WriteLine("อาจารย์ผู้สอน: " + name);
        }
    }
}