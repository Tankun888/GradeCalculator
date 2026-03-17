using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankunGrade
{
    public abstract class Person
    {
        protected string name;

        public Person(string n)
        {
            name = n;
        }

        public abstract void show();
    }
}