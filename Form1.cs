using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchZayavka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void FillTree()
        {
            foreach (BDDataSet.ВидОрганизацииRow v in bDDataSet.ВидОрганизации)
            {
                TreeNode n = treeView1.Nodes.Add(v.Наименование);
                BDDataSet.ОрганизацияDataTable dt = организацияTableAdapter.GetDataByVid(v.КодВидаОрганизации);
                foreach (BDDataSet.ОрганизацияRow o in dt.Rows)
                {
                    TreeNode nn=n.Nodes.Add(o.Наименование);
                    dict.Add(nn, o);
                }
            }
            treeView1.ExpandAll();
        }

        Dictionary<TreeNode, BDDataSet.ОрганизацияRow> dict = new Dictionary<TreeNode, BDDataSet.ОрганизацияRow>();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.КонтактныеДанные". При необходимости она может быть перемещена или удалена.
            this.контактныеДанныеTableAdapter.Fill(this.bDDataSet.КонтактныеДанные);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet1.СтатусЗаявителя". При необходимости она может быть перемещена или удалена.
            this.статусЗаявителяTableAdapter.Fill(this.bDDataSet1.СтатусЗаявителя);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Результаты". При необходимости она может быть перемещена или удалена.
            this.результатыTableAdapter.Fill(this.bDDataSet.Результаты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.ВидОрганизации". При необходимости она может быть перемещена или удалена.
            this.видОрганизацииTableAdapter.Fill(this.bDDataSet.ВидОрганизации);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.РезультатыОбработки". При необходимости она может быть перемещена или удалена.
            this.результатыОбработкиTableAdapter.Fill(this.bDDataSet.РезультатыОбработки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.bDDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.СпособПолучения". При необходимости она может быть перемещена или удалена.
            this.способПолученияTableAdapter.Fill(this.bDDataSet.СпособПолучения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.КодВидаЗаявки". При необходимости она может быть перемещена или удалена.
            this.кодВидаЗаявкиTableAdapter.Fill(this.bDDataSet.КодВидаЗаявки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Организация". При необходимости она может быть перемещена или удалена.
            this.организацияTableAdapter.Fill(this.bDDataSet.Организация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Заявитель". При необходимости она может быть перемещена или удалена.
            this.заявительTableAdapter.Fill(this.bDDataSet.Заявитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Заявка". При необходимости она может быть перемещена или удалена.
            this.заявкаTableAdapter.Fill(this.bDDataSet.Заявка);


            FillTree();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявкаBindingSource1.EndEdit();


            BDDataSet.ЗаявкаDataTable deletedOrders = (BDDataSet.ЗаявкаDataTable)
            bDDataSet.Заявка.GetChanges(DataRowState.Deleted);

            BDDataSet.ЗаявкаDataTable newOrders = (BDDataSet.ЗаявкаDataTable)
                bDDataSet.Заявка.GetChanges(DataRowState.Added);

            BDDataSet.ЗаявкаDataTable modifiedOrders = (BDDataSet.ЗаявкаDataTable)
                bDDataSet.Заявка.GetChanges(DataRowState.Modified);


            if (deletedOrders != null)
            {
                заявкаTableAdapter.Update(deletedOrders);
            }


            if (newOrders != null)
            {
                заявкаTableAdapter.Update(newOrders);
            }


            if (modifiedOrders != null)
            {
                заявкаTableAdapter.Update(modifiedOrders);
            }

            bDDataSet.AcceptChanges();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявительBindingSource.EndEdit();


            BDDataSet.ЗаявительDataTable deletedOrders = (BDDataSet.ЗаявительDataTable)
            bDDataSet.Заявитель.GetChanges(DataRowState.Deleted);

            BDDataSet.ЗаявительDataTable newOrders = (BDDataSet.ЗаявительDataTable)
                bDDataSet.Заявитель.GetChanges(DataRowState.Added);

            BDDataSet.ЗаявительDataTable modifiedOrders = (BDDataSet.ЗаявительDataTable)
                bDDataSet.Заявитель.GetChanges(DataRowState.Modified);


            if (deletedOrders != null)
            {
                заявительTableAdapter.Update(deletedOrders);
            }


            if (newOrders != null)
            {
                заявительTableAdapter.Update(newOrders);
            }


            if (modifiedOrders != null)
            {
                заявительTableAdapter.Update(modifiedOrders);
            }

            bDDataSet.AcceptChanges();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.результатыОбработкиBindingSource.EndEdit();


            BDDataSet.РезультатыОбработкиDataTable deletedOrders = (BDDataSet.РезультатыОбработкиDataTable)
            bDDataSet.РезультатыОбработки.GetChanges(DataRowState.Deleted);

            BDDataSet.РезультатыОбработкиDataTable newOrders = (BDDataSet.РезультатыОбработкиDataTable)
                bDDataSet.РезультатыОбработки.GetChanges(DataRowState.Added);

            BDDataSet.РезультатыОбработкиDataTable modifiedOrders = (BDDataSet.РезультатыОбработкиDataTable)
                bDDataSet.РезультатыОбработки.GetChanges(DataRowState.Modified);


            if (deletedOrders != null)
            {
                результатыОбработкиTableAdapter.Update(deletedOrders);
            }


            if (newOrders != null)
            {
                результатыОбработкиTableAdapter.Update(newOrders);
            }


            if (modifiedOrders != null)
            {
                результатыОбработкиTableAdapter.Update(modifiedOrders);
            }

            bDDataSet.AcceptChanges();
        }

        private void организацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrg f = new FormOrg();
            f.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView2.Rows[e.RowIndex].DataBoundItem==null) return;
        

            BDDataSet.ЗаявкаRow mod = (BDDataSet.ЗаявкаRow)((DataRowView)dataGridView2.Rows[e.RowIndex].DataBoundItem).Row;

            richTextBox1.Text = "";

            if (mod == null) return;

            if (!mod.IsКомментарииNull()) richTextBox1.Text = mod.Комментарии;


            if (e.ColumnIndex == 11)
            {
                if (mod.IsДокументыNull())
                {
                    MessageBox.Show("Документы не загружены");
                    return;
                }
                //открыть
                string filename = Path.ChangeExtension(Path.GetTempFileName(), mod.Расширение);
                File.WriteAllBytes(filename, mod.Документы);
                Process.Start(filename);
            }

            if (e.ColumnIndex == 10)
            {
                //загрузить
                OpenFileDialog o = new OpenFileDialog();
                if (o.ShowDialog() == DialogResult.OK)
                {

                    mod.Расширение = Path.GetExtension(o.FileName).Replace(".", "");
                    Byte[] byteArray = File.ReadAllBytes(o.FileName);
                    mod.Документы = byteArray;
                    заявкаTableAdapter.Update(mod);
                    bDDataSet.AcceptChanges();
                }
            }
        }

        public int Sotrudnik = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            FormNewZayavka z = new FormNewZayavka();
            z.SposobPolush = 1;
            z.KodSotrud = Sotrudnik;
            z.txt = "Заявка по личному обращению";
            z.KodOrganiz = org.КодОрганизации;
            z.ShowDialog();
            заявкаTableAdapter.Fill(bDDataSet.Заявка);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNewZayavka z = new FormNewZayavka();
            z.SposobPolush = 2;
            z.KodSotrud = Sotrudnik;
            z.txt = "Заявка по электронной почте";
            z.KodOrganiz = org.КодОрганизации;
            z.ShowDialog();
            заявкаTableAdapter.Fill(bDDataSet.Заявка);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormNewZayavka z = new FormNewZayavka();
            z.SposobPolush = 3;
            z.KodSotrud = Sotrudnik;
            z.txt = "Заявка по почте (письмо)";
            z.KodOrganiz = org.КодОрганизации;
            z.ShowDialog();
            заявкаTableAdapter.Fill(bDDataSet.Заявка);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormNewZayavka z = new FormNewZayavka();
            z.SposobPolush = 4;
            z.KodSotrud = Sotrudnik;
            z.txt = "Заявка по телефону";
            z.KodOrganiz = org.КодОрганизации;
            z.ShowDialog();
            заявкаTableAdapter.Fill(bDDataSet.Заявка);
        }

        BDDataSet.ОрганизацияRow org;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent==null)
            {
                foreach(Control c in tabPage1.Controls)
                {
                    c.Enabled = false;
                    dataGridView2.Visible = false;
                }
            }
            else
            {
                org = dict[e.Node];
                заявкаBindingSource.Filter = "КодОрганизации =" + org.КодОрганизации.ToString();
                //результатыОбработкиBindingSource.Filter = "КодОрганизации =" + org.КодОрганизации.ToString();
                foreach (Control c in tabPage1.Controls)
                {
                    c.Enabled = true;
                    dataGridView2.Visible = !false;
                }
            }
        }

        private void результатыОбработкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormResult f = new FormResult();
            f.Show();
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

   
        private void Print(BDDataSet.ЗаявкаRow mod)
        {
            if (mod == null) return;

            Microsoft.Office.Interop.Word.Document wdDoc;
            wdApp = new Microsoft.Office.Interop.Word.Application();
            wdApp.Visible = false;

          
            BDDataSet.СпособПолученияRow sp = bDDataSet.СпособПолучения.FindByКодСпособа(mod.КодСпособаПолучения);

            BDDataSet.ЗаявительRow z = bDDataSet.Заявитель.FindByКодЗаявителя(mod.КодЗаявителя);
            BDDataSet.ОрганизацияRow org = bDDataSet.Организация.FindByКодОрганизации(mod.КодОрганизации);
            BDDataSet.СотрудникиRow sotr = bDDataSet.Сотрудники.FindByКодСотрудника(mod.КодСотрудника);



            wdDoc = LoadTemplate(Environment.CurrentDirectory + @"\шаблоны\заявка.docx");
            wdDoc.Bookmarks["з1"].Select();
            wdApp.Selection.TypeText(z.IsФИОNull() ? "" : z.ФИО);

            wdDoc.Bookmarks["фио"].Select();
            wdApp.Selection.TypeText(z.IsФИОNull() ? "" : z.ФИО);


          

            wdDoc.Bookmarks["за"].Select();
            wdApp.Selection.TypeText(z.IsАдресNull() ? "" : z.Адрес);

            wdDoc.Bookmarks["зт"].Select();
            wdApp.Selection.TypeText(z.IsТелефонNull() ? "" : z.Телефон);

            wdDoc.Bookmarks["зэ"].Select();
            wdApp.Selection.TypeText(z.IsЭлектроннаяПочтаNull() ? "" : z.ЭлектроннаяПочта);

            wdDoc.Bookmarks["номер"].Select();
            wdApp.Selection.TypeText(mod.IsНомерЗаявкиNull() ? "" : mod.НомерЗаявки);

            wdDoc.Bookmarks["дата"].Select();
            wdApp.Selection.TypeText(mod.IsДатаЗаявкиNull() ? "" : mod.ДатаЗаявки.ToShortDateString());

            wdDoc.Bookmarks["орг"].Select();
            wdApp.Selection.TypeText(org.IsНаименованиеNull() ? "" : org.Наименование);

            wdDoc.Bookmarks["способ"].Select();
            wdApp.Selection.TypeText(sp.IsНаименованиеNull() ? "" : sp.Наименование);

            wdDoc.Bookmarks["сотр"].Select();
            wdApp.Selection.TypeText(sotr.IsФИОNull() ? "" : sotr.ФИО);

            StringBuilder sb = new StringBuilder();
            if (!mod.IsРасширениеNull())
            {
                sb.Append("К заявлению приложены документы.");
            }
            else
            {
                sb.Append("К заявлению документы не приложены.");
            }

            BDDataSet.РезультатыОбработкиDataTable d = результатыОбработкиTableAdapter.GetDataByКодЗаявки(mod.КодЗаявки);
            if (d != null && d.Rows.Count > 0)
            {
                sb.AppendLine().AppendLine();
                sb.AppendLine("___________________________________________________________");
                sb.AppendLine("РЕЗУЛЬТАТЫ РАССМОТРЕНИЯ ЗАЯВКИ:");
                BDDataSet.РезультатыОбработкиRow r = (BDDataSet.РезультатыОбработкиRow)d.Rows[0];
                if (!r.IsДатаРассмотренияNull()) sb.Append("Дата рассмотрения заявки: ").Append(r.ДатаРассмотрения).AppendLine(); ;
                if (!r.IsКтоРассмотрелNull()) sb.Append("Заявку рассмотрел: ").Append(r.КтоРассмотрел).AppendLine();

                if (!r.IsКодРезультатаРассмNull())
                {
                    BDDataSet.РезультатыRow rr = bDDataSet.Результаты.FindByКодРезультата(r.КодРезультатаРассм);
                    sb.Append("Результат рассмотрения: ").Append(rr.Наименование).AppendLine(); ;
                }

                if (!r.IsКомментарииNull()) sb.Append("Комментарии: ").Append(r.Комментарии);
            }


            wdDoc.Bookmarks["док"].Select();
            wdApp.Selection.TypeText(sb.ToString());

            wdDoc.SaveAs(Environment.CurrentDirectory + @"\документы\ + Заявка №" + mod.НомерЗаявки + ".pdf", WdSaveFormat.wdFormatPDF);
            wdDoc.Close(false);

            Process.Start(Environment.CurrentDirectory + @"\документы\ + Заявка №" + mod.НомерЗаявки + ".pdf");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            BDDataSet.ЗаявкаRow mod = (BDDataSet.ЗаявкаRow)((DataRowView)dataGridView2.Rows[dataGridView2.CurrentRow.Index].DataBoundItem).Row;

            Print(mod);

        }

        private void бланкЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
             BDDataSet.РезультатыОбработкиRow r = (BDDataSet.РезультатыОбработкиRow)((DataRowView)dataGridView3.Rows[dataGridView3.CurrentRow.Index].DataBoundItem).Row;
            BDDataSet.ЗаявкаRow mod = bDDataSet.Заявка.FindByКодЗаявки(r.КодЗаявки);
            Print(mod);
        }

        private void списокЗаявителейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReports f = new FormReports();
            f.FillReport("Список заявителей");
            f.Show();
        }

        private void списокЗаявокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReports f = new FormReports();
            f.FillReport("Список заявок");
            f.Show();
        }

        private void результатыОбработкиЗаявокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReports f = new FormReports();
            f.FillReport("Результаты обработки заявок");
            f.Show();
        }

        private void статистикаПриемаЗаявокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReports f = new FormReports();
            f.FillReport( "Статистика приема и обработки заявок");
        
            f.Show();

        }
        public int KodSotrud = 1;
        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KodSotrud != 1)
            {
                MessageBox.Show("У вас нет прав доступа к данному справочнику","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormUsers f = new FormUsers();
                f.Show();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void бланкОтчетаПоЗаявкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.CurrentDirectory + @"\шаблоны\заявка.docx");
        }

        private void бланкШаблонаОтчетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.CurrentDirectory + @"\шаблоны\Шаблон отчета.docx");
        }

        public static void SendMail(string smtpServer, string from, string password,
string mailto, string caption, string message, string attachFile = null)
        {
            try
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = caption;
                mail.Body = message;
                if (!string.IsNullOrEmpty(attachFile))
                    mail.Attachments.Add(new Attachment(attachFile));
                SmtpClient client = new SmtpClient();
                client.Host = smtpServer;
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }


        private void toolStripButton6_Click(object sender, EventArgs e)
        {
          
            //uchzayav@mail.ru
           // 753951Rs

            if (dataGridView2.CurrentRow!=null)
            {
                BDDataSet.ЗаявкаRow z = (BDDataSet.ЗаявкаRow)((DataRowView)dataGridView2.Rows[dataGridView2.CurrentRow.Index].DataBoundItem).Row;

                FormSelectContact f = new FormSelectContact();
                f.SetFilter(z.КодОрганизации);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    
                    string mailto = f.contact.ЭлектроннаяПочта;
                    BDDataSet.КодВидаЗаявкиRow v = (BDDataSet.КодВидаЗаявкиRow)bDDataSet.КодВидаЗаявки.FindByКодВидаЗаявки(z.КодВидаЗаявки);
                    BDDataSet.ЗаявительRow zv = (BDDataSet.ЗаявительRow)bDDataSet.Заявитель.FindByКодЗаявителя(z.КодЗаявителя);

                    string cap = "Новое обращение: " + v.Наименование;
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Добрый день!").AppendLine().AppendLine();
                    sb.Append("Поступила новая заявка. Вид заявки: " + v.Наименование).AppendLine();
                    sb.Append("Клиент: " + zv.ФИО).AppendLine();
                    if (!zv.IsАдресNull()) sb.Append("Адрес: " + zv.Адрес).AppendLine();
                    if (!zv.IsПаспортныеДанныеNull()) sb.Append("Паспортные данные: " + zv.ПаспортныеДанные).AppendLine();
                    //if (!zv.IsСНИЛСNull()) sb.Append("СНИСЛС: " + zv.СНИЛС).AppendLine();
                    //if (!zv.IsНомерПолисаNull()) sb.Append("Номер полиса: " + zv.НомерПолиса).AppendLine();
                    if (!zv.IsТелефонNull()) sb.Append("Телефон: " + zv.Телефон).AppendLine();
                    if (!zv.IsЭлектроннаяПочтаNull()) sb.Append("EMail: " + zv.ЭлектроннаяПочта).AppendLine();

                    string path = null;
                    if (!z.IsРасширениеNull())
                    {
                        path = Path.ChangeExtension(Path.GetTempPath(), z.Расширение);
                        sb.AppendLine();
                        sb.Append("К заявлению приложены документы.");
                        File.WriteAllBytes(path, z.Документы);

                    }
                    else
                    {
                        sb.Append("К заявлению документы не приложены");
                    }
                    z.КомуОтправлена = f.contact.КодКонтакта;
                    заявкаTableAdapter.Update(z);
                    bDDataSet.AcceptChanges();
                    bDDataSet1.AcceptChanges();

                    SendMail("smtp.mail.ru", "diplom2021diplom@mail.ru", "1234567Rs", mailto, cap, sb.ToString(), path);
                }
            }
        }

        private void видыОрганизацийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVidOrg f = new FormVidOrg();
            f.Show();
        }

        private void статусыЗаявителейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatus f = new FormStatus();
            f.Show();
        }

        private void группыЗаявокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrZayavka f = new FormGrZayavka();
            f.Show();
        }

        private void статистикаЗаявокПоСтатусамЗаявителейИВидамЗаявокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReports f = new FormReports();
            f.FillReport("Статистика заявок по статусам заявителей и видам заявок");

            f.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSotr f = new FormSotr();
            f.Show();

        }
    }
}
