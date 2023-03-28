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
    public partial class FormStatus : Form
    {
        public FormStatus()
        {
            InitializeComponent();
        }

        private void FormStatus_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.СтатусЗаявителя". При необходимости она может быть перемещена или удалена.
            this.статусЗаявителяTableAdapter.Fill(this.bDDataSet.СтатусЗаявителя);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.статусЗаявителяBindingSource.EndEdit();


            BDDataSet.СтатусЗаявителяDataTable deletedOrders = (BDDataSet.СтатусЗаявителяDataTable)
            bDDataSet.СтатусЗаявителя.GetChanges(DataRowState.Deleted);

            BDDataSet.СтатусЗаявителяDataTable newOrders = (BDDataSet.СтатусЗаявителяDataTable)
                bDDataSet.СтатусЗаявителя.GetChanges(DataRowState.Added);

            BDDataSet.СтатусЗаявителяDataTable modifiedOrders = (BDDataSet.СтатусЗаявителяDataTable)
                bDDataSet.СтатусЗаявителя.GetChanges(DataRowState.Modified);


            if (deletedOrders != null)
            {
                статусЗаявителяTableAdapter.Update(deletedOrders);
            }


            if (newOrders != null)
            {
                статусЗаявителяTableAdapter.Update(newOrders);
            }


            if (modifiedOrders != null)
            {
                статусЗаявителяTableAdapter.Update(modifiedOrders);
            }

            bDDataSet.AcceptChanges();
        }
    }
}
