namespace Finance
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAtv = new System.Windows.Forms.TextBox();
            this.txtGn = new System.Windows.Forms.TextBox();
            this.txtDt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoss = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(82, 232);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(93, 40);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data";
            // 
            // txtAtv
            // 
            this.txtAtv.BackColor = System.Drawing.Color.White;
            this.txtAtv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAtv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtv.Location = new System.Drawing.Point(172, 36);
            this.txtAtv.Name = "txtAtv";
            this.txtAtv.Size = new System.Drawing.Size(125, 23);
            this.txtAtv.TabIndex = 4;
            // 
            // txtGn
            // 
            this.txtGn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGn.Location = new System.Drawing.Point(172, 73);
            this.txtGn.Name = "txtGn";
            this.txtGn.Size = new System.Drawing.Size(125, 30);
            this.txtGn.TabIndex = 5;
            // 
            // txtDt
            // 
            this.txtDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDt.Location = new System.Drawing.Point(172, 155);
            this.txtDt.Name = "txtDt";
            this.txtDt.Size = new System.Drawing.Size(125, 30);
            this.txtDt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loss";
            // 
            // txtLoss
            // 
            this.txtLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoss.Location = new System.Drawing.Point(172, 110);
            this.txtLoss.Name = "txtLoss";
            this.txtLoss.Size = new System.Drawing.Size(125, 30);
            this.txtLoss.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(242, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Exibir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLoss);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDt);
            this.Controls.Add(this.txtGn);
            this.Controls.Add(this.txtAtv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAtv;
        private System.Windows.Forms.TextBox txtGn;
        private System.Windows.Forms.DateTimePicker txtDt;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtLoss;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

