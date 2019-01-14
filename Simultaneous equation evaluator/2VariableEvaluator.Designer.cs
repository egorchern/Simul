namespace Simultaneous_equation_evaluator
{
    partial class _2VariableEvaluator
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
            this.txtEq1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEq2 = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equation 1: (if no variable write 0x/0y)";
            // 
            // txtEq1
            // 
            this.txtEq1.Location = new System.Drawing.Point(17, 36);
            this.txtEq1.Name = "txtEq1";
            this.txtEq1.Size = new System.Drawing.Size(411, 26);
            this.txtEq1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Equation 2: ((if no variable write 0x/0y)";
            // 
            // txtEq2
            // 
            this.txtEq2.Location = new System.Drawing.Point(17, 101);
            this.txtEq2.Name = "txtEq2";
            this.txtEq2.Size = new System.Drawing.Size(411, 26);
            this.txtEq2.TabIndex = 3;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(130, 171);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(166, 103);
            this.btnSolve.TabIndex = 4;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // _2VariableEvaluator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 287);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.txtEq2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEq1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "_2VariableEvaluator";
            this.Text = "2VariableEvaluator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEq1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEq2;
        private System.Windows.Forms.Button btnSolve;
    }
}