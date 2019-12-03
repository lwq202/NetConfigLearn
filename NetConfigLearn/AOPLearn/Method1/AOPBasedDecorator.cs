using System;
using System.Collections.Generic;
using System.Text;
using AOPLearn.BaseClass;

namespace AOPLearn.Method1
{
    /// <summary>
    /// 这个是传统的装饰器类
    /// </summary>
    public class AOPBasedDecorator
    {
        private readonly IOrderService orderService;
        /// <summary>
        /// 
        /// </summary>
        public AOPBasedDecorator( IOrderService service)
        {
            orderService = service;
        }

        public int SubmitOrder(CourseOrder order)
        {
            //其他的业务逻辑
            Console.WriteLine("执行核心业务逻辑之前执行的方法");

            //这个是核心业务
            orderService.SubmitOrder(order);
            return 1;
        }
    }
}
