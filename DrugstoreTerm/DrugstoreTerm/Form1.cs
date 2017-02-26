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
        static string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Товари". При необходимости она может быть перемещена или удалена.
            this.товариTableAdapter.Fill(this.drugstoreDataSet.Товари);

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
        }

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
