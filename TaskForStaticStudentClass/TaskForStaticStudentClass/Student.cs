using System;
using System.Collections.Generic;
using System.Text;

namespace TaskForStaticStudentClass
{
    class Student
    {
        private static string _fullName;
        private static string _groupNo;
        private static string Fullname { get => _fullName; set { } }
        private static string GroupNo {get=>_groupNo ;set { } }

        private int _age;
        public int Age { 
            get
            {
                return _age;    
            }
            set 
            {
                if (value>=0 && value<=170)
                {
                    _age = value;
                }
            
            } 
        }
        public Student(string fullname, string groupnumber, int age)
        {
            if (CheckFullname(fullname) && CheckGroupNo(groupnumber))
            {
                Fullname = fullname;
                GroupNo = groupnumber;
                Age = age;
            }

        }
        public static bool CheckGroupNo(string groupmember)
        {
            if (groupmember.Length == 4 && Char.IsUpper(groupmember[0]))
            {
                int count = 0;
                for (int i = 1; i < 4; i++)
                {
                    if (Char.IsDigit(groupmember[i]))
                    {
                        count++;
                    }
                }
                if (count == 3)
                {
                    return true;
                }
                return false;

            }
            return false;
        }
        public static bool CheckFullname(string FullName)
        {
            bool condition = false;

            for (int i = 0; i < FullName.Length; i++)
            {
                if (Char.IsDigit(FullName[i]))
                {
                    return false;
                }
            }
            for (int i = 0; i < FullName.Length; i++)
            {
                if (FullName[i] == ' ')
                {
                    condition = true;
                    break;
                }


            }
            if (condition == true)
            {
                string[] NamewithSur = FullName.Split();

                int count = 0;
                for (int i = 0; i < NamewithSur.Length; i++)
                {
                    string value = NamewithSur[i];
                    if (Char.IsUpper(value[0]))
                    {
                        count++;
                    }
                }
                if (count == NamewithSur.Length - 1)
                {
                    return true;
                }
                else
                    return false;



            }
            else
                return false;
            












        }
        public void GetInfo()
        {
            Console.WriteLine($"Fullname :{Fullname} \n Group number:{GroupNo} \n Age:{Age}");
        }

    }

}
    

