
namespace AtividadePraticaPolimorfismo
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
            this.labelBase = new System.Windows.Forms.Label();
            this.txtBoxBase = new System.Windows.Forms.TextBox();
            this.labelAltura = new System.Windows.Forms.Label();
            this.txtBoxAltura = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRetangulo = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.labelArea = new System.Windows.Forms.Label();
            this.txtBoxArea = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(59, 61);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(34, 13);
            this.labelBase.TabIndex = 0;
            this.labelBase.Text = "Base:";
            // 
            // txtBoxBase
            // 
            this.txtBoxBase.Location = new System.Drawing.Point(62, 92);
            this.txtBoxBase.Name = "txtBoxBase";
            this.txtBoxBase.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBase.TabIndex = 1;
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(191, 61);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(34, 13);
            this.labelAltura.TabIndex = 0;
            this.labelAltura.Text = "Altura";
            // 
            // txtBoxAltura
            // 
            this.txtBoxAltura.Location = new System.Drawing.Point(194, 92);
            this.txtBoxAltura.Name = "txtBoxAltura";
            this.txtBoxAltura.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAltura.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTriangulo);
            this.groupBox1.Controls.Add(this.btnRetangulo);
            this.groupBox1.Location = new System.Drawing.Point(62, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calcular Área:";
            // 
            // btnRetangulo
            // 
            this.btnRetangulo.Location = new System.Drawing.Point(25, 42);
            this.btnRetangulo.Name = "btnRetangulo";
            this.btnRetangulo.Size = new System.Drawing.Size(75, 23);
            this.btnRetangulo.TabIndex = 0;
            this.btnRetangulo.Text = "Retângulo";
            this.btnRetangulo.UseVisualStyleBackColor = true;
            this.btnRetangulo.Click += new System.EventHandler(this.btnRetangulo_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(132, 42);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(75, 23);
            this.btnTriangulo.TabIndex = 0;
            this.btnTriangulo.Text = "Triângulo";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(116, 263);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(32, 13);
            this.labelArea.TabIndex = 0;
            this.labelArea.Text = "Área:";
            // 
            // txtBoxArea
            // 
            this.txtBoxArea.Location = new System.Drawing.Point(119, 294);
            this.txtBoxArea.Name = "txtBoxArea";
            this.txtBoxArea.Size = new System.Drawing.Size(100, 20);
            this.txtBoxArea.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBoxArea);
            this.Controls.Add(this.txtBoxAltura);
            this.Controls.Add(this.txtBoxBase);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.labelBase);
            this.Name = "Form1";
            this.Text = "Exercício Polimorfismo";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.TextBox txtBoxBase;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.TextBox txtBoxAltura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnRetangulo;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox txtBoxArea;
    }
}

