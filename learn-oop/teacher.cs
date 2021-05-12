 using System;
namespace learn_oop
{
    public class teacher : person, PersonInterface
    {
        string title;
        double salary;

        public teacher()
        {
        }

        public teacher(string name,string title, double salary)
        {
            this.Name = name;
            this.Title = title;
            this.Salary = salary;

         }

        public string Title { get => title; set => title = value; }
        public double Salary { get => salary; set => salary = value; }

        //interface method impelemtaiton
        public double getSalay()
        {
            return salary;
        }

        public override void print_data()
        {
            Console.WriteLine("Name ->" + this.Name);
            Console.WriteLine("Age ->" + this.Age);
            Console.WriteLine("Nationality ->" + this.Nationality);
            Console.WriteLine("Address ->" + this.Address);
            Console.WriteLine("Title ->" + this.Title);
            Console.WriteLine("Salary ->" + this.Salary + " EGP");

            Console.WriteLine("------------------------------>");
        }

        
    }
}
