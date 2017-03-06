namespace DrugstoreTerm
{
    partial class DetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbInform = new System.Windows.Forms.TextBox();
            this.tbOutPrice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbOdVum = new System.Windows.Forms.ComboBox();
            this.cbAnalog = new System.Windows.Forms.ComboBox();
            this.cbPack = new System.Windows.Forms.ComboBox();
            this.cbProducer = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbReturn = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // tbInform
            // 
            this.tbInform.Location = new System.Drawing.Point(11, 168);
            this.tbInform.Multiline = true;
            this.tbInform.Name = "tbInform";
            this.tbInform.Size = new System.Drawing.Size(551, 110);
            this.tbInform.TabIndex = 11;
            // 
            // tbOutPrice
            // 
            this.tbOutPrice.Location = new System.Drawing.Point(228, 142);
            this.tbOutPrice.Name = "tbOutPrice";
            this.tbOutPrice.ReadOnly = true;
            this.tbOutPrice.Size = new System.Drawing.Size(185, 20);
            this.tbOutPrice.TabIndex = 14;
            this.tbOutPrice.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(168, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Відп. ціна";
            // 
            // cbOdVum
            // 
            this.cbOdVum.FormattingEnabled = true;
            this.cbOdVum.Items.AddRange(new object[] {
            "упковка",
            "ампула",
            "порошок"});
            this.cbOdVum.Location = new System.Drawing.Point(257, 35);
            this.cbOdVum.Name = "cbOdVum";
            this.cbOdVum.Size = new System.Drawing.Size(120, 21);
            this.cbOdVum.TabIndex = 29;
            this.cbOdVum.SelectedIndexChanged += new System.EventHandler(this.cbOdVum_SelectedIndexChanged);
            // 
            // cbAnalog
            // 
            this.cbAnalog.DisplayMember = "Назва";
            this.cbAnalog.FormattingEnabled = true;
            this.cbAnalog.Location = new System.Drawing.Point(297, 115);
            this.cbAnalog.Name = "cbAnalog";
            this.cbAnalog.Size = new System.Drawing.Size(116, 21);
            this.cbAnalog.TabIndex = 27;
            this.cbAnalog.ValueMember = "Код";
            this.cbAnalog.Visible = false;
            // 
            // cbPack
            // 
            this.cbPack.DisplayMember = "Назва";
            this.cbPack.FormattingEnabled = true;
            this.cbPack.Location = new System.Drawing.Point(231, 88);
            this.cbPack.Name = "cbPack";
            this.cbPack.Size = new System.Drawing.Size(182, 21);
            this.cbPack.TabIndex = 28;
            this.cbPack.ValueMember = "Код";
            // 
            // cbProducer
            // 
            this.cbProducer.DisplayMember = "Назва";
            this.cbProducer.FormattingEnabled = true;
            this.cbProducer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbProducer.Location = new System.Drawing.Point(445, 35);
            this.cbProducer.Name = "cbProducer";
            this.cbProducer.Size = new System.Drawing.Size(117, 21);
            this.cbProducer.TabIndex = 26;
            this.cbProducer.ValueMember = "Код";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(168, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Упаковка";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(257, 9);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(305, 20);
            this.tbName.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(333, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "По рецепті";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbReturn
            // 
            this.cbReturn.AutoSize = true;
            this.cbReturn.Enabled = false;
            this.cbReturn.Location = new System.Drawing.Point(171, 65);
            this.cbReturn.Name = "cbReturn";
            this.cbReturn.Size = new System.Drawing.Size(149, 17);
            this.cbReturn.TabIndex = 23;
            this.cbReturn.Text = "Можливість повернення";
            this.cbReturn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Одиниці виміру";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Назва товара";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(168, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Аналог для препарата:";
            this.label13.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Виробник";
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 286);
            this.Controls.Add(this.cbOdVum);
            this.Controls.Add(this.cbAnalog);
            this.Controls.Add(this.cbPack);
            this.Controls.Add(this.cbProducer);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbReturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbOutPrice);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbInform);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetailsForm";
            this.Text = "Детальний перегляд";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbInform;
        private System.Windows.Forms.TextBox tbOutPrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbOdVum;
        private System.Windows.Forms.ComboBox cbAnalog;
        private System.Windows.Forms.ComboBox cbPack;
        private System.Windows.Forms.ComboBox cbProducer;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox cbReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
    }
}