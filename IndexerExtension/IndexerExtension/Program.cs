using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Indexer
            //int[] a = new int[3];
            //a[0] = 100;
            //a[1] = 200;
            //Console.WriteLine(a[1]);
            Group group = new Group("P314");
            Student s1 = new Student("Kamil");
            Student s2 = new Student("Zahid");
            Student s3 = new Student("Seynur");
            Student s4 = new Student("Javidan");
            //group[0] = s1;
            //group[1] = s2;
            //group[2] = s3;
            //group[4] = s4;
            //Console.WriteLine(group[5]);
            #endregion

            #region Extension
            //string word = "Kamran";
            //word.Trim();
            //word.Replace("a", "u");
            //Extention.GetStrLenght(word);
            //word.GetStrLenght();
            //int a = 5;
            //int b = 6;
            //Console.WriteLine(a.Sum(b));

            //Task-1
            //int number = 5;
            //int power = 3;
            //number.GetPower(power);

            //Task-2

            //string word = "Hello";
            //char letter = 'l';
            //word.CountLetter(letter);

            //Task-3
            //string word = "Hello";
            //char l = 'e';
            //word.WriteIndex(l);

            //Task-4
            //int[] arr = { 10, 20, 30, 33 };
            //int val = 10;
            //arr.HasValue(val);
            #endregion
        }
        //public static void GetStrLenght(string str)
        //{
        //    Console.WriteLine($"String lenght:{str.Length}");
        //} 
    }

    

    #region Indexer
    class Group
    {
        public string Name { get; set; }
        private Student[] students;

        public Student this[int i]
        {
            get 
            {
                if(i> students.Length - 1)
                {
                    Console.WriteLine("Bu index set olunmayib!!!");
                    return null;
                }
                return students[i];
            }
            set
            {
                if (i > students.Length - 1)
                {
                    Array.Resize(ref students, i + 1);
                    students[i] = value;
                }
                
            }
        }
        public Group(string name)
        {
            Name = name;
            students = new Student[0];
        }

        public void AddStudent(Student stu)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = stu;
        }

        public void ShowList()
        {
            foreach (Student item in students)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public Student(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    #endregion
}
