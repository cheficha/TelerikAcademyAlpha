using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOrder
{
    public struct Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var studentsNumber = input[0];
            var changes = input[1];
            var names = Console.ReadLine().Split().ToArray();
            var students = new Dictionary<string,Student>();
            var result = new StringBuilder();
            Student head = new Student(names[0],null,null);
            students.Add(names[0],head);



            for (int i = 1; i < names.Length; i++)
            {
                var studentToAdd = new Student(names[i],null,null);
                studentToAdd.Prev = students[names[i-1]];
                students[names[i - 1]].Next = studentToAdd;
                students.Add(names[i],studentToAdd);
            }
            var counter = 1;
            while (counter <= changes)
            {
                counter++;
                var change = Console.ReadLine().Split().ToArray();
                var first = change[0];
                var second = change[1];

                //var FirstStudent = students.Where(x => x.Name == first).Single();
                //var SecondStudent = students.Where(x => x.Name == second).Single();
                Student FirstStudent = students[first];
                Student SecondStudent = students[second];

           

                if (FirstStudent.Next == SecondStudent)
                {
                    continue;
                }
                else if (FirstStudent.Prev == SecondStudent)
                {
                    var FP = FirstStudent.Prev;
                    var FN = FirstStudent.Next;
                    var SP = SecondStudent.Prev;
                    var SN = SecondStudent.Next;
                    FirstStudent.Next = SecondStudent;
                    SecondStudent.Prev = FirstStudent;
                    if (FN == null)
                    {
                        SecondStudent.Next = null;
                    }
                    else
                    {
                        SecondStudent.Next = FN;
                        FN.Prev = SecondStudent;
                    }
                    if (SP == null)
                    {
                        FirstStudent.Prev = null;
                    }
                    else
                    {
                        FirstStudent.Prev = SP;
                        SP.Next = FirstStudent;
                    }

                }
                else
                {


                    var Prev2 = SecondStudent.Prev;
                    var Next2 = SecondStudent.Next;

                    var Prev1 = FirstStudent.Prev;
                    var Next1 = FirstStudent.Next;

                    FirstStudent.Next = SecondStudent;

                    FirstStudent.Prev = Prev2;
                    if (Prev2 != null)
                    {
                        Prev2.Next = FirstStudent;

                    }

                    SecondStudent.Prev = FirstStudent;

                    if (Next1 == null)
                    {
                        Prev1.Next = null;

                    }
                    else if (Prev1 == null)
                    {
                        Next1.Prev = null;
                    }
                    else
                    {
                        Prev1.Next = Next1;
                        Next1.Prev = Prev1;
                    }

                }

                         
            }
            //head = students.Where(x => x.Prev == null).Single();
            foreach (var item in students.Values)
            {
                if (item.Prev==null)
                {
                    head = item;
                    break;
                }
            }
            while (true)
            {
                result.Append($"{head.Name} ");
                if (head.Next==null)
                {
                    break;
                }
                else
                {

                head = head.Next;
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
     class Student
    {
        public Student(string name,Student next,Student prev)
        {
            this.Name = name;
            this.Next = next;
            this.Prev = prev;
        }
        public string Name { get; set; }
        public Student Next { get; set; }
        public Student Prev { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Name: {this.Name}");
            return sb.ToString();
        }
    }
}
