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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.система_для_технической_поддержкиDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "система_для_технической_поддержкиDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.система_для_технической_поддержкиDataSet.Staff);

        }

        private void Tasks_Butt_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form1 MyForm1 = new Form1();
            MyForm1.ShowDialog();
            Close();
        }

        private void Client_Butt_Click_1(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form2 MyForm2 = new Form2();
            MyForm2.ShowDialog();
            Close();
        }

        private void Incident_Butt_Click_1(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form3 MyForm3 = new Form3();
            MyForm3.ShowDialog();
            Close();
        }

        private void Crash_Butt_Click_1(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form4 MyForm4 = new Form4();
            MyForm4.ShowDialog();
            Close();
        }

        private void Add_Butt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_5 add = new Add_5();
            add.ShowDialog();
        }

        private void Save_Butt_Click(object sender, EventArgs e)
        {
            staffBindingSource.EndEdit();
            staffTableAdapter.Update(система_для_технической_поддержкиDataSet);
            MessageBox.Show("Запись сохранена!", "Предупреждение!");
        }

        private void staffDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
