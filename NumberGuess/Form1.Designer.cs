namespace NumberGuess
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
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblRemainingGuess = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.Transparent;
            this.btnGuess.Location = new System.Drawing.Point(248, 109);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 0;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.AutoSize = true;
            this.lblRandomNumber.Location = new System.Drawing.Point(107, 76);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(34, 13);
            this.lblRandomNumber.TabIndex = 1;
            this.lblRandomNumber.Text = "0 - 10";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(110, 109);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 2;
            // 
            // lblRemainingGuess
            // 
            this.lblRemainingGuess.AutoSize = true;
            this.lblRemainingGuess.Location = new System.Drawing.Point(110, 162);
            this.lblRemainingGuess.Name = "lblRemainingGuess";
            this.lblRemainingGuess.Size = new System.Drawing.Size(111, 13);
            this.lblRemainingGuess.TabIndex = 3;
            this.lblRemainingGuess.Text = "Your remaining guess:";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(248, 162);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(13, 13);
            this.lblCounter.TabIndex = 4;
            this.lblCounter.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Guess a number between 0 and 10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(410, 258);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblRemainingGuess);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblRandomNumber);
            this.Controls.Add(this.btnGuess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblRandomNumber;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblRemainingGuess;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label label2;
    }
}

