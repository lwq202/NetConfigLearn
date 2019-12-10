using System;

namespace Ioc测试.BaseClass
{
    public class DaoImpl : Dao
    {
        public DaoImpl()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        public virtual void insert()
        {
            Console.WriteLine("DaoImpl.insert()");
        }

        public void delete()
        {
            Console.WriteLine("DaoImpl.delete()");
        }

        public virtual void update()
        {
            Console.WriteLine("DaoImpl.update()");
        }

    }
}
