using System;

namespace TaskForStaticStudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuInput();
        }
        static void MenuInput()
        {
            Console.WriteLine("Input Fullname:");
            string fullName = Console.ReadLine();
            Console.WriteLine("input group id:");
            string groupNo = Console.ReadLine();
            Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Student student = new Student(fullName, groupNo, age);
            if (Student.CheckFullname(fullName) && Student.CheckGroupNo(groupNo) && age != 0)
            {
                student.GetInfo();
            }
            else
            {
                Console.WriteLine("Inputs are wrong!");
                MenuInput();
            }


        }
    }
}
