using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Add_2 : Form
    {
        public Add_2()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.система_для_технической_поддержкиDataSet);

        }

        private void Add_2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "система_для_технической_поддержкиDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.система_для_технической_поддержкиDataSet.Clients);

        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            clientsBindingSource.AddNew();
            clientsTableAdapter.Update(система_для_технической_поддержкиDataSet);
        }

        private void CloseAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Form2 = new Form2();
            Form2.ShowDialog();
        }
    }
}
