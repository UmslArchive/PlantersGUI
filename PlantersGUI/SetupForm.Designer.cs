namespace PlantersGUI
{
    partial class SetupForm
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
            this.SetupForm_TabControl = new System.Windows.Forms.TabControl();
            this.deviceManageTab = new System.Windows.Forms.TabPage();
            this.tablesTab = new System.Windows.Forms.TabPage();
            this.ioLabel = new System.Windows.Forms.Label();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.varNameLabel = new System.Windows.Forms.Label();
            this.variableTextBox = new System.Windows.Forms.TextBox();
            this.constraintLabel = new System.Windows.Forms.Label();
            this.inequalityComboBox = new System.Windows.Forms.ComboBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.addDeviceButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addTableButton = new System.Windows.Forms.Button();
            this.tablesListBox = new System.Windows.Forms.ListBox();
            this.tablesLabel = new System.Windows.Forms.Label();
            this.removeTableButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SetupForm_TabControl.SuspendLayout();
            this.deviceManageTab.SuspendLayout();
            this.tablesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetupForm_TabControl
            // 
            this.SetupForm_TabControl.Controls.Add(this.deviceManageTab);
            this.SetupForm_TabControl.Controls.Add(this.tablesTab);
            this.SetupForm_TabControl.Location = new System.Drawing.Point(12, 12);
            this.SetupForm_TabControl.Name = "SetupForm_TabControl";
            this.SetupForm_TabControl.SelectedIndex = 0;
            this.SetupForm_TabControl.Size = new System.Drawing.Size(499, 353);
            this.SetupForm_TabControl.TabIndex = 0;
            // 
            // deviceManageTab
            // 
            this.deviceManageTab.Controls.Add(this.applyButton);
            this.deviceManageTab.Controls.Add(this.addDeviceButton);
            this.deviceManageTab.Controls.Add(this.valueTextBox);
            this.deviceManageTab.Controls.Add(this.inequalityComboBox);
            this.deviceManageTab.Controls.Add(this.constraintLabel);
            this.deviceManageTab.Controls.Add(this.variableTextBox);
            this.deviceManageTab.Controls.Add(this.varNameLabel);
            this.deviceManageTab.Controls.Add(this.deviceComboBox);
            this.deviceManageTab.Controls.Add(this.ioLabel);
            this.deviceManageTab.Location = new System.Drawing.Point(4, 22);
            this.deviceManageTab.Name = "deviceManageTab";
            this.deviceManageTab.Size = new System.Drawing.Size(491, 327);
            this.deviceManageTab.TabIndex = 0;
            this.deviceManageTab.Text = "Device Mangement";
            this.deviceManageTab.UseVisualStyleBackColor = true;
            // 
            // tablesTab
            // 
            this.tablesTab.Controls.Add(this.button1);
            this.tablesTab.Controls.Add(this.removeTableButton);
            this.tablesTab.Controls.Add(this.tablesLabel);
            this.tablesTab.Controls.Add(this.tablesListBox);
            this.tablesTab.Controls.Add(this.addTableButton);
            this.tablesTab.Location = new System.Drawing.Point(4, 22);
            this.tablesTab.Name = "tablesTab";
            this.tablesTab.Size = new System.Drawing.Size(491, 327);
            this.tablesTab.TabIndex = 1;
            this.tablesTab.Text = "Tables";
            this.tablesTab.UseVisualStyleBackColor = true;
            // 
            // ioLabel
            // 
            this.ioLabel.AutoSize = true;
            this.ioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ioLabel.Location = new System.Drawing.Point(41, 21);
            this.ioLabel.Name = "ioLabel";
            this.ioLabel.Size = new System.Drawing.Size(74, 13);
            this.ioLabel.TabIndex = 0;
            this.ioLabel.Text = "I/O Device:";
            this.ioLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(44, 38);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(121, 21);
            this.deviceComboBox.TabIndex = 1;
            this.deviceComboBox.Text = "Select Device...";
            this.deviceComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // varNameLabel
            // 
            this.varNameLabel.AutoSize = true;
            this.varNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varNameLabel.Location = new System.Drawing.Point(172, 21);
            this.varNameLabel.Name = "varNameLabel";
            this.varNameLabel.Size = new System.Drawing.Size(93, 13);
            this.varNameLabel.TabIndex = 2;
            this.varNameLabel.Text = "Variable Name:";
            this.varNameLabel.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // variableTextBox
            // 
            this.variableTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.variableTextBox.Location = new System.Drawing.Point(175, 38);
            this.variableTextBox.MaxLength = 36;
            this.variableTextBox.Name = "variableTextBox";
            this.variableTextBox.Size = new System.Drawing.Size(128, 20);
            this.variableTextBox.TabIndex = 3;
            this.variableTextBox.Text = "Control Variable Name...";
            this.variableTextBox.WordWrap = false;
            // 
            // constraintLabel
            // 
            this.constraintLabel.AutoSize = true;
            this.constraintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.constraintLabel.Location = new System.Drawing.Point(310, 21);
            this.constraintLabel.Name = "constraintLabel";
            this.constraintLabel.Size = new System.Drawing.Size(68, 13);
            this.constraintLabel.TabIndex = 4;
            this.constraintLabel.Text = "Constraint:";
            // 
            // inequalityComboBox
            // 
            this.inequalityComboBox.FormattingEnabled = true;
            this.inequalityComboBox.Items.AddRange(new object[] {
            "=",
            "<=",
            ">=",
            "<",
            ">"});
            this.inequalityComboBox.Location = new System.Drawing.Point(313, 37);
            this.inequalityComboBox.Name = "inequalityComboBox";
            this.inequalityComboBox.Size = new System.Drawing.Size(48, 21);
            this.inequalityComboBox.TabIndex = 5;
            this.inequalityComboBox.SelectedIndexChanged += new System.EventHandler(this.InequalityComboBox_SelectedIndexChanged);
            // 
            // valueTextBox
            // 
            this.valueTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.valueTextBox.Location = new System.Drawing.Point(368, 37);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(78, 20);
            this.valueTextBox.TabIndex = 6;
            this.valueTextBox.Text = "Enter Value...";
            // 
            // addDeviceButton
            // 
            this.addDeviceButton.Location = new System.Drawing.Point(371, 83);
            this.addDeviceButton.Name = "addDeviceButton";
            this.addDeviceButton.Size = new System.Drawing.Size(75, 23);
            this.addDeviceButton.TabIndex = 7;
            this.addDeviceButton.Text = "Add Device";
            this.addDeviceButton.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(690, 301);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 8;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(432, 374);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 64);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(16, 374);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 64);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addTableButton
            // 
            this.addTableButton.Location = new System.Drawing.Point(82, 193);
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.Size = new System.Drawing.Size(100, 25);
            this.addTableButton.TabIndex = 0;
            this.addTableButton.Text = "Add";
            this.addTableButton.UseVisualStyleBackColor = true;
            // 
            // tablesListBox
            // 
            this.tablesListBox.BackColor = System.Drawing.SystemColors.Window;
            this.tablesListBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tablesListBox.FormattingEnabled = true;
            this.tablesListBox.Items.AddRange(new object[] {
            "Add a table..."});
            this.tablesListBox.Location = new System.Drawing.Point(82, 66);
            this.tablesListBox.Name = "tablesListBox";
            this.tablesListBox.Size = new System.Drawing.Size(279, 121);
            this.tablesListBox.TabIndex = 1;
            this.tablesListBox.SelectedIndexChanged += new System.EventHandler(this.TablesListBox_SelectedIndexChanged);
            // 
            // tablesLabel
            // 
            this.tablesLabel.AutoSize = true;
            this.tablesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesLabel.Location = new System.Drawing.Point(79, 50);
            this.tablesLabel.Name = "tablesLabel";
            this.tablesLabel.Size = new System.Drawing.Size(49, 13);
            this.tablesLabel.TabIndex = 2;
            this.tablesLabel.Text = "Tables:";
            // 
            // removeTableButton
            // 
            this.removeTableButton.Location = new System.Drawing.Point(261, 224);
            this.removeTableButton.Name = "removeTableButton";
            this.removeTableButton.Size = new System.Drawing.Size(100, 25);
            this.removeTableButton.TabIndex = 3;
            this.removeTableButton.Text = "Remove";
            this.removeTableButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Edit...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.SetupForm_TabControl);
            this.Name = "SetupForm";
            this.Text = "Setup Experiment";
            this.SetupForm_TabControl.ResumeLayout(false);
            this.deviceManageTab.ResumeLayout(false);
            this.deviceManageTab.PerformLayout();
            this.tablesTab.ResumeLayout(false);
            this.tablesTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SetupForm_TabControl;
        private System.Windows.Forms.TabPage deviceManageTab;
        private System.Windows.Forms.Label ioLabel;
        private System.Windows.Forms.TabPage tablesTab;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Label varNameLabel;
        private System.Windows.Forms.TextBox variableTextBox;
        private System.Windows.Forms.ComboBox inequalityComboBox;
        private System.Windows.Forms.Label constraintLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button addDeviceButton;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label tablesLabel;
        private System.Windows.Forms.ListBox tablesListBox;
        private System.Windows.Forms.Button addTableButton;
        private System.Windows.Forms.Button removeTableButton;
        private System.Windows.Forms.Button button1;
    }
}