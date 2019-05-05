namespace PlantersGUI
{
    partial class ContinueForm
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
            this.tablesDataGrid = new System.Windows.Forms.DataGridView();
            this.tablesLabel = new System.Windows.Forms.Label();
            this.tablesComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.deviceMonitorGroupBox = new System.Windows.Forms.GroupBox();
            this.deviceStatusLabel = new System.Windows.Forms.Label();
            this.deviceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.tableExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablesDataGrid)).BeginInit();
            this.deviceMonitorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablesDataGrid
            // 
            this.tablesDataGrid.AllowUserToAddRows = false;
            this.tablesDataGrid.AllowUserToDeleteRows = false;
            this.tablesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablesDataGrid.Location = new System.Drawing.Point(12, 54);
            this.tablesDataGrid.Name = "tablesDataGrid";
            this.tablesDataGrid.ReadOnly = true;
            this.tablesDataGrid.Size = new System.Drawing.Size(350, 285);
            this.tablesDataGrid.TabIndex = 0;
            // 
            // tablesLabel
            // 
            this.tablesLabel.AutoSize = true;
            this.tablesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesLabel.Location = new System.Drawing.Point(9, 11);
            this.tablesLabel.Name = "tablesLabel";
            this.tablesLabel.Size = new System.Drawing.Size(49, 13);
            this.tablesLabel.TabIndex = 1;
            this.tablesLabel.Text = "Tables:";
            // 
            // tablesComboBox
            // 
            this.tablesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tablesComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablesComboBox.FormattingEnabled = true;
            this.tablesComboBox.Location = new System.Drawing.Point(12, 27);
            this.tablesComboBox.Name = "tablesComboBox";
            this.tablesComboBox.Size = new System.Drawing.Size(350, 21);
            this.tablesComboBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(615, 383);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(67, 44);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // deviceMonitorGroupBox
            // 
            this.deviceMonitorGroupBox.Controls.Add(this.deviceStatusLabel);
            this.deviceMonitorGroupBox.Controls.Add(this.deviceLabel);
            this.deviceMonitorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceMonitorGroupBox.Location = new System.Drawing.Point(404, 12);
            this.deviceMonitorGroupBox.Name = "deviceMonitorGroupBox";
            this.deviceMonitorGroupBox.Size = new System.Drawing.Size(349, 327);
            this.deviceMonitorGroupBox.TabIndex = 6;
            this.deviceMonitorGroupBox.TabStop = false;
            this.deviceMonitorGroupBox.Text = "Device Monitor";
            this.deviceMonitorGroupBox.Enter += new System.EventHandler(this.DeviceMonitorGroupBox_Enter);
            // 
            // deviceStatusLabel
            // 
            this.deviceStatusLabel.AutoSize = true;
            this.deviceStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceStatusLabel.Location = new System.Drawing.Point(156, 20);
            this.deviceStatusLabel.Name = "deviceStatusLabel";
            this.deviceStatusLabel.Size = new System.Drawing.Size(43, 13);
            this.deviceStatusLabel.TabIndex = 1;
            this.deviceStatusLabel.Text = "Status";
            // 
            // deviceLabel
            // 
            this.deviceLabel.AutoSize = true;
            this.deviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceLabel.Location = new System.Drawing.Point(7, 20);
            this.deviceLabel.Name = "deviceLabel";
            this.deviceLabel.Size = new System.Drawing.Size(47, 13);
            this.deviceLabel.TabIndex = 0;
            this.deviceLabel.Text = "Device";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(688, 383);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(67, 44);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // tableExportButton
            // 
            this.tableExportButton.Location = new System.Drawing.Point(287, 345);
            this.tableExportButton.Name = "tableExportButton";
            this.tableExportButton.Size = new System.Drawing.Size(75, 23);
            this.tableExportButton.TabIndex = 14;
            this.tableExportButton.Text = "Export...";
            this.tableExportButton.UseVisualStyleBackColor = true;
            // 
            // ContinueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 439);
            this.Controls.Add(this.tableExportButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deviceMonitorGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tablesComboBox);
            this.Controls.Add(this.tablesLabel);
            this.Controls.Add(this.tablesDataGrid);
            this.Name = "ContinueForm";
            this.Text = "My Experiment";
            this.Load += new System.EventHandler(this.ContinueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablesDataGrid)).EndInit();
            this.deviceMonitorGroupBox.ResumeLayout(false);
            this.deviceMonitorGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablesDataGrid;
        private System.Windows.Forms.Label tablesLabel;
        private System.Windows.Forms.ComboBox tablesComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox deviceMonitorGroupBox;
        private System.Windows.Forms.Label deviceStatusLabel;
        private System.Windows.Forms.Label deviceLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button tableExportButton;
    }
}