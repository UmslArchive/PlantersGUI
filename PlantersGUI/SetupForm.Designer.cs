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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.deviceManageTab = new System.Windows.Forms.TabPage();
            this.constraintCheckBox = new System.Windows.Forms.CheckBox();
            this.valueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.applyButton = new System.Windows.Forms.Button();
            this.addVarButton = new System.Windows.Forms.Button();
            this.inequalityComboBox = new System.Windows.Forms.ComboBox();
            this.variableTextBox = new System.Windows.Forms.TextBox();
            this.varNameLabel = new System.Windows.Forms.Label();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.ioLabel = new System.Windows.Forms.Label();
            this.tablesTab = new System.Windows.Forms.TabPage();
            this.editButton = new System.Windows.Forms.Button();
            this.removeTableButton = new System.Windows.Forms.Button();
            this.tablesLabel = new System.Windows.Forms.Label();
            this.tablesListBox = new System.Windows.Forms.ListBox();
            this.addTableButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.userVariableListLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.deviceManageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumericUpDown)).BeginInit();
            this.tablesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.deviceManageTab);
            this.tabControl.Controls.Add(this.tablesTab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(499, 353);
            this.tabControl.TabIndex = 0;
            // 
            // deviceManageTab
            // 
            this.deviceManageTab.Controls.Add(this.userVariableListLabel);
            this.deviceManageTab.Controls.Add(this.constraintCheckBox);
            this.deviceManageTab.Controls.Add(this.valueNumericUpDown);
            this.deviceManageTab.Controls.Add(this.applyButton);
            this.deviceManageTab.Controls.Add(this.addVarButton);
            this.deviceManageTab.Controls.Add(this.inequalityComboBox);
            this.deviceManageTab.Controls.Add(this.variableTextBox);
            this.deviceManageTab.Controls.Add(this.varNameLabel);
            this.deviceManageTab.Controls.Add(this.deviceComboBox);
            this.deviceManageTab.Controls.Add(this.ioLabel);
            this.deviceManageTab.Location = new System.Drawing.Point(4, 22);
            this.deviceManageTab.Name = "deviceManageTab";
            this.deviceManageTab.Size = new System.Drawing.Size(491, 327);
            this.deviceManageTab.TabIndex = 0;
            this.deviceManageTab.Text = "User Variables";
            this.deviceManageTab.UseVisualStyleBackColor = true;
            // 
            // constraintCheckBox
            // 
            this.constraintCheckBox.AutoSize = true;
            this.constraintCheckBox.Checked = true;
            this.constraintCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.constraintCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.constraintCheckBox.Location = new System.Drawing.Point(313, 17);
            this.constraintCheckBox.Name = "constraintCheckBox";
            this.constraintCheckBox.Size = new System.Drawing.Size(83, 17);
            this.constraintCheckBox.TabIndex = 3;
            this.constraintCheckBox.Text = "Constraint";
            this.constraintCheckBox.UseVisualStyleBackColor = true;
            this.constraintCheckBox.Click += new System.EventHandler(this.ConstraintCheckBox_Click);
            // 
            // valueNumericUpDown
            // 
            this.valueNumericUpDown.DecimalPlaces = 2;
            this.valueNumericUpDown.Location = new System.Drawing.Point(371, 37);
            this.valueNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.valueNumericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.valueNumericUpDown.Name = "valueNumericUpDown";
            this.valueNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.valueNumericUpDown.TabIndex = 5;
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
            // addVarButton
            // 
            this.addVarButton.Location = new System.Drawing.Point(352, 83);
            this.addVarButton.Name = "addVarButton";
            this.addVarButton.Size = new System.Drawing.Size(94, 23);
            this.addVarButton.TabIndex = 6;
            this.addVarButton.Text = "Add Variable";
            this.addVarButton.UseVisualStyleBackColor = true;
            this.addVarButton.Click += new System.EventHandler(this.AddDeviceButton_Click);
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
            this.inequalityComboBox.TabIndex = 4;
            // 
            // variableTextBox
            // 
            this.variableTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.variableTextBox.Location = new System.Drawing.Point(31, 38);
            this.variableTextBox.MaxLength = 36;
            this.variableTextBox.Name = "variableTextBox";
            this.variableTextBox.Size = new System.Drawing.Size(128, 20);
            this.variableTextBox.TabIndex = 1;
            this.variableTextBox.Text = "Type Name...";
            this.variableTextBox.WordWrap = false;
            this.variableTextBox.Click += new System.EventHandler(this.VariableTextBox_Click);
            // 
            // varNameLabel
            // 
            this.varNameLabel.AutoSize = true;
            this.varNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varNameLabel.Location = new System.Drawing.Point(28, 18);
            this.varNameLabel.Name = "varNameLabel";
            this.varNameLabel.Size = new System.Drawing.Size(83, 13);
            this.varNameLabel.TabIndex = 2;
            this.varNameLabel.Text = "User Variable";
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Items.AddRange(new object[] {
            "No Device"});
            this.deviceComboBox.Location = new System.Drawing.Point(174, 37);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(121, 21);
            this.deviceComboBox.TabIndex = 2;
            // 
            // ioLabel
            // 
            this.ioLabel.AutoSize = true;
            this.ioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ioLabel.Location = new System.Drawing.Point(171, 18);
            this.ioLabel.Name = "ioLabel";
            this.ioLabel.Size = new System.Drawing.Size(70, 13);
            this.ioLabel.TabIndex = 0;
            this.ioLabel.Text = "I/O Device";
            // 
            // tablesTab
            // 
            this.tablesTab.Controls.Add(this.editButton);
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
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(261, 193);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 25);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit...";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // removeTableButton
            // 
            this.removeTableButton.Location = new System.Drawing.Point(261, 224);
            this.removeTableButton.Name = "removeTableButton";
            this.removeTableButton.Size = new System.Drawing.Size(100, 25);
            this.removeTableButton.TabIndex = 3;
            this.removeTableButton.Text = "Remove";
            this.removeTableButton.UseVisualStyleBackColor = true;
            this.removeTableButton.Click += new System.EventHandler(this.RemoveTableButton_Click);
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
            // tablesListBox
            // 
            this.tablesListBox.BackColor = System.Drawing.SystemColors.Window;
            this.tablesListBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablesListBox.FormattingEnabled = true;
            this.tablesListBox.Items.AddRange(new object[] {
            "Add a table..."});
            this.tablesListBox.Location = new System.Drawing.Point(82, 66);
            this.tablesListBox.Name = "tablesListBox";
            this.tablesListBox.Size = new System.Drawing.Size(279, 121);
            this.tablesListBox.TabIndex = 1;
            // 
            // addTableButton
            // 
            this.addTableButton.Location = new System.Drawing.Point(82, 193);
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.Size = new System.Drawing.Size(100, 25);
            this.addTableButton.TabIndex = 0;
            this.addTableButton.Text = "Add";
            this.addTableButton.UseVisualStyleBackColor = true;
            this.addTableButton.Click += new System.EventHandler(this.AddTableButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(432, 374);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 64);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(16, 374);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 64);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // userVariableListLabel
            // 
            this.userVariableListLabel.AutoSize = true;
            this.userVariableListLabel.Location = new System.Drawing.Point(31, 122);
            this.userVariableListLabel.Name = "userVariableListLabel";
            this.userVariableListLabel.Size = new System.Drawing.Size(124, 13);
            this.userVariableListLabel.TabIndex = 9;
            this.userVariableListLabel.Text = "USER_VARIABLE_LIST";
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.tabControl);
            this.Name = "SetupForm";
            this.Text = "Setup Experiment";
            this.Activated += new System.EventHandler(this.SetupForm_Activated);
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.tabControl.ResumeLayout(false);
            this.deviceManageTab.ResumeLayout(false);
            this.deviceManageTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumericUpDown)).EndInit();
            this.tablesTab.ResumeLayout(false);
            this.tablesTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage deviceManageTab;
        private System.Windows.Forms.Label ioLabel;
        private System.Windows.Forms.TabPage tablesTab;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Label varNameLabel;
        private System.Windows.Forms.TextBox variableTextBox;
        private System.Windows.Forms.ComboBox inequalityComboBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button addVarButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label tablesLabel;
        private System.Windows.Forms.ListBox tablesListBox;
        private System.Windows.Forms.Button addTableButton;
        private System.Windows.Forms.Button removeTableButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.NumericUpDown valueNumericUpDown;
        private System.Windows.Forms.CheckBox constraintCheckBox;
        private System.Windows.Forms.Label userVariableListLabel;
    }
}