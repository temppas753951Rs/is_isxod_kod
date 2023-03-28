namespace UchZayavka
{
    partial class FormNewZayavka
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.заявительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet = new UchZayavka.BDDataSet();
            this.заявительTableAdapter = new UchZayavka.BDDataSetTableAdapters.ЗаявительTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.подразделенияПоВидамЗаявокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet1 = new UchZayavka.BDDataSet();
            this.организацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.организацияTableAdapter = new UchZayavka.BDDataSetTableAdapters.ОрганизацияTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.кодВидаЗаявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодВидаЗаявкиTableAdapter = new UchZayavka.BDDataSetTableAdapters.КодВидаЗаявкиTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.заявкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявкаTableAdapter = new UchZayavka.BDDataSetTableAdapters.ЗаявкаTableAdapter();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.разделыЗаявокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.разделыЗаявокTableAdapter = new UchZayavka.BDDataSetTableAdapters.РазделыЗаявокTableAdapter();
            this.подразделенияПоВидамЗаявокTableAdapter = new UchZayavka.BDDataSetTableAdapters.ПодразделенияПоВидамЗаявокTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.заявительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подразделенияПоВидамЗаявокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кодВидаЗаявкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.разделыЗаявокBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата обращения";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(220, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер обращения";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox1.Location = new System.Drawing.Point(342, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Заявитель";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox1.DataSource = this.заявительBindingSource;
            this.comboBox1.DisplayMember = "ФИО";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(306, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "КодЗаявителя";
            // 
            // заявительBindingSource
            // 
            this.заявительBindingSource.DataMember = "Заявитель";
            this.заявительBindingSource.DataSource = this.bDDataSet;
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заявительTableAdapter
            // 
            this.заявительTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Подразделение";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox2.DataSource = this.подразделенияПоВидамЗаявокBindingSource;
            this.comboBox2.DisplayMember = "Наименование";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(105, 136);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(306, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "КодОрганизации";
            // 
            // подразделенияПоВидамЗаявокBindingSource
            // 
            this.подразделенияПоВидамЗаявокBindingSource.DataMember = "ПодразделенияПоВидамЗаявок";
            this.подразделенияПоВидамЗаявокBindingSource.DataSource = this.bDDataSet1;
            // 
            // bDDataSet1
            // 
            this.bDDataSet1.DataSetName = "BDDataSet";
            this.bDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // организацияBindingSource
            // 
            this.организацияBindingSource.DataMember = "Организация";
            this.организацияBindingSource.DataSource = this.bDDataSet;
            // 
            // организацияTableAdapter
            // 
            this.организацияTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Вид обращения";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox3.DataSource = this.кодВидаЗаявкиBindingSource;
            this.comboBox3.DisplayMember = "Наименование";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(105, 99);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(306, 21);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.ValueMember = "КодВидаЗаявки";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // кодВидаЗаявкиBindingSource
            // 
            this.кодВидаЗаявкиBindingSource.DataMember = "КодВидаЗаявки";
            this.кодВидаЗаявкиBindingSource.DataSource = this.bDDataSet;
            // 
            // кодВидаЗаявкиTableAdapter
            // 
            this.кодВидаЗаявкиTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Комментарии";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox1.Location = new System.Drawing.Point(19, 264);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(392, 96);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(20, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Загрузить документы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::UchZayavka.Properties.Resources._24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(154, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 42);
            this.button2.TabIndex = 14;
            this.button2.Text = "Зарегистрировать обращение";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(157, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 51);
            this.label7.TabIndex = 15;
            this.label7.Text = "Если обращение содержит несколько документов предварительно заархивируйте их в фо" +
    "рмат rar, zip, 7z, др.";
            // 
            // заявкаBindingSource
            // 
            this.заявкаBindingSource.DataMember = "Заявка";
            this.заявкаBindingSource.DataSource = this.bDDataSet;
            // 
            // заявкаTableAdapter
            // 
            this.заявкаTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox4.DataSource = this.разделыЗаявокBindingSource;
            this.comboBox4.DisplayMember = "Наименование";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(106, 61);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(306, 21);
            this.comboBox4.TabIndex = 17;
            this.comboBox4.ValueMember = "КодРаздела";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // разделыЗаявокBindingSource
            // 
            this.разделыЗаявокBindingSource.DataMember = "РазделыЗаявок";
            this.разделыЗаявокBindingSource.DataSource = this.bDDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Категория ";
            // 
            // разделыЗаявокTableAdapter
            // 
            this.разделыЗаявокTableAdapter.ClearBeforeFill = true;
            // 
            // подразделенияПоВидамЗаявокTableAdapter
            // 
            this.подразделенияПоВидамЗаявокTableAdapter.ClearBeforeFill = true;
            // 
            // FormNewZayavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 422);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "FormNewZayavka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новое обращение";
            this.Load += new System.EventHandler(this.FormNewZayavka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.заявительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подразделенияПоВидамЗаявокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кодВидаЗаявкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.разделыЗаявокBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource заявительBindingSource;
        private BDDataSetTableAdapters.ЗаявительTableAdapter заявительTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource организацияBindingSource;
        private BDDataSetTableAdapters.ОрганизацияTableAdapter организацияTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource кодВидаЗаявкиBindingSource;
        private BDDataSetTableAdapters.КодВидаЗаявкиTableAdapter кодВидаЗаявкиTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource заявкаBindingSource;
        private BDDataSetTableAdapters.ЗаявкаTableAdapter заявкаTableAdapter;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource разделыЗаявокBindingSource;
        private BDDataSetTableAdapters.РазделыЗаявокTableAdapter разделыЗаявокTableAdapter;
        private BDDataSet bDDataSet1;
        private System.Windows.Forms.BindingSource подразделенияПоВидамЗаявокBindingSource;
        private BDDataSetTableAdapters.ПодразделенияПоВидамЗаявокTableAdapter подразделенияПоВидамЗаявокTableAdapter;
    }
}