using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugstoreTerm
{
    public partial class Item : UserControl
    {
        string name;
        string category;
        string price;
        public Item()
        {
            InitializeComponent();
        }

        public Item(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
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
    }
}
