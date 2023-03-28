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
    public partial class FormSelectContact : Form
    {
        public FormSelectContact()
        {
            InitializeComponent();
        }

        private void FormSelectContact_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.КонтактныеДанные". При необходимости она может быть перемещена или удалена.
            this.контактныеДанныеTableAdapter.Fill(this.bDDataSet.КонтактныеДанные);

        }
        
        public void SetFilter(int kod)
        {
            контактныеДанныеBindingSource.Filter = "КодОрганизации=" + kod.ToString() + " and ЭлектроннаяПочта<>''";
        }
        public BDDataSet.КонтактныеДанныеRow contact;
        private void button1_Click(object sender, EventArgs e)
        {
            contact= (BDDataSet.КонтактныеДанныеRow)((DataRowView)dataGridView1.Rows[dataGridView1.CurrentRow.Index].DataBoundItem).Row;
            this.Close();
        }
    }
}
