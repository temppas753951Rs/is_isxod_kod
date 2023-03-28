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
    public partial class FormOrg : Form
    {
        public FormOrg()
        {
            InitializeComponent();
        }

        private void FormOrg_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.РазделыЗаявок". При необходимости она может быть перемещена или удалена.
            this.разделыЗаявокTableAdapter.Fill(this.bDDataSet.РазделыЗаявок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.ВидОрганизации". При необходимости она может быть перемещена или удалена.
            this.видОрганизацииTableAdapter.Fill(this.bDDataSet.ВидОрганизации);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.КонтактныеДанные". При необходимости она может быть перемещена или удалена.
            this.контактныеДанныеTableAdapter.Fill(this.bDDataSet.КонтактныеДанные);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.КодВидаЗаявки". При необходимости она может быть перемещена или удалена.
            this.кодВидаЗаявкиTableAdapter.Fill(this.bDDataSet.КодВидаЗаявки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Организация". При необходимости она может быть перемещена или удалена.
            this.организацияTableAdapter.Fill(this.bDDataSet.Организация);

        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex<0||(DataRowView)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem == null) return;
            BDDataSet.ОрганизацияRow mtr = (BDDataSet.ОрганизацияRow)((DataRowView)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem).Row;
            if (mtr != null)
            {
                контактныеДанныеBindingSource.Filter = "КодОрганизации=" + mtr.КодОрганизации.ToString();
                bDDataSet.КонтактныеДанные.КодОрганизацииColumn.DefaultValue = mtr.КодОрганизации;

                кодВидаЗаявкиBindingSource.Filter = "КодОрганизации=" + mtr.КодОрганизации.ToString();
                bDDataSet.КодВидаЗаявки.КодОрганизацииColumn.DefaultValue = mtr.КодОрганизации;
            }
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.кодВидаЗаявкиBindingSource.EndEdit();


            BDDataSet.КодВидаЗаявкиDataTable deletedOrders = (BDDataSet.КодВидаЗаявкиDataTable)
            bDDataSet.КодВидаЗаявки.GetChanges(DataRowState.Deleted);

            BDDataSet.КодВидаЗаявкиDataTable newOrders = (BDDataSet.КодВидаЗаявкиDataTable)
                bDDataSet.КодВидаЗаявки.GetChanges(DataRowState.Added);

            BDDataSet.КодВидаЗаявкиDataTable modifiedOrders = (BDDataSet.КодВидаЗаявкиDataTable)
                bDDataSet.КодВидаЗаявки.GetChanges(DataRowState.Modified);


            if (deletedOrders != null)
            {
                кодВидаЗаявкиTableAdapter.Update(deletedOrders);
            }


            if (newOrders != null)
            {
                кодВидаЗаявкиTableAdapter.Update(newOrders);
            }


            if (modifiedOrders != null)
            {
                кодВидаЗаявкиTableAdapter.Update(modifiedOrders);
            }

            bDDataSet.AcceptChanges();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.контактныеДанныеBindingSource.EndEdit();


            BDDataSet.КонтактныеДанныеDataTable deletedOrders = (BDDataSet.КонтактныеДанныеDataTable)
            bDDataSet.КонтактныеДанные.GetChanges(DataRowState.Deleted);

            BDDataSet.КонтактныеДанныеDataTable newOrders = (BDDataSet.КонтактныеДанныеDataTable)
                bDDataSet.КонтактныеДанные.GetChanges(DataRowState.Added);

            BDDataSet.КонтактныеДанныеDataTable modifiedOrders = (BDDataSet.КонтактныеДанныеDataTable)
                bDDataSet.КонтактныеДанные.GetChanges(DataRowState.Modified);


            if (deletedOrders != null)
            {
                контактныеДанныеTableAdapter.Update(deletedOrders);
            }


            if (newOrders != null)
            {
                контактныеДанныеTableAdapter.Update(newOrders);
            }


            if (modifiedOrders != null)
            {
                контактныеДанныеTableAdapter.Update(modifiedOrders);
            }

            bDDataSet.AcceptChanges();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.организацияBindingSource.EndEdit();


            BDDataSet.ОрганизацияDataTable deletedOrders = (BDDataSet.ОрганизацияDataTable)
            bDDataSet.Организация.GetChanges(DataRowState.Deleted);

            BDDataSet.ОрганизацияDataTable newOrders = (BDDataSet.ОрганизацияDataTable)
                bDDataSet.Организация.GetChanges(DataRowState.Added);

            BDDataSet.ОрганизацияDataTable modifiedOrders = (BDDataSet.ОрганизацияDataTable)
                bDDataSet.Организация.GetChanges(DataRowState.Modified);


            if (deletedOrders != null)
            {
                организацияTableAdapter.Update(deletedOrders);
            }


            if (newOrders != null)
            {
                организацияTableAdapter.Update(newOrders);
            }


            if (modifiedOrders != null)
            {
                организацияTableAdapter.Update(modifiedOrders);
            }

            bDDataSet.AcceptChanges();
        }

        private void FormOrg_FormClosed(object sender, FormClosedEventArgs e)
        {

            
        }

        private void FormOrg_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            this.Controls.Clear();
        }
    }
}
