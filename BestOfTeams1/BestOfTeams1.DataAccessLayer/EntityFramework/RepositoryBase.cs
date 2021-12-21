using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOfTeams1.DataAccessLayer.EntityFramework
{
   public class RepositoryBase
    {
        private static BestOfTeamsContext _db;
        private static object _lockSync = new object();
        public RepositoryBase()
        {

        }
        public static BestOfTeamsContext CreateContext()
        {
            if (_db==null)
            {
                lock (_lockSync)
                {
                    if (_db==null)
                    {
                        _db = new BestOfTeamsContext();
                    }
                }
            }
            return _db;
        }
    }
}
