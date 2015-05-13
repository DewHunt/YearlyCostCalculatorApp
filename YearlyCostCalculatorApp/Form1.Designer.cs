namespace YearlyCostCalculatorApp
{
    partial class YearlyCostCalculatorUI
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
            this.classLabel = new System.Windows.Forms.Label();
            this.discountCheckBox = new System.Windows.Forms.CheckBox();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(198, 44);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(65, 13);
            this.classLabel.TabIndex = 1;
            this.classLabel.Text = "Select Class";
            // 
            // discountCheckBox
            // 
            this.discountCheckBox.AutoSize = true;
            this.discountCheckBox.Location = new System.Drawing.Point(243, 80);
            this.discountCheckBox.Name = "discountCheckBox";
            this.discountCheckBox.Size = new System.Drawing.Size(192, 17);
            this.discountCheckBox.TabIndex = 2;
            this.discountCheckBox.Text = "Get 5% discount for early admission";
            this.discountCheckBox.UseVisualStyleBackColor = true;
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.Location = new System.Drawing.Point(201, 115);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(273, 38);
            this.calculateTotalButton.TabIndex = 3;
            this.calculateTotalButton.Text = "Calculate total amount for one year";
            this.calculateTotalButton.UseVisualStyleBackColor = true;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(283, 41);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(191, 21);
            this.classComboBox.TabIndex = 4;
            // 
            // YearlyCostCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 300);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.discountCheckBox);
            this.Controls.Add(this.classLabel);
            this.Name = "YearlyCostCalculatorUI";
            this.Text = "Yearly Cost Calculator";
            this.Load += new System.EventHandler(this.YearlyCostCalculatorUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.CheckBox discountCheckBox;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.ComboBox classComboBox;
    }
}

