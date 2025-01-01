namespace Udemi_WinFormsApp_NumericTypeSuggestion
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
            this.checkBoxIntegralOnly = new System.Windows.Forms.CheckBox();
            this.checkBoxMustBePrecise = new System.Windows.Forms.CheckBox();
            this.labelMinValue = new System.Windows.Forms.Label();
            this.labelMaxValue = new System.Windows.Forms.Label();
            this.labelSuggestedType = new System.Windows.Forms.Label();
            this.textBoxMinValue = new System.Windows.Forms.TextBox();
            this.textBoxMaxValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxIntegralOnly
            // 
            this.checkBoxIntegralOnly.AutoSize = true;
            this.checkBoxIntegralOnly.Checked = true;
            this.checkBoxIntegralOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIntegralOnly.Location = new System.Drawing.Point(47, 218);
            this.checkBoxIntegralOnly.Name = "checkBoxIntegralOnly";
            this.checkBoxIntegralOnly.Size = new System.Drawing.Size(145, 29);
            this.checkBoxIntegralOnly.TabIndex = 0;
            this.checkBoxIntegralOnly.Text = "Integral only?";
            this.checkBoxIntegralOnly.UseVisualStyleBackColor = true;
            this.checkBoxIntegralOnly.CheckedChanged += new System.EventHandler(this.checkBoxIntegralOnly_CheckedChanged);
            // 
            // checkBoxMustBePrecise
            // 
            this.checkBoxMustBePrecise.AutoSize = true;
            this.checkBoxMustBePrecise.Location = new System.Drawing.Point(47, 288);
            this.checkBoxMustBePrecise.Name = "checkBoxMustBePrecise";
            this.checkBoxMustBePrecise.Size = new System.Drawing.Size(171, 29);
            this.checkBoxMustBePrecise.TabIndex = 1;
            this.checkBoxMustBePrecise.Text = "Must be precise?";
            this.checkBoxMustBePrecise.UseVisualStyleBackColor = true;
            this.checkBoxMustBePrecise.CheckedChanged += new System.EventHandler(this.SuggestedTypeCalculation);
            // 
            // labelMinValue
            // 
            this.labelMinValue.AutoSize = true;
            this.labelMinValue.Location = new System.Drawing.Point(52, 58);
            this.labelMinValue.Name = "labelMinValue";
            this.labelMinValue.Size = new System.Drawing.Size(89, 25);
            this.labelMinValue.TabIndex = 2;
            this.labelMinValue.Text = "Min Value";
            // 
            // labelMaxValue
            // 
            this.labelMaxValue.AutoSize = true;
            this.labelMaxValue.Location = new System.Drawing.Point(52, 119);
            this.labelMaxValue.Name = "labelMaxValue";
            this.labelMaxValue.Size = new System.Drawing.Size(92, 25);
            this.labelMaxValue.TabIndex = 3;
            this.labelMaxValue.Text = "Max Value";
            // 
            // labelSuggestedType
            // 
            this.labelSuggestedType.AutoSize = true;
            this.labelSuggestedType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSuggestedType.Location = new System.Drawing.Point(47, 377);
            this.labelSuggestedType.Name = "labelSuggestedType";
            this.labelSuggestedType.Size = new System.Drawing.Size(147, 25);
            this.labelSuggestedType.TabIndex = 4;
            this.labelSuggestedType.Text = "Suggested Type";
            // 
            // textBoxMinValue
            // 
            this.textBoxMinValue.Location = new System.Drawing.Point(225, 58);
            this.textBoxMinValue.Name = "textBoxMinValue";
            this.textBoxMinValue.Size = new System.Drawing.Size(150, 31);
            this.textBoxMinValue.TabIndex = 5;
            this.textBoxMinValue.TextChanged += new System.EventHandler(this.SuggestedTypeCalculation);
            this.textBoxMinValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMinValue_KeyPress);
            // 
            // textBoxMaxValue
            // 
            this.textBoxMaxValue.Location = new System.Drawing.Point(225, 113);
            this.textBoxMaxValue.Name = "textBoxMaxValue";
            this.textBoxMaxValue.Size = new System.Drawing.Size(150, 31);
            this.textBoxMaxValue.TabIndex = 6;
            this.textBoxMaxValue.TextChanged += new System.EventHandler(this.SuggestedTypeCalculation);
            this.textBoxMaxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMaxValue_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.textBoxMaxValue);
            this.Controls.Add(this.textBoxMinValue);
            this.Controls.Add(this.labelSuggestedType);
            this.Controls.Add(this.labelMaxValue);
            this.Controls.Add(this.labelMinValue);
            this.Controls.Add(this.checkBoxMustBePrecise);
            this.Controls.Add(this.checkBoxIntegralOnly);
            this.Name = "MainForm";
            this.Text = "Numeric Type Suggestion App";
            this.Activated += new System.EventHandler(this.checkBoxIntegralOnly_CheckedChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkBoxIntegralOnly;
        private CheckBox checkBoxMustBePrecise;
        private Label labelMinValue;
        private Label labelMaxValue;
        private Label labelSuggestedType;
        private TextBox textBoxMinValue;
        private TextBox textBoxMaxValue;
    }
}