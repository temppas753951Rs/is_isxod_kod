using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchZayavka
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BDDataSet.ПользователиDataTable dt = пользователиTableAdapter.GetDataByЛогинПароль(textBox1.Text, textBox2.Text);
            if (dt != null && dt.Rows.Count > 0)
            {
                BDDataSet.ПользователиRow p = (BDDataSet.ПользователиRow)dt.Rows[0];
                Form1 f = new Form1();
                f.KodSotrud = p.КодСотрудника;
                f.Show();
                this.Hide();
            }

        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.bDDataSet.Пользователи);

        }
    }
}
