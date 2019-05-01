namespace PlantersGUI
{
    partial class EntryForm
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
            this.programNameLabel = new System.Windows.Forms.Label();
            this.setupButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.advancedSetupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programNameLabel.Location = new System.Drawing.Point(162, 73);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(453, 51);
            this.programNameLabel.TabIndex = 0;
            this.programNameLabel.Text = "PLANT EXPERIMENT";
            // 
            // setupButton
            // 
            this.setupButton.Location = new System.Drawing.Point(288, 209);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(75, 23);
            this.setupButton.TabIndex = 1;
            this.setupButton.Text = "Setup...";
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.EntrySetupButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(288, 238);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(191, 23);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.EntryContinueButton_Click);
            // 
            // advancedSetupButton
            // 
            this.advancedSetupButton.Location = new System.Drawing.Point(369, 209);
            this.advancedSetupButton.Name = "advancedSetupButton";
            this.advancedSetupButton.Size = new System.Drawing.Size(110, 23);
            this.advancedSetupButton.TabIndex = 3;
            this.advancedSetupButton.Text = "Advanced Setup...";
            this.advancedSetupButton.UseVisualStyleBackColor = true;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.advancedSetupButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.setupButton);
            this.Controls.Add(this.programNameLabel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "EntryForm";
            this.Text = "Planters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label programNameLabel;
        private System.Windows.Forms.Button setupButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button advancedSetupButton;
    }
}

