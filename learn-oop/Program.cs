using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace learn_oop
{
    class Program
    {
        //Enumerated
        enum Level
        {
            Low=1,
            Medium =2,
            High = 3
        }

     


        static void Main(string[] args)
        {

            student std1 = new student();
            std1.Name = "sameh";
            std1.Age = 20;
            std1.Nationality = "egyption";
            std1.Address = "giza";
            std1.Student_level =  (Level.Medium).ToString();
            std1.Student_gpa = 3.5;

            std1.print_data();


            teacher tch1 = new teacher() ;
            tch1.Name = "Ahmed";
            tch1.Age = 50;
            tch1.Nationality = "egyption";
            tch1.Address = "giza";
            tch1.Title = "math teacher";
            tch1.Salary = 2500;

            tch1.print_data();

            //interface print data
            Console.WriteLine("interface: "+tch1.getSalay());

            //ArrayList

            ArrayList arrlist;

            //basic method to add item
            //arrlist = new ArrayList()
            //    {
            //        2, "Steve", " ", true, 4.5, null
            //    };
            arrlist = new ArrayList();
            arrlist.Add(2);
            arrlist.Add("sameh");
            arrlist.Add(true);

            arrlist.AddRange(new ArrayList() { 1, 5, 4, 95, 88,99 });

            arrlist.RemoveAt(1); //remove sameh value
            arrlist.RemoveRange(0,2); // remove 2 and true values
            arrlist.Sort();
            arrlist.Reverse();

            Console.WriteLine("------------------");

            Console.Write("ArrayList : (");
            int index = 0;
            foreach(var value in arrlist)
            {
                index++;

                if (index!=arrlist.Count)
                {
                    Console.Write(value + " , ");


                }
                else
                {
                    Console.Write(value + ")");

                }


            }

        }
    }
}
