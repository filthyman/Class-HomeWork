namespace ClassWork_11._02._2020.View
{
    partial class MainForm
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
            this.specialtyButton = new System.Windows.Forms.Button();
            this.groupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // specialtyButton
            // 
            this.specialtyButton.Location = new System.Drawing.Point(12, 12);
            this.specialtyButton.Name = "specialtyButton";
            this.specialtyButton.Size = new System.Drawing.Size(195, 35);
            this.specialtyButton.TabIndex = 0;
            this.specialtyButton.Text = "Специальности";
            this.specialtyButton.UseVisualStyleBackColor = true;
            this.specialtyButton.Click += new System.EventHandler(this.specialtyButton_Click);
            // 
            // groupButton
            // 
            this.groupButton.Location = new System.Drawing.Point(12, 53);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(195, 35);
            this.groupButton.TabIndex = 1;
            this.groupButton.Text = "Группы";
            this.groupButton.UseVisualStyleBackColor = true;
            this.groupButton.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 98);
            this.Controls.Add(this.groupButton);
            this.Controls.Add(this.specialtyButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button specialtyButton;
        private System.Windows.Forms.Button groupButton;
    }
}