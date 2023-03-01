using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Lyakhov_lab2
{
    internal class Person
    {
        public override string ToString() 
        { 
            return "Фамилия и инициалы: "+Surname+" " + Name[0]+"."+" "+"Возраст: "+ Age(B_day)+" "+"Пол: "+Sex;
        }
        public void Output()
        {
            Console.WriteLine("Фамилия и инициалы: {0} {1}.", Surname, Name[0]);
            Console.WriteLine("Возраст: {0}", Age(B_day));
            Console.WriteLine("Пол: {0}",Sex);


        }
        public void Input()
        {
            Console.WriteLine("Введите данные");
            Console.Write("Фамилия:");
            Surname= Console.ReadLine();
            Console.Write("Имя:");
            Name= Console.ReadLine();
            Console.Write("Дата рождения(не получается ввести):");//не получается ввести
            B_day= DateTime.Parse(Console.ReadLine());
            Console.Write("Пол(м/ж):");
            Sex= char.Parse(Console.ReadLine());

        }
        public int Age(DateTime B_day)
        {

            DateTime date_now = DateTime.Now;

            int age = date_now.Year - B_day.Year;

            if (DateTime.Now.DayOfYear<B_day.DayOfYear)
            {
                return age--;
            }
            return age;
        }
        
        
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime B_day{
            get
            {
                return B_day;
            }
            set
            {
                if (value.Year > 1900 && value.Year <= DateTime.Today.Year)
                {
                    B_day = value;
                }
            } 
        }
        private char sex;
        public char Sex
        {
            get{ return sex;}
            set{ if (value == 'м')
                    sex = 'м';
                else if (value == 'ж')
                    sex = 'ж';
                }
        }
        public Person() { }
        public Person(string Surname, string Name, DateTime B_day, char Sex)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.B_day = B_day;
            this.Sex = Sex;
        }
        public Person(Person firstperson) : this(firstperson.Surname, firstperson.Name, firstperson.B_day, firstperson.Sex) { }


    }
}
