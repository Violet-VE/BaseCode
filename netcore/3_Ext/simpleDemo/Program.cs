﻿using System;

namespace simpleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray();
            array.Add("~").Add("这").Add("是").Add("一").Add("个").Add("测").Add("试").Add("。").RemoveAt(0).RemoveAt(3).RemoveAt(6);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
            foreach (var item in array)
            {
                Console.Write(item);
            }
        }
    }
}
