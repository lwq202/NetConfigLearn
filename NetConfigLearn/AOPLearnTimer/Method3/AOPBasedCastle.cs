using System;
using Castle.DynamicProxy;

namespace AOPLearnTimer.Method3
{
    /// <summary>
    /// 基于Castle动态代理完成对象扩展
    /// 需要实现一个拦截器接口
    /// </summary>
    public class AOPBasedCastle : IInterceptor
    {
        /// <summary>
        /// 接口实现方法：主要用来完成核心业务调用
        /// </summary>
        /// <param name="invocation"></param>
        public void Intercept(IInvocation invocation)
        {

            Console.WriteLine("insert()方法开始时间：" + DateTime.Now.Millisecond);
            invocation.Proceed();//核心业务调用
            Console.WriteLine("insert()方法结束时间：" + DateTime.Now.Millisecond);

        }
    }
}
