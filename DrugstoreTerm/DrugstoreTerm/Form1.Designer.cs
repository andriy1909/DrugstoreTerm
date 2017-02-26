namespace DrugstoreTerm
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.товариBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugstoreDataSet = new DrugstoreTerm.DrugstoreDataSet();
            this.товариTableAdapter = new DrugstoreTerm.DrugstoreDataSetTableAdapters.ТовариTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.категоріяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.позиціяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аналогDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рецептDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.можливістьПоверненняDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.фотоDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.інформаціяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цінаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.упаковкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.націнкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вхЦінаБезНДСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вхЦінаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.виробникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ставкаНДСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.штрихКодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.мінЗапасDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодМорионаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.одВимDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товариBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Location = new System.Drawing.Point(0, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(30, 482);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Tomato;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(30, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(742, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // товариBindingSource
            // 
            this.товариBindingSource.DataMember = "Товари";
            this.товариBindingSource.DataSource = this.drugstoreDataSet;
            // 
            // drugstoreDataSet
            // 
            this.drugstoreDataSet.DataSetName = "DrugstoreDataSet";
            this.drugstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товариTableAdapter
            // 
            this.товариTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(76, 23);
            this.toolStripMenuItem1.Text = "Сортувати";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // пошукToolStripMenuItem
            // 
            this.пошукToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.пошукToolStripMenuItem.Name = "пошукToolStripMenuItem";
            this.пошукToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.пошукToolStripMenuItem.Text = "Пошук";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.пошукToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(772, 27);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // категоріяDataGridViewTextBoxColumn
            // 
            this.категоріяDataGridViewTextBoxColumn.DataPropertyName = "Категорія";
            this.категоріяDataGridViewTextBoxColumn.HeaderText = "Категорія";
            this.категоріяDataGridViewTextBoxColumn.Name = "категоріяDataGridViewTextBoxColumn";
            this.категоріяDataGridViewTextBoxColumn.Visible = false;
            // 
            // позиціяDataGridViewTextBoxColumn
            // 
            this.позиціяDataGridViewTextBoxColumn.DataPropertyName = "Позиція";
            this.позиціяDataGridViewTextBoxColumn.HeaderText = "Позиція";
            this.позиціяDataGridViewTextBoxColumn.Name = "позиціяDataGridViewTextBoxColumn";
            this.позиціяDataGridViewTextBoxColumn.Visible = false;
            // 
            // кількістьDataGridViewTextBoxColumn
            // 
            this.кількістьDataGridViewTextBoxColumn.DataPropertyName = "Кількість";
            this.кількістьDataGridViewTextBoxColumn.HeaderText = "Кількість";
            this.кількістьDataGridViewTextBoxColumn.Name = "кількістьDataGridViewTextBoxColumn";
            this.кількістьDataGridViewTextBoxColumn.Visible = false;
            // 
            // аналогDataGridViewTextBoxColumn
            // 
            this.аналогDataGridViewTextBoxColumn.DataPropertyName = "Аналог";
            this.аналогDataGridViewTextBoxColumn.HeaderText = "Аналог";
            this.аналогDataGridViewTextBoxColumn.Name = "аналогDataGridViewTextBoxColumn";
            this.аналогDataGridViewTextBoxColumn.Visible = false;
            // 
            // рецептDataGridViewCheckBoxColumn
            // 
            this.рецептDataGridViewCheckBoxColumn.DataPropertyName = "Рецепт";
            this.рецептDataGridViewCheckBoxColumn.HeaderText = "Рецепт";
            this.рецептDataGridViewCheckBoxColumn.Name = "рецептDataGridViewCheckBoxColumn";
            // 
            // можливістьПоверненняDataGridViewCheckBoxColumn
            // 
            this.можливістьПоверненняDataGridViewCheckBoxColumn.DataPropertyName = "МожливістьПовернення";
            this.можливістьПоверненняDataGridViewCheckBoxColumn.HeaderText = "МожливістьПовернення";
            this.можливістьПоверненняDataGridViewCheckBoxColumn.Name = "можливістьПоверненняDataGridViewCheckBoxColumn";
            // 
            // фотоDataGridViewImageColumn
            // 
            this.фотоDataGridViewImageColumn.DataPropertyName = "Фото";
            this.фотоDataGridViewImageColumn.HeaderText = "Фото";
            this.фотоDataGridViewImageColumn.Name = "фотоDataGridViewImageColumn";
            // 
            // інформаціяDataGridViewTextBoxColumn
            // 
            this.інформаціяDataGridViewTextBoxColumn.DataPropertyName = "Інформація";
            this.інформаціяDataGridViewTextBoxColumn.HeaderText = "Інформація";
            this.інформаціяDataGridViewTextBoxColumn.Name = "інформаціяDataGridViewTextBoxColumn";
            this.інформаціяDataGridViewTextBoxColumn.Visible = false;
            // 
            // цінаDataGridViewTextBoxColumn
            // 
            this.цінаDataGridViewTextBoxColumn.DataPropertyName = "Ціна";
            this.цінаDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.цінаDataGridViewTextBoxColumn.Name = "цінаDataGridViewTextBoxColumn";
            // 
            // упаковкаDataGridViewTextBoxColumn
            // 
            this.упаковкаDataGridViewTextBoxColumn.DataPropertyName = "Упаковка";
            this.упаковкаDataGridViewTextBoxColumn.HeaderText = "Упаковка";
            this.упаковкаDataGridViewTextBoxColumn.Name = "упаковкаDataGridViewTextBoxColumn";
            this.упаковкаDataGridViewTextBoxColumn.Visible = false;
            // 
            // націнкаDataGridViewTextBoxColumn
            // 
            this.націнкаDataGridViewTextBoxColumn.DataPropertyName = "Націнка";
            this.націнкаDataGridViewTextBoxColumn.HeaderText = "Націнка";
            this.націнкаDataGridViewTextBoxColumn.Name = "націнкаDataGridViewTextBoxColumn";
            this.націнкаDataGridViewTextBoxColumn.Visible = false;
            // 
            // вхЦінаБезНДСDataGridViewTextBoxColumn
            // 
            this.вхЦінаБезНДСDataGridViewTextBoxColumn.DataPropertyName = "ВхЦінаБезНДС";
            this.вхЦінаБезНДСDataGridViewTextBoxColumn.HeaderText = "ВхЦінаБезНДС";
            this.вхЦінаБезНДСDataGridViewTextBoxColumn.Name = "вхЦінаБезНДСDataGridViewTextBoxColumn";
            this.вхЦінаБезНДСDataGridViewTextBoxColumn.Visible = false;
            // 
            // вхЦінаDataGridViewTextBoxColumn
            // 
            this.вхЦінаDataGridViewTextBoxColumn.DataPropertyName = "ВхЦіна";
            this.вхЦінаDataGridViewTextBoxColumn.HeaderText = "ВхЦіна";
            this.вхЦінаDataGridViewTextBoxColumn.Name = "вхЦінаDataGridViewTextBoxColumn";
            this.вхЦінаDataGridViewTextBoxColumn.Visible = false;
            // 
            // виробникDataGridViewTextBoxColumn
            // 
            this.виробникDataGridViewTextBoxColumn.DataPropertyName = "Виробник";
            this.виробникDataGridViewTextBoxColumn.HeaderText = "Виробник";
            this.виробникDataGridViewTextBoxColumn.Name = "виробникDataGridViewTextBoxColumn";
            this.виробникDataGridViewTextBoxColumn.Visible = false;
            // 
            // ставкаНДСDataGridViewTextBoxColumn
            // 
            this.ставкаНДСDataGridViewTextBoxColumn.DataPropertyName = "СтавкаНДС";
            this.ставкаНДСDataGridViewTextBoxColumn.HeaderText = "СтавкаНДС";
            this.ставкаНДСDataGridViewTextBoxColumn.Name = "ставкаНДСDataGridViewTextBoxColumn";
            this.ставкаНДСDataGridViewTextBoxColumn.Visible = false;
            // 
            // штрихКодDataGridViewTextBoxColumn
            // 
            this.штрихКодDataGridViewTextBoxColumn.DataPropertyName = "ШтрихКод";
            this.штрихКодDataGridViewTextBoxColumn.HeaderText = "ШтрихКод";
            this.штрихКодDataGridViewTextBoxColumn.Name = "штрихКодDataGridViewTextBoxColumn";
            this.штрихКодDataGridViewTextBoxColumn.Visible = false;
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            this.артикулDataGridViewTextBoxColumn.Visible = false;
            // 
            // мінЗапасDataGridViewTextBoxColumn
            // 
            this.мінЗапасDataGridViewTextBoxColumn.DataPropertyName = "МінЗапас";
            this.мінЗапасDataGridViewTextBoxColumn.HeaderText = "МінЗапас";
            this.мінЗапасDataGridViewTextBoxColumn.Name = "мінЗапасDataGridViewTextBoxColumn";
            this.мінЗапасDataGridViewTextBoxColumn.Visible = false;
            // 
            // кодМорионаDataGridViewTextBoxColumn
            // 
            this.кодМорионаDataGridViewTextBoxColumn.DataPropertyName = "КодМориона";
            this.кодМорионаDataGridViewTextBoxColumn.HeaderText = "КодМориона";
            this.кодМорионаDataGridViewTextBoxColumn.Name = "кодМорионаDataGridViewTextBoxColumn";
            this.кодМорионаDataGridViewTextBoxColumn.Visible = false;
            // 
            // одВимDataGridViewTextBoxColumn
            // 
            this.одВимDataGridViewTextBoxColumn.DataPropertyName = "ОдВим";
            this.одВимDataGridViewTextBoxColumn.HeaderText = "ОдВим";
            this.одВимDataGridViewTextBoxColumn.Name = "одВимDataGridViewTextBoxColumn";
            // 
            // назваDataGridViewTextBoxColumn
            // 
            this.назваDataGridViewTextBoxColumn.DataPropertyName = "Назва";
            this.назваDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.назваDataGridViewTextBoxColumn.Name = "назваDataGridViewTextBoxColumn";
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.назваDataGridViewTextBoxColumn,
            this.одВимDataGridViewTextBoxColumn,
            this.кодМорионаDataGridViewTextBoxColumn,
            this.мінЗапасDataGridViewTextBoxColumn,
            this.артикулDataGridViewTextBoxColumn,
            this.штрихКодDataGridViewTextBoxColumn,
            this.ставкаНДСDataGridViewTextBoxColumn,
            this.виробникDataGridViewTextBoxColumn,
            this.вхЦінаDataGridViewTextBoxColumn,
            this.вхЦінаБезНДСDataGridViewTextBoxColumn,
            this.націнкаDataGridViewTextBoxColumn,
            this.упаковкаDataGridViewTextBoxColumn,
            this.цінаDataGridViewTextBoxColumn,
            this.інформаціяDataGridViewTextBoxColumn,
            this.фотоDataGridViewImageColumn,
            this.можливістьПоверненняDataGridViewCheckBoxColumn,
            this.рецептDataGridViewCheckBoxColumn,
            this.аналогDataGridViewTextBoxColumn,
            this.кількістьDataGridViewTextBoxColumn,
            this.позиціяDataGridViewTextBoxColumn,
            this.категоріяDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.товариBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(30, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(742, 460);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Термінал аптеки";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товариBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DrugstoreDataSet drugstoreDataSet;
        private System.Windows.Forms.BindingSource товариBindingSource;
        private DrugstoreDataSetTableAdapters.ТовариTableAdapter товариTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem пошукToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.DataGridViewTextBoxColumn категоріяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn позиціяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn аналогDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn рецептDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn можливістьПоверненняDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn фотоDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn інформаціяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цінаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn упаковкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn націнкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вхЦінаБезНДСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вхЦінаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn виробникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ставкаНДСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn штрихКодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn мінЗапасDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодМорионаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn одВимDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

