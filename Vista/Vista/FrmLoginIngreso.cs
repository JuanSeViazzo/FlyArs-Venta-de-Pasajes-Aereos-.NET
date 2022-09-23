using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using Logica;



namespace Vista
{
    public partial class FrmLoginIngreso : Form
    {

        public Timer timer;

   


        public FrmLoginIngreso()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }
        private void FrmLoginIngreso_Load(object sender, EventArgs e)
        {
            pb_avionFrontal.Hide();
            ManejoDeVista.FechaVista(lbl_Fecha);
            timer = new Timer();
            timer.Tick += new EventHandler(EventoReloj);
            timer.Enabled = true;
            pc_LoginOk.Visible = false;
            pc_LoginNo.Visible = false;
            lbl_IngresoOkNo.Visible = false;
            ManejoDeVista.ReproducirMusica();
            BaseDeDatosHardCodeo.HarcodeoDeClientes();
            BaseDeDatosHardCodeo.HarcodeoDeDestinos();
            BaseDeDatosHardCodeo.HarcodeoDeVuelos();

        }

      



        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("El que tenga miedo a crashear, que no programe");
        }


        public void HiloHora()
        {
            lbl_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void HiloFecha()
        {
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void EventoReloj(object ob, EventArgs evt)
        {
            lbl_Hora.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private async void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (this.tb_usuario.Text == "A" && this.tb_password.Text == "A")
            {

                lbl_IngresoOkNo.Visible = true;
                lbl_IngresoOkNo.ForeColor = System.Drawing.Color.Green;
                pc_LoginOk.Visible = true;
                lbl_IngresoOkNo.Text = "Ingreso Correcto";

                FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal(tb_usuario.Text);


                pb_avionFrontal.Show();
                await Task.Delay(1000);
                pb_avionFrontal.Hide();

                menuPrincipal.Show();

                ManejoDeVista.BlanqueoVista(this.tb_usuario, this.tb_password);


            }else
            {

                pc_LoginNo.Visible = true;
                lbl_IngresoOkNo.Visible = true;
                lbl_IngresoOkNo.ForeColor = System.Drawing.Color.Red;
                lbl_IngresoOkNo.Text = "Datos Incorrectos";


                DialogResult resultado = MessageBox.Show("Elija una opcion", "Datos Incorrectos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);


                if (resultado == DialogResult.Retry)
                {
                    pc_LoginNo.Visible = false;
                    lbl_IngresoOkNo.Visible = false;
                    ManejoDeVista.BlanqueoVista(this.tb_usuario, this.tb_password);
                }
                else
                    this.Close();
            }
        }


        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Ingresar_Click(this, new EventArgs());
            }
        }
    }
}
