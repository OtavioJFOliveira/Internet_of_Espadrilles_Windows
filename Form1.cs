using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Biblioteca utilizada para fazer o arraste de tela 


namespace Alpargatas_IoT
{
   
    public partial class Alpargatas : Form
    {
        public Alpargatas()
        {
            InitializeComponent();
        }

        // Trecho de código responsável por permitir movimentar a tela da aplicação clicanco e arrastanto na linha superior 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] 
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam); // Fim da função de arraste de tela

        private void Alpargatas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 200)
            {
                MenuVertical.Width = 50;
                
            }
            else
                MenuVertical.Width = 200;
           
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Restaurar.Visible = true;
            Maximizar.Visible = false;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MenuTopo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
           
            AbrirFormEnPanel(new PainelConexao());

        }

        private void Usuario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new PainelUsuario());

        }

        private void PainelInformacoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormEnPanel(object Formhijo)//Função responsavel por chamar os paineis para abrir 
        {
           
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void Medico_Click(object sender, EventArgs e)
        {
            if (panelMedico.Visible == true)
            {
                panelMedico.Visible = false;
            }
            else
                panelMedico.Visible = true;
            
        }

        private void Grafico_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new PainelMedicoGrafico());
        }

        private void Historico_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new PainelMedicoHistorico());
        }

        private void Notas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new PainelMedicoNotas());
        }

        private void MenuTopo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
