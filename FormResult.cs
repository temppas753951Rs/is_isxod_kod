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
    public partial class FormResult : Form
    {
        public FormResult()
        {
            InitializeComponent();
        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Результаты". При необходимости она может быть перемещена или удалена.
            this.результатыTableAdapter.Fill(this.bDDataSet.Результаты);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.результатыBindingSource.EndEdit();


            BDDataSet.РезультатыDataTable deletedOrders = (BDDataSet.РезультатыDataTable)
            bDDataSet.Результаты.GetChanges(DataRowState.Deleted);

            BDDataSet.РезультатыDataTable newOrders = (BDDataSet.РезультатыDataTable)
                bDDataSet.Результаты.GetChanges(DataRowState.Added);

            BDDataSet.РезультатыDataTable modifiedOrders = (BDDataSet.РезультатыDataTable)
                bDDataSet.Результаты.GetChanges(DataRowState.Modified);


            if (deletedOrders != null)
            {
                результатыTableAdapter.Update(deletedOrders);
            }


            if (newOrders != null)
            {
                результатыTableAdapter.Update(newOrders);
            }


            if (modifiedOrders != null)
            {
                результатыTableAdapter.Update(modifiedOrders);
            }

            bDDataSet.AcceptChanges();
        }
    }
}
