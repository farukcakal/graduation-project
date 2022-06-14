using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace OnMuhasebe.Classlar
{
    class ExcelIslemleri
    {
        
        public DataTable Veriler(string Yol)
        {
            string BaglantiStringi = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source="+ Yol +"; Extended Properties='Excel 8.0;';";
            OleDbConnection baglanti = new OleDbConnection(BaglantiStringi);
            baglanti.Open();
            OleDbDataAdapter Adapter = new OleDbDataAdapter("SELECT * FROM [Sayfa1$A:Z]", baglanti);
            DataTable Veriler = new DataTable();
            Adapter.Fill(Veriler);
            return Veriler;

        }
    }
}
