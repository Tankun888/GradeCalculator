using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankunGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c = null;

            while (true)
            {
                Console.WriteLine("\n===== เมนู =====");
                Console.WriteLine("1. เปิดวิชา");
                Console.WriteLine("2. เพิ่มข้อมูลนักศึกษา");
                Console.WriteLine("3. แสดงผล");
                Console.WriteLine("พิมพ์ exit เพื่อออก");
                Console.Write("เลือก: ");
                string ch = Console.ReadLine();

                if (ch == "exit")
                {
                    break;
                }
                else if (ch == "1")
                {
                    Console.Write("ชื่อวิชา: ");
                    string cname = Console.ReadLine();

                    Console.Write("รหัสวิชา: ");
                    string cid = Console.ReadLine();

                    Console.Write("ชื่ออาจารย์: ");
                    string tname = Console.ReadLine();

                    Teacher t = new Teacher(tname);
                    c = new Course(cname, cid, t);
                }
                else if (ch == "2")
                {
                    if (c == null)
                    {
                        Console.WriteLine("กรุณาเปิดวิชาก่อน");
                        continue;
                    }

                    Console.Write("ชื่อนักศึกษา: ");
                    string name = Console.ReadLine();

                    Console.Write("รหัสนักศึกษา: ");
                    string id = Console.ReadLine();

                    Console.Write("คะแนน: ");
                    double score = Convert.ToDouble(Console.ReadLine());

                    Student s = new Student(name, id, score);
                    c.addStudent(s);
                }
                else if (ch == "3")
                {
                    if (c == null)
                    {
                        Console.WriteLine("ยังไม่มีข้อมูล");
                        continue;
                    }

                    c.showAll();
                    c.sortScore();
                    c.showMaxMin();
                    c.showAvg();
                }
                else
                {
                    Console.WriteLine("กรุณาเลือกใหม่");
                }
            }

            Console.WriteLine("จบการทำงาน");
        }
    }
}