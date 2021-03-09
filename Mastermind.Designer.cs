namespace logikai_jatekok
{
    partial class Mastermind
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
            this.label2 = new System.Windows.Forms.Label();
            this.tLP_Tabla = new System.Windows.Forms.TableLayoutPanel();
            this.tLP_szinek = new System.Windows.Forms.TableLayoutPanel();
            this.lbRejtett = new System.Windows.Forms.Label();
            this.btnRejtettVissza = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.fLP_ertekeles = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSugo = new System.Windows.Forms.Button();
            this.btn_ujJatek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mastermind";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(668, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Színek";
            // 
            // tLP_Tabla
            // 
            this.tLP_Tabla.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tLP_Tabla.ColumnCount = 4;
            this.tLP_Tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLP_Tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLP_Tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLP_Tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLP_Tabla.Location = new System.Drawing.Point(20, 62);
            this.tLP_Tabla.Name = "tLP_Tabla";
            this.tLP_Tabla.RowCount = 10;
            this.tLP_Tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_Tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_Tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_Tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_Tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_Tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_Tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_Tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_Tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_Tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_Tabla.Size = new System.Drawing.Size(250, 500);
            this.tLP_Tabla.TabIndex = 4;
            // 
            // tLP_szinek
            // 
            this.tLP_szinek.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tLP_szinek.ColumnCount = 4;
            this.tLP_szinek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tLP_szinek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tLP_szinek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tLP_szinek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tLP_szinek.Location = new System.Drawing.Point(672, 62);
            this.tLP_szinek.Name = "tLP_szinek";
            this.tLP_szinek.RowCount = 1;
            this.tLP_szinek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_szinek.Size = new System.Drawing.Size(329, 500);
            this.tLP_szinek.TabIndex = 7;
            // 
            // lbRejtett
            // 
            this.lbRejtett.AutoSize = true;
            this.lbRejtett.Location = new System.Drawing.Point(669, 578);
            this.lbRejtett.Name = "lbRejtett";
            this.lbRejtett.Size = new System.Drawing.Size(136, 17);
            this.lbRejtett.TabIndex = 8;
            this.lbRejtett.Text = "Elrejtett színek: 0 db";
            // 
            // btnRejtettVissza
            // 
            this.btnRejtettVissza.Location = new System.Drawing.Point(672, 606);
            this.btnRejtettVissza.Name = "btnRejtettVissza";
            this.btnRejtettVissza.Size = new System.Drawing.Size(101, 23);
            this.btnRejtettVissza.TabIndex = 9;
            this.btnRejtettVissza.Text = "Visszaállítás";
            this.btnRejtettVissza.UseVisualStyleBackColor = true;
            this.btnRejtettVissza.Click += new System.EventHandler(this.btnRejtettVissza_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Enabled = false;
            this.btnTorles.Location = new System.Drawing.Point(20, 578);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(250, 23);
            this.btnTorles.TabIndex = 11;
            this.btnTorles.Text = "Visszavonás";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // fLP_ertekeles
            // 
            this.fLP_ertekeles.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLP_ertekeles.Location = new System.Drawing.Point(293, 62);
            this.fLP_ertekeles.Name = "fLP_ertekeles";
            this.fLP_ertekeles.Size = new System.Drawing.Size(209, 500);
            this.fLP_ertekeles.TabIndex = 12;
            // 
            // btnSugo
            // 
            this.btnSugo.Location = new System.Drawing.Point(20, 607);
            this.btnSugo.Name = "btnSugo";
            this.btnSugo.Size = new System.Drawing.Size(75, 23);
            this.btnSugo.TabIndex = 13;
            this.btnSugo.Text = "Súgó";
            this.btnSugo.UseVisualStyleBackColor = true;
            this.btnSugo.Click += new System.EventHandler(this.btnSugo_Click);
            // 
            // btn_ujJatek
            // 
            this.btn_ujJatek.Location = new System.Drawing.Point(101, 608);
            this.btn_ujJatek.Name = "btn_ujJatek";
            this.btn_ujJatek.Size = new System.Drawing.Size(169, 23);
            this.btn_ujJatek.TabIndex = 14;
            this.btn_ujJatek.Text = "Új játék";
            this.btn_ujJatek.UseVisualStyleBackColor = true;
            this.btn_ujJatek.Click += new System.EventHandler(this.btn_ujJatek_Click);
            // 
            // Mastermind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 643);
            this.Controls.Add(this.btn_ujJatek);
            this.Controls.Add(this.btnSugo);
            this.Controls.Add(this.fLP_ertekeles);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnRejtettVissza);
            this.Controls.Add(this.lbRejtett);
            this.Controls.Add(this.tLP_szinek);
            this.Controls.Add(this.tLP_Tabla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 690);
            this.MinimumSize = new System.Drawing.Size(1050, 690);
            this.Name = "Mastermind";
            this.Text = "Mastermind";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mastermind_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tLP_Tabla;
        private System.Windows.Forms.TableLayoutPanel tLP_szinek;
        private System.Windows.Forms.Label lbRejtett;
        private System.Windows.Forms.Button btnRejtettVissza;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.FlowLayoutPanel fLP_ertekeles;
        private System.Windows.Forms.Button btnSugo;
        private System.Windows.Forms.Button btn_ujJatek;
    }
}