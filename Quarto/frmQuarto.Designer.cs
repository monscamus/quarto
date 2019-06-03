namespace Quarto
{
    partial class frmQuarto
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
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnPick = new System.Windows.Forms.Button();
            this.lvPieces = new System.Windows.Forms.ListBox();
            this.txtBoard00 = new System.Windows.Forms.TextBox();
            this.txtBoard01 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoard33 = new System.Windows.Forms.TextBox();
            this.txtBoard32 = new System.Windows.Forms.TextBox();
            this.txtBoard31 = new System.Windows.Forms.TextBox();
            this.txtBoard30 = new System.Windows.Forms.TextBox();
            this.txtBoard23 = new System.Windows.Forms.TextBox();
            this.txtBoard22 = new System.Windows.Forms.TextBox();
            this.txtBoard21 = new System.Windows.Forms.TextBox();
            this.txtBoard20 = new System.Windows.Forms.TextBox();
            this.txtBoard13 = new System.Windows.Forms.TextBox();
            this.txtBoard12 = new System.Windows.Forms.TextBox();
            this.txtBoard11 = new System.Windows.Forms.TextBox();
            this.txtBoard10 = new System.Windows.Forms.TextBox();
            this.txtBoard03 = new System.Windows.Forms.TextBox();
            this.txtBoard02 = new System.Windows.Forms.TextBox();
            this.txtPicked = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRestart.Location = new System.Drawing.Point(0, 547);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(1080, 37);
            this.btnRestart.TabIndex = 17;
            this.btnRestart.Text = "&Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnPick
            // 
            this.btnPick.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPick.Location = new System.Drawing.Point(0, 510);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(1080, 37);
            this.btnPick.TabIndex = 18;
            this.btnPick.Text = "&Pick";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // lvPieces
            // 
            this.lvPieces.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvPieces.FormattingEnabled = true;
            this.lvPieces.Location = new System.Drawing.Point(674, 0);
            this.lvPieces.Name = "lvPieces";
            this.lvPieces.Size = new System.Drawing.Size(406, 510);
            this.lvPieces.TabIndex = 19;
            // 
            // txtBoard00
            // 
            this.txtBoard00.Location = new System.Drawing.Point(17, 28);
            this.txtBoard00.Multiline = true;
            this.txtBoard00.Name = "txtBoard00";
            this.txtBoard00.Size = new System.Drawing.Size(82, 77);
            this.txtBoard00.TabIndex = 17;
            this.txtBoard00.Click += new System.EventHandler(this.txtBoard00_Click);
            // 
            // txtBoard01
            // 
            this.txtBoard01.Location = new System.Drawing.Point(105, 28);
            this.txtBoard01.Multiline = true;
            this.txtBoard01.Name = "txtBoard01";
            this.txtBoard01.Size = new System.Drawing.Size(82, 77);
            this.txtBoard01.TabIndex = 18;
            this.txtBoard01.Click += new System.EventHandler(this.txtBoard01_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoard33);
            this.groupBox1.Controls.Add(this.txtBoard32);
            this.groupBox1.Controls.Add(this.txtBoard31);
            this.groupBox1.Controls.Add(this.txtBoard30);
            this.groupBox1.Controls.Add(this.txtBoard23);
            this.groupBox1.Controls.Add(this.txtBoard22);
            this.groupBox1.Controls.Add(this.txtBoard21);
            this.groupBox1.Controls.Add(this.txtBoard20);
            this.groupBox1.Controls.Add(this.txtBoard13);
            this.groupBox1.Controls.Add(this.txtBoard12);
            this.groupBox1.Controls.Add(this.txtBoard11);
            this.groupBox1.Controls.Add(this.txtBoard10);
            this.groupBox1.Controls.Add(this.txtBoard03);
            this.groupBox1.Controls.Add(this.txtBoard02);
            this.groupBox1.Controls.Add(this.txtBoard01);
            this.groupBox1.Controls.Add(this.txtBoard00);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 510);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // txtBoard33
            // 
            this.txtBoard33.Location = new System.Drawing.Point(281, 277);
            this.txtBoard33.Multiline = true;
            this.txtBoard33.Name = "txtBoard33";
            this.txtBoard33.Size = new System.Drawing.Size(82, 77);
            this.txtBoard33.TabIndex = 32;
            this.txtBoard33.Click += new System.EventHandler(this.txtBoard33_Click);
            // 
            // txtBoard32
            // 
            this.txtBoard32.Location = new System.Drawing.Point(193, 277);
            this.txtBoard32.Multiline = true;
            this.txtBoard32.Name = "txtBoard32";
            this.txtBoard32.Size = new System.Drawing.Size(82, 77);
            this.txtBoard32.TabIndex = 31;
            this.txtBoard32.Click += new System.EventHandler(this.txtBoard32_Click);
            // 
            // txtBoard31
            // 
            this.txtBoard31.Location = new System.Drawing.Point(105, 277);
            this.txtBoard31.Multiline = true;
            this.txtBoard31.Name = "txtBoard31";
            this.txtBoard31.Size = new System.Drawing.Size(82, 77);
            this.txtBoard31.TabIndex = 30;
            this.txtBoard31.Click += new System.EventHandler(this.txtBoard31_Click);
            // 
            // txtBoard30
            // 
            this.txtBoard30.Location = new System.Drawing.Point(17, 277);
            this.txtBoard30.Multiline = true;
            this.txtBoard30.Name = "txtBoard30";
            this.txtBoard30.Size = new System.Drawing.Size(82, 77);
            this.txtBoard30.TabIndex = 29;
            this.txtBoard30.Click += new System.EventHandler(this.txtBoard30_Click);
            // 
            // txtBoard23
            // 
            this.txtBoard23.Location = new System.Drawing.Point(281, 194);
            this.txtBoard23.Multiline = true;
            this.txtBoard23.Name = "txtBoard23";
            this.txtBoard23.Size = new System.Drawing.Size(82, 77);
            this.txtBoard23.TabIndex = 28;
            this.txtBoard23.Click += new System.EventHandler(this.txtBoard23_Click);
            // 
            // txtBoard22
            // 
            this.txtBoard22.Location = new System.Drawing.Point(193, 194);
            this.txtBoard22.Multiline = true;
            this.txtBoard22.Name = "txtBoard22";
            this.txtBoard22.Size = new System.Drawing.Size(82, 77);
            this.txtBoard22.TabIndex = 27;
            this.txtBoard22.Click += new System.EventHandler(this.txtBoard22_Click);
            // 
            // txtBoard21
            // 
            this.txtBoard21.Location = new System.Drawing.Point(105, 194);
            this.txtBoard21.Multiline = true;
            this.txtBoard21.Name = "txtBoard21";
            this.txtBoard21.Size = new System.Drawing.Size(82, 77);
            this.txtBoard21.TabIndex = 26;
            this.txtBoard21.Click += new System.EventHandler(this.txtBoard21_Click);
            // 
            // txtBoard20
            // 
            this.txtBoard20.Location = new System.Drawing.Point(17, 194);
            this.txtBoard20.Multiline = true;
            this.txtBoard20.Name = "txtBoard20";
            this.txtBoard20.Size = new System.Drawing.Size(82, 77);
            this.txtBoard20.TabIndex = 25;
            this.txtBoard20.Click += new System.EventHandler(this.txtBoard20_Click);
            // 
            // txtBoard13
            // 
            this.txtBoard13.Location = new System.Drawing.Point(281, 111);
            this.txtBoard13.Multiline = true;
            this.txtBoard13.Name = "txtBoard13";
            this.txtBoard13.Size = new System.Drawing.Size(82, 77);
            this.txtBoard13.TabIndex = 24;
            this.txtBoard13.Click += new System.EventHandler(this.txtBoard13_Click);
            // 
            // txtBoard12
            // 
            this.txtBoard12.Location = new System.Drawing.Point(193, 111);
            this.txtBoard12.Multiline = true;
            this.txtBoard12.Name = "txtBoard12";
            this.txtBoard12.Size = new System.Drawing.Size(82, 77);
            this.txtBoard12.TabIndex = 23;
            this.txtBoard12.Click += new System.EventHandler(this.txtBoard12_Click);
            // 
            // txtBoard11
            // 
            this.txtBoard11.Location = new System.Drawing.Point(105, 111);
            this.txtBoard11.Multiline = true;
            this.txtBoard11.Name = "txtBoard11";
            this.txtBoard11.Size = new System.Drawing.Size(82, 77);
            this.txtBoard11.TabIndex = 22;
            this.txtBoard11.Click += new System.EventHandler(this.txtBoard11_Click);
            // 
            // txtBoard10
            // 
            this.txtBoard10.Location = new System.Drawing.Point(17, 111);
            this.txtBoard10.Multiline = true;
            this.txtBoard10.Name = "txtBoard10";
            this.txtBoard10.Size = new System.Drawing.Size(82, 77);
            this.txtBoard10.TabIndex = 21;
            this.txtBoard10.Click += new System.EventHandler(this.txtBoard10_Click);
            // 
            // txtBoard03
            // 
            this.txtBoard03.Location = new System.Drawing.Point(281, 28);
            this.txtBoard03.Multiline = true;
            this.txtBoard03.Name = "txtBoard03";
            this.txtBoard03.Size = new System.Drawing.Size(82, 77);
            this.txtBoard03.TabIndex = 20;
            this.txtBoard03.Click += new System.EventHandler(this.txtBoard03_Click);
            // 
            // txtBoard02
            // 
            this.txtBoard02.Location = new System.Drawing.Point(193, 28);
            this.txtBoard02.Multiline = true;
            this.txtBoard02.Name = "txtBoard02";
            this.txtBoard02.Size = new System.Drawing.Size(82, 77);
            this.txtBoard02.TabIndex = 19;
            this.txtBoard02.Click += new System.EventHandler(this.txtBoard02_Click);
            // 
            // txtPicked
            // 
            this.txtPicked.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPicked.Location = new System.Drawing.Point(496, 194);
            this.txtPicked.Name = "txtPicked";
            this.txtPicked.Size = new System.Drawing.Size(74, 40);
            this.txtPicked.TabIndex = 21;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(430, 81);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(117, 24);
            this.lblInstructions.TabIndex = 22;
            this.lblInstructions.Text = "Player 1 Pick";
            // 
            // frmQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 584);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtPicked);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvPieces);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.btnRestart);
            this.Name = "frmQuarto";
            this.Text = "Quarto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.ListBox lvPieces;
        private System.Windows.Forms.TextBox txtBoard00;
        private System.Windows.Forms.TextBox txtBoard01;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoard33;
        private System.Windows.Forms.TextBox txtBoard32;
        private System.Windows.Forms.TextBox txtBoard31;
        private System.Windows.Forms.TextBox txtBoard30;
        private System.Windows.Forms.TextBox txtBoard23;
        private System.Windows.Forms.TextBox txtBoard22;
        private System.Windows.Forms.TextBox txtBoard21;
        private System.Windows.Forms.TextBox txtBoard20;
        private System.Windows.Forms.TextBox txtBoard13;
        private System.Windows.Forms.TextBox txtBoard12;
        private System.Windows.Forms.TextBox txtBoard11;
        private System.Windows.Forms.TextBox txtBoard10;
        private System.Windows.Forms.TextBox txtBoard03;
        private System.Windows.Forms.TextBox txtBoard02;
        private System.Windows.Forms.TextBox txtPicked;
        private System.Windows.Forms.Label lblInstructions;
    }
}

