namespace waAlguelVeiculo
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
            this.radioButtonOnibus = new System.Windows.Forms.RadioButton();
            this.radioButtonCaminhao = new System.Windows.Forms.RadioButton();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbAssentosEixos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lvCO = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.tbAssentosEixos = new System.Windows.Forms.TextBox();
            this.mtbPlaca = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonOnibus
            // 
            this.radioButtonOnibus.AutoSize = true;
            this.radioButtonOnibus.Location = new System.Drawing.Point(45, 48);
            this.radioButtonOnibus.Name = "radioButtonOnibus";
            this.radioButtonOnibus.Size = new System.Drawing.Size(70, 20);
            this.radioButtonOnibus.TabIndex = 0;
            this.radioButtonOnibus.TabStop = true;
            this.radioButtonOnibus.Text = "Ônibus";
            this.radioButtonOnibus.UseVisualStyleBackColor = true;
            this.radioButtonOnibus.CheckedChanged += new System.EventHandler(this.radioButtonOnibus_CheckedChanged);
            // 
            // radioButtonCaminhao
            // 
            this.radioButtonCaminhao.AutoSize = true;
            this.radioButtonCaminhao.Location = new System.Drawing.Point(202, 48);
            this.radioButtonCaminhao.Name = "radioButtonCaminhao";
            this.radioButtonCaminhao.Size = new System.Drawing.Size(89, 20);
            this.radioButtonCaminhao.TabIndex = 1;
            this.radioButtonCaminhao.TabStop = true;
            this.radioButtonCaminhao.Text = "Caminhão";
            this.radioButtonCaminhao.UseVisualStyleBackColor = true;
            this.radioButtonCaminhao.CheckedChanged += new System.EventHandler(this.radioButtonCaminhao_CheckedChanged);
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(129, 93);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(42, 16);
            this.lbPlaca.TabIndex = 2;
            this.lbPlaca.Text = "Placa";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(129, 134);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(31, 16);
            this.lbAno.TabIndex = 3;
            this.lbAno.Text = "Ano";
            // 
            // lbAssentosEixos
            // 
            this.lbAssentosEixos.AutoSize = true;
            this.lbAssentosEixos.Location = new System.Drawing.Point(129, 168);
            this.lbAssentosEixos.Name = "lbAssentosEixos";
            this.lbAssentosEixos.Size = new System.Drawing.Size(44, 16);
            this.lbAssentosEixos.TabIndex = 4;
            this.lbAssentosEixos.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lvCO
            // 
            this.lvCO.HideSelection = false;
            this.lvCO.Location = new System.Drawing.Point(42, 304);
            this.lvCO.Name = "lvCO";
            this.lvCO.Size = new System.Drawing.Size(739, 132);
            this.lvCO.TabIndex = 7;
            this.lvCO.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::waAlguelVeiculo.Properties.Resources.Onibus;
            this.pictureBox1.Location = new System.Drawing.Point(474, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 202);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(231, 128);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(100, 22);
            this.tbAno.TabIndex = 9;
            // 
            // tbAssentosEixos
            // 
            this.tbAssentosEixos.Location = new System.Drawing.Point(231, 162);
            this.tbAssentosEixos.Name = "tbAssentosEixos";
            this.tbAssentosEixos.Size = new System.Drawing.Size(100, 22);
            this.tbAssentosEixos.TabIndex = 10;
            // 
            // mtbPlaca
            // 
            this.mtbPlaca.Location = new System.Drawing.Point(231, 90);
            this.mtbPlaca.Name = "mtbPlaca";
            this.mtbPlaca.Size = new System.Drawing.Size(100, 22);
            this.mtbPlaca.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtbPlaca);
            this.Controls.Add(this.tbAssentosEixos);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvCO);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbAssentosEixos);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.radioButtonCaminhao);
            this.Controls.Add(this.radioButtonOnibus);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonOnibus;
        private System.Windows.Forms.RadioButton radioButtonCaminhao;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbAssentosEixos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lvCO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.TextBox tbAssentosEixos;
        private System.Windows.Forms.MaskedTextBox mtbPlaca;
    }
}

