using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankunGrade
{
    public class Student : Person
    {
        private string id;
        private double score;

        public Student(string n, string i, double s) : base(n)
        {
            id = i;
            score = s;
        }

        public double getScore()
        {
            return score;
        }

        public string getGrade()
        {
            if (score >= 80) return "A";
            else if (score >= 75) return "B+";
            else if (score >= 70) return "B";
            else if (score >= 65) return "C+";
            else if (score >= 60) return "C";
            else if (score >= 55) return "D+";
            else if (score >= 50) return "D";
            else return "F";
        }

        public override void show()
        {
            Console.WriteLine("ชื่อ: " + name +
                              " รหัส: " + id +
                              " คะแนน: " + score +
                              " เกรด: " + getGrade());
        }
    }
}