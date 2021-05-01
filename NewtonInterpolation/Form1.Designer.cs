namespace NewtonInterpolation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_SampleX = new System.Windows.Forms.TextBox();
            this.txt_SampleY = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_InterpolX = new System.Windows.Forms.TextBox();
            this.txt_InterpolY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Newton\'s Divided Difference \r\nInterpolating Polynomial Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of points:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPoints
            // 
            this.txtPoints.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoints.Location = new System.Drawing.Point(170, 37);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(100, 29);
            this.txtPoints.TabIndex = 1;
            this.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Point Coordinates:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Enter
            // 
            this.btn_Enter.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.Location = new System.Drawing.Point(115, 72);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(100, 30);
            this.btn_Enter.TabIndex = 2;
            this.btn_Enter.Text = "ENTER";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "x";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "y";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.btn_Enter);
            this.panel1.Controls.Add(this.txtPoints);
            this.panel1.Controls.Add(this.txt_InterpolY);
            this.panel1.Controls.Add(this.txt_InterpolX);
            this.panel1.Location = new System.Drawing.Point(56, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 187);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.txt_SampleY);
            this.panel2.Controls.Add(this.txt_SampleX);
            this.panel2.Location = new System.Drawing.Point(46, 359);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 41);
            this.panel2.TabIndex = 4;
            // 
            // txt_SampleX
            // 
            this.txt_SampleX.Enabled = false;
            this.txt_SampleX.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SampleX.Location = new System.Drawing.Point(110, 5);
            this.txt_SampleX.Name = "txt_SampleX";
            this.txt_SampleX.Size = new System.Drawing.Size(100, 29);
            this.txt_SampleX.TabIndex = 1;
            this.txt_SampleX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_SampleY
            // 
            this.txt_SampleY.Enabled = false;
            this.txt_SampleY.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SampleY.Location = new System.Drawing.Point(240, 5);
            this.txt_SampleY.Name = "txt_SampleY";
            this.txt_SampleY.Size = new System.Drawing.Size(100, 29);
            this.txt_SampleY.TabIndex = 1;
            this.txt_SampleY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(230, 72);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 30);
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_InterpolX
            // 
            this.txt_InterpolX.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InterpolX.Location = new System.Drawing.Point(100, 140);
            this.txt_InterpolX.Name = "txt_InterpolX";
            this.txt_InterpolX.Size = new System.Drawing.Size(100, 29);
            this.txt_InterpolX.TabIndex = 2;
            this.txt_InterpolX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_InterpolY
            // 
            this.txt_InterpolY.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InterpolY.Location = new System.Drawing.Point(230, 140);
            this.txt_InterpolY.Name = "txt_InterpolY";
            this.txt_InterpolY.Size = new System.Drawing.Size(100, 29);
            this.txt_InterpolY.TabIndex = 3;
            this.txt_InterpolY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Interpolating Points:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(650, 600);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NDDP Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_SampleY;
        private System.Windows.Forms.TextBox txt_SampleX;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox txt_InterpolX;
        private System.Windows.Forms.TextBox txt_InterpolY;
        private System.Windows.Forms.Label label6;
    }
}

