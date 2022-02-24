using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Student
    {
        //фамилия
        public string Surname { get; set; }

        //имя
        public string Name { get; set; }

        //отчество
        public string Patronymic { get; set; }

        //возраст
        public int Age { get; set; }

        //пол женский/мужской
        public GenderType Gender { get; set; }

        //цвет волос
        public string Hair { get; set; }

        //религия
        public string Religion { get; set; }

        //национальность
        public string Nationality { get; set; }

        public static void Match(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.Gender != secondStudent.Gender)
            {
                Console.WriteLine($"{firstStudent.Name} и {secondStudent.Name} = Match!");
                return;
            }
            else
            {
                Console.WriteLine(" No Match!");
            }
        }

    }
}
