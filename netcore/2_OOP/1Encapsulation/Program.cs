﻿using System;

namespace _1Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student() { Name = "mmd", Age = 13, Gender = 1 };
            s.Show();
            
            Student s1 = new Student("dmm", 20);
            s1.Show();

            Console.WriteLine(s);
        }
    }
}
