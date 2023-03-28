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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.bDDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.bDDataSet.Пользователи);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользователиBindingSource.EndEdit();


            BDDataSet.ПользователиDataTable deletedOrders = (BDDataSet.ПользователиDataTable)
            bDDataSet.Пользователи.GetChanges(DataRowState.Deleted);

            BDDataSet.ПользователиDataTable newOrders = (BDDataSet.ПользователиDataTable)
                bDDataSet.Пользователи.GetChanges(DataRowState.Added);

            BDDataSet.ПользователиDataTable modifiedOrders = (BDDataSet.ПользователиDataTable)
                bDDataSet.Пользователи.GetChanges(DataRowState.Modified);


            if (deletedOrders != null)
            {
                пользователиTableAdapter.Update(deletedOrders);
            }


            if (newOrders != null)
            {
                пользователиTableAdapter.Update(newOrders);
            }


            if (modifiedOrders != null)
            {
                пользователиTableAdapter.Update(modifiedOrders);
            }

            bDDataSet.AcceptChanges();
        }
    }
}
