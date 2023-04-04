namespace Diplom
{
    partial class Form2
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
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
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
            this.Tasks_Butt.Click += new System.EventHandler(this.Tasks_Butt_Click_1);
            // 
            // Client_Butt
            // 
            this.Client_Butt.Location = new System.Drawing.Point(107, 6);
            this.Client_Butt.Name = "Client_Butt";
            this.Client_Butt.Size = new System.Drawing.Size(73, 57);
            this.Client_Butt.TabIndex = 5;
            this.Client_Butt.Text = "Клиенты";
            this.Client_Butt.UseVisualStyleBackColor = true;
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
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.система_для_технической_поддержкиDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.CrashTableAdapter = null;
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
            // clientsDataGridView
            // 
            this.clientsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientsDataGridView.AutoGenerateColumns = false;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.clientsDataGridView.DataSource = this.clientsBindingSource;
            this.clientsDataGridView.Location = new System.Drawing.Point(0, 99);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.Size = new System.Drawing.Size(1288, 301);
            this.clientsDataGridView.TabIndex = 18;
            this.clientsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.clientsDataGridView_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Client_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Client_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "F_CName";
            this.dataGridViewTextBoxColumn2.HeaderText = "F_CName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "R_CName";
            this.dataGridViewTextBoxColumn3.HeaderText = "R_CName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "O_CName";
            this.dataGridViewTextBoxColumn4.HeaderText = "O_CName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Address";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Registrarion_Date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Registrarion_Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Contract_Number";
            this.dataGridViewTextBoxColumn8.HeaderText = "Contract_Number";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Tariff";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tariff";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Passport_Series";
            this.dataGridViewTextBoxColumn10.HeaderText = "Passport_Series";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Passport_Number";
            this.dataGridViewTextBoxColumn11.HeaderText = "Passport_Number";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Birth";
            this.dataGridViewTextBoxColumn12.HeaderText = "Birth";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1288, 466);
            this.Controls.Add(this.clientsDataGridView);
            this.Controls.Add(this.Save_Butt);
            this.Controls.Add(this.Add_Butt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Система_для_технической_поддержкиDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}