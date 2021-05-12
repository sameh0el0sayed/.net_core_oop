using System;
namespace learn_oop
{
    public abstract class person
    {
        string name;

        double age;

        string address;

        string nationality;
         
       
        public person()
        {
         






        }

        public person(string name, double age, string address, string nationality)
        {
            this.Name = name;
            this.Age = age;
            this.Address = address;
            this.Nationality = nationality;
        }

        public string Name { get => name; set => name = value; }
        public double Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public string Nationality { get => nationality; set => nationality = value; }


        public abstract void print_data();

    }

}
