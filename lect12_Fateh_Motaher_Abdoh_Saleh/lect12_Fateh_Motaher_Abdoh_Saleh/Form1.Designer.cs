namespace lect12_Fateh_Motaher_Abdoh_Saleh
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.horizntal = new System.Windows.Forms.RadioButton();
            this.verticle = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(412, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "انشاء";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "الطول";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.Location = new System.Drawing.Point(232, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // horizntal
            // 
            this.horizntal.AutoSize = true;
            this.horizntal.Location = new System.Drawing.Point(124, 410);
            this.horizntal.Name = "horizntal";
            this.horizntal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.horizntal.Size = new System.Drawing.Size(50, 17);
            this.horizntal.TabIndex = 3;
            this.horizntal.TabStop = true;
            this.horizntal.Text = "افقي";
            this.horizntal.UseVisualStyleBackColor = true;
            // 
            // verticle
            // 
            this.verticle.AutoSize = true;
            this.verticle.Location = new System.Drawing.Point(12, 405);
            this.verticle.Name = "verticle";
            this.verticle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.verticle.Size = new System.Drawing.Size(59, 17);
            this.verticle.TabIndex = 4;
            this.verticle.TabStop = true;
            this.verticle.Text = "عمودي";
            this.verticle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 431);
            this.Controls.Add(this.verticle);
            this.Controls.Add(this.horizntal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton horizntal;
        private System.Windows.Forms.RadioButton verticle;
    }
}

