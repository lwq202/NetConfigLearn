using AOPLearn.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ioc测试.BaseClass
{
    class OrderService1 : IOrderService
    {
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<CourseOrder> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public int SubmitOrder(CourseOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
