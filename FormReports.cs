using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchZayavka
{
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.ОтчетРезультатРассм". При необходимости она может быть перемещена или удалена.
            this.отчетРезультатРассмTableAdapter.Fill(this.bDDataSet.ОтчетРезультатРассм);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.СтатистикаПоСтатусаиВиду". При необходимости она может быть перемещена или удалена.
            this.статистикаПоСтатусаиВидуTableAdapter.Fill(this.bDDataSet.СтатистикаПоСтатусаиВиду);

        }
        public string n = "";

        public void FillReport(string name)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Организация". При необходимости она может быть перемещена или удалена.
            this.организацияTableAdapter.Fill(this.bDDataSet.Организация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.ОтчетЗаявки". При необходимости она может быть перемещена или удалена.
            this.отчетЗаявкиTableAdapter.Fill(this.bDDataSet.ОтчетЗаявки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.ОтчетРезультатРассм". При необходимости она может быть перемещена или удалена.
            this.отчетРезультатРассмTableAdapter.Fill(this.bDDataSet.ОтчетРезультатРассм);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.СтатистикаЗаявок". При необходимости она может быть перемещена или удалена.
            this.статистикаЗаявокTableAdapter.Fill(this.bDDataSet.СтатистикаЗаявок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Заявитель". При необходимости она может быть перемещена или удалена.
            this.заявительTableAdapter.Fill(this.bDDataSet.Заявитель);

            numericUpDown1.Value = DateTime.Now.Year;
            comboBox2.SelectedIndex = DateTime.Now.Month - 1;

            comboBox1.BindingContext = new BindingContext();
            comboBox1.SelectedValue = -1;

            dateTimePicker1.Value = new DateTime(2021, 1, 1);


            n = name;
            string dt1 = dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
            string dt2 = dateTimePicker2.Value.AddHours(23).Month.ToString() + "/" + dateTimePicker2.Value.AddHours(23).Day.ToString() + "/" + dateTimePicker2.Value.AddHours(23).Year.ToString();

            if (name == "Список заявок")
            {
                отчетЗаявкиBindingSource.Filter = "[Дата обращения]>=#" + dt1 + "# and  [Дата обращения] <=#" + dt2 + "#";
                if (comboBox1.SelectedValue != null) отчетЗаявкиBindingSource.Filter += " and Отдел='" + comboBox1.Text+"'";
                dataGridView1.DataSource = отчетЗаявкиBindingSource;
                
            }
            if (name == "Список заявителей")
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                comboBox1.Enabled = false;
                dataGridView1.DataSource = заявительBindingSource;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
            }
            if (name == "Результаты обработки заявок")
            {
                отчетРезультатРассмBindingSource.Filter = "[Дата обращения]>=#" + dt1 + "# and  [Дата обращения] <=#" + dt2 + "#";
                if (comboBox1.SelectedValue != null) отчетРезультатРассмBindingSource.Filter += " and Отдел='" + comboBox1.Text + "'";

                dataGridView1.DataSource = отчетРезультатРассмBindingSource;
            }

            if (name == "Статистика заявок по статусам заявителей и видам заявок")
            {
                if (comboBox2.SelectedIndex == -1) comboBox2.SelectedIndex = DateTime.Now.Month - 1;

                статистикаПоСтатусаиВидуBindingSource.Filter = "Год=" + numericUpDown1.Value.ToString() + " and Месяц=" + (comboBox2.SelectedIndex + 1).ToString();
                //  if (comboBox1.SelectedValue != null) статистикаПоСтатусаиВидуBindingSource.Filter += " and Организация_Наименование='" + comboBox1.Text + "'";
                dataGridView1.DataSource = статистикаПоСтатусаиВидуBindingSource;
                numericUpDown1.Visible = true;
                comboBox2.Visible = true;
                comboBox1.Visible = !true;
            }
                
            if (name == "Статистика приема и обработки заявок")
            {
                if (comboBox2.SelectedIndex==-1) comboBox2.SelectedIndex = DateTime.Now.Month - 1;

                статистикаЗаявокBindingSource.Filter = "Год=" + numericUpDown1.Value.ToString() + " and Месяц="+(comboBox2.SelectedIndex + 1).ToString();
                if (comboBox1.SelectedValue != null) статистикаЗаявокBindingSource.Filter += " and Отдел='" + comboBox1.Text + "'";
                dataGridView1.DataSource = статистикаЗаявокBindingSource;
                numericUpDown1.Visible = true;
                comboBox2.Visible = true;
             
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FillReport(n);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedValue = -1;
            comboBox1.Text = "";
        }

        static object oMissing = System.Reflection.Missing.Value;

        private Microsoft.Office.Interop.Word.Document LoadTemplate(string filePath)
        {
            object oTemplate = filePath;
            Microsoft.Office.Interop.Word.Document oDoc = wdApp.Documents.Add(ref oTemplate, ref oMissing, ref oMissing, ref oMissing);
            return oDoc;
        }

        Microsoft.Office.Interop.Word.Application wdApp;
        System.Data.DataTable inv = new System.Data.DataTable();


        /// <summary>
        ///
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="tbl"></param>
        /// <param name="title"></param>
        private void ExpGridToWord(System.Data.DataTable dt, Microsoft.Office.Interop.Word.Table tbl, string title)
        {
            int row = 1;
            // Microsoft.Office.Interop.Word.WdParagraphAlignment alg = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            // tbl.Cell(row, 1).Range.Text = title;
            //tbl.Rows[1].Cells.Merge();
            //tbl.Rows[1].Range.Paragraphs[1].Alignment = alg;
            row = 1;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                tbl.Cell(row, i + 1).Range.Text = dt.Columns[i].Caption;
            }

            row = 2;
            int col = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                col = 1;
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    tbl.Cell(row, col).Range.Text = dt.Rows[i][j].ToString();
                    col++;
                }

                row++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Document wdDoc;
            wdApp = new Microsoft.Office.Interop.Word.Application();
            wdApp.Visible = false;

            wdDoc = LoadTemplate(Environment.CurrentDirectory + @"\шаблоны\Шаблон отчета.docx");
            wdDoc.Bookmarks["NameOtch"].Select();
            wdApp.Selection.TypeText(n);

            wdDoc.Bookmarks["otch"].Select();
            Microsoft.Office.Interop.Word.Table tbl = wdDoc.Tables.Add(wdApp.Selection.Range, dataGridView1.Rows.Count + 1, dataGridView1.Columns.Count, Type.Missing, Type.Missing);

            System.Data.DataTable dt1 = null;

            BindingSource bs = (BindingSource)dataGridView1.DataSource;
            dt1 = ((DataSet)bs.DataSource).Tables[bs.DataMember];


            tbl.Range.Font.Size = 10;

            tbl.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
            tbl.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;

            wdDoc.Bookmarks["now"].Select();
            wdApp.Selection.TypeText(DateTime.Now.ToLongDateString());

            ExpGridToWord(dt1, tbl, n);

            wdDoc.SaveAs(Environment.CurrentDirectory + @"\документы\" + n + ".pdf", WdSaveFormat.wdFormatPDF);
            wdDoc.Close(false);

            Process.Start(Environment.CurrentDirectory + @"\документы\" + n + ".pdf");

        }
    }
}
