using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1 - Инкапсуляция");
            Console.WriteLine("Выполнила - Григорьева Екатерина ВИС32");

            //Создадим комплексные числа и сразу присвоим значения действительной и мнимой частям
            //Complex a = new Complex() { Real = 3, Imag = 0.5 };
            //Complex b = new Complex() { Real = 2, Imag = 0.8 };
            //Complex c = new Complex() { Real = 2, Imag = 0.2 };
            //Complex f = new Complex() { Real = 6, Imag = 0.7 };

            //К числу a прибавим число b
            //a.Add(b);

            //Из числа b вычтем число a
            //b.Substract(a);

            //Число c умножим на число f
            //c.Multiply(f);

            //Число f поделим на число c 
            //f.Divide(c);

            //Выведем результат 
            //Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            //Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);
            //Console.WriteLine("c = {0} + {1}i", c.Real, c.Imag);
            //Console.WriteLine("f = {0} + {1}i", f.Real, f.Imag);


            Student firstStudent = new Student()
            {
                Surname = "Иванов",
                Name = "Иван",
                Patronymic = "Иванович",
                Age = 23,
                Gender = GenderType.Man,
                Hair = "черный",
                Religion = "католицизм",
                Nationality = "кореец"
            };

            Student secondStudent = new Student()
            {
                Surname = "Любимая",
                Name = "Любовь",
                Patronymic = "Александровна",
                Age = 21,
                Gender = GenderType.Woman,
                Hair = "коричневый",
                Religion = "православие",
                Nationality = "полячка"
            };

            Student.Match(firstStudent, secondStudent);
        }
    }
}
