using System;
namespace learn_oop
{
    public class student : person 
    {
        string student_level;
        double student_gpa;

        public student()
        {
        }

        public student(string student_level, double student_gpa)
        {
            this.Student_level = student_level;
            this.Student_gpa = student_gpa;
        }

        public string Student_level { get => student_level; set => student_level = value; }
        public double Student_gpa { get => student_gpa; set => student_gpa = value; }

        public override void print_data()
        {
            Console.WriteLine("Name ->" + this.Name);
            Console.WriteLine("Age ->" + this.Age);
            Console.WriteLine("Nationality ->" + this.Nationality);
            Console.WriteLine("Address ->" + this.Address);
            Console.WriteLine("student_level ->" + this.student_level);
            Console.WriteLine("student_gpa ->" + this.student_gpa);

            Console.WriteLine("------------------------------>");
        }


        //public abstract void print_student()
        //{
        //    Console.WriteLine("Name ->" + this.Name);
        //    Console.WriteLine("Age ->" + this.Age);
        //    Console.WriteLine("Nationality ->" + this.Nationality);
        //    Console.WriteLine("Address ->" + this.Address);
        //    Console.WriteLine("student_level ->" + this.student_level);
        //    Console.WriteLine("student_gpa ->" + this.student_gpa);

        //    Console.WriteLine("------------------------------>");
        //}
    }
}
