﻿using System;

namespace _2Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Student("app", 10, "北京大学", "001", "01001");
            p.Hi(); p.Show();

            System.Console.WriteLine();

            Student s = p as Student;
            s.Hi(); s.Show();

        }
    }
}
