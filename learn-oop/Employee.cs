using System;
namespace learn_oop
{
    public class Employee
    {
        private int Emp_ID;
        private string Name;
        private string Depart;
        private double Salary;
        private double Bonus;
        private bool Resident;
        private static int num_opj;

        public Employee()
        {
            this.Emp_ID = '1';
            this.Name = "No name";
            this.Depart = "No Depart";
            this.Salary = 0;
            this.Bonus = 0;
            this.Resident = true;
            num_opj++;

        }
        public Employee(int id, string name)
        {
            this.Emp_ID = id;
            this.Name = name;

            num_opj++;

        }

        public Employee(int id, string name, double salary)
        {
            this.Emp_ID = id;
            this.Name = name;
            this.Salary = salary;
            num_opj++;

        }

        public void print_emp_data()
        {
            Console.WriteLine("Emp_ID ->" + this.Emp_ID);
            Console.WriteLine("name ->" + this.Name);
            Console.WriteLine("Depart ->" + this.Depart);
            Console.WriteLine("Salary ->" + this.Salary);
            Console.WriteLine("Bonus ->" + this.Bonus);
            Console.WriteLine("Resident ->" + this.Resident);
        }
        public static void print_num_opj ()
        {
            Console.WriteLine("num_opj ->" + num_opj);
          
        }

    }
}
