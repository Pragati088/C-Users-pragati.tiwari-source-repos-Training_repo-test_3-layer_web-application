using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALClass;

namespace BALclass
{
    public class BAL
    {
        //
        /// <summary>
        /// 
        /// </summary>
        DAL obj = new DAL();
        //
        public void InsertData(int id, string name, string author, string publisher,decimal price)
        {
            obj.Insert(id, name, author ,publisher,price);
        }

        public void DeleteData(int id)
        {
            obj.Delete(id);
        }
        //
        public void UpdateData(int id, string name, string author, string publisher,decimal price)
        {
            obj.Update(id, name, author, publisher, price);
        }
        public void SelectData()
        {
            obj.SelectAll();
        }

    }
}
