namespace FrmBasicCalculator
{
    partial class FrmBasicCalculator
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
            this.tbInput1 = new System.Windows.Forms.TextBox();
            this.tbInput2 = new System.Windows.Forms.TextBox();
            this.rtbTotal = new System.Windows.Forms.RichTextBox();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbInput1
            // 
            this.tbInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput1.Location = new System.Drawing.Point(61, 96);
            this.tbInput1.Name = "tbInput1";
            this.tbInput1.Size = new System.Drawing.Size(488, 29);
            this.tbInput1.TabIndex = 1;
            this.tbInput1.Text = "0";
            // 
            // tbInput2
            // 
            this.tbInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput2.Location = new System.Drawing.Point(61, 214);
            this.tbInput2.Name = "tbInput2";
            this.tbInput2.Size = new System.Drawing.Size(488, 29);
            this.tbInput2.TabIndex = 2;
            this.tbInput2.Text = "0";
            // 
            // rtbTotal
            // 
            this.rtbTotal.Location = new System.Drawing.Point(103, 270);
            this.rtbTotal.Name = "rtbTotal";
            this.rtbTotal.Size = new System.Drawing.Size(401, 100);
            this.rtbTotal.TabIndex = 3;
            this.rtbTotal.Text = "";
            this.rtbTotal.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // cbOperation
            // 
            this.cbOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Location = new System.Drawing.Point(246, 152);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(121, 39);
            this.cbOperation.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(246, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrmBasicCalculator.Properties.Resources._1233;
            this.ClientSize = new System.Drawing.Size(630, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.rtbTotal);
            this.Controls.Add(this.tbInput2);
            this.Controls.Add(this.tbInput1);
            this.Controls.Add(this.label1);
            this.Name = "FrmBasicCalculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInput1;
        private System.Windows.Forms.TextBox tbInput2;
        private System.Windows.Forms.RichTextBox rtbTotal;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.Button button1;
    }
}

