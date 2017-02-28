using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugstoreTerm
{
    public partial class Form1 : Form
    {
        //КП 3.11 ПР-132.NN ПЗ(ВП, Д1)
        static string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Товари". При необходимости она может быть перемещена или удалена.
            this.товариTableAdapter.Fill(this.drugstoreDataSet.Товари);

            // Робота з menuStrip1

            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();

            SqlCommand cmd = new SqlCommand("Select ID, Назва From Категорії ", bd);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            for (int nMain = 0; nMain < dt.Rows.Count; nMain++)
            {
                if (dt.Rows[nMain]["Назва"].ToString() == "0")
                {
                    ++nMain;
                }
                else
                {
                    ToolStripMenuItem tsmMain = new ToolStripMenuItem(dt.Rows[nMain]["Назва"].ToString());
                    menuStrip1.Items.Add(tsmMain);
                }
            }        
            bd.Close();

            // Робота з Item

            panel1.Parent = this;


            SqlConnection bd1 = new SqlConnection(connectString);
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

                    if (panel1.Width < (kr+1) * 351)
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
        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
