using System;
using System.Collections.Generic;
using AOPLearn.BaseClass;

namespace AOPLearn.Method2
{
    /// <summary>
    /// 接口实现类：请大家在实现接口的时候，方法必须是virtual
    /// </summary>
    public class OrderServiceCastle : IOrderService
    {
        public  List<CourseOrder> GetAllOrders()
        {
            //在这里编写具体的查询业务...
            Console.WriteLine("读取方法调用");
            return new List<CourseOrder>
            {
                new CourseOrder {  CourseId=1000, CourseName="课程0", CoursePrice=3500, OrderId=2000, SchoolId=502100, StudentId=293400},
                new CourseOrder {  CourseId=1001, CourseName="课程1", CoursePrice=4500, OrderId=2001, SchoolId=502101, StudentId=293400},
                new CourseOrder {  CourseId=1002, CourseName="课程2", CoursePrice=5500, OrderId=2002, SchoolId=502102, StudentId=293400}
            };
        }

        public virtual int SubmitOrder(CourseOrder order)
        {
            //
            //在这里编写具体的查询业务...

            Console.WriteLine("--------------------------------《核心业务》课程订单被正确提交...");

            return 1000;
        }
    }
}
