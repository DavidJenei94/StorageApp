namespace StorageAppDesktop
{
    partial class AddItem
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.RoomComboBox = new System.Windows.Forms.ComboBox();
            this.StorageComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Storage";
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(164, 190);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(164, 279);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 5;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(164, 49);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox.TabIndex = 6;
            // 
            // RoomComboBox
            // 
            this.RoomComboBox.FormattingEnabled = true;
            this.RoomComboBox.Location = new System.Drawing.Point(164, 91);
            this.RoomComboBox.Name = "RoomComboBox";
            this.RoomComboBox.Size = new System.Drawing.Size(121, 23);
            this.RoomComboBox.TabIndex = 7;
            this.RoomComboBox.TextChanged += new System.EventHandler(this.SelectedValue_Change);
            // 
            // StorageComboBox
            // 
            this.StorageComboBox.FormattingEnabled = true;
            this.StorageComboBox.Location = new System.Drawing.Point(164, 140);
            this.StorageComboBox.Name = "StorageComboBox";
            this.StorageComboBox.Size = new System.Drawing.Size(121, 23);
            this.StorageComboBox.TabIndex = 8;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 349);
            this.Controls.Add(this.StorageComboBox);
            this.Controls.Add(this.RoomComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddItem";
            this.Text = "AddItem";
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox RoomComboBox;
        private System.Windows.Forms.ComboBox StorageComboBox;
    }
}