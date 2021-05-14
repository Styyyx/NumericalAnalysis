namespace Compile
{
    partial class FormSecant
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
            this.btnBack = new System.Windows.Forms.Button();
            this.labTitle = new System.Windows.Forms.Label();
            this.tboxFx = new System.Windows.Forms.TextBox();
            this.labFx = new System.Windows.Forms.Label();
            this.labX0 = new System.Windows.Forms.Label();
            this.tboxX0 = new System.Windows.Forms.TextBox();
            this.tboxX1 = new System.Windows.Forms.TextBox();
            this.labX1 = new System.Windows.Forms.Label();
            this.rbtnIter = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnErr = new System.Windows.Forms.RadioButton();
            this.panelStopForce = new System.Windows.Forms.Panel();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.tboxStopForce = new System.Windows.Forms.TextBox();
            this.panelStopForce.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 40);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(235, 40);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(337, 54);
            this.labTitle.TabIndex = 17;
            this.labTitle.Text = "Secant Method";
            // 
            // tboxFx
            // 
            this.tboxFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxFx.Location = new System.Drawing.Point(332, 123);
            this.tboxFx.Multiline = true;
            this.tboxFx.Name = "tboxFx";
            this.tboxFx.Size = new System.Drawing.Size(250, 30);
            this.tboxFx.TabIndex = 19;
            // 
            // labFx
            // 
            this.labFx.AutoSize = true;
            this.labFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFx.Location = new System.Drawing.Point(225, 126);
            this.labFx.Name = "labFx";
            this.labFx.Size = new System.Drawing.Size(101, 20);
            this.labFx.TabIndex = 18;
            this.labFx.Text = "Function f(x):";
            // 
            // labX0
            // 
            this.labX0.AutoSize = true;
            this.labX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labX0.Location = new System.Drawing.Point(271, 177);
            this.labX0.Name = "labX0";
            this.labX0.Size = new System.Drawing.Size(29, 20);
            this.labX0.TabIndex = 20;
            this.labX0.Text = "x0:";
            // 
            // tboxX0
            // 
            this.tboxX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxX0.Location = new System.Drawing.Point(306, 174);
            this.tboxX0.Multiline = true;
            this.tboxX0.Name = "tboxX0";
            this.tboxX0.Size = new System.Drawing.Size(85, 30);
            this.tboxX0.TabIndex = 21;
            // 
            // tboxX1
            // 
            this.tboxX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxX1.Location = new System.Drawing.Point(445, 174);
            this.tboxX1.Multiline = true;
            this.tboxX1.Name = "tboxX1";
            this.tboxX1.Size = new System.Drawing.Size(85, 30);
            this.tboxX1.TabIndex = 23;
            // 
            // labX1
            // 
            this.labX1.AutoSize = true;
            this.labX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labX1.Location = new System.Drawing.Point(410, 177);
            this.labX1.Name = "labX1";
            this.labX1.Size = new System.Drawing.Size(29, 20);
            this.labX1.TabIndex = 22;
            this.labX1.Text = "x1:";
            // 
            // rbtnIter
            // 
            this.rbtnIter.AutoSize = true;
            this.rbtnIter.Checked = true;
            this.rbtnIter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIter.Location = new System.Drawing.Point(16, 14);
            this.rbtnIter.Name = "rbtnIter";
            this.rbtnIter.Size = new System.Drawing.Size(84, 21);
            this.rbtnIter.TabIndex = 30;
            this.rbtnIter.Text = "Iterations";
            this.rbtnIter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Stopping Force:";
            // 
            // rbtnErr
            // 
            this.rbtnErr.AutoSize = true;
            this.rbtnErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnErr.Location = new System.Drawing.Point(16, 41);
            this.rbtnErr.Name = "rbtnErr";
            this.rbtnErr.Size = new System.Drawing.Size(58, 21);
            this.rbtnErr.TabIndex = 31;
            this.rbtnErr.Text = "Error";
            this.rbtnErr.UseVisualStyleBackColor = true;
            // 
            // panelStopForce
            // 
            this.panelStopForce.Controls.Add(this.rbtnIter);
            this.panelStopForce.Controls.Add(this.rbtnErr);
            this.panelStopForce.Location = new System.Drawing.Point(257, 246);
            this.panelStopForce.Name = "panelStopForce";
            this.panelStopForce.Size = new System.Drawing.Size(103, 81);
            this.panelStopForce.TabIndex = 27;
            // 
            // btnSolve
            // 
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(291, 375);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(111, 30);
            this.btnSolve.TabIndex = 28;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(445, 375);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(111, 30);
            this.btnClearAll.TabIndex = 29;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // tboxStopForce
            // 
            this.tboxStopForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxStopForce.Location = new System.Drawing.Point(392, 272);
            this.tboxStopForce.Multiline = true;
            this.tboxStopForce.Name = "tboxStopForce";
            this.tboxStopForce.Size = new System.Drawing.Size(103, 30);
            this.tboxStopForce.TabIndex = 24;
            // 
            // FormSecant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tboxStopForce);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.panelStopForce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxX1);
            this.Controls.Add(this.labX1);
            this.Controls.Add(this.tboxX0);
            this.Controls.Add(this.labX0);
            this.Controls.Add(this.tboxFx);
            this.Controls.Add(this.labFx);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormSecant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Secant_FormClosed);
            this.panelStopForce.ResumeLayout(false);
            this.panelStopForce.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.TextBox tboxFx;
        private System.Windows.Forms.Label labFx;
        private System.Windows.Forms.Label labX0;
        private System.Windows.Forms.TextBox tboxX0;
        private System.Windows.Forms.TextBox tboxX1;
        private System.Windows.Forms.Label labX1;
        private System.Windows.Forms.RadioButton rbtnIter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnErr;
        private System.Windows.Forms.Panel panelStopForce;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.TextBox tboxStopForce;
    }
}