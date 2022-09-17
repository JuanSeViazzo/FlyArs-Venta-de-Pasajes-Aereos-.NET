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

        public Timer Timer { get => timer; }


        public FrmLoginIngreso()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
           // ManejoDeVista.ReproducirMusica();

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

            Pasajero pasajero1 = new Pasajero("Sebastian", "Viazzo", Persona.TipoDocumento.DNI, "34262507", "33", "argentino", new DateTime(1988, 12, 17), Persona.TipoDeSexo.Masculino);
            Pasajero pasajero2 = new Pasajero("Lucas", "Rodriguez", Persona.TipoDocumento.DNI, "35003321", "30", "argentino", new DateTime(1990, 07, 15), Persona.TipoDeSexo.Masculino);
            Pasajero pasajero3 = new Pasajero("Marina", "Rodriguez", Persona.TipoDocumento.DNI, "38000132", "33", "argentino", new DateTime(1992, 04, 22), Persona.TipoDeSexo.Femenino);
            Pasajero pasajero4 = new Pasajero("Ignacio", "Smirlian", Persona.TipoDocumento.Pasaporte, "37213986", "25", "Italiano", new DateTime(1998, 06, 10), Persona.TipoDeSexo.Masculino);
            Pasajero pasajero5 = new Pasajero("Thierry", "Henry", Persona.TipoDocumento.Pasaporte, "34222503", "48", "Frances", new DateTime(1974, 03, 19), Persona.TipoDeSexo.Masculino);
            Pasajero pasajero6 = new Pasajero("Diego", "Maradona", Persona.TipoDocumento.DNI, "24323788", "60", "argentino", new DateTime(1960, 01, 15), Persona.TipoDeSexo.Masculino);
            Pasajero pasajero7 = new Pasajero("Lionel", "Messi", Persona.TipoDocumento.DNI, "32198605", "35", "argentino", new DateTime(1985, 11, 15), Persona.TipoDeSexo.Masculino);

            GestionDeAerolinea.ListaDePasajeros.Add(pasajero1);
            GestionDeAerolinea.ListaDePasajeros.Add(pasajero2);
            GestionDeAerolinea.ListaDePasajeros.Add(pasajero3);
            GestionDeAerolinea.ListaDePasajeros.Add(pasajero4);
            GestionDeAerolinea.ListaDePasajeros.Add(pasajero5);
            GestionDeAerolinea.ListaDePasajeros.Add(pasajero6);
            GestionDeAerolinea.ListaDePasajeros.Add(pasajero7);

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private async void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (this.tb_usuario.Text == "A" && this.tb_password.Text == "A")
            {

                lbl_IngresoOkNo.Visible = true;
                lbl_IngresoOkNo.ForeColor = System.Drawing.Color.Green;
                pc_LoginOk.Visible = true;
                lbl_IngresoOkNo.Text = "Ingreso Correcto";

                FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal();

                menuPrincipal.MostrarUsuario(this.tb_usuario.Text);

                menuPrincipal.MostrarHora(this.lbl_Hora.Text);

                pb_avionFrontal.Show();
                await Task.Delay(1000);
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
                }
                else
                    this.Close();
            }
        }
    }
}
