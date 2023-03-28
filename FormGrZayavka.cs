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
    public partial class FormGrZayavka : Form
    {
        public FormGrZayavka()
        {
            InitializeComponent();
        }

        private void FormGrZayavka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.РазделыЗаявок". При необходимости она может быть перемещена или удалена.
            this.разделыЗаявокTableAdapter.Fill(this.bDDataSet.РазделыЗаявок);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.разделыЗаявокBindingSource.EndEdit();


            BDDataSet.РазделыЗаявокDataTable deletedOrders = (BDDataSet.РазделыЗаявокDataTable)
            bDDataSet.РазделыЗаявок.GetChanges(DataRowState.Deleted);

            BDDataSet.РазделыЗаявокDataTable newOrders = (BDDataSet.РазделыЗаявокDataTable)
                bDDataSet.РазделыЗаявок.GetChanges(DataRowState.Added);

            BDDataSet.РазделыЗаявокDataTable modifiedOrders = (BDDataSet.РазделыЗаявокDataTable)
                bDDataSet.РазделыЗаявок.GetChanges(DataRowState.Modified);


            if (deletedOrders != null)
            {
                разделыЗаявокTableAdapter.Update(deletedOrders);
            }


            if (newOrders != null)
            {
                разделыЗаявокTableAdapter.Update(newOrders);
            }


            if (modifiedOrders != null)
            {
                разделыЗаявокTableAdapter.Update(modifiedOrders);
            }

            bDDataSet.AcceptChanges();
        }
    }
}
