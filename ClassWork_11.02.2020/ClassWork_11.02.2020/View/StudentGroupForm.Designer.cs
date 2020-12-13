namespace ClassWork_11._02._2020.View
{
    partial class StudentGroupForm
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
            this.groupView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupView
            // 
            this.groupView.AllowUserToAddRows = false;
            this.groupView.AllowUserToDeleteRows = false;
            this.groupView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameGroup,
            this.SpecialtyId,
            this.NumberOfStudents,
            this.Specialty});
            this.groupView.Location = new System.Drawing.Point(9, 10);
            this.groupView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupView.MultiSelect = false;
            this.groupView.Name = "groupView";
            this.groupView.ReadOnly = true;
            this.groupView.RowHeadersWidth = 51;
            this.groupView.RowTemplate.Height = 24;
            this.groupView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupView.Size = new System.Drawing.Size(582, 314);
            this.groupView.TabIndex = 0;
            this.groupView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.groupView_CellFormatting);
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // NameGroup
            // 
            this.NameGroup.DataPropertyName = "Name";
            this.NameGroup.HeaderText = "Название";
            this.NameGroup.MinimumWidth = 6;
            this.NameGroup.Name = "NameGroup";
            this.NameGroup.ReadOnly = true;
            this.NameGroup.Width = 125;
            // 
            // SpecialtyId
            // 
            this.SpecialtyId.DataPropertyName = "Specialty_id";
            this.SpecialtyId.HeaderText = "SpecialtyId";
            this.SpecialtyId.MinimumWidth = 6;
            this.SpecialtyId.Name = "SpecialtyId";
            this.SpecialtyId.ReadOnly = true;
            this.SpecialtyId.Visible = false;
            this.SpecialtyId.Width = 125;
            // 
            // NumberOfStudents
            // 
            this.NumberOfStudents.DataPropertyName = "NumberOfStudents";
            this.NumberOfStudents.HeaderText = "Кол-во студентов";
            this.NumberOfStudents.MinimumWidth = 6;
            this.NumberOfStudents.Name = "NumberOfStudents";
            this.NumberOfStudents.ReadOnly = true;
            this.NumberOfStudents.Width = 125;
            // 
            // Specialty
            // 
            this.Specialty.DataPropertyName = "Specialty";
            this.Specialty.HeaderText = "Специальность";
            this.Specialty.MinimumWidth = 6;
            this.Specialty.Name = "Specialty";
            this.Specialty.ReadOnly = true;
            this.Specialty.Width = 125;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(523, 329);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(68, 27);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(453, 329);
            this.changeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(65, 27);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(383, 329);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(65, 27);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // StudentGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.groupView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentGroupForm";
            this.Text = "StudentGroupForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView groupView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialty;
    }
}