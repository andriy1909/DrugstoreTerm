using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugstoreTerm
{
    public partial class DetailsForm : Form
    {
        int id;
        public DetailsForm()
        {
            InitializeComponent();
        }
        public DetailsForm(int id)
        {
            InitializeComponent();
            Details det = new Details();
            det.getDataItem(id);
            this.id = id;

            tbName.Text = det.name;

            cbProducer.DisplayMember = det.maker.ToString();
            cbProducer.Text = Producers.getName(det.maker);

            cbPack.DisplayMember = det.pack.ToString();
            cbPack.Text = Packing.getname(det.pack);

            tbOutPrice.Text = Convert.ToString(det.price);
            tbInform.Text = det.info;
            pictureBox1.Image = det.getImage();
            cbReturn.Checked = det.isReturn;
            checkBox1.Checked = det.recept;
        }

        private void cbOdVum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DetailsForm_Leave(object sender, EventArgs e)
        {
           // MessageBox.Show("sdfghghj");
            if (!DetailsForm.ActiveForm.Focused)
                this.Activate();
        }
    }
}
