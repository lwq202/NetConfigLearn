using System;
using AOPLearnTimer.BaseClass;

namespace AOPLearnTimer.Method1
{
    public class ServiceImpl
    {

        private Dao dao = new DaoImpl();

        public void insert()
        {
            Console.WriteLine("insert()方法开始时间：" + DateTime.Now.ToLongTimeString());
            dao.insert();
            Console.WriteLine("insert()方法结束时间：" + DateTime.Now.ToLongTimeString());
        }

        public void delete()
        {
            dao.delete();
        }

        public void update()
        {
            Console.WriteLine("update()方法开始时间：" + DateTime.Now.ToLongTimeString());
            dao.update();
            Console.WriteLine("update()方法结束时间：" + DateTime.Now.ToLongTimeString());
        }

    }
}
