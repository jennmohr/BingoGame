namespace BingoLetsTryThisAgain
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblNameEntry = new System.Windows.Forms.Label();
            this.btnLetsGo = new System.Windows.Forms.Button();
            this.txtNameEntry = new System.Windows.Forms.TextBox();
            this.lblReadyToPlay = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHowToPlay = new System.Windows.Forms.Label();
            this.lblWhatWeDo = new System.Windows.Forms.Label();
            this.lblDontHave = new System.Windows.Forms.Label();
            this.txtNumberCalled = new System.Windows.Forms.TextBox();
            this.btnDontHave = new System.Windows.Forms.Button();
            this.lblBingoCard = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(241, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(276, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Game of BINGO!";
            // 
            // lblNameEntry
            // 
            this.lblNameEntry.AutoSize = true;
            this.lblNameEntry.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEntry.Location = new System.Drawing.Point(192, 61);
            this.lblNameEntry.Name = "lblNameEntry";
            this.lblNameEntry.Size = new System.Drawing.Size(245, 24);
            this.lblNameEntry.TabIndex = 1;
            this.lblNameEntry.Text = "Enter your name at the right:";
            // 
            // btnLetsGo
            // 
            this.btnLetsGo.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetsGo.ForeColor = System.Drawing.Color.Green;
            this.btnLetsGo.Location = new System.Drawing.Point(329, 102);
            this.btnLetsGo.Name = "btnLetsGo";
            this.btnLetsGo.Size = new System.Drawing.Size(123, 32);
            this.btnLetsGo.TabIndex = 2;
            this.btnLetsGo.Text = "Yes! Let\'s GO!";
            this.btnLetsGo.UseVisualStyleBackColor = true;
            this.btnLetsGo.Click += new System.EventHandler(this.btnLetsGo_Click_1);
            // 
            // txtNameEntry
            // 
            this.txtNameEntry.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEntry.Location = new System.Drawing.Point(452, 64);
            this.txtNameEntry.Name = "txtNameEntry";
            this.txtNameEntry.Size = new System.Drawing.Size(100, 25);
            this.txtNameEntry.TabIndex = 1;
            this.txtNameEntry.TextChanged += new System.EventHandler(this.txtNameEntry_TextChanged);
            // 
            // lblReadyToPlay
            // 
            this.lblReadyToPlay.AutoSize = true;
            this.lblReadyToPlay.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadyToPlay.Location = new System.Drawing.Point(116, 106);
            this.lblReadyToPlay.Name = "lblReadyToPlay";
            this.lblReadyToPlay.Size = new System.Drawing.Size(192, 24);
            this.lblReadyToPlay.TabIndex = 4;
            this.lblReadyToPlay.Text = "Are you ready to play?";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(491, 103);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "No! Exit!";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHowToPlay
            // 
            this.lblHowToPlay.AutoSize = true;
            this.lblHowToPlay.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowToPlay.Location = new System.Drawing.Point(61, 162);
            this.lblHowToPlay.Name = "lblHowToPlay";
            this.lblHowToPlay.Size = new System.Drawing.Size(456, 16);
            this.lblHowToPlay.TabIndex = 6;
            this.lblHowToPlay.Text = "We call one number at a time. Check your card for that number and if found click " +
    "that cell.";
            this.lblHowToPlay.Visible = false;
            // 
            // lblWhatWeDo
            // 
            this.lblWhatWeDo.AutoSize = true;
            this.lblWhatWeDo.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatWeDo.Location = new System.Drawing.Point(61, 184);
            this.lblWhatWeDo.Name = "lblWhatWeDo";
            this.lblWhatWeDo.Size = new System.Drawing.Size(477, 16);
            this.lblWhatWeDo.TabIndex = 7;
            this.lblWhatWeDo.Text = "We will do the rest, checking for a Bingo or not. The number called will appear t" +
    "o the right.  --->";
            this.lblWhatWeDo.Visible = false;
            // 
            // lblDontHave
            // 
            this.lblDontHave.AutoSize = true;
            this.lblDontHave.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDontHave.Location = new System.Drawing.Point(62, 207);
            this.lblDontHave.Name = "lblDontHave";
            this.lblDontHave.Size = new System.Drawing.Size(458, 16);
            this.lblDontHave.TabIndex = 8;
            this.lblDontHave.Text = "If you do not have the number called in your card click the \"Don\'t Have\" button t" +
    "o the right.\r\n";
            this.lblDontHave.Visible = false;
            // 
            // txtNumberCalled
            // 
            this.txtNumberCalled.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberCalled.Location = new System.Drawing.Point(555, 177);
            this.txtNumberCalled.Name = "txtNumberCalled";
            this.txtNumberCalled.Size = new System.Drawing.Size(100, 31);
            this.txtNumberCalled.TabIndex = 9;
            this.txtNumberCalled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumberCalled.Visible = false;
            // 
            // btnDontHave
            // 
            this.btnDontHave.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDontHave.ForeColor = System.Drawing.Color.Black;
            this.btnDontHave.Location = new System.Drawing.Point(555, 214);
            this.btnDontHave.Name = "btnDontHave";
            this.btnDontHave.Size = new System.Drawing.Size(100, 32);
            this.btnDontHave.TabIndex = 10;
            this.btnDontHave.Text = "Don\'t Have";
            this.btnDontHave.UseVisualStyleBackColor = true;
            this.btnDontHave.Visible = false;
            this.btnDontHave.Click += new System.EventHandler(this.btnDontHave_Click);
            // 
            // lblBingoCard
            // 
            this.lblBingoCard.AutoSize = true;
            this.lblBingoCard.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBingoCard.Location = new System.Drawing.Point(310, 260);
            this.lblBingoCard.Name = "lblBingoCard";
            this.lblBingoCard.Size = new System.Drawing.Size(142, 24);
            this.lblBingoCard.TabIndex = 11;
            this.lblBingoCard.Text = "Your Bingo Card";
            this.lblBingoCard.Visible = false;
            // 
            // pnlCard
            // 
            this.pnlCard.Location = new System.Drawing.Point(104, 306);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(526, 524);
            this.pnlCard.TabIndex = 12;
            this.pnlCard.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 872);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.lblBingoCard);
            this.Controls.Add(this.btnDontHave);
            this.Controls.Add(this.txtNumberCalled);
            this.Controls.Add(this.lblDontHave);
            this.Controls.Add(this.lblWhatWeDo);
            this.Controls.Add(this.lblHowToPlay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblReadyToPlay);
            this.Controls.Add(this.txtNameEntry);
            this.Controls.Add(this.btnLetsGo);
            this.Controls.Add(this.lblNameEntry);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.Text = "BINGO Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblNameEntry;
        private System.Windows.Forms.Button btnLetsGo;
        private System.Windows.Forms.TextBox txtNameEntry;
        private System.Windows.Forms.Label lblReadyToPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHowToPlay;
        private System.Windows.Forms.Label lblWhatWeDo;
        private System.Windows.Forms.Label lblDontHave;
        private System.Windows.Forms.TextBox txtNumberCalled;
        private System.Windows.Forms.Button btnDontHave;
        private System.Windows.Forms.Label lblBingoCard;
        private System.Windows.Forms.Panel pnlCard;
    }
}

