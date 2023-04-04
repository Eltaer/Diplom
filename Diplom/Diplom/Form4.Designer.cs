namespace Diplom
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Staff_Butt = new System.Windows.Forms.Button();
            this.Tasks_Butt = new System.Windows.Forms.Button();
            this.Client_Butt = new System.Windows.Forms.Button();
            this.Crash_Butt = new System.Windows.Forms.Button();
            this.Incident_Butt = new System.Windows.Forms.Button();
            this.Save_Butt = new System.Windows.Forms.Button();
            this.Add_Butt = new System.Windows.Forms.Button();
            this.система_для_технической_поддержкиDataSet = new Diplom.Система_для_технической_поддержкиDataSet();
            this.crashBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crashTableAdapter = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.CrashTableAdapter();
            this.tableAdapterManager = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager();
            this.crashDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crashBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crashDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 10;
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
            this.panel1.TabIndex = 11;
            // 
            // Staff_Butt
            // 
            this.Staff_Butt.Location = new System.Drawing.Point(392, 6);
            this.Staff_Butt.Name = "Staff_Butt";
            this.Staff_Butt.Size = new System.Drawing.Size(73, 57);
            this.Staff_Butt.TabIndex = 0;
            this.Staff_Butt.Text = "Персонал";
            this.Staff_Butt.UseVisualStyleBackColor = true;
            this.Staff_Butt.Click += new System.EventHandler(this.Staff_Butt_Click_1);
            // 
            // Tasks_Butt
            // 
            this.Tasks_Butt.Location = new System.Drawing.Point(12, 6);
            this.Tasks_Butt.Name = "Tasks_Butt";
            this.Tasks_Butt.Size = new System.Drawing.Size(73, 57);
            this.Tasks_Butt.TabIndex = 4;
            this.Tasks_Butt.Text = "Задачи";
            this.Tasks_Butt.UseVisualStyleBackColor = true;
            this.Tasks_Butt.Click += new System.EventHandler(this.Tasks_Butt_Click);
            // 
            // Client_Butt
            // 
            this.Client_Butt.Location = new System.Drawing.Point(107, 6);
            this.Client_Butt.Name = "Client_Butt";
            this.Client_Butt.Size = new System.Drawing.Size(73, 57);
            this.Client_Butt.TabIndex = 5;
            this.Client_Butt.Text = "Клиенты";
            this.Client_Butt.UseVisualStyleBackColor = true;
            this.Client_Butt.Click += new System.EventHandler(this.Client_Butt_Click_1);
            // 
            // Crash_Butt
            // 
            this.Crash_Butt.Location = new System.Drawing.Point(295, 6);
            this.Crash_Butt.Name = "Crash_Butt";
            this.Crash_Butt.Size = new System.Drawing.Size(73, 57);
            this.Crash_Butt.TabIndex = 3;
            this.Crash_Butt.Text = "Аварии";
            this.Crash_Butt.UseVisualStyleBackColor = true;
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
            // Save_Butt
            // 
            this.Save_Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_Butt.Location = new System.Drawing.Point(233, 406);
            this.Save_Butt.Name = "Save_Butt";
            this.Save_Butt.Size = new System.Drawing.Size(197, 40);
            this.Save_Butt.TabIndex = 17;
            this.Save_Butt.Text = "Сохранить";
            this.Save_Butt.UseVisualStyleBackColor = true;
            this.Save_Butt.Click += new System.EventHandler(this.Save_Butt_Click);
            // 
            // Add_Butt
            // 
            this.Add_Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Butt.Location = new System.Drawing.Point(12, 406);
            this.Add_Butt.Name = "Add_Butt";
            this.Add_Butt.Size = new System.Drawing.Size(197, 40);
            this.Add_Butt.TabIndex = 16;
            this.Add_Butt.Text = "Добавить";
            this.Add_Butt.UseVisualStyleBackColor = true;
            this.Add_Butt.Click += new System.EventHandler(this.Add_Butt_Click);
            // 
            // система_для_технической_поддержкиDataSet
            // 
            this.система_для_технической_поддержкиDataSet.DataSetName = "Система_для_технической_поддержкиDataSet";
            this.система_для_технической_поддержкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crashBindingSource
            // 
            this.crashBindingSource.DataMember = "Crash";
            this.crashBindingSource.DataSource = this.система_для_технической_поддержкиDataSet;
            // 
            // crashTableAdapter
            // 
            this.crashTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.CrashTableAdapter = this.crashTableAdapter;
            this.tableAdapterManager.Incident_ClientTableAdapter = null;
            this.tableAdapterManager.IncidentTableAdapter = null;
            this.tableAdapterManager.Staff_CrashTableAdapter = null;
            this.tableAdapterManager.Staff_IncidentTableAdapter = null;
            this.tableAdapterManager.Staff_TaskTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.Task_ClientTableAdapter = null;
            this.tableAdapterManager.TaskTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // crashDataGridView
            // 
            this.crashDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crashDataGridView.AutoGenerateColumns = false;
            this.crashDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crashDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.crashDataGridView.DataSource = this.crashBindingSource;
            this.crashDataGridView.Location = new System.Drawing.Point(0, 99);
            this.crashDataGridView.Name = "crashDataGridView";
            this.crashDataGridView.Size = new System.Drawing.Size(1288, 301);
            this.crashDataGridView.TabIndex = 18;
            this.crashDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.crashDataGridView_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Crash_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Crash_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Registrarion_Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Registrarion_Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cause";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cause";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Specialist";
            this.dataGridViewTextBoxColumn5.HeaderText = "Specialist";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Priority";
            this.dataGridViewTextBoxColumn6.HeaderText = "Priority";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1288, 466);
            this.Controls.Add(this.crashDataGridView);
            this.Controls.Add(this.Save_Butt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Add_Butt);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form4";
            this.Text = "Аварии";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crashBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crashDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Staff_Butt;
        private System.Windows.Forms.Button Tasks_Butt;
        private System.Windows.Forms.Button Client_Butt;
        private System.Windows.Forms.Button Crash_Butt;
        private System.Windows.Forms.Button Incident_Butt;
        public System.Windows.Forms.Button Save_Butt;
        public System.Windows.Forms.Button Add_Butt;
        private Система_для_технической_поддержкиDataSet система_для_технической_поддержкиDataSet;
        private System.Windows.Forms.BindingSource crashBindingSource;
        private Система_для_технической_поддержкиDataSetTableAdapters.CrashTableAdapter crashTableAdapter;
        private Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView crashDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}