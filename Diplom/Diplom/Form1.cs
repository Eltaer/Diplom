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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void taskBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taskBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.система_для_технической_поддержкиDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "система_для_технической_поддержкиDataSet.Task". При необходимости она может быть перемещена или удалена.
            this.taskTableAdapter.Fill(this.система_для_технической_поддержкиDataSet.Task);

        }

        private void Add_Butt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_1 add = new Add_1();
            add.ShowDialog();
        }

        private void Client_Butt_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form2 MyForm2 = new Form2();
            MyForm2.ShowDialog();
            Close();
        }

        private void Incident_Butt_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form3 MyForm3 = new Form3();
            MyForm3.ShowDialog();
            Close();
        }

        private void Crash_Butt_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form4 MyForm4 = new Form4();
            MyForm4.ShowDialog();
            Close();
        }

        private void Staff_Butt_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form5 MyForm5 = new Form5();
            MyForm5.ShowDialog();
            Close();
        }

        private void Save_Butt_Click(object sender, EventArgs e)
        {
            taskBindingSource.EndEdit();
            taskTableAdapter.Update(система_для_технической_поддержкиDataSet);
            MessageBox.Show("Запись сохранена!", "Предупреждение!");
        }

        private void taskDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
