using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;

namespace Ioc测试
{
    public class PrintTimeHandler: IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {

            Console.WriteLine("insert()方法开始时间：" + DateTime.Now.Millisecond);
            invocation.Proceed();//核心业务调用
            Console.WriteLine("insert()方法结束时间：" + DateTime.Now.Millisecond);

        }
    }
}
