namespace WindowsFormsApp5
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодтовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиетовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьтовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.каталогТоваровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrov1122DataSet2 = new WindowsFormsApp5.petrov1122DataSet2();
            this.каталог_товаровTableAdapter = new WindowsFormsApp5.petrov1122DataSet2TableAdapters.Каталог_товаровTableAdapter();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrov1122DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодтовараDataGridViewTextBoxColumn,
            this.наименованиетовараDataGridViewTextBoxColumn,
            this.кодпоставщикаDataGridViewTextBoxColumn,
            this.кодзаказаDataGridViewTextBoxColumn,
            this.стоимостьтовараDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.каталогТоваровBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(133, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // кодтовараDataGridViewTextBoxColumn
            // 
            this.кодтовараDataGridViewTextBoxColumn.DataPropertyName = "Код_товара";
            this.кодтовараDataGridViewTextBoxColumn.HeaderText = "Код_товара";
            this.кодтовараDataGridViewTextBoxColumn.Name = "кодтовараDataGridViewTextBoxColumn";
            // 
            // наименованиетовараDataGridViewTextBoxColumn
            // 
            this.наименованиетовараDataGridViewTextBoxColumn.DataPropertyName = "Наименование_товара";
            this.наименованиетовараDataGridViewTextBoxColumn.HeaderText = "Наименование_товара";
            this.наименованиетовараDataGridViewTextBoxColumn.Name = "наименованиетовараDataGridViewTextBoxColumn";
            // 
            // кодпоставщикаDataGridViewTextBoxColumn
            // 
            this.кодпоставщикаDataGridViewTextBoxColumn.DataPropertyName = "Код_поставщика";
            this.кодпоставщикаDataGridViewTextBoxColumn.HeaderText = "Код_поставщика";
            this.кодпоставщикаDataGridViewTextBoxColumn.Name = "кодпоставщикаDataGridViewTextBoxColumn";
            // 
            // кодзаказаDataGridViewTextBoxColumn
            // 
            this.кодзаказаDataGridViewTextBoxColumn.DataPropertyName = "Код_заказа";
            this.кодзаказаDataGridViewTextBoxColumn.HeaderText = "Код_заказа";
            this.кодзаказаDataGridViewTextBoxColumn.Name = "кодзаказаDataGridViewTextBoxColumn";
            // 
            // стоимостьтовараDataGridViewTextBoxColumn
            // 
            this.стоимостьтовараDataGridViewTextBoxColumn.DataPropertyName = "Стоимость_товара";
            this.стоимостьтовараDataGridViewTextBoxColumn.HeaderText = "Стоимость_товара";
            this.стоимостьтовараDataGridViewTextBoxColumn.Name = "стоимостьтовараDataGridViewTextBoxColumn";
            // 
            // каталогТоваровBindingSource
            // 
            this.каталогТоваровBindingSource.DataMember = "Каталог товаров";
            this.каталогТоваровBindingSource.DataSource = this.petrov1122DataSet2;
            // 
            // petrov1122DataSet2
            // 
            this.petrov1122DataSet2.DataSetName = "petrov1122DataSet2";
            this.petrov1122DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // каталог_товаровTableAdapter
            // 
            this.каталог_товаровTableAdapter.ClearBeforeFill = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(484, 305);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(99, 66);
            this.save.TabIndex = 2;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(351, 305);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(99, 66);
            this.delete.TabIndex = 3;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(206, 305);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(99, 66);
            this.add.TabIndex = 4;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(694, 328);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(85, 43);
            this.back.TabIndex = 5;
            this.back.Text = "На главную";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrov1122DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private petrov1122DataSet2 petrov1122DataSet2;
        private System.Windows.Forms.BindingSource каталогТоваровBindingSource;
        private petrov1122DataSet2TableAdapters.Каталог_товаровTableAdapter каталог_товаровTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодтовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиетовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодзаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьтовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button back;
    }
}