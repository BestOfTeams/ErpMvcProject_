using ErpMvcProject.DataAccessLayer.EntityFramework;
using ErpMvcProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.BusinessLayer
{
   public class ProductManager
    {
        Repository<Products> rpro = new Repository<Products>();
        public List<Products> GetProducts()
        {
            return rpro.List();
        }
    }
}
