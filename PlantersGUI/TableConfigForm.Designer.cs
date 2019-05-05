namespace PlantersGUI
{
    partial class TableConfigForm
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
            this.indepVarLabel = new System.Windows.Forms.Label();
            this.indepVarComboBox = new System.Windows.Forms.ComboBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.depVarLabel = new System.Windows.Forms.Label();
            this.depVarComboBox = new System.Windows.Forms.ComboBox();
            this.refreshRateLabel = new System.Windows.Forms.Label();
            this.dffNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.freqSettingComboBox = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dffNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // indepVarLabel
            // 
            this.indepVarLabel.AutoSize = true;
            this.indepVarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indepVarLabel.Location = new System.Drawing.Point(17, 60);
            this.indepVarLabel.Name = "indepVarLabel";
            this.indepVarLabel.Size = new System.Drawing.Size(132, 13);
            this.indepVarLabel.TabIndex = 0;
            this.indepVarLabel.Text = "Independent Variable:";
            // 
            // indepVarComboBox
            // 
            this.indepVarComboBox.FormattingEnabled = true;
            this.indepVarComboBox.Items.AddRange(new object[] {
            "Time"});
            this.indepVarComboBox.Location = new System.Drawing.Point(20, 77);
            this.indepVarComboBox.Name = "indepVarComboBox";
            this.indepVarComboBox.Size = new System.Drawing.Size(186, 21);
            this.indepVarComboBox.TabIndex = 1;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(40, 244);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(121, 244);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // depVarLabel
            // 
            this.depVarLabel.AutoSize = true;
            this.depVarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depVarLabel.Location = new System.Drawing.Point(17, 117);
            this.depVarLabel.Name = "depVarLabel";
            this.depVarLabel.Size = new System.Drawing.Size(123, 13);
            this.depVarLabel.TabIndex = 4;
            this.depVarLabel.Text = "Dependent Variable:";
            // 
            // depVarComboBox
            // 
            this.depVarComboBox.FormattingEnabled = true;
            this.depVarComboBox.Location = new System.Drawing.Point(20, 133);
            this.depVarComboBox.Name = "depVarComboBox";
            this.depVarComboBox.Size = new System.Drawing.Size(186, 21);
            this.depVarComboBox.TabIndex = 5;
            this.depVarComboBox.SelectedIndexChanged += new System.EventHandler(this.DepVarComboBox_SelectedIndexChanged);
            // 
            // refreshRateLabel
            // 
            this.refreshRateLabel.AutoSize = true;
            this.refreshRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshRateLabel.Location = new System.Drawing.Point(17, 177);
            this.refreshRateLabel.Name = "refreshRateLabel";
            this.refreshRateLabel.Size = new System.Drawing.Size(137, 13);
            this.refreshRateLabel.TabIndex = 6;
            this.refreshRateLabel.Text = "Data Fetch Frequency:";
            // 
            // dffNumericUpDown
            // 
            this.dffNumericUpDown.DecimalPlaces = 3;
            this.dffNumericUpDown.Location = new System.Drawing.Point(20, 194);
            this.dffNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.dffNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dffNumericUpDown.Name = "dffNumericUpDown";
            this.dffNumericUpDown.Size = new System.Drawing.Size(95, 20);
            this.dffNumericUpDown.TabIndex = 7;
            this.dffNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // freqSettingComboBox
            // 
            this.freqSettingComboBox.FormattingEnabled = true;
            this.freqSettingComboBox.Items.AddRange(new object[] {
            "Second(s)",
            "Minute(s)",
            "Hour(s)",
            "Day(s)"});
            this.freqSettingComboBox.Location = new System.Drawing.Point(121, 193);
            this.freqSettingComboBox.Name = "freqSettingComboBox";
            this.freqSettingComboBox.Size = new System.Drawing.Size(85, 21);
            this.freqSettingComboBox.TabIndex = 8;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(17, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(36, 13);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(23, 29);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(183, 20);
            this.titleTextBox.TabIndex = 10;
            // 
            // TableConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 298);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.freqSettingComboBox);
            this.Controls.Add(this.dffNumericUpDown);
            this.Controls.Add(this.refreshRateLabel);
            this.Controls.Add(this.depVarComboBox);
            this.Controls.Add(this.depVarLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.indepVarComboBox);
            this.Controls.Add(this.indepVarLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableConfigForm";
            this.Text = "Table Configuration";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TableConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dffNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label indepVarLabel;
        private System.Windows.Forms.ComboBox indepVarComboBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label depVarLabel;
        private System.Windows.Forms.ComboBox depVarComboBox;
        private System.Windows.Forms.Label refreshRateLabel;
        private System.Windows.Forms.NumericUpDown dffNumericUpDown;
        private System.Windows.Forms.ComboBox freqSettingComboBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
    }
}