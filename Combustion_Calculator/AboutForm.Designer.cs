namespace Combustion_Calculator
{
    partial class AboutForm
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
            AboutTextBox = new RichTextBox();
            OKbutton = new Button();
            SuspendLayout();
            // 
            // AboutTextBox
            // 
            AboutTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AboutTextBox.Location = new Point(2, 10);
            AboutTextBox.MaxLength = 6000;
            AboutTextBox.Name = "AboutTextBox";
            AboutTextBox.ReadOnly = true;
            AboutTextBox.Size = new Size(369, 297);
            AboutTextBox.TabIndex = 1;
            AboutTextBox.TabStop = false;
            AboutTextBox.Text = "This App prepared by Amer10Coder";
            // 
            // OKbutton
            // 
            OKbutton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            OKbutton.Location = new Point(102, 225);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(168, 65);
            OKbutton.TabIndex = 0;
            OKbutton.Text = "OK";
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 326);
            Controls.Add(OKbutton);
            Controls.Add(AboutTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            Padding = new Padding(2, 42, 2, 2);
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox AboutTextBox;
        private Button OKbutton;
    }
}