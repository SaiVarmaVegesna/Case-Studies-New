using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDataAccessLib
{
    public class productDAL
    {
        public void addproduct(tbl_product p)
        {
            SaiEntities n = new SaiEntities();
            n.tbl_product.Add(p);
            n.SaveChanges();
           

        }
        public List<tbl_product> Viewproduct()
       {
            SaiEntities n = new SaiEntities();

            var p = n.tbl_product.ToList();

            return p;     
        }
        public List<string> getcategoryid()
        {
            SaiEntities n = new SaiEntities();
            var d = n.tbl_category.Select(o => o.categoryid).ToList();
            return d;
        }
        public tbl_category  getcategorynames(string id)
        {
            SaiEntities n = new SaiEntities();
            var result = n.tbl_category.Where(o => o.categoryid == id).SingleOrDefault();
                         
            return result;
        }
      
    }
}
