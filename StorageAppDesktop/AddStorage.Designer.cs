﻿namespace StorageAppDesktop
{
    partial class AddStorage
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
            this.StorageNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddStorageButton = new System.Windows.Forms.Button();
            this.RoomComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StorageNameTextBox
            // 
            this.StorageNameTextBox.Location = new System.Drawing.Point(96, 59);
            this.StorageNameTextBox.Name = "StorageNameTextBox";
            this.StorageNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.StorageNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // AddStorageButton
            // 
            this.AddStorageButton.Location = new System.Drawing.Point(96, 142);
            this.AddStorageButton.Name = "AddStorageButton";
            this.AddStorageButton.Size = new System.Drawing.Size(75, 23);
            this.AddStorageButton.TabIndex = 2;
            this.AddStorageButton.Text = "Add";
            this.AddStorageButton.UseVisualStyleBackColor = true;
            this.AddStorageButton.Click += new System.EventHandler(this.AddStorage_Click);
            // 
            // RoomComboBox
            // 
            this.RoomComboBox.FormattingEnabled = true;
            this.RoomComboBox.Location = new System.Drawing.Point(96, 89);
            this.RoomComboBox.Name = "RoomComboBox";
            this.RoomComboBox.Size = new System.Drawing.Size(121, 23);
            this.RoomComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room";
            // 
            // AddStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 214);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoomComboBox);
            this.Controls.Add(this.AddStorageButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StorageNameTextBox);
            this.Name = "AddStorage";
            this.Text = "AddEditStorage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StorageNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddStorageButton;
        private System.Windows.Forms.ComboBox RoomComboBox;
        private System.Windows.Forms.Label label2;
    }
}