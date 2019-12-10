using System;
using System.Collections.Generic;
using System.Text;

namespace AOPLearnTimer.BaseClass
{
    public class DaoImpl : Dao
    {

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
