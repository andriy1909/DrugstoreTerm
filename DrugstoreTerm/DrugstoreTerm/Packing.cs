using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugstoreTerm
{
    class Packing
    {
        public int id { get; set; }
        public string name { get; set; }

        static string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";
        public void setProvider(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public static string getname(int id)
        {
            string name = "";
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Упаковки WHERE Код=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();

            while (dataReader1.Read())
            {
                name = dataReader1["Назва"].ToString().Trim();
            }
            bd.Close();
            return name;
        }
    }
}
