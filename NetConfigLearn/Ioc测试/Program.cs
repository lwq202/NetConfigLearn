using System;
using AOPLearn.BaseClass;
using Autofac;
using Autofac.Builder;


namespace Ioc测试
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IOrderService orderService = new OrderService();
            DI();
            Console.ReadLine();
        }

        /// <summary>
        /// 普通的容器用法
        /// </summary>
        static void DI()
        {
            Autofac.ContainerBuilder containerBuilder = new Autofac.ContainerBuilder();
            //单例模式
            //containerBuilder.RegisterType<OrderService>()
            //    .As<IOrderService>()
            //    .SingleInstance();

            // 一个生命周期一个实例
            //containerBuilder.RegisterType<OrderService>()
            //    .As<IOrderService>()
            //    .InstancePerLifetimeScope();

            //每一次被请求都是一个实例
            containerBuilder.RegisterType<OrderService>()
                .As<IOrderService>()
                .InstancePerDependency();

            var container = containerBuilder.Build();
            for (int j = 0; j < 2; j++)
            {
                using (var life = container.BeginLifetimeScope())
                {
                    for (int i = 0; i < 2; i++)
                    {
                        var service = life.Resolve<IOrderService>();
                        Console.WriteLine($"{service.Id}");
                    }


                }
            }
           
        }

        static void In()
        {

        }
    }

}
