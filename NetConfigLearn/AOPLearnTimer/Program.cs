using System;
using AOPLearnTimer.BaseClass;
using AOPLearnTimer.Method1;
using AOPLearnTimer.Method2;
using AOPLearnTimer.Method3;

namespace AOPLearnTimer
{
    class Program
    {
        /// <summary>
        /// 这里出现的一个场景是统计一个类下面的方法的执行时间
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("这个是传统方式请求");
            Method1();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("这个是装饰器方式");
            Method2();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("AOP模式");
            Method3();
            Console.WriteLine("----------------------------------------------------");
            Console.ReadLine();
        }

        /// <summary>
        /// 传统方式
        /// </summary>
        static void Method1()
        {
            ServiceImpl service = new ServiceImpl();
            service.insert();
            service.update();
            service.delete();
        }
        /// <summary>
        /// 装饰器
        /// </summary>
        static void Method2()
        {

            LogDao dao = new LogDao(new DaoImpl());
            dao.insert();
            dao.update();
            dao.delete();
        }
        /// <summary>
        /// AOP
        /// </summary>
        static void Method3()
        {
            ServiceImpl3 service = new ServiceImpl3();
            service.insert();
            service.update();
            service.delete();
        }
    }
}
