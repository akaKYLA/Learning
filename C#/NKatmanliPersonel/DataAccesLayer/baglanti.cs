using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccesLayer
{
    public class baglanti
    {
       public static SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-PNBUNT7\SQLEXPRESS;Initial Catalog=DBPersonel;Integrated Security=True");

    }
}
