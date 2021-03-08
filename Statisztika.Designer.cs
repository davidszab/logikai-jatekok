
namespace logikai_jatekok
{
    partial class Statisztika
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rBJatek = new System.Windows.Forms.RadioButton();
            this.rBJatekos = new System.Windows.Forms.RadioButton();
            this.rBRekord = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rBOsszes = new System.Windows.Forms.RadioButton();
            this.rBLegjobb = new System.Windows.Forms.RadioButton();
            this.lbCel = new System.Windows.Forms.Label();
            this.cBCel = new System.Windows.Forms.ComboBox();
            this.fLP_fo = new System.Windows.Forms.FlowLayoutPanel();
            this.fLP_alap = new System.Windows.Forms.FlowLayoutPanel();
            this.fLP_szuro = new System.Windows.Forms.FlowLayoutPanel();
            this.fLP_cel = new System.Windows.Forms.FlowLayoutPanel();
            this.fLP_output = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.rBKepernyo = new System.Windows.Forms.RadioButton();
            this.rBHtml = new System.Windows.Forms.RadioButton();
            this.rBCSV = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.fLP_fo.SuspendLayout();
            this.fLP_alap.SuspendLayout();
            this.fLP_szuro.SuspendLayout();
            this.fLP_cel.SuspendLayout();
            this.fLP_output.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Statisztika";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rBJatek);
            this.flowLayoutPanel1.Controls.Add(this.rBJatekos);
            this.flowLayoutPanel1.Controls.Add(this.rBRekord);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(489, 30);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // rBJatek
            // 
            this.rBJatek.AutoSize = true;
            this.rBJatek.Location = new System.Drawing.Point(3, 3);
            this.rBJatek.Name = "rBJatek";
            this.rBJatek.Size = new System.Drawing.Size(63, 21);
            this.rBJatek.TabIndex = 1;
            this.rBJatek.Text = "Játék";
            this.rBJatek.UseVisualStyleBackColor = true;
            this.rBJatek.CheckedChanged += new System.EventHandler(this.handleLekerdezesAlapChange);
            // 
            // rBJatekos
            // 
            this.rBJatekos.AutoSize = true;
            this.rBJatekos.Location = new System.Drawing.Point(72, 3);
            this.rBJatekos.Name = "rBJatekos";
            this.rBJatekos.Size = new System.Drawing.Size(78, 21);
            this.rBJatekos.TabIndex = 0;
            this.rBJatekos.Text = "Játékos";
            this.rBJatekos.UseVisualStyleBackColor = true;
            this.rBJatekos.CheckedChanged += new System.EventHandler(this.handleLekerdezesAlapChange);
            // 
            // rBRekord
            // 
            this.rBRekord.AutoSize = true;
            this.rBRekord.Location = new System.Drawing.Point(156, 3);
            this.rBRekord.Name = "rBRekord";
            this.rBRekord.Size = new System.Drawing.Size(136, 21);
            this.rBRekord.TabIndex = 2;
            this.rBRekord.Text = "Rekordpontszám";
            this.rBRekord.UseVisualStyleBackColor = true;
            this.rBRekord.CheckedChanged += new System.EventHandler(this.handleLekerdezesAlapChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lekérdezés alapja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Szűrés:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.rBOsszes);
            this.flowLayoutPanel2.Controls.Add(this.rBLegjobb);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 20);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(644, 30);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // rBOsszes
            // 
            this.rBOsszes.AutoSize = true;
            this.rBOsszes.Location = new System.Drawing.Point(3, 3);
            this.rBOsszes.Name = "rBOsszes";
            this.rBOsszes.Size = new System.Drawing.Size(144, 21);
            this.rBOsszes.TabIndex = 0;
            this.rBOsszes.Text = "Összes bejegyzés";
            this.rBOsszes.UseVisualStyleBackColor = true;
            this.rBOsszes.CheckedChanged += new System.EventHandler(this.handleSzuresChange);
            // 
            // rBLegjobb
            // 
            this.rBLegjobb.AutoSize = true;
            this.rBLegjobb.Location = new System.Drawing.Point(153, 3);
            this.rBLegjobb.Name = "rBLegjobb";
            this.rBLegjobb.Size = new System.Drawing.Size(147, 21);
            this.rBLegjobb.TabIndex = 1;
            this.rBLegjobb.Text = "Legjobb eredmény";
            this.rBLegjobb.UseVisualStyleBackColor = true;
            this.rBLegjobb.CheckedChanged += new System.EventHandler(this.handleSzuresChange);
            // 
            // lbCel
            // 
            this.lbCel.AutoSize = true;
            this.lbCel.Location = new System.Drawing.Point(3, 0);
            this.lbCel.Name = "lbCel";
            this.lbCel.Size = new System.Drawing.Size(46, 17);
            this.lbCel.TabIndex = 4;
            this.lbCel.Text = "Játék:";
            // 
            // cBCel
            // 
            this.cBCel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCel.FormattingEnabled = true;
            this.cBCel.Items.AddRange(new object[] {
            "Játékos1",
            "Béla",
            "Feri",
            "Zsuzsa"});
            this.cBCel.Location = new System.Drawing.Point(3, 20);
            this.cBCel.Name = "cBCel";
            this.cBCel.Size = new System.Drawing.Size(167, 24);
            this.cBCel.TabIndex = 5;
            // 
            // fLP_fo
            // 
            this.fLP_fo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.fLP_fo.Controls.Add(this.fLP_alap);
            this.fLP_fo.Controls.Add(this.fLP_szuro);
            this.fLP_fo.Controls.Add(this.fLP_cel);
            this.fLP_fo.Controls.Add(this.fLP_output);
            this.fLP_fo.Controls.Add(this.btnStart);
            this.fLP_fo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLP_fo.Location = new System.Drawing.Point(18, 48);
            this.fLP_fo.Name = "fLP_fo";
            this.fLP_fo.Size = new System.Drawing.Size(725, 273);
            this.fLP_fo.TabIndex = 6;
            // 
            // fLP_alap
            // 
            this.fLP_alap.Controls.Add(this.label2);
            this.fLP_alap.Controls.Add(this.flowLayoutPanel1);
            this.fLP_alap.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLP_alap.Location = new System.Drawing.Point(3, 3);
            this.fLP_alap.Name = "fLP_alap";
            this.fLP_alap.Size = new System.Drawing.Size(665, 53);
            this.fLP_alap.TabIndex = 8;
            // 
            // fLP_szuro
            // 
            this.fLP_szuro.Controls.Add(this.label3);
            this.fLP_szuro.Controls.Add(this.flowLayoutPanel2);
            this.fLP_szuro.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLP_szuro.Location = new System.Drawing.Point(3, 62);
            this.fLP_szuro.Name = "fLP_szuro";
            this.fLP_szuro.Size = new System.Drawing.Size(665, 53);
            this.fLP_szuro.TabIndex = 6;
            // 
            // fLP_cel
            // 
            this.fLP_cel.Controls.Add(this.lbCel);
            this.fLP_cel.Controls.Add(this.cBCel);
            this.fLP_cel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLP_cel.Location = new System.Drawing.Point(3, 121);
            this.fLP_cel.Name = "fLP_cel";
            this.fLP_cel.Size = new System.Drawing.Size(200, 53);
            this.fLP_cel.TabIndex = 7;
            // 
            // fLP_output
            // 
            this.fLP_output.Controls.Add(this.label5);
            this.fLP_output.Controls.Add(this.flowLayoutPanel4);
            this.fLP_output.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLP_output.Location = new System.Drawing.Point(3, 180);
            this.fLP_output.Name = "fLP_output";
            this.fLP_output.Size = new System.Drawing.Size(665, 53);
            this.fLP_output.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kimenet típusa:";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.rBKepernyo);
            this.flowLayoutPanel4.Controls.Add(this.rBHtml);
            this.flowLayoutPanel4.Controls.Add(this.rBCSV);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 20);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(370, 30);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // rBKepernyo
            // 
            this.rBKepernyo.AutoSize = true;
            this.rBKepernyo.Location = new System.Drawing.Point(3, 3);
            this.rBKepernyo.Name = "rBKepernyo";
            this.rBKepernyo.Size = new System.Drawing.Size(90, 21);
            this.rBKepernyo.TabIndex = 1;
            this.rBKepernyo.Text = "Képernyő";
            this.rBKepernyo.UseVisualStyleBackColor = true;
            this.rBKepernyo.CheckedChanged += new System.EventHandler(this.handleKimenetChange);
            // 
            // rBHtml
            // 
            this.rBHtml.AutoSize = true;
            this.rBHtml.Location = new System.Drawing.Point(99, 3);
            this.rBHtml.Name = "rBHtml";
            this.rBHtml.Size = new System.Drawing.Size(128, 21);
            this.rBHtml.TabIndex = 0;
            this.rBHtml.Text = "Weboldal(.html)";
            this.rBHtml.UseVisualStyleBackColor = true;
            this.rBHtml.CheckedChanged += new System.EventHandler(this.handleKimenetChange);
            // 
            // rBCSV
            // 
            this.rBCSV.AutoSize = true;
            this.rBCSV.Location = new System.Drawing.Point(233, 3);
            this.rBCSV.Name = "rBCSV";
            this.rBCSV.Size = new System.Drawing.Size(123, 21);
            this.rBCSV.TabIndex = 2;
            this.rBCSV.TabStop = true;
            this.rBCSV.Text = "Táblázat (.csv)";
            this.rBCSV.UseVisualStyleBackColor = true;
            this.rBCSV.CheckedChanged += new System.EventHandler(this.handleKimenetChange);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 239);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 29);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Lekérdezés!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(725, 357);
            this.dataGridView1.TabIndex = 7;
            // 
            // Statisztika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 708);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fLP_fo);
            this.Controls.Add(this.label1);
            this.Name = "Statisztika";
            this.Text = "Statisztika";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.fLP_fo.ResumeLayout(false);
            this.fLP_alap.ResumeLayout(false);
            this.fLP_alap.PerformLayout();
            this.fLP_szuro.ResumeLayout(false);
            this.fLP_szuro.PerformLayout();
            this.fLP_cel.ResumeLayout(false);
            this.fLP_cel.PerformLayout();
            this.fLP_output.ResumeLayout(false);
            this.fLP_output.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rBJatekos;
        private System.Windows.Forms.RadioButton rBJatek;
        private System.Windows.Forms.RadioButton rBRekord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton rBOsszes;
        private System.Windows.Forms.RadioButton rBLegjobb;
        private System.Windows.Forms.Label lbCel;
        private System.Windows.Forms.ComboBox cBCel;
        private System.Windows.Forms.FlowLayoutPanel fLP_fo;
        private System.Windows.Forms.FlowLayoutPanel fLP_szuro;
        private System.Windows.Forms.FlowLayoutPanel fLP_cel;
        private System.Windows.Forms.FlowLayoutPanel fLP_alap;
        private System.Windows.Forms.FlowLayoutPanel fLP_output;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.RadioButton rBKepernyo;
        private System.Windows.Forms.RadioButton rBHtml;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rBCSV;
    }
}