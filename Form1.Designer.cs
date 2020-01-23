namespace Alpargatas_IoT
{
    partial class Alpargatas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alpargatas));
            this.Conectar = new System.Windows.Forms.Button();
            this.Usuario = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label5 = new System.Windows.Forms.Label();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panelMedico = new System.Windows.Forms.Panel();
            this.Notas = new System.Windows.Forms.Button();
            this.Grafico = new System.Windows.Forms.Button();
            this.Historico = new System.Windows.Forms.Button();
            this.Versao = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.Label();
            this.Medico = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuTopo = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.MenuLateral = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            this.panelMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuLateral)).BeginInit();
            this.SuspendLayout();
            // 
            // Conectar
            // 
            this.Conectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Conectar.FlatAppearance.BorderSize = 0;
            this.Conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Conectar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conectar.ForeColor = System.Drawing.Color.White;
            this.Conectar.Image = ((System.Drawing.Image)(resources.GetObject("Conectar.Image")));
            this.Conectar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Conectar.Location = new System.Drawing.Point(0, 180);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(200, 42);
            this.Conectar.TabIndex = 1;
            this.Conectar.Text = "Connect";
            this.Conectar.UseVisualStyleBackColor = false;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // Usuario
            // 
            this.Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Usuario.FlatAppearance.BorderSize = 0;
            this.Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.White;
            this.Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Usuario.Image")));
            this.Usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Usuario.Location = new System.Drawing.Point(0, 239);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(200, 42);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "User";
            this.Usuario.UseVisualStyleBackColor = false;
            this.Usuario.Click += new System.EventHandler(this.Usuario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(84, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 43);
            this.label5.TabIndex = 13;
            this.label5.Text = "Internet of Espadrilles";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.panelMedico);
            this.MenuVertical.Controls.Add(this.Versao);
            this.MenuVertical.Controls.Add(this.Autor);
            this.MenuVertical.Controls.Add(this.Medico);
            this.MenuVertical.Controls.Add(this.Conectar);
            this.MenuVertical.Controls.Add(this.Usuario);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(200, 600);
            this.MenuVertical.TabIndex = 14;
            // 
            // panelMedico
            // 
            this.panelMedico.Controls.Add(this.Notas);
            this.panelMedico.Controls.Add(this.Grafico);
            this.panelMedico.Controls.Add(this.Historico);
            this.panelMedico.Location = new System.Drawing.Point(35, 345);
            this.panelMedico.Name = "panelMedico";
            this.panelMedico.Size = new System.Drawing.Size(159, 134);
            this.panelMedico.TabIndex = 0;
            this.panelMedico.Visible = false;
            // 
            // Notas
            // 
            this.Notas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Notas.FlatAppearance.BorderSize = 0;
            this.Notas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notas.ForeColor = System.Drawing.Color.White;
            this.Notas.Image = ((System.Drawing.Image)(resources.GetObject("Notas.Image")));
            this.Notas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Notas.Location = new System.Drawing.Point(12, 79);
            this.Notas.Name = "Notas";
            this.Notas.Size = new System.Drawing.Size(141, 32);
            this.Notas.TabIndex = 18;
            this.Notas.Text = "Notes   ";
            this.Notas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Notas.UseVisualStyleBackColor = false;
            this.Notas.Click += new System.EventHandler(this.Notas_Click);
            // 
            // Grafico
            // 
            this.Grafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Grafico.FlatAppearance.BorderSize = 0;
            this.Grafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grafico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grafico.ForeColor = System.Drawing.Color.White;
            this.Grafico.Image = ((System.Drawing.Image)(resources.GetObject("Grafico.Image")));
            this.Grafico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Grafico.Location = new System.Drawing.Point(12, 3);
            this.Grafico.Name = "Grafico";
            this.Grafico.Size = new System.Drawing.Size(141, 32);
            this.Grafico.TabIndex = 16;
            this.Grafico.Text = "Grafics ";
            this.Grafico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Grafico.UseVisualStyleBackColor = false;
            this.Grafico.Click += new System.EventHandler(this.Grafico_Click);
            // 
            // Historico
            // 
            this.Historico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Historico.FlatAppearance.BorderSize = 0;
            this.Historico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Historico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Historico.ForeColor = System.Drawing.Color.White;
            this.Historico.Image = ((System.Drawing.Image)(resources.GetObject("Historico.Image")));
            this.Historico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Historico.Location = new System.Drawing.Point(12, 41);
            this.Historico.Name = "Historico";
            this.Historico.Size = new System.Drawing.Size(141, 32);
            this.Historico.TabIndex = 17;
            this.Historico.Text = "Historic";
            this.Historico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Historico.UseVisualStyleBackColor = false;
            this.Historico.Click += new System.EventHandler(this.Historico_Click);
            // 
            // Versao
            // 
            this.Versao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Versao.AutoSize = true;
            this.Versao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Versao.ForeColor = System.Drawing.Color.White;
            this.Versao.Location = new System.Drawing.Point(63, 576);
            this.Versao.Name = "Versao";
            this.Versao.Size = new System.Drawing.Size(51, 15);
            this.Versao.TabIndex = 15;
            this.Versao.Text = "V 1.0.0";
            // 
            // Autor
            // 
            this.Autor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Autor.AutoSize = true;
            this.Autor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autor.ForeColor = System.Drawing.Color.White;
            this.Autor.Location = new System.Drawing.Point(28, 561);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(124, 15);
            this.Autor.TabIndex = 14;
            this.Autor.Text = "Liquid Galaxy Lab ";
            // 
            // Medico
            // 
            this.Medico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Medico.FlatAppearance.BorderSize = 0;
            this.Medico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Medico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medico.ForeColor = System.Drawing.Color.White;
            this.Medico.Image = ((System.Drawing.Image)(resources.GetObject("Medico.Image")));
            this.Medico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Medico.Location = new System.Drawing.Point(0, 297);
            this.Medico.Name = "Medico";
            this.Medico.Size = new System.Drawing.Size(200, 42);
            this.Medico.TabIndex = 13;
            this.Medico.Text = "Doctor";
            this.Medico.UseVisualStyleBackColor = false;
            this.Medico.Click += new System.EventHandler(this.Medico_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MenuTopo
            // 
            this.MenuTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.MenuTopo.Controls.Add(this.Restaurar);
            this.MenuTopo.Controls.Add(this.Maximizar);
            this.MenuTopo.Controls.Add(this.Minimizar);
            this.MenuTopo.Controls.Add(this.Fechar);
            this.MenuTopo.Controls.Add(this.MenuLateral);
            this.MenuTopo.Controls.Add(this.label5);
            this.MenuTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTopo.Location = new System.Drawing.Point(200, 0);
            this.MenuTopo.Name = "MenuTopo";
            this.MenuTopo.Size = new System.Drawing.Size(1080, 90);
            this.MenuTopo.TabIndex = 15;
            this.MenuTopo.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuTopo_Paint);
            this.MenuTopo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuTopo_MouseDown);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1002, 9);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restaurar.TabIndex = 18;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1002, 9);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximizar.TabIndex = 17;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(966, 9);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 16;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Fechar
            // 
            this.Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Fechar.Image")));
            this.Fechar.Location = new System.Drawing.Point(1038, 9);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(30, 30);
            this.Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fechar.TabIndex = 15;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Close_Click);
            // 
            // MenuLateral
            // 
            this.MenuLateral.Image = ((System.Drawing.Image)(resources.GetObject("MenuLateral.Image")));
            this.MenuLateral.Location = new System.Drawing.Point(17, 23);
            this.MenuLateral.Name = "MenuLateral";
            this.MenuLateral.Size = new System.Drawing.Size(61, 43);
            this.MenuLateral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuLateral.TabIndex = 14;
            this.MenuLateral.TabStop = false;
            this.MenuLateral.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 90);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1080, 510);
            this.panelContenedor.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(200, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 510);
            this.panel1.TabIndex = 17;
            // 
            // Alpargatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1280, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuTopo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alpargatas";
            this.Text = "Alpargatas IoT";
            this.Load += new System.EventHandler(this.Alpargatas_Load);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.panelMedico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuTopo.ResumeLayout(false);
            this.MenuTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuLateral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Button Usuario;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel MenuTopo;
        private System.Windows.Forms.PictureBox MenuLateral;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.Button Medico;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.Label Versao;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Notas;
        private System.Windows.Forms.Button Historico;
        private System.Windows.Forms.Button Grafico;
        private System.Windows.Forms.Panel panelMedico;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

