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
    public partial class FormVidOrg : Form
    {
        public FormVidOrg()
        {
            InitializeComponent();
        }

        private void FormVidOrg_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.ВидОрганизации". При необходимости она может быть перемещена или удалена.
            this.видОрганизацииTableAdapter.Fill(this.bDDataSet.ВидОрганизации);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.видОрганизацииBindingSource.EndEdit();


            BDDataSet.ВидОрганизацииDataTable deletedOrders = (BDDataSet.ВидОрганизацииDataTable)
            bDDataSet.ВидОрганизации.GetChanges(DataRowState.Deleted);

            BDDataSet.ВидОрганизацииDataTable newOrders = (BDDataSet.ВидОрганизацииDataTable)
                bDDataSet.ВидОрганизации.GetChanges(DataRowState.Added);

            BDDataSet.ВидОрганизацииDataTable modifiedOrders = (BDDataSet.ВидОрганизацииDataTable)
                bDDataSet.ВидОрганизации.GetChanges(DataRowState.Modified);


            if (deletedOrders != null)
            {
                видОрганизацииTableAdapter.Update(deletedOrders);
            }


            if (newOrders != null)
            {
                видОрганизацииTableAdapter.Update(newOrders);
            }


            if (modifiedOrders != null)
            {
                видОрганизацииTableAdapter.Update(modifiedOrders);
            }

            bDDataSet.AcceptChanges();
        }
    }
}
