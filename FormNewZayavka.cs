using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchZayavka
{
    public partial class FormNewZayavka : Form
    {
        public FormNewZayavka()
        {
            InitializeComponent();
        }

        private void FormNewZayavka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet1.ПодразделенияПоВидамЗаявок". При необходимости она может быть перемещена или удалена.
            this.подразделенияПоВидамЗаявокTableAdapter.Fill(this.bDDataSet1.ПодразделенияПоВидамЗаявок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.РазделыЗаявок". При необходимости она может быть перемещена или удалена.
            this.разделыЗаявокTableAdapter.Fill(this.bDDataSet.РазделыЗаявок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Заявка". При необходимости она может быть перемещена или удалена.
            this.заявкаTableAdapter.Fill(this.bDDataSet.Заявка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.КодВидаЗаявки". При необходимости она может быть перемещена или удалена.
            this.кодВидаЗаявкиTableAdapter.Fill(this.bDDataSet.КодВидаЗаявки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Организация". При необходимости она может быть перемещена или удалена.
            this.организацияTableAdapter.Fill(this.bDDataSet.Организация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Заявитель". При необходимости она может быть перемещена или удалена.
            this.заявительTableAdapter.Fill(this.bDDataSet.Заявитель);

            dateTimePicker1.Value = DateTime.Now;
            Random rnd = new Random();
            string s = "З-0" + rnd.Next(1000);
            textBox1.Text = s;
            this.Text = txt;
            z = bDDataSet.Заявка.NewЗаявкаRow();

            comboBox1.BindingContext = new BindingContext();
            comboBox2.BindingContext = new BindingContext();
            comboBox3.BindingContext = new BindingContext();
            comboBox4.BindingContext = new BindingContext();
            comboBox1.SelectedValue = -1;
            comboBox2.SelectedValue = -1;
            comboBox3.SelectedValue = -1;
            comboBox4.SelectedValue = -1;
        }

        public int SposobPolush = 1;
        public int KodSotrud = 1;
        public int KodOrganiz = 1;
        public string txt = "";

        BDDataSet.ЗаявкаRow z;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Byte[] byteArray = File.ReadAllBytes(f.FileName);
                z.Документы = byteArray;
                z.Расширение = Path.GetExtension(f.FileName).Replace(".", "");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox2.SelectedValue == null || comboBox3.SelectedValue == null)
            {
                MessageBox.Show("Заполните все поля", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            z.ДатаЗаявки = dateTimePicker1.Value;
            z.НомерЗаявки = textBox1.Text;
         
            z.КодОрганизации =  (int)comboBox2.SelectedValue;
            z.КодВидаЗаявки = (int)comboBox3.SelectedValue;
            z.КодЗаявителя= (int)comboBox1.SelectedValue;
            
            z.КодСпособаПолучения = SposobPolush;
            z.КодСотрудника = KodSotrud;
            z.Комментарии = richTextBox1.Text;

            bDDataSet.Заявка.AddЗаявкаRow(z);
            заявкаTableAdapter.Update(z);
            bDDataSet.AcceptChanges();

            this.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedValue == null) return;
            кодВидаЗаявкиBindingSource.Filter = "КодРаздела=" + comboBox4.SelectedValue.ToString();
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedValue == null) return;
            BDDataSet.КодВидаЗаявкиRow row = bDDataSet.КодВидаЗаявки.FindByКодВидаЗаявки(Convert.ToInt32(comboBox3.SelectedValue));
            if (row == null || row.IsКодОрганизацииNull()) return;

            BDDataSet.ОрганизацияRow org = bDDataSet.Организация.FindByКодОрганизации(row.КодОрганизации);
            if (org == null || org.IsКодВидаОрганизацииNull()) return;

           
            подразделенияПоВидамЗаявокBindingSource.Filter = "КодОрганизации=" + org.КодОрганизации.ToString();
            //организацияBindingSource.Filter = "КодРаздела=" + comboBox4.SelectedValue.ToString();
            // this.организацияTableAdapter.fILLByrAZDEL(this.bDDataSet.Организация,Convert.ToInt32( comboBox4.SelectedValue));
        }
    }
}
