namespace FirstWindowsFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CounterLabel = new System.Windows.Forms.Label();
            this.IncreaseCounterButton = new System.Windows.Forms.Button();
            this.HideButtonCheckBox = new System.Windows.Forms.CheckBox();
            this.YesrOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CounterLabel
            // 
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CounterLabel.Location = new System.Drawing.Point(85, 132);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(46, 54);
            this.CounterLabel.TabIndex = 0;
            this.CounterLabel.Text = "0";
            // 
            // IncreaseCounterButton
            // 
            this.IncreaseCounterButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncreaseCounterButton.Location = new System.Drawing.Point(85, 283);
            this.IncreaseCounterButton.Name = "IncreaseCounterButton";
            this.IncreaseCounterButton.Size = new System.Drawing.Size(171, 65);
            this.IncreaseCounterButton.TabIndex = 1;
            this.IncreaseCounterButton.Text = "Click me!";
            this.IncreaseCounterButton.UseMnemonic = false;
            this.IncreaseCounterButton.UseVisualStyleBackColor = true;
            this.IncreaseCounterButton.Click += new System.EventHandler(this.IncreaseCounterButton_Click);
            // 
            // HideButtonCheckBox
            // 
            this.HideButtonCheckBox.AutoSize = true;
            this.HideButtonCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HideButtonCheckBox.Location = new System.Drawing.Point(85, 224);
            this.HideButtonCheckBox.Name = "HideButtonCheckBox";
            this.HideButtonCheckBox.Size = new System.Drawing.Size(169, 36);
            this.HideButtonCheckBox.TabIndex = 2;
            this.HideButtonCheckBox.Text = "Hide button";
            this.HideButtonCheckBox.UseMnemonic = false;
            this.HideButtonCheckBox.UseVisualStyleBackColor = true;
            this.HideButtonCheckBox.CheckedChanged += new System.EventHandler(this.HideButtonCheckBox_CheckedChanged);
            // 
            // YesrOfBirthTextBox
            // 
            this.YesrOfBirthTextBox.Location = new System.Drawing.Point(82, 383);
            this.YesrOfBirthTextBox.Name = "YesrOfBirthTextBox";
            this.YesrOfBirthTextBox.Size = new System.Drawing.Size(150, 31);
            this.YesrOfBirthTextBox.TabIndex = 3;
            this.YesrOfBirthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YesrOfBirthTextBox_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.YesrOfBirthTextBox);
            this.Controls.Add(this.HideButtonCheckBox);
            this.Controls.Add(this.IncreaseCounterButton);
            this.Controls.Add(this.CounterLabel);
            this.Name = "MainForm";
            this.Text = "MyFirstApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CounterLabel;
        private Button IncreaseCounterButton;
        private CheckBox HideButtonCheckBox;
        private TextBox YesrOfBirthTextBox;
    }
}