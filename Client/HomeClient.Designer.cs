namespace Client
{
    partial class HomeClient
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
            this.btnTime = new System.Windows.Forms.Button();
            this.btnGreet = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(23, 78);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(91, 32);
            this.btnTime.TabIndex = 0;
            this.btnTime.Text = "Obter hora";
            this.btnTime.UseVisualStyleBackColor = true;
            // 
            // btnGreet
            // 
            this.btnGreet.Location = new System.Drawing.Point(133, 78);
            this.btnGreet.Name = "btnGreet";
            this.btnGreet.Size = new System.Drawing.Size(95, 32);
            this.btnGreet.TabIndex = 1;
            this.btnGreet.Text = "Cumprimentar";
            this.btnGreet.UseVisualStyleBackColor = true;
            this.btnGreet.Click += new System.EventHandler(this.btnGreet_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(64, 26);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(109, 20);
            this.tbName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // HomeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 132);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnGreet);
            this.Controls.Add(this.btnTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(272, 171);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(272, 171);
            this.Name = "HomeClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnGreet;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
    }
}

