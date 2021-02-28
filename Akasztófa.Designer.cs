namespace logikai_jatekok
{
    partial class Akasztófa
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
            this.flp_word = new System.Windows.Forms.FlowLayoutPanel();
            this.gb_kitalalndo = new System.Windows.Forms.GroupBox();
            this.flp_buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.l_szohossz = new System.Windows.Forms.Label();
            this.p_hangman = new System.Windows.Forms.Panel();
            this.l_hibalehetoseg = new System.Windows.Forms.Label();
            this.l_info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_rosszvalaszok = new System.Windows.Forms.TextBox();
            this.l_proba = new System.Windows.Forms.Label();
            this.b_ujjatek = new System.Windows.Forms.Button();
            this.b_kilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp_word
            // 
            this.flp_word.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flp_word.Location = new System.Drawing.Point(12, 39);
            this.flp_word.Name = "flp_word";
            this.flp_word.Size = new System.Drawing.Size(509, 126);
            this.flp_word.TabIndex = 0;
            // 
            // gb_kitalalndo
            // 
            this.gb_kitalalndo.Location = new System.Drawing.Point(12, 39);
            this.gb_kitalalndo.Name = "gb_kitalalndo";
            this.gb_kitalalndo.Size = new System.Drawing.Size(509, 100);
            this.gb_kitalalndo.TabIndex = 0;
            this.gb_kitalalndo.TabStop = false;
            this.gb_kitalalndo.Text = "A kitalálandó szó";
            // 
            // flp_buttons
            // 
            this.flp_buttons.Location = new System.Drawing.Point(12, 246);
            this.flp_buttons.Name = "flp_buttons";
            this.flp_buttons.Size = new System.Drawing.Size(509, 133);
            this.flp_buttons.TabIndex = 1;
            // 
            // l_szohossz
            // 
            this.l_szohossz.AutoSize = true;
            this.l_szohossz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_szohossz.Location = new System.Drawing.Point(12, 168);
            this.l_szohossz.Name = "l_szohossz";
            this.l_szohossz.Size = new System.Drawing.Size(46, 18);
            this.l_szohossz.TabIndex = 0;
            this.l_szohossz.Text = "label1";
            // 
            // p_hangman
            // 
            this.p_hangman.Location = new System.Drawing.Point(557, 39);
            this.p_hangman.Name = "p_hangman";
            this.p_hangman.Size = new System.Drawing.Size(219, 340);
            this.p_hangman.TabIndex = 2;
            this.p_hangman.Paint += new System.Windows.Forms.PaintEventHandler(this.p_hangman_Paint);
            // 
            // l_hibalehetoseg
            // 
            this.l_hibalehetoseg.AutoSize = true;
            this.l_hibalehetoseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_hibalehetoseg.Location = new System.Drawing.Point(12, 186);
            this.l_hibalehetoseg.Name = "l_hibalehetoseg";
            this.l_hibalehetoseg.Size = new System.Drawing.Size(46, 18);
            this.l_hibalehetoseg.TabIndex = 3;
            this.l_hibalehetoseg.Text = "label1";
            // 
            // l_info
            // 
            this.l_info.AutoSize = true;
            this.l_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_info.Location = new System.Drawing.Point(12, 225);
            this.l_info.Name = "l_info";
            this.l_info.Size = new System.Drawing.Size(46, 18);
            this.l_info.TabIndex = 4;
            this.l_info.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(271, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rossz válaszok:";
            // 
            // tb_rosszvalaszok
            // 
            this.tb_rosszvalaszok.Enabled = false;
            this.tb_rosszvalaszok.Location = new System.Drawing.Point(396, 166);
            this.tb_rosszvalaszok.Multiline = true;
            this.tb_rosszvalaszok.Name = "tb_rosszvalaszok";
            this.tb_rosszvalaszok.Size = new System.Drawing.Size(125, 38);
            this.tb_rosszvalaszok.TabIndex = 6;
            // 
            // l_proba
            // 
            this.l_proba.AutoSize = true;
            this.l_proba.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_proba.Location = new System.Drawing.Point(475, 382);
            this.l_proba.Name = "l_proba";
            this.l_proba.Size = new System.Drawing.Size(46, 18);
            this.l_proba.TabIndex = 7;
            this.l_proba.Text = "label1";
            // 
            // b_ujjatek
            // 
            this.b_ujjatek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_ujjatek.Location = new System.Drawing.Point(557, 407);
            this.b_ujjatek.Name = "b_ujjatek";
            this.b_ujjatek.Size = new System.Drawing.Size(89, 31);
            this.b_ujjatek.TabIndex = 8;
            this.b_ujjatek.Text = "Új játék";
            this.b_ujjatek.UseVisualStyleBackColor = true;
            this.b_ujjatek.Click += new System.EventHandler(this.b_ujjatek_Click);
            // 
            // b_kilepes
            // 
            this.b_kilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_kilepes.Location = new System.Drawing.Point(687, 407);
            this.b_kilepes.Name = "b_kilepes";
            this.b_kilepes.Size = new System.Drawing.Size(89, 31);
            this.b_kilepes.TabIndex = 9;
            this.b_kilepes.Text = "Kilépés";
            this.b_kilepes.UseVisualStyleBackColor = true;
            this.b_kilepes.Click += new System.EventHandler(this.b_kilepes_Click);
            // 
            // Akasztófa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_kilepes);
            this.Controls.Add(this.b_ujjatek);
            this.Controls.Add(this.l_proba);
            this.Controls.Add(this.tb_rosszvalaszok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_info);
            this.Controls.Add(this.l_hibalehetoseg);
            this.Controls.Add(this.p_hangman);
            this.Controls.Add(this.l_szohossz);
            this.Controls.Add(this.flp_buttons);
            this.Controls.Add(this.gb_kitalalndo);
            this.Controls.Add(this.flp_word);
            this.Name = "Akasztófa";
            this.Text = "fl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_word;
        private System.Windows.Forms.GroupBox gb_kitalalndo;
        private System.Windows.Forms.FlowLayoutPanel flp_buttons;
        private System.Windows.Forms.Label l_szohossz;
        private System.Windows.Forms.Panel p_hangman;
        private System.Windows.Forms.Label l_hibalehetoseg;
        private System.Windows.Forms.Label l_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_rosszvalaszok;
        private System.Windows.Forms.Label l_proba;
        private System.Windows.Forms.Button b_ujjatek;
        private System.Windows.Forms.Button b_kilepes;
    }
}