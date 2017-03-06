using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugstoreTerm
{
    public class Request
    {
        static string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";
        public void QueryToDatabase()
    {
     /*   SqlConnection bd1 = new SqlConnection(connectString);
        bd1.Open();

        SqlCommand cmd1 = new SqlCommand("Select Код, Товари.Назва, Ціна, Категорії.Назва From Товари, Категорії Where Код = ID ", bd1);
        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
        DataTable dt1 = new DataTable();
        adapter1.Fill(dt1);

        int kr = 0;
        int kl = 0;
        for (int nMa = 0; nMa < dt1.Rows.Count; nMa++)
        {

            if (dt1.Rows[nMa][1].ToString() == "0")
            {
                ++nMa;
            }
            else
            {
                Item it = new Item();

                if (panel1.Width < (kr + 1) * 351)
                {
                    kr = 0;
                    it.Left = 351 * kr;
                    it.Top = 130;
                    kl = kl + 130;
                    it.Parent = panel1;
                    it.IName = dt1.Rows[nMa][1].ToString();
                    it.ICategory = dt1.Rows[nMa][3].ToString();
                    it.IPrice = dt1.Rows[nMa]["Ціна"].ToString();
                    it.Show();

                }
                else
                {
                    it.Left = 351 * kr;
                    it.Top = kl;
                    it.Parent = panel1;
                    it.IName = dt1.Rows[nMa][1].ToString();
                    it.ICategory = dt1.Rows[nMa][3].ToString();
                    it.IPrice = dt1.Rows[nMa]["Ціна"].ToString();
                    it.Show();
                    kr++;
                }
            }
        }
        bd1.Close();
        */
    }

    }
}
