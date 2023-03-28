namespace UchZayavka
{
    partial class FormSelectContact
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодКонтактаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодОрганизацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отделDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.подраздлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.электроннаяПочтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактныеДанныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet = new UchZayavka.BDDataSet();
            this.контактныеДанныеTableAdapter = new UchZayavka.BDDataSetTableAdapters.КонтактныеДанныеTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактныеДанныеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 49);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(186, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выбрать и отправить обращение на рассмотрение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКонтактаDataGridViewTextBoxColumn,
            this.кодОрганизацииDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.отделDataGridViewTextBoxColumn,
            this.подраздлениеDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.электроннаяПочтаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.контактныеДанныеBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(657, 252);
            this.dataGridView1.TabIndex = 1;
            // 
            // кодКонтактаDataGridViewTextBoxColumn
            // 
            this.кодКонтактаDataGridViewTextBoxColumn.DataPropertyName = "КодКонтакта";
            this.кодКонтактаDataGridViewTextBoxColumn.HeaderText = "КодКонтакта";
            this.кодКонтактаDataGridViewTextBoxColumn.Name = "кодКонтактаDataGridViewTextBoxColumn";
            this.кодКонтактаDataGridViewTextBoxColumn.Visible = false;
            // 
            // кодОрганизацииDataGridViewTextBoxColumn
            // 
            this.кодОрганизацииDataGridViewTextBoxColumn.DataPropertyName = "КодОрганизации";
            this.кодОрганизацииDataGridViewTextBoxColumn.HeaderText = "КодОрганизации";
            this.кодОрганизацииDataGridViewTextBoxColumn.Name = "кодОрганизацииDataGridViewTextBoxColumn";
            this.кодОрганизацииDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // отделDataGridViewTextBoxColumn
            // 
            this.отделDataGridViewTextBoxColumn.DataPropertyName = "Отдел";
            this.отделDataGridViewTextBoxColumn.HeaderText = "Отдел";
            this.отделDataGridViewTextBoxColumn.Name = "отделDataGridViewTextBoxColumn";
            this.отделDataGridViewTextBoxColumn.Visible = false;
            // 
            // подраздлениеDataGridViewTextBoxColumn
            // 
            this.подраздлениеDataGridViewTextBoxColumn.DataPropertyName = "Подраздление";
            this.подраздлениеDataGridViewTextBoxColumn.HeaderText = "Подраздление";
            this.подраздлениеDataGridViewTextBoxColumn.Name = "подраздлениеDataGridViewTextBoxColumn";
            this.подраздлениеDataGridViewTextBoxColumn.Visible = false;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // электроннаяПочтаDataGridViewTextBoxColumn
            // 
            this.электроннаяПочтаDataGridViewTextBoxColumn.DataPropertyName = "ЭлектроннаяПочта";
            this.электроннаяПочтаDataGridViewTextBoxColumn.HeaderText = "ЭлектроннаяПочта";
            this.электроннаяПочтаDataGridViewTextBoxColumn.Name = "электроннаяПочтаDataGridViewTextBoxColumn";
            // 
            // контактныеДанныеBindingSource
            // 
            this.контактныеДанныеBindingSource.DataMember = "КонтактныеДанные";
            this.контактныеДанныеBindingSource.DataSource = this.bDDataSet;
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // контактныеДанныеTableAdapter
            // 
            this.контактныеДанныеTableAdapter.ClearBeforeFill = true;
            // 
            // FormSelectContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 301);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormSelectContact";
            this.Text = "Выбор исполнителя обращения";
            this.Load += new System.EventHandler(this.FormSelectContact_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактныеДанныеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource контактныеДанныеBindingSource;
        private BDDataSetTableAdapters.КонтактныеДанныеTableAdapter контактныеДанныеTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКонтактаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодОрганизацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отделDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn подраздлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn электроннаяПочтаDataGridViewTextBoxColumn;
    }
}