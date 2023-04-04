namespace Diplom
{
    partial class Form5
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
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.StaffTableAdapter();
            this.tableAdapterManager = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
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
            this.Crash_Butt.Click += new System.EventHandler(this.Crash_Butt_Click_1);
            // 
            // Incident_Butt
            // 
            this.Incident_Butt.Location = new System.Drawing.Point(201, 6);
            this.Incident_Butt.Name = "Incident_Butt";
            this.Incident_Butt.Size = new System.Drawing.Size(73, 57);
            this.Incident_Butt.TabIndex = 2;
            this.Incident_Butt.Text = "Инциденты";
            this.Incident_Butt.UseVisualStyleBackColor = true;
            this.Incident_Butt.Click += new System.EventHandler(this.Incident_Butt_Click_1);
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
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.система_для_технической_поддержкиDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.Task_ClientTableAdapter = null;
            this.tableAdapterManager.TaskTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffDataGridView.AutoGenerateColumns = false;
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.staffDataGridView.DataSource = this.staffBindingSource;
            this.staffDataGridView.Location = new System.Drawing.Point(0, 99);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.Size = new System.Drawing.Size(1288, 301);
            this.staffDataGridView.TabIndex = 18;
            this.staffDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.staffDataGridView_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Staff_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Staff_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Specialist";
            this.dataGridViewTextBoxColumn2.HeaderText = "Specialist";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Post";
            this.dataGridViewTextBoxColumn3.HeaderText = "Post";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn4.HeaderText = "Status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1288, 466);
            this.Controls.Add(this.staffDataGridView);
            this.Controls.Add(this.Save_Butt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Add_Butt);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form5";
            this.Text = "Персонал";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource staffBindingSource;
        private Система_для_технической_поддержкиDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}