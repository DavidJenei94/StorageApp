namespace StorageAppDesktop
{
    partial class EditDeleteItem
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
            this.StorageComboBox = new System.Windows.Forms.ComboBox();
            this.RoomComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.editItemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // StorageComboBox
            // 
            this.StorageComboBox.FormattingEnabled = true;
            this.StorageComboBox.Location = new System.Drawing.Point(211, 150);
            this.StorageComboBox.Name = "StorageComboBox";
            this.StorageComboBox.Size = new System.Drawing.Size(121, 23);
            this.StorageComboBox.TabIndex = 8;
            // 
            // RoomComboBox
            // 
            this.RoomComboBox.FormattingEnabled = true;
            this.RoomComboBox.Location = new System.Drawing.Point(211, 101);
            this.RoomComboBox.Name = "RoomComboBox";
            this.RoomComboBox.Size = new System.Drawing.Size(121, 23);
            this.RoomComboBox.TabIndex = 7;
            this.RoomComboBox.TextChanged += new System.EventHandler(this.SelectedValue_Change);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(211, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox.TabIndex = 6;
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(257, 289);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(75, 23);
            this.deleteItemButton.TabIndex = 5;
            this.deleteItemButton.Text = "Delete Item";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantity";
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(211, 200);
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.quantityNumericUpDown.TabIndex = 3;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Storage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // editItemButton
            // 
            this.editItemButton.Location = new System.Drawing.Point(82, 289);
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(112, 23);
            this.editItemButton.TabIndex = 5;
            this.editItemButton.Text = "Edit/Move Item";
            this.editItemButton.UseVisualStyleBackColor = true;
            this.editItemButton.Click += new System.EventHandler(this.EditItemButton_Click);
            // 
            // EditDeleteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 370);
            this.Controls.Add(this.editItemButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.RoomComboBox);
            this.Controls.Add(this.StorageComboBox);
            this.Name = "EditDeleteItem";
            this.Text = "EditDeleteItem";
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StorageComboBox;
        private System.Windows.Forms.ComboBox RoomComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editItemButton;
    }
}