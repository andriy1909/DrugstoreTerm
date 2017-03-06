using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugstoreTerm
{
    public partial class Item : UserControl
    {
        int id;
        string name;
        string category;
        string price;
        public byte[] image;
        public Item()
        {
            InitializeComponent();
        }

        public Item(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public int Iid
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public void getImage(byte[] image)
        {
            Image newImage = null;
            if (image != null)
            {
                using (MemoryStream stream = new MemoryStream(image))
                {
                    newImage = Image.FromStream(stream);
                }
            }
            pictureBox1.Image = newImage;
        }

        public string IName
        {
            get
            {
                return name;
            }
            set
            {
                Iname.Text = value;
                name = value;
            }
        }
        public string ICategory
        {
            get 
            {
                return category;
            }
            set
            {
                Icategoty.Text = value;
                category = value;
            }
        }
        public string IPrice
        {
            get 
            {
                return price;
            }
            set
            {
                Iprice.Text = value;
                price = value;
            }
        }

        private void lName_Click(object sender, EventArgs e)
        {

        }

        private void Item_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Item_Click(object sender, EventArgs e)
        {
            DetailsForm DT = new DetailsForm(id);
            DT.Show();
        }
    }
}
