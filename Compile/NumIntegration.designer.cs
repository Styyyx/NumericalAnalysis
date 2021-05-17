namespace Compile
{
    partial class FormIntegration
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
            this.labFx = new System.Windows.Forms.Label();
            this.tboxFx = new System.Windows.Forms.TextBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.labA = new System.Windows.Forms.Label();
            this.labB = new System.Windows.Forms.Label();
            this.tboxA = new System.Windows.Forms.TextBox();
            this.tboxB = new System.Windows.Forms.TextBox();
            this.labN = new System.Windows.Forms.Label();
            this.numUpDownN = new System.Windows.Forms.NumericUpDown();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.labTResult = new System.Windows.Forms.Label();
            this.labTError = new System.Windows.Forms.Label();
            this.labSError = new System.Windows.Forms.Label();
            this.labSResult = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownN)).BeginInit();
            this.SuspendLayout();
            // 
            // labFx
            // 
            this.labFx.AutoSize = true;
            this.labFx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFx.Location = new System.Drawing.Point(49, 113);
            this.labFx.Name = "labFx";
            this.labFx.Size = new System.Drawing.Size(96, 18);
            this.labFx.TabIndex = 0;
            this.labFx.Text = "Function f(x):";
            // 
            // tboxFx
            // 
            this.tboxFx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxFx.Location = new System.Drawing.Point(182, 106);
            this.tboxFx.Multiline = true;
            this.tboxFx.Name = "tboxFx";
            this.tboxFx.Size = new System.Drawing.Size(250, 25);
            this.tboxFx.TabIndex = 1;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(119, 57);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(260, 29);
            this.labTitle.TabIndex = 2;
            this.labTitle.Text = "Numerical Integration";
            // 
            // labA
            // 
            this.labA.AutoSize = true;
            this.labA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labA.Location = new System.Drawing.Point(49, 158);
            this.labA.Name = "labA";
            this.labA.Size = new System.Drawing.Size(116, 18);
            this.labA.TabIndex = 3;
            this.labA.Text = "Lower Limit (a):";
            // 
            // labB
            // 
            this.labB.AutoSize = true;
            this.labB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labB.Location = new System.Drawing.Point(49, 203);
            this.labB.Name = "labB";
            this.labB.Size = new System.Drawing.Size(116, 18);
            this.labB.TabIndex = 4;
            this.labB.Text = "Upper Limit (b):";
            // 
            // tboxA
            // 
            this.tboxA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxA.Location = new System.Drawing.Point(182, 148);
            this.tboxA.Multiline = true;
            this.tboxA.Name = "tboxA";
            this.tboxA.Size = new System.Drawing.Size(250, 28);
            this.tboxA.TabIndex = 5;
            // 
            // tboxB
            // 
            this.tboxB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxB.Location = new System.Drawing.Point(182, 193);
            this.tboxB.Multiline = true;
            this.tboxB.Name = "tboxB";
            this.tboxB.Size = new System.Drawing.Size(250, 28);
            this.tboxB.TabIndex = 6;
            // 
            // labN
            // 
            this.labN.AutoSize = true;
            this.labN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labN.Location = new System.Drawing.Point(49, 244);
            this.labN.Name = "labN";
            this.labN.Size = new System.Drawing.Size(162, 18);
            this.labN.TabIndex = 7;
            this.labN.Text = "Number of Intervals (n)";
            // 
            // numUpDownN
            // 
            this.numUpDownN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownN.Location = new System.Drawing.Point(231, 242);
            this.numUpDownN.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDownN.Name = "numUpDownN";
            this.numUpDownN.Size = new System.Drawing.Size(80, 26);
            this.numUpDownN.TabIndex = 8;
            this.numUpDownN.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnSolve
            // 
            this.btnSolve.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(102, 441);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(127, 38);
            this.btnSolve.TabIndex = 9;
            this.btnSolve.Text = "SOLVE";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(263, 441);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(127, 38);
            this.btnClearAll.TabIndex = 10;
            this.btnClearAll.Text = "CLEAR ALL";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // labTResult
            // 
            this.labTResult.AutoSize = true;
            this.labTResult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTResult.Location = new System.Drawing.Point(49, 292);
            this.labTResult.Name = "labTResult";
            this.labTResult.Size = new System.Drawing.Size(141, 18);
            this.labTResult.TabIndex = 11;
            this.labTResult.Text = "Trapezoid Result = ";
            this.labTResult.Visible = false;
            // 
            // labTError
            // 
            this.labTError.AutoSize = true;
            this.labTError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTError.Location = new System.Drawing.Point(49, 321);
            this.labTError.Name = "labTError";
            this.labTError.Size = new System.Drawing.Size(120, 18);
            this.labTError.TabIndex = 12;
            this.labTError.Text = "Relative Error = ";
            this.labTError.Visible = false;
            // 
            // labSError
            // 
            this.labSError.AutoSize = true;
            this.labSError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSError.Location = new System.Drawing.Point(49, 397);
            this.labSError.Name = "labSError";
            this.labSError.Size = new System.Drawing.Size(120, 18);
            this.labSError.TabIndex = 14;
            this.labSError.Text = "Relative Error = ";
            this.labSError.Visible = false;
            // 
            // labSResult
            // 
            this.labSResult.AutoSize = true;
            this.labSResult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSResult.Location = new System.Drawing.Point(49, 368);
            this.labSResult.Name = "labSResult";
            this.labSResult.Size = new System.Drawing.Size(134, 18);
            this.labSResult.TabIndex = 13;
            this.labSResult.Text = "Simpson Result = ";
            this.labSResult.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 30);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormIntegration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 511);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labSError);
            this.Controls.Add(this.labSResult);
            this.Controls.Add(this.labTError);
            this.Controls.Add(this.labTResult);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.numUpDownN);
            this.Controls.Add(this.labN);
            this.Controls.Add(this.tboxB);
            this.Controls.Add(this.tboxA);
            this.Controls.Add(this.labB);
            this.Controls.Add(this.labA);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.tboxFx);
            this.Controls.Add(this.labFx);
            this.Name = "FormIntegration";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numerical Analysis | MP - Numerical Integration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormIntegration_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labFx;
        private System.Windows.Forms.TextBox tboxFx;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labA;
        private System.Windows.Forms.Label labB;
        private System.Windows.Forms.TextBox tboxA;
        private System.Windows.Forms.TextBox tboxB;
        private System.Windows.Forms.Label labN;
        private System.Windows.Forms.NumericUpDown numUpDownN;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label labTResult;
        private System.Windows.Forms.Label labTError;
        private System.Windows.Forms.Label labSError;
        private System.Windows.Forms.Label labSResult;
        private System.Windows.Forms.Button btnBack;
    }
}

