namespace Part_4_Random_Numbers
{
    partial class frmRandomNumbers
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
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.txtMinimum = new System.Windows.Forms.TextBox();
            this.txtMaximum = new System.Windows.Forms.TextBox();
            this.btnInteger = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(22, 22);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(241, 17);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Enter a minimum and maximum value";
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Location = new System.Drawing.Point(22, 70);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(63, 17);
            this.lblMinimum.TabIndex = 1;
            this.lblMinimum.Text = "Minimum";
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Location = new System.Drawing.Point(22, 117);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(66, 17);
            this.lblMaximum.TabIndex = 2;
            this.lblMaximum.Text = "Maximum";
            // 
            // txtMinimum
            // 
            this.txtMinimum.Location = new System.Drawing.Point(91, 67);
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.Size = new System.Drawing.Size(100, 22);
            this.txtMinimum.TabIndex = 3;
            // 
            // txtMaximum
            // 
            this.txtMaximum.Location = new System.Drawing.Point(94, 114);
            this.txtMaximum.Name = "txtMaximum";
            this.txtMaximum.Size = new System.Drawing.Size(100, 22);
            this.txtMaximum.TabIndex = 4;
            // 
            // btnInteger
            // 
            this.btnInteger.Location = new System.Drawing.Point(25, 171);
            this.btnInteger.Name = "btnInteger";
            this.btnInteger.Size = new System.Drawing.Size(98, 29);
            this.btnInteger.TabIndex = 5;
            this.btnInteger.Text = "Get Integer";
            this.btnInteger.UseVisualStyleBackColor = true;
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(150, 171);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(96, 29);
            this.btnDouble.TabIndex = 6;
            this.btnDouble.Text = "Get Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(22, 237);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(104, 17);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Your Number =";
            // 
            // frmRandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 304);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInteger);
            this.Controls.Add(this.txtMaximum);
            this.Controls.Add(this.txtMinimum);
            this.Controls.Add(this.lblMaximum);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.lblInstruction);
            this.Name = "frmRandomNumbers";
            this.Text = "Random Numbers";
            this.Load += new System.EventHandler(this.frmRandomNumbers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.TextBox txtMinimum;
        private System.Windows.Forms.TextBox txtMaximum;
        private System.Windows.Forms.Button btnInteger;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Label lblResult;
    }
}

