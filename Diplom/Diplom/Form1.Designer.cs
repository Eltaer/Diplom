namespace Diplom
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Staff_Butt = new System.Windows.Forms.Button();
            this.Tasks_Butt = new System.Windows.Forms.Button();
            this.Client_Butt = new System.Windows.Forms.Button();
            this.Crash_Butt = new System.Windows.Forms.Button();
            this.Incident_Butt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Butt = new System.Windows.Forms.Button();
            this.Save_Butt = new System.Windows.Forms.Button();
            this.система_для_технической_поддержкиDataSet = new Diplom.Система_для_технической_поддержкиDataSet();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskTableAdapter = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TaskTableAdapter();
            this.tableAdapterManager = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager();
            this.taskDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Staff_Butt);
            this.panel1.Controls.Add(this.Tasks_Butt);
            this.panel1.Controls.Add(this.Client_Butt);
            this.panel1.Controls.Add(this.Crash_Butt);
            this.panel1.Controls.Add(this.Incident_Butt);
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1756, 72);
            this.panel1.TabIndex = 8;
            // 
            // Staff_Butt
            // 
            this.Staff_Butt.Location = new System.Drawing.Point(392, 6);
            this.Staff_Butt.Name = "Staff_Butt";
            this.Staff_Butt.Size = new System.Drawing.Size(73, 57);
            this.Staff_Butt.TabIndex = 0;
            this.Staff_Butt.Text = "Персонал";
            this.Staff_Butt.UseVisualStyleBackColor = true;
            this.Staff_Butt.Click += new System.EventHandler(this.Staff_Butt_Click);
            // 
            // Tasks_Butt
            // 
            this.Tasks_Butt.Location = new System.Drawing.Point(12, 6);
            this.Tasks_Butt.Name = "Tasks_Butt";
            this.Tasks_Butt.Size = new System.Drawing.Size(73, 57);
            this.Tasks_Butt.TabIndex = 4;
            this.Tasks_Butt.Text = "Задачи";
            this.Tasks_Butt.UseVisualStyleBackColor = true;
            // 
            // Client_Butt
            // 
            this.Client_Butt.Location = new System.Drawing.Point(107, 6);
            this.Client_Butt.Name = "Client_Butt";
            this.Client_Butt.Size = new System.Drawing.Size(73, 57);
            this.Client_Butt.TabIndex = 5;
            this.Client_Butt.Text = "Клиенты";
            this.Client_Butt.UseVisualStyleBackColor = true;
            this.Client_Butt.Click += new System.EventHandler(this.Client_Butt_Click);
            // 
            // Crash_Butt
            // 
            this.Crash_Butt.Location = new System.Drawing.Point(295, 6);
            this.Crash_Butt.Name = "Crash_Butt";
            this.Crash_Butt.Size = new System.Drawing.Size(73, 57);
            this.Crash_Butt.TabIndex = 3;
            this.Crash_Butt.Text = "Аварии";
            this.Crash_Butt.UseVisualStyleBackColor = true;
            this.Crash_Butt.Click += new System.EventHandler(this.Crash_Butt_Click);
            // 
            // Incident_Butt
            // 
            this.Incident_Butt.Location = new System.Drawing.Point(201, 6);
            this.Incident_Butt.Name = "Incident_Butt";
            this.Incident_Butt.Size = new System.Drawing.Size(73, 57);
            this.Incident_Butt.TabIndex = 2;
            this.Incident_Butt.Text = "Инциденты";
            this.Incident_Butt.UseVisualStyleBackColor = true;
            this.Incident_Butt.Click += new System.EventHandler(this.Incident_Butt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1288, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // Add_Butt
            // 
            this.Add_Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Butt.Location = new System.Drawing.Point(12, 406);
            this.Add_Butt.Name = "Add_Butt";
            this.Add_Butt.Size = new System.Drawing.Size(197, 40);
            this.Add_Butt.TabIndex = 14;
            this.Add_Butt.Text = "Добавить";
            this.Add_Butt.UseVisualStyleBackColor = true;
            this.Add_Butt.Click += new System.EventHandler(this.Add_Butt_Click);
            // 
            // Save_Butt
            // 
            this.Save_Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_Butt.Location = new System.Drawing.Point(233, 406);
            this.Save_Butt.Name = "Save_Butt";
            this.Save_Butt.Size = new System.Drawing.Size(197, 40);
            this.Save_Butt.TabIndex = 15;
            this.Save_Butt.Text = "Сохранить";
            this.Save_Butt.UseVisualStyleBackColor = true;
            this.Save_Butt.Click += new System.EventHandler(this.Save_Butt_Click);
            // 
            // система_для_технической_поддержкиDataSet
            // 
            this.система_для_технической_поддержкиDataSet.DataSetName = "Система_для_технической_поддержкиDataSet";
            this.система_для_технической_поддержкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.система_для_технической_поддержкиDataSet;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.CrashTableAdapter = null;
            this.tableAdapterManager.Incident_ClientTableAdapter = null;
            this.tableAdapterManager.IncidentTableAdapter = null;
            this.tableAdapterManager.Staff_CrashTableAdapter = null;
            this.tableAdapterManager.Staff_IncidentTableAdapter = null;
            this.tableAdapterManager.Staff_TaskTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.Task_ClientTableAdapter = null;
            this.tableAdapterManager.TaskTableAdapter = this.taskTableAdapter;
            this.tableAdapterManager.UpdateOrder = Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taskDataGridView
            // 
            this.taskDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskDataGridView.AutoGenerateColumns = false;
            this.taskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.taskDataGridView.DataSource = this.taskBindingSource;
            this.taskDataGridView.Location = new System.Drawing.Point(0, 99);
            this.taskDataGridView.Name = "taskDataGridView";
            this.taskDataGridView.Size = new System.Drawing.Size(1288, 301);
            this.taskDataGridView.TabIndex = 16;
            this.taskDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.taskDataGridView_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Task_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Task_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Registration_Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Registration_Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "F_CName";
            this.dataGridViewTextBoxColumn3.HeaderText = "F_CName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "R_CName";
            this.dataGridViewTextBoxColumn4.HeaderText = "R_CName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "O_CName";
            this.dataGridViewTextBoxColumn5.HeaderText = "O_CName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Completion_Date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Completion_Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Specialist";
            this.dataGridViewTextBoxColumn8.HeaderText = "Specialist";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn9.HeaderText = "Address";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1288, 466);
            this.Controls.Add(this.taskDataGridView);
            this.Controls.Add(this.Save_Butt);
            this.Controls.Add(this.Add_Butt);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Задачи";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Staff_Butt;
        private System.Windows.Forms.Button Tasks_Butt;
        private System.Windows.Forms.Button Client_Butt;
        private System.Windows.Forms.Button Crash_Butt;
        private System.Windows.Forms.Button Incident_Butt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        public System.Windows.Forms.Button Add_Butt;
        public System.Windows.Forms.Button Save_Butt;
        private Система_для_технической_поддержкиDataSet система_для_технической_поддержкиDataSet;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private Система_для_технической_поддержкиDataSetTableAdapters.TaskTableAdapter taskTableAdapter;
        private Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView taskDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}

