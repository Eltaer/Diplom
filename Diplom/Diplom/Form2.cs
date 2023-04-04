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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Add_Butt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_2 add = new Add_2();
            add.ShowDialog();
        }

        private void Save_Butt_Click(object sender, EventArgs e)
        {
            clientsBindingSource.EndEdit();
            clientsTableAdapter.Update(система_для_технической_поддержкиDataSet);
            MessageBox.Show("Запись сохранена!", "Предупреждение!");
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.система_для_технической_поддержкиDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "система_для_технической_поддержкиDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.система_для_технической_поддержкиDataSet.Clients);

        }

        private void Tasks_Butt_Click_1(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form1 MyForm1 = new Form1();
            MyForm1.ShowDialog();
            Close();
        }

        private void Incident_Butt_Click_1(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form3 MyForm3 = new Form3();
            MyForm3.ShowDialog();
            Close();
        }

        private void Crash_Butt_Click_1(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form4 MyForm4 = new Form4();
            MyForm4.ShowDialog();
            Close();
        }

        private void Staff_Butt_Click_1(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form5 MyForm5 = new Form5();
            MyForm5.ShowDialog();
            Close();
        }

        private void clientsDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
