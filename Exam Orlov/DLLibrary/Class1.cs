using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLibrary
{

    // Student.cs
    public class Student
    {
        public string Name { get; set; }
        public double Ocenka { get; set; }

        public Student(string name, double ocenka)
        {
            Name = name;
            Ocenka = ocenka;
        }

        public void Show()
        {
            Console.WriteLine($"ФИО: {Name}, Средняя оценка: {Ocenka}");
        }
    }
    // Group.cs


    public class Group
    {
        public string College { get; set; }
        public List<Student> Students { get; set; }

        public Group(string college)
        {
            College = college;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void Show()
        {
            Console.WriteLine($"Колледж: {College}");
        }

        public void ShowAll()
        {
            Show();
            foreach (var student in Students)
            {
                student.Show();
            }
        }
    }
}