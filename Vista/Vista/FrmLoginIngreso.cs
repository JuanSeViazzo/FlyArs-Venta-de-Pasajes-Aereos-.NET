using Logica;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;



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
            BaseDeDatosHardCodeo.numero = 1;
            

        }

        private void EventoReloj(object ob, EventArgs evt)
        {
            lbl_Hora.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private async void btn_Ingresar_Click(object sender, EventArgs e)
        {

            foreach (Persona item in GestionDeAerolinea.ListaDePersonas)
            {
                if (item is Usuario usuarioAux)
                {
                    if (this.tb_usuario.Text == usuarioAux.User)
                    {
                        if (this.tb_password.Text == usuarioAux.Password)
                        {
                            lbl_IngresoOkNo.Visible = true;
                            lbl_IngresoOkNo.ForeColor = System.Drawing.Color.Green;
                            pc_LoginOk.Visible = true;
                            lbl_IngresoOkNo.Text = "Ingreso Correcto";

                            FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal(tb_usuario.Text);


                            pb_avionFrontal.Show();
                            await Task.Delay(10000);
                            pb_avionFrontal.Hide();

                            menuPrincipal.Show();

                            ManejoDeVista.BlanqueoVista(this.tb_usuario, this.tb_password);
                        }
                        else
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
                                break;
                            }
                            else
                                this.Close();
                        }
                    }

                }

            }

        }


        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Ingresar_Click(this, new EventArgs());
            }
        }

        private async void btnAutoLogin_Click(object sender, EventArgs e)
        {
            lbl_IngresoOkNo.Visible = true;
            lbl_IngresoOkNo.ForeColor = System.Drawing.Color.Green;
            pc_LoginOk.Visible = true;
            lbl_IngresoOkNo.Text = "Ingreso Correcto";

            FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal("Usuario Invitado");


            pb_avionFrontal.Show();
            await Task.Delay(500);
            pb_avionFrontal.Hide();

            menuPrincipal.Show();

            ManejoDeVista.BlanqueoVista(this.tb_usuario, this.tb_password);
        }
    }
}
