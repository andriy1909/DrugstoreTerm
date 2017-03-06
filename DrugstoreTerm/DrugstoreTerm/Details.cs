using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugstoreTerm
{
    class Details
    {
            public int id { get; set; }              //код
            public string name { get; set; }         //назва
            public string odVum { get; set; }        //од. виміру
            public int maker { get; set; }           //виробник
            public int pack { get; set; }            //упаковка
            public float price { get; set; }         //ціна
            public string info { get; set; }         //інформація
            public byte[] image { get; set; }        //зображення
            public bool isReturn { get; set; }       //можл повернення
            public bool recept { get; set; }         //рецепт
            public int analog { get; set; }          //аналог

            static string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";

            public Details()
            {

            }

            public void setDetails(string name, string odVum,
                int maker, int pack, float price, string info, Image image, bool isReturn,
                bool recept, int analog, int id = 0)
            {
                this.id = id;
                this.name = name;
                this.odVum = odVum;
                this.maker = maker;
                this.pack = pack;
                this.price = price;
                this.info = info;
                setImage(image);
                this.isReturn = isReturn;
                this.recept = recept;
                this.analog = analog;
            }

            public Image getImage()
            {
                Image newImage = null;
                if (image != null)
                {
                    using (MemoryStream stream = new MemoryStream(image))
                    {
                        newImage = Image.FromStream(stream);
                    }
                }
                return newImage;
            }
            public void setImage(Image img)
            {
                ImageConverter converter = new ImageConverter();
                image = (byte[])converter.ConvertTo(img, typeof(byte[]));
            }

            public void getDataItem(int id)
            {
                SqlConnection bd = new SqlConnection(connectString);
                bd.Open();
                SqlCommand command1 = new SqlCommand("SELECT * FROM Товари WHERE Код=" + id.ToString(), bd);
                SqlDataReader dataReader1 = command1.ExecuteReader();
                while (dataReader1.Read())
                {
                    name = dataReader1["Назва"].ToString().Trim();
                    odVum = dataReader1["ОдВим"].ToString().Trim();
                    maker = (int)dataReader1["Виробник"];
                    pack = (int)dataReader1["Упаковка"];
                    price = Convert.ToSingle(dataReader1["Ціна"]);
                    info = dataReader1["Інформація"].ToString().Trim();
                    image = (byte[])dataReader1["Фото"];
                    isReturn = (bool)dataReader1["МожливістьПовернення"];
                    recept = (bool)dataReader1["Рецепт"];
                    analog = (int)dataReader1["Аналог"];
                }
                bd.Close();
            }
    }
}
