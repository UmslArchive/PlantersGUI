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
            this.addReportButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deviceMonitorGroupBox = new System.Windows.Forms.GroupBox();
            this.deviceStatusLabel = new System.Windows.Forms.Label();
            this.deviceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.reportsComboBox = new System.Windows.Forms.ComboBox();
            this.reportsLabel = new System.Windows.Forms.Label();
            this.editReportButton = new System.Windows.Forms.Button();
            this.removeReportButton = new System.Windows.Forms.Button();
            this.previewReportButton = new System.Windows.Forms.Button();
            this.tableExportButton = new System.Windows.Forms.Button();
            this.reportsPanel = new System.Windows.Forms.Panel();
            this.printReportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablesDataGrid)).BeginInit();
            this.deviceMonitorGroupBox.SuspendLayout();
            this.reportsPanel.SuspendLayout();
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
            this.tablesDataGrid.Size = new System.Drawing.Size(350, 208);
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
            this.tablesComboBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tablesComboBox.FormattingEnabled = true;
            this.tablesComboBox.Location = new System.Drawing.Point(12, 27);
            this.tablesComboBox.Name = "tablesComboBox";
            this.tablesComboBox.Size = new System.Drawing.Size(350, 21);
            this.tablesComboBox.TabIndex = 2;
            this.tablesComboBox.Text = "Select Table...";
            // 
            // addReportButton
            // 
            this.addReportButton.Location = new System.Drawing.Point(6, 57);
            this.addReportButton.Name = "addReportButton";
            this.addReportButton.Size = new System.Drawing.Size(75, 29);
            this.addReportButton.TabIndex = 3;
            this.addReportButton.Text = "Add...";
            this.addReportButton.UseVisualStyleBackColor = true;
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
            this.deviceMonitorGroupBox.Size = new System.Drawing.Size(349, 250);
            this.deviceMonitorGroupBox.TabIndex = 6;
            this.deviceMonitorGroupBox.TabStop = false;
            this.deviceMonitorGroupBox.Text = "Devices Monitor";
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
            // reportsComboBox
            // 
            this.reportsComboBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.reportsComboBox.FormattingEnabled = true;
            this.reportsComboBox.Location = new System.Drawing.Point(6, 30);
            this.reportsComboBox.Name = "reportsComboBox";
            this.reportsComboBox.Size = new System.Drawing.Size(237, 21);
            this.reportsComboBox.TabIndex = 9;
            this.reportsComboBox.Text = "Select a Report...";
            // 
            // reportsLabel
            // 
            this.reportsLabel.AutoSize = true;
            this.reportsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsLabel.Location = new System.Drawing.Point(3, 14);
            this.reportsLabel.Name = "reportsLabel";
            this.reportsLabel.Size = new System.Drawing.Size(55, 13);
            this.reportsLabel.TabIndex = 10;
            this.reportsLabel.Text = "Reports:";
            // 
            // editReportButton
            // 
            this.editReportButton.Location = new System.Drawing.Point(87, 57);
            this.editReportButton.Name = "editReportButton";
            this.editReportButton.Size = new System.Drawing.Size(75, 29);
            this.editReportButton.TabIndex = 11;
            this.editReportButton.Text = "Edit...";
            this.editReportButton.UseVisualStyleBackColor = true;
            // 
            // removeReportButton
            // 
            this.removeReportButton.Location = new System.Drawing.Point(168, 57);
            this.removeReportButton.Name = "removeReportButton";
            this.removeReportButton.Size = new System.Drawing.Size(75, 29);
            this.removeReportButton.TabIndex = 12;
            this.removeReportButton.Text = "Remove";
            this.removeReportButton.UseVisualStyleBackColor = true;
            // 
            // previewReportButton
            // 
            this.previewReportButton.Location = new System.Drawing.Point(275, 23);
            this.previewReportButton.Name = "previewReportButton";
            this.previewReportButton.Size = new System.Drawing.Size(90, 30);
            this.previewReportButton.TabIndex = 13;
            this.previewReportButton.Text = "Preview";
            this.previewReportButton.UseVisualStyleBackColor = true;
            // 
            // tableExportButton
            // 
            this.tableExportButton.Location = new System.Drawing.Point(287, 268);
            this.tableExportButton.Name = "tableExportButton";
            this.tableExportButton.Size = new System.Drawing.Size(75, 23);
            this.tableExportButton.TabIndex = 14;
            this.tableExportButton.Text = "Export...";
            this.tableExportButton.UseVisualStyleBackColor = true;
            // 
            // reportsPanel
            // 
            this.reportsPanel.Controls.Add(this.printReportButton);
            this.reportsPanel.Controls.Add(this.previewReportButton);
            this.reportsPanel.Controls.Add(this.removeReportButton);
            this.reportsPanel.Controls.Add(this.editReportButton);
            this.reportsPanel.Controls.Add(this.reportsLabel);
            this.reportsPanel.Controls.Add(this.reportsComboBox);
            this.reportsPanel.Controls.Add(this.addReportButton);
            this.reportsPanel.Location = new System.Drawing.Point(12, 320);
            this.reportsPanel.Name = "reportsPanel";
            this.reportsPanel.Size = new System.Drawing.Size(378, 107);
            this.reportsPanel.TabIndex = 15;
            // 
            // printReportButton
            // 
            this.printReportButton.Location = new System.Drawing.Point(275, 62);
            this.printReportButton.Name = "printReportButton";
            this.printReportButton.Size = new System.Drawing.Size(90, 30);
            this.printReportButton.TabIndex = 14;
            this.printReportButton.Text = "Print";
            this.printReportButton.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.reportsPanel);
            this.Name = "ContinueForm";
            this.Text = "My Experiment";
            this.Load += new System.EventHandler(this.ContinueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablesDataGrid)).EndInit();
            this.deviceMonitorGroupBox.ResumeLayout(false);
            this.deviceMonitorGroupBox.PerformLayout();
            this.reportsPanel.ResumeLayout(false);
            this.reportsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablesDataGrid;
        private System.Windows.Forms.Label tablesLabel;
        private System.Windows.Forms.ComboBox tablesComboBox;
        private System.Windows.Forms.Button addReportButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox deviceMonitorGroupBox;
        private System.Windows.Forms.Label deviceStatusLabel;
        private System.Windows.Forms.Label deviceLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox reportsComboBox;
        private System.Windows.Forms.Label reportsLabel;
        private System.Windows.Forms.Button editReportButton;
        private System.Windows.Forms.Button removeReportButton;
        private System.Windows.Forms.Button previewReportButton;
        private System.Windows.Forms.Button tableExportButton;
        private System.Windows.Forms.Panel reportsPanel;
        private System.Windows.Forms.Button printReportButton;
    }
}