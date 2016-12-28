using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Students> students = new List<Students>();
            students.Add(new Students() {id=100,name="Vinay",score=65});
            students.Add(new Students() { id = 101, name = "Kumar", score = 70 });
            students.Add(new Students() { id = 102, name = "Raj", score = 80 });
            students.Add(new Students() { id = 103, name = "IMCS", score = 35 });

            delegateex d1 = new delegateex(Grade.grade);
            Students.Grades(students, d1);
            Console.ReadLine();
        }
    }

    class Students
    {
        public int id { get; set; }
        public int score { get; set; }
        public string name { get; set; }
        public static void Grades(List<Students> s,delegateex pass)
        {
            foreach(Students member in s)
            {
                if(pass(member))
                {
                    Console.WriteLine(member.id+" is Pass");

                }
                else
                    Console.WriteLine(member.id + " is Fail");
            }
        }


    }
    class Grade
    {
        public static bool grade(Students st)
        {
            if (st.score > 35)
                return true;
            else
                return false;
        }
    }
    delegate bool delegateex(Students st);

}
