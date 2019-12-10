using System;

namespace Ioc测试.BaseClass
{
    public interface Dao
    {
        Guid Id { get; set; }
        void insert();

        void delete();

        void update();

    }
}
