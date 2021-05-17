namespace Compile
{
    partial class FormSecantResult
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
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.iteration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fx0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fx1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.err = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToResizeColumns = false;
            this.dgvResult.AllowUserToResizeRows = false;
            this.dgvResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteration,
            this.x0,
            this.x1,
            this.fx0,
            this.fx1,
            this.x2,
            this.err});
            this.dgvResult.Location = new System.Drawing.Point(1, 0);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvResult.Size = new System.Drawing.Size(416, 138);
            this.dgvResult.TabIndex = 1;
            // 
            // iteration
            // 
            this.iteration.HeaderText = "n";
            this.iteration.Name = "iteration";
            this.iteration.Width = 38;
            // 
            // x0
            // 
            this.x0.HeaderText = "x0";
            this.x0.Name = "x0";
            this.x0.ReadOnly = true;
            this.x0.Width = 43;
            // 
            // x1
            // 
            this.x1.HeaderText = "x1";
            this.x1.Name = "x1";
            this.x1.ReadOnly = true;
            this.x1.Width = 43;
            // 
            // fx0
            // 
            this.fx0.HeaderText = "f(x0)";
            this.fx0.Name = "fx0";
            this.fx0.ReadOnly = true;
            this.fx0.Width = 52;
            // 
            // fx1
            // 
            this.fx1.HeaderText = "f(x1)";
            this.fx1.Name = "fx1";
            this.fx1.ReadOnly = true;
            this.fx1.Width = 52;
            // 
            // x2
            // 
            this.x2.HeaderText = "x2";
            this.x2.Name = "x2";
            this.x2.ReadOnly = true;
            this.x2.Width = 43;
            // 
            // err
            // 
            this.err.HeaderText = "Error %";
            this.err.Name = "err";
            this.err.ReadOnly = true;
            this.err.Width = 65;
            // 
            // FormSecantResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 162);
            this.Controls.Add(this.dgvResult);
            this.Name = "FormSecantResult";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secant Result";
            this.Load += new System.EventHandler(this.FormSecantResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteration;
        private System.Windows.Forms.DataGridViewTextBoxColumn x0;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fx0;
        private System.Windows.Forms.DataGridViewTextBoxColumn fx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn x2;
        private System.Windows.Forms.DataGridViewTextBoxColumn err;
    }
}