using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QLSQA
{
    public class DAO_DonVanChuyen
    {
        public bool ThemBillVC()
        {
            string query = "sp_taodonvanchuyen";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool XoaBillVC()
        {
            string query = "sp_xoadonvanchuyen";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
