using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankunGrade
{
    public class Course
    {
        private string cname;
        private string cid;
        private Teacher teacher;
        private List<Student> students = new List<Student>();

        public Course(string n, string i, Teacher t)
        {
            cname = n;
            cid = i;
            teacher = t;
        }

        public void addStudent(Student s)
        {
            students.Add(s);
        }

        public void showAll()
        {
            Console.WriteLine("\n===== ข้อมูลรายวิชา =====");
            Console.WriteLine("ชื่อวิชา: " + cname);
            Console.WriteLine("รหัสวิชา: " + cid);
            teacher.show();

            Console.WriteLine("\nรายชื่อนักศึกษา");
            foreach (Student s in students)
            {
                s.show();
            }
        }

        public void sortScore()
        {
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = i + 1; j < students.Count; j++)
                {
                    if (students[i].getScore() < students[j].getScore())
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nเรียงคะแนนมาก -> น้อย");
            foreach (Student s in students)
            {
                s.show();
            }
        }

        public void showMaxMin()
        {
            if (students.Count == 0) return;

            double max = students[0].getScore();
            double min = students[0].getScore();

            foreach (Student s in students)
            {
                if (s.getScore() > max) max = s.getScore();
                if (s.getScore() < min) min = s.getScore();
            }

            Console.WriteLine("\nคะแนนสูงสุด: " + max);
            Console.WriteLine("คะแนนต่ำสุด: " + min);
        }

        public void showAvg()
        {
            if (students.Count == 0) return;

            double sum = 0;

            foreach (Student s in students)
            {
                sum += s.getScore();
            }

            Console.WriteLine("คะแนนเฉลี่ย: " + (sum / students.Count));
        }
    }
}