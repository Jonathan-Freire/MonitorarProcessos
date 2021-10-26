
namespace MonitorarProcessos
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxProcesso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMatar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(294, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Monitorar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxProcesso
            // 
            this.txtBoxProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProcesso.Location = new System.Drawing.Point(256, 120);
            this.txtBoxProcesso.Name = "txtBoxProcesso";
            this.txtBoxProcesso.Size = new System.Drawing.Size(274, 31);
            this.txtBoxProcesso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o nome do Processo:";
            // 
            // btnMatar
            // 
            this.btnMatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatar.Location = new System.Drawing.Point(294, 275);
            this.btnMatar.Name = "btnMatar";
            this.btnMatar.Size = new System.Drawing.Size(210, 55);
            this.btnMatar.TabIndex = 3;
            this.btnMatar.Text = "Matar ";
            this.btnMatar.UseVisualStyleBackColor = true;
            this.btnMatar.Click += new System.EventHandler(this.btnMatar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMatar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxProcesso);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxProcesso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMatar;
    }
}

