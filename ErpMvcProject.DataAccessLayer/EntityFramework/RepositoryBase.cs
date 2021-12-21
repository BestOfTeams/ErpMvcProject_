using ErpMvcProject.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.DataAccessLayer.EntityFramework
{
    public class RepositoryBase
    {
        private static ErpMvcContext _db;

        private static object _lockSync = new object();

        public RepositoryBase()
        {

        }
        // aşağıdaki yapı birden cok context yapı varsa oluyor
        public static ErpMvcContext CreateContext()
        {
            if (_db == null)
            {
                lock (_lockSync)
                {
                    if (_db == null)
                    {
                        _db = new ErpMvcContext();
                    }
                }

            }
            return _db;
        }

    }
}
