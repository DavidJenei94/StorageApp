namespace StorageAppDesktop
{
    partial class EditDeleteStorage
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
            this.StorageComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StorageNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RoomComboBox = new System.Windows.Forms.ComboBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Storage";
            // 
            // StorageComboBox
            // 
            this.StorageComboBox.FormattingEnabled = true;
            this.StorageComboBox.Location = new System.Drawing.Point(175, 34);
            this.StorageComboBox.Name = "StorageComboBox";
            this.StorageComboBox.Size = new System.Drawing.Size(121, 23);
            this.StorageComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Name";
            // 
            // StorageNameTextBox
            // 
            this.StorageNameTextBox.Location = new System.Drawing.Point(175, 131);
            this.StorageNameTextBox.Name = "StorageNameTextBox";
            this.StorageNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.StorageNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room";
            // 
            // RoomComboBox
            // 
            this.RoomComboBox.FormattingEnabled = true;
            this.RoomComboBox.Location = new System.Drawing.Point(175, 80);
            this.RoomComboBox.Name = "RoomComboBox";
            this.RoomComboBox.Size = new System.Drawing.Size(121, 23);
            this.RoomComboBox.TabIndex = 1;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(52, 226);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(99, 23);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit / Move To";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(268, 226);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditDeleteStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 286);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RoomComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StorageNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StorageComboBox);
            this.Controls.Add(this.label1);
            this.Name = "EditDeleteStorage";
            this.Text = "EditDeleteStorage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StorageComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StorageNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox RoomComboBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}