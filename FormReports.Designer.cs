namespace UchZayavka
{
    partial class FormReports
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
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.организацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet = new UchZayavka.BDDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.заявительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявительTableAdapter = new UchZayavka.BDDataSetTableAdapters.ЗаявительTableAdapter();
            this.статистикаЗаявокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.статистикаЗаявокTableAdapter = new UchZayavka.BDDataSetTableAdapters.СтатистикаЗаявокTableAdapter();
            this.отчетЗаявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отчетЗаявкиTableAdapter = new UchZayavka.BDDataSetTableAdapters.ОтчетЗаявкиTableAdapter();
            this.организацияTableAdapter = new UchZayavka.BDDataSetTableAdapters.ОрганизацияTableAdapter();
            this.статистикаПоСтатусаиВидуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.статистикаПоСтатусаиВидуTableAdapter = new UchZayavka.BDDataSetTableAdapters.СтатистикаПоСтатусаиВидуTableAdapter();
            this.отчетРезультатРассмBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отчетРезультатРассмTableAdapter = new UchZayavka.BDDataSetTableAdapters.ОтчетРезультатРассмTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статистикаЗаявокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетЗаявкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статистикаПоСтатусаиВидуBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетРезультатРассмBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 72);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Image = global::UchZayavka.Properties.Resources.w16h161349012427eraser;
            this.button3.Location = new System.Drawing.Point(315, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 22);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "январь",
            "февраль",
            "март",
            "апрель",
            "май",
            "июнь",
            "июль",
            "август ",
            "сентябрь",
            "октябрь",
            "ноябрь"});
            this.comboBox2.Location = new System.Drawing.Point(235, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(103, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(126, 41);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(103, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(465, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "Экспорт отчета в формат PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Построить отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(235, 40);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Период отчета";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.организацияBindingSource;
            this.comboBox1.DisplayMember = "Наименование";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "КодОрганизации";
            // 
            // организацияBindingSource
            // 
            this.организацияBindingSource.DataMember = "Организация";
            this.организацияBindingSource.DataSource = this.bDDataSetBindingSource;
            // 
            // bDDataSetBindingSource
            // 
            this.bDDataSetBindingSource.DataSource = this.bDDataSet;
            this.bDDataSetBindingSource.Position = 0;
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подразделение";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 334);
            this.dataGridView1.TabIndex = 1;
            // 
            // заявительBindingSource
            // 
            this.заявительBindingSource.DataMember = "Заявитель";
            this.заявительBindingSource.DataSource = this.bDDataSet;
            // 
            // заявительTableAdapter
            // 
            this.заявительTableAdapter.ClearBeforeFill = true;
            // 
            // статистикаЗаявокBindingSource
            // 
            this.статистикаЗаявокBindingSource.DataMember = "СтатистикаЗаявок";
            this.статистикаЗаявокBindingSource.DataSource = this.bDDataSet;
            // 
            // статистикаЗаявокTableAdapter
            // 
            this.статистикаЗаявокTableAdapter.ClearBeforeFill = true;
            // 
            // отчетЗаявкиBindingSource
            // 
            this.отчетЗаявкиBindingSource.DataMember = "ОтчетЗаявки";
            this.отчетЗаявкиBindingSource.DataSource = this.bDDataSet;
            // 
            // отчетЗаявкиTableAdapter
            // 
            this.отчетЗаявкиTableAdapter.ClearBeforeFill = true;
            // 
            // организацияTableAdapter
            // 
            this.организацияTableAdapter.ClearBeforeFill = true;
            // 
            // статистикаПоСтатусаиВидуBindingSource
            // 
            this.статистикаПоСтатусаиВидуBindingSource.DataMember = "СтатистикаПоСтатусаиВиду";
            this.статистикаПоСтатусаиВидуBindingSource.DataSource = this.bDDataSet;
            // 
            // статистикаПоСтатусаиВидуTableAdapter
            // 
            this.статистикаПоСтатусаиВидуTableAdapter.ClearBeforeFill = true;
            // 
            // отчетРезультатРассмBindingSource
            // 
            this.отчетРезультатРассмBindingSource.DataMember = "ОтчетРезультатРассм";
            this.отчетРезультатРассмBindingSource.DataSource = this.bDDataSet;
            // 
            // отчетРезультатРассмTableAdapter
            // 
            this.отчетРезультатРассмTableAdapter.ClearBeforeFill = true;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 406);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormReports";
            this.Text = "Отчеты";
            this.Load += new System.EventHandler(this.FormReports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статистикаЗаявокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетЗаявкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статистикаПоСтатусаиВидуBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетРезультатРассмBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource заявительBindingSource;
        private BDDataSetTableAdapters.ЗаявительTableAdapter заявительTableAdapter;
        private System.Windows.Forms.BindingSource статистикаЗаявокBindingSource;
        private BDDataSetTableAdapters.СтатистикаЗаявокTableAdapter статистикаЗаявокTableAdapter;
        private System.Windows.Forms.BindingSource отчетЗаявкиBindingSource;
        private BDDataSetTableAdapters.ОтчетЗаявкиTableAdapter отчетЗаявкиTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.BindingSource bDDataSetBindingSource;
        private System.Windows.Forms.BindingSource организацияBindingSource;
        private BDDataSetTableAdapters.ОрганизацияTableAdapter организацияTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource статистикаПоСтатусаиВидуBindingSource;
        private BDDataSetTableAdapters.СтатистикаПоСтатусаиВидуTableAdapter статистикаПоСтатусаиВидуTableAdapter;
        private System.Windows.Forms.BindingSource отчетРезультатРассмBindingSource;
        private BDDataSetTableAdapters.ОтчетРезультатРассмTableAdapter отчетРезультатРассмTableAdapter;
    }
}