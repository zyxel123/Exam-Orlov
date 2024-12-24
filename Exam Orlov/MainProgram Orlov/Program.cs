using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLLibrary;

namespace MainProgram_Orlov
{

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта основного класса Group
            Group group = new Group("Технический колледж");

            // Создание объектов дополнительного класса Student с произвольными данными
            Student student1 = new Student("Иванов Иван", 4.5);
            Student student2 = new Student("Петров Петр", 3.6);
            Student student3 = new Student("Сидоров Сидор", 4.8);
            Student student4 = new Student("Кузнецова Анна", 4.2);
            Student student5 = new Student("Лебедева Ольга", 5.0);

            // Добавление студентов в группу
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.AddStudent(student4);
            group.AddStudent(student5);

            // Сортировка студентов по средней оценке (Ocenka)
            group.Students.Sort((s1, s2) => s1.Ocenka.CompareTo(s2.Ocenka));

            // Показ всей информации о группе и студентах
            group.ShowAll();

            // Задержка перед закрытием консоли
            Console.ReadLine();
        }
    }
}
