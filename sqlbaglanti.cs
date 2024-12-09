using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YurtkayıtSistemi
{
    public class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=ENES\SQL;Initial Catalog=Yurtkayıt;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
