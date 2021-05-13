namespace Compile
{
    partial class FormMain
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
            this.labTitle = new System.Windows.Forms.Label();
            this.btnTaylor = new System.Windows.Forms.Button();
            this.btnSecant = new System.Windows.Forms.Button();
            this.btnInterpolation = new System.Windows.Forms.Button();
            this.btnIntegration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Proxima Nova Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(75, 50);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(343, 52);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "NUMERICAL ANAYLSIS\r\nMACHINE PROBLEM COMPILATION\r\n";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTaylor
            // 
            this.btnTaylor.Font = new System.Drawing.Font("Proxima Nova Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaylor.Location = new System.Drawing.Point(101, 152);
            this.btnTaylor.Name = "btnTaylor";
            this.btnTaylor.Size = new System.Drawing.Size(279, 52);
            this.btnTaylor.TabIndex = 1;
            this.btnTaylor.Text = "Taylor Series";
            this.btnTaylor.UseVisualStyleBackColor = true;
            this.btnTaylor.Click += new System.EventHandler(this.btnTaylor_Click);
            // 
            // btnSecant
            // 
            this.btnSecant.Font = new System.Drawing.Font("Proxima Nova Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecant.Location = new System.Drawing.Point(101, 219);
            this.btnSecant.Name = "btnSecant";
            this.btnSecant.Size = new System.Drawing.Size(279, 52);
            this.btnSecant.TabIndex = 2;
            this.btnSecant.Text = "Secant Method";
            this.btnSecant.UseVisualStyleBackColor = true;
            // 
            // btnInterpolation
            // 
            this.btnInterpolation.Font = new System.Drawing.Font("Proxima Nova Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterpolation.Location = new System.Drawing.Point(101, 287);
            this.btnInterpolation.Name = "btnInterpolation";
            this.btnInterpolation.Size = new System.Drawing.Size(279, 52);
            this.btnInterpolation.TabIndex = 3;
            this.btnInterpolation.Text = "Newton Interpolation";
            this.btnInterpolation.UseVisualStyleBackColor = true;
            // 
            // btnIntegration
            // 
            this.btnIntegration.Font = new System.Drawing.Font("Proxima Nova Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntegration.Location = new System.Drawing.Point(101, 354);
            this.btnIntegration.Name = "btnIntegration";
            this.btnIntegration.Size = new System.Drawing.Size(279, 52);
            this.btnIntegration.TabIndex = 4;
            this.btnIntegration.Text = "Numerical Integration";
            this.btnIntegration.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnIntegration);
            this.Controls.Add(this.btnInterpolation);
            this.Controls.Add(this.btnSecant);
            this.Controls.Add(this.btnTaylor);
            this.Controls.Add(this.labTitle);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numerical Analysis | Machine Problem Compilation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnTaylor;
        private System.Windows.Forms.Button btnSecant;
        private System.Windows.Forms.Button btnInterpolation;
        private System.Windows.Forms.Button btnIntegration;
    }
}

