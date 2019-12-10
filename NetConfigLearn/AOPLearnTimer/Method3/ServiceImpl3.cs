using System;
using System.Collections.Generic;
using System.Text;
using AOPLearnTimer.BaseClass;
using Castle.DynamicProxy;

namespace AOPLearnTimer.Method3
{
    public class ServiceImpl3
    {

        private ProxyGenerator generator = new ProxyGenerator();//为类或接口提供代理对象
        private AOPBasedCastle interceptor = new AOPBasedCastle();

        private Dao dao;
        public ServiceImpl3()
        {
            //建议Castle动态完成对象创建
            dao = generator.CreateClassProxy<DaoImpl>(interceptor);
        }
        public void insert()
        {
            dao.insert();
        }

        public void delete()
        {
            dao.delete();
        }

        public void update()
        {
            dao.update();
        }
    }
}
