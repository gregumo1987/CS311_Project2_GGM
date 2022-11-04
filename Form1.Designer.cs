namespace CS311_Project2_GGM
{
    partial class frmMain
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
            this.lblLeftDice = new System.Windows.Forms.Label();
            this.lblRightDice = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // lblLeftDice
            // 
            this.lblLeftDice.AutoSize = true;
            this.lblLeftDice.Location = new System.Drawing.Point(85, 52);
            this.lblLeftDice.Name = "lblLeftDice";
            this.lblLeftDice.Size = new System.Drawing.Size(0, 13);
            this.lblLeftDice.TabIndex = 1;
            // 
            // lblRightDice
            // 
            this.lblRightDice.AutoSize = true;
            this.lblRightDice.Location = new System.Drawing.Point(186, 52);
            this.lblRightDice.Name = "lblRightDice";
            this.lblRightDice.Size = new System.Drawing.Size(0, 13);
            this.lblRightDice.TabIndex = 2;
            this.lblRightDice.Click += new System.EventHandler(this.lblRightDice_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(371, 52);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(25, 13);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "100";
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(126, 134);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "Roll!";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(345, 97);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(100, 20);
            this.txtBet.TabIndex = 5;
            this.txtBet.TextChanged += new System.EventHandler(this.txtBet_TextChanged);
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Location = new System.Drawing.Point(135, 97);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(50, 13);
            this.lblOutcome.TabIndex = 6;
            this.lblOutcome.Text = "Outcome";
            this.lblOutcome.Click += new System.EventHandler(this.lblOutcome_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 221);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblRightDice);
            this.Controls.Add(this.lblLeftDice);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Craps";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLeftDice;
        private System.Windows.Forms.Label lblRightDice;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Label lblOutcome;
    }
}

