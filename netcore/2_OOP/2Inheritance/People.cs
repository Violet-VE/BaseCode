using System;

namespace _2Inheritance
{
    public class Person
    {
        /// <summary>
        ///ushort参考： https://msdn.microsoft.com/zh-CN/library/cbf1574z.aspx
        /// </summary>
        public string Name { get; set; }
        public ushort Age { get; set; }

        public Person(string name, ushort age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void Hi()//People
        {
            Console.WriteLine("Name: " + this.Name + " Age: " + this.Age);
        }
        public virtual void Show()//People
        {
            Console.WriteLine("Name: " + this.Name + " Age: " + this.Age);
        }
    }
}