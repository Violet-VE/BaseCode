using System;

namespace Polymorphism2
{
    public abstract class Animal
    {
        /// <summary>
        /// 抽象类中可以有正常的方法
        /// </summary>
        public void Action()
        {
            Console.WriteLine("动物可以动");
        }

        /// <summary>
        /// 抽象方法必须在抽象类中
        /// </summary>
        public abstract void Call();
    }
}