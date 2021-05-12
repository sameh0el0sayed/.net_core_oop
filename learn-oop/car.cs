using System;
namespace learn_oop
{
    public class car
    {
        private string maker;
        private int year;



        //constractor base
        public car()
        {
            this.maker = "honda";
            this.year = 2017;



        }

        public car(string maker, int year)
        {
            setmaker(maker);
            setyear(year);
        }



        public string getmaker()
        {
            return this.maker;
        }
        public void setmaker(string _maker) => maker = _maker;

        public int getyear()
        {
            return this.year;
        }
        public void setyear(int _year)
        {
            //role of  variable
            if (_year < 2015)
            {
                
                this.year = 0;
                Console.WriteLine("invalid year");
            }
            else
            {
                this.year = _year;

            }

        }








    }
}
