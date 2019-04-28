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
            this.label1 = new System.Windows.Forms.Label();
            this.EntrySetupButton = new System.Windows.Forms.Button();
            this.EntryContinueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLANT EXPERIMENT";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // EntrySetupButton
            // 
            this.EntrySetupButton.Location = new System.Drawing.Point(359, 151);
            this.EntrySetupButton.Name = "EntrySetupButton";
            this.EntrySetupButton.Size = new System.Drawing.Size(75, 23);
            this.EntrySetupButton.TabIndex = 1;
            this.EntrySetupButton.Text = "Setup";
            this.EntrySetupButton.UseVisualStyleBackColor = true;
            this.EntrySetupButton.Click += new System.EventHandler(this.EntrySetupButton_Click);
            // 
            // EntryContinueButton
            // 
            this.EntryContinueButton.Location = new System.Drawing.Point(359, 202);
            this.EntryContinueButton.Name = "EntryContinueButton";
            this.EntryContinueButton.Size = new System.Drawing.Size(75, 23);
            this.EntryContinueButton.TabIndex = 2;
            this.EntryContinueButton.Text = "Continue...";
            this.EntryContinueButton.UseVisualStyleBackColor = true;
            this.EntryContinueButton.Click += new System.EventHandler(this.EntryContinueButton_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.EntryContinueButton);
            this.Controls.Add(this.EntrySetupButton);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "EntryForm";
            this.Text = "Planters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EntrySetupButton;
        private System.Windows.Forms.Button EntryContinueButton;
    }
}

