
namespace LiveCurrencyConverter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelConverted = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.hiddenComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Converter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(223, 217);
            this.textBox.MaxLength = 15;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(244, 29);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "To";
            // 
            // fromComboBox
            // 
            this.fromComboBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(223, 282);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(244, 29);
            this.fromComboBox.Sorted = true;
            this.fromComboBox.TabIndex = 5;
            // 
            // toComboBox
            // 
            this.toComboBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Location = new System.Drawing.Point(223, 352);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(244, 29);
            this.toComboBox.Sorted = true;
            this.toComboBox.TabIndex = 5;
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.convertButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.ForeColor = System.Drawing.SystemColors.Control;
            this.convertButton.Location = new System.Drawing.Point(183, 491);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(234, 47);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(185, 573);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Converted Amount:";
            // 
            // labelConverted
            // 
            this.labelConverted.AutoSize = true;
            this.labelConverted.BackColor = System.Drawing.SystemColors.Control;
            this.labelConverted.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConverted.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelConverted.Location = new System.Drawing.Point(249, 614);
            this.labelConverted.Name = "labelConverted";
            this.labelConverted.Size = new System.Drawing.Size(0, 28);
            this.labelConverted.TabIndex = 8;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(223, 424);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker.Size = new System.Drawing.Size(244, 29);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.Value = new System.DateTime(2021, 3, 27, 15, 26, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(126, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Date";
            // 
            // hiddenComboBox
            // 
            this.hiddenComboBox.FormattingEnabled = true;
            this.hiddenComboBox.Location = new System.Drawing.Point(473, 352);
            this.hiddenComboBox.Name = "hiddenComboBox";
            this.hiddenComboBox.Size = new System.Drawing.Size(71, 28);
            this.hiddenComboBox.Sorted = true;
            this.hiddenComboBox.TabIndex = 10;
            this.hiddenComboBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(578, 694);
            this.Controls.Add(this.hiddenComboBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelConverted);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.toComboBox);
            this.Controls.Add(this.fromComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(600, 750);
            this.MinimumSize = new System.Drawing.Size(600, 750);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Live Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox fromComboBox;
        private System.Windows.Forms.ComboBox toComboBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelConverted;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox hiddenComboBox;
    }
}

