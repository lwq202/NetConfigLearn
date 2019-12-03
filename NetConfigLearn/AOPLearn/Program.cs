using System;
using AOPLearn.BaseClass;
using AOPLearn.Method1;
using AOPLearn.Method2;
using Castle.DynamicProxy;

namespace AOPLearn
{

    /// <summary>
    /// AOP学习
    /// 这里模拟用户购买课程的方法
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CourseOrder order = new CourseOrder
            {
                CourseId = 1001,
                CourseName = ".NET高级VIP课程",
                CoursePrice = 3500,
                SchoolId = 502102,
                StudentId = 293400
            };
            Method0(order);
            Method1(order);
            Method2(order);

            Console.WriteLine("Hello World!");
        }
        /// <summary>
        /// 传统的方法
        /// 【0】基于普通的接口编程
        /// </summary>
        static void Method0(CourseOrder order)
        {
            //创建订单信息对象
            
            //【1】基于普通的接口编程
            Console.WriteLine("\r\n\r\n---------【0】基于普通接口编程\r\n");
            IOrderService orderService = new OrderService();
            int result = orderService.SubmitOrder(order);
            Console.WriteLine("订单提交返回结果：" + result);
        }

        /// <summary>
        /// 【1】基于装饰器设计模式为核心业务切入方法
        /// 这个缺点很明显 每个方法都要实现特定的一个装饰器，重复很多的工作
        /// </summary>
        static void Method1(CourseOrder order)
        {
            Console.WriteLine("\r\n\r\n---------【1】基于装饰器设计模式为核心业务切入方法");
            var method = new AOPBasedDecorator(new OrderService());
            method.SubmitOrder(order);
        }

        /// <summary>
        /// 【2】基于动态代理方式为核心业务切入方法
        /// 1.先实现一个拦截器
        /// 2.实现接口的方法 如果要时间拦截器 需要用virtual 方法
        /// </summary>
        static void Method2(CourseOrder order)
        {
            Console.WriteLine("\r\n\r\n---------【2】基于动态代理方式为核心业务切入方法");

            ProxyGenerator generator = new ProxyGenerator();//为类或接口提供代理对象
            AOPBasedCastle interceptor = new AOPBasedCastle();

            //建议Castle动态完成对象创建
            IOrderService orderService4 = generator.CreateClassProxy<OrderServiceCastle>(interceptor);
            var result = orderService4.SubmitOrder(order);
            //orderService4.GetAllOrders();
            Console.WriteLine("订单提交返回结果：" + result);

            Console.WriteLine("结束了------------------------------");
            var list= orderService4.GetAllOrders();

            Console.ReadLine();
        }

    }
}
