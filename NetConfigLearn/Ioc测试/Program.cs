using System;
using Autofac;
using Autofac.Builder;
using Autofac.Extras.DynamicProxy;
using Ioc测试.BaseClass;


namespace Ioc测试
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //DI();
            Aop();
            Console.ReadLine();
        }

        /// <summary>
        /// 普通的容器用法
        /// </summary>
        static void DI()
        {
            Autofac.ContainerBuilder containerBuilder = new Autofac.ContainerBuilder();
            //单例模式
            containerBuilder.RegisterType<DaoImpl>()
                .As<Dao>()
                .SingleInstance();

            //一个生命周期一个实例
            //containerBuilder.RegisterType<OrderService>()
            //    .As<IOrderService>()
            //    .InstancePerLifetimeScope();

            //每一次被请求都是一个实例
            //containerBuilder.RegisterType<OrderService>()
            //    .As<IOrderService>()
            //    .InstancePerDependency();

            var container = containerBuilder.Build();
            for (int j = 0; j < 2; j++)
            {
                using (var life = container.BeginLifetimeScope())
                {
                    for (int i = 0; i < 2; i++)
                    {
                        var service = life.Resolve<Dao>();
                        Console.WriteLine($"{service.Id}");
                    }
                }
            }
           
        }

        static void Aop()
        {
            Autofac.ContainerBuilder containerBuilder = new Autofac.ContainerBuilder();
            containerBuilder.RegisterType<PrintTimeHandler>();
            containerBuilder.RegisterType<DaoImpl>().As<Dao>().InterceptedBy(typeof(PrintTimeHandler)).EnableClassInterceptors();
            var life= containerBuilder.Build().BeginLifetimeScope();
            var dao= life.Resolve<Dao>();
            dao.insert();
            dao.update();
            dao.delete();
        }
    }

}
