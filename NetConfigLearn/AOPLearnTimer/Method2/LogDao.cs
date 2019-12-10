using System;
using System.Collections.Generic;
using System.Text;
using AOPLearnTimer.BaseClass;

namespace AOPLearnTimer.Method2
{
    /// <summary>
    /// 装饰器模式的方法
    /// </summary>
    public class LogDao : Dao
    {

        private Dao dao;

        public LogDao(Dao dao)
        {
            this.dao = dao;
        }

        public void insert()
        {
            Console.WriteLine("insert()方法开始时间：" + DateTime.Now.Millisecond);
            dao.insert();
            Console.WriteLine("insert()方法结束时间：" + DateTime.Now.Millisecond);
        }

        public void delete()
        {
            dao.delete();
        }

        public void update()
        {
            Console.WriteLine("update()方法开始时间：" + DateTime.Now.Millisecond);
            dao.update();
            Console.WriteLine("update()方法结束时间：" + DateTime.Now.Millisecond);
        }
    }
}
