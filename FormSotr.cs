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
    public partial class FormSotr : Form
    {
        public FormSotr()
        {
            InitializeComponent();
        }

        private void FormSotr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.bDDataSet.Сотрудники);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();


            BDDataSet.СотрудникиDataTable deletedOrders = (BDDataSet.СотрудникиDataTable)
            bDDataSet.Сотрудники.GetChanges(DataRowState.Deleted);

            BDDataSet.СотрудникиDataTable newOrders = (BDDataSet.СотрудникиDataTable)
                bDDataSet.Сотрудники.GetChanges(DataRowState.Added);

            BDDataSet.СотрудникиDataTable modifiedOrders = (BDDataSet.СотрудникиDataTable)
                bDDataSet.Сотрудники.GetChanges(DataRowState.Modified);


            if (deletedOrders != null)
            {
                сотрудникиTableAdapter.Update(deletedOrders);
            }


            if (newOrders != null)
            {
                сотрудникиTableAdapter.Update(newOrders);
            }


            if (modifiedOrders != null)
            {
                сотрудникиTableAdapter.Update(modifiedOrders);
            }

            bDDataSet.AcceptChanges();
        }
    }
}
