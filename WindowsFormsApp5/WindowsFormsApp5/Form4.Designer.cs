namespace WindowsFormsApp5
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.petrov1122DataSet = new WindowsFormsApp5.petrov1122DataSet();
            this.каталогТоваровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.каталог_товаровTableAdapter = new WindowsFormsApp5.petrov1122DataSetTableAdapters.Каталог_товаровTableAdapter();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодпокупателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.логинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.почтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.покупателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrov1122DataSet1 = new WindowsFormsApp5.petrov1122DataSet1();
            this.petrov1122DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.каталогТоваровBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.каталогТоваровBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.покупателиTableAdapter = new WindowsFormsApp5.petrov1122DataSet1TableAdapters.ПокупателиTableAdapter();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.petrov1122DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrov1122DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrov1122DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // petrov1122DataSet
            // 
            this.petrov1122DataSet.DataSetName = "petrov1122DataSet";
            this.petrov1122DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // каталогТоваровBindingSource
            // 
            this.каталогТоваровBindingSource.DataMember = "Каталог товаров";
            this.каталогТоваровBindingSource.DataSource = this.petrov1122DataSet;
            // 
            // каталог_товаровTableAdapter
            // 
            this.каталог_товаровTableAdapter.ClearBeforeFill = true;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add.Location = new System.Drawing.Point(153, 295);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(171, 97);
            this.add.TabIndex = 1;
            this.add.Text = "Добавить запись";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.delete.Location = new System.Drawing.Point(330, 295);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(178, 97);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить запись";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 97);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодпокупателяDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.логинDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn,
            this.почтаDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.покупателиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(52, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // кодпокупателяDataGridViewTextBoxColumn
            // 
            this.кодпокупателяDataGridViewTextBoxColumn.DataPropertyName = "Код_покупателя";
            this.кодпокупателяDataGridViewTextBoxColumn.HeaderText = "Код_покупателя";
            this.кодпокупателяDataGridViewTextBoxColumn.Name = "кодпокупателяDataGridViewTextBoxColumn";
            this.кодпокупателяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // логинDataGridViewTextBoxColumn
            // 
            this.логинDataGridViewTextBoxColumn.DataPropertyName = "Логин";
            this.логинDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.логинDataGridViewTextBoxColumn.Name = "логинDataGridViewTextBoxColumn";
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            // 
            // почтаDataGridViewTextBoxColumn
            // 
            this.почтаDataGridViewTextBoxColumn.DataPropertyName = "Почта";
            this.почтаDataGridViewTextBoxColumn.HeaderText = "Почта";
            this.почтаDataGridViewTextBoxColumn.Name = "почтаDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // покупателиBindingSource
            // 
            this.покупателиBindingSource.DataMember = "Покупатели";
            this.покупателиBindingSource.DataSource = this.petrov1122DataSet1;
            // 
            // petrov1122DataSet1
            // 
            this.petrov1122DataSet1.DataSetName = "petrov1122DataSet1";
            this.petrov1122DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petrov1122DataSetBindingSource
            // 
            this.petrov1122DataSetBindingSource.DataSource = this.petrov1122DataSet;
            this.petrov1122DataSetBindingSource.Position = 0;
            // 
            // каталогТоваровBindingSource1
            // 
            this.каталогТоваровBindingSource1.DataMember = "Каталог товаров";
            this.каталогТоваровBindingSource1.DataSource = this.petrov1122DataSetBindingSource;
            // 
            // каталогТоваровBindingSource2
            // 
            this.каталогТоваровBindingSource2.DataMember = "Каталог товаров";
            this.каталогТоваровBindingSource2.DataSource = this.petrov1122DataSetBindingSource;
            // 
            // покупателиTableAdapter
            // 
            this.покупателиTableAdapter.ClearBeforeFill = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(703, 349);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(85, 43);
            this.back.TabIndex = 6;
            this.back.Text = "На главную";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petrov1122DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrov1122DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrov1122DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private petrov1122DataSet petrov1122DataSet;
        private System.Windows.Forms.BindingSource каталогТоваровBindingSource;
        private petrov1122DataSetTableAdapters.Каталог_товаровTableAdapter каталог_товаровTableAdapter;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource каталогТоваровBindingSource2;
        private System.Windows.Forms.BindingSource petrov1122DataSetBindingSource;
        private System.Windows.Forms.BindingSource каталогТоваровBindingSource1;
        private petrov1122DataSet1 petrov1122DataSet1;
        private System.Windows.Forms.BindingSource покупателиBindingSource;
        private petrov1122DataSet1TableAdapters.ПокупателиTableAdapter покупателиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпокупателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn почтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button back;
    }
}