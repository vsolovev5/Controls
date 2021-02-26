
namespace Controls
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
            this.components = new System.ComponentModel.Container();
            this.numberTextBox2 = new WinFormsControlLab.NumberTextBox(this.components);
            this.numberTextBox1 = new WinFormsControlLab.NumberTextBox(this.components);
            this.SuspendLayout();
            // 
            // numberTextBox2
            // 
            this.numberTextBox2.ForeColor = System.Drawing.Color.Red;
            this.numberTextBox2.Location = new System.Drawing.Point(13, 57);
            this.numberTextBox2.Name = "numberTextBox2";
            this.numberTextBox2.Size = new System.Drawing.Size(100, 22);
            this.numberTextBox2.TabIndex = 1;
            // 
            // numberTextBox1
            // 
            this.numberTextBox1.ForeColor = System.Drawing.Color.Red;
            this.numberTextBox1.Location = new System.Drawing.Point(13, 13);
            this.numberTextBox1.Name = "numberTextBox1";
            this.numberTextBox1.Size = new System.Drawing.Size(100, 22);
            this.numberTextBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberTextBox2);
            this.Controls.Add(this.numberTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinFormsControlLab.NumberTextBox numberTextBox1;
        private WinFormsControlLab.NumberTextBox numberTextBox2;
    }
}

