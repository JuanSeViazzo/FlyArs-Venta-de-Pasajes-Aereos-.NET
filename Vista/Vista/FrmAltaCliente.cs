﻿using Logica;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAltaCliente : Form
    {
        Pasajero pasajero;
        public FrmAltaCliente()
        {
            InitializeComponent();
        }
        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            cmb_tipoDeDocumento.DataSource = Enum.GetValues(typeof(Persona.TipoDocumento));
            // cmb_TipoDeEquipaje.DataSource = Enum.GetValues(typeof(Equipaje.TipoDeEquipaje));

        }

        private void btn_aceptarPasajero_Click(object sender, EventArgs e)
        {
            Persona.TipoDeSexo sexoElegido = Persona.TipoDeSexo.Femenino;


            foreach (RadioButton radioButton in grp_Sexo.Controls)
            {
                if (radioButton.Checked)
                {
                    sexoElegido = (Persona.TipoDeSexo)radioButton.TabIndex;
                    break;
                }
            }


            for (int i = 0; i < Pasajero.ListaDePasajeros.Count; i++)
            {

                if (!(Pasajero.ListaDePasajeros[i].Documento == pasajero.Documento))
                {

                    Pasajero.ListaDePasajeros.Add(pasajero);
                }
                else
                {
                    lbl_errorExcep.Text = "Cliente ya en la base";
                }

            }


            try
            {
                pasajero = new Pasajero(txt_nombre.Text, Txt_apellido.Text, (Persona.TipoDocumento)cmb_tipoDeDocumento.SelectedItem,
                Txt_numeroDeDocumento.Text, txt_edad.Text, txt_nacionalidad.Text, calendar_nacimiento.SelectionStart,sexoElegido);

                rtb_DatosDelCliente.Text = pasajero.Mostrar();

                // dataGrid_AltaCliente.DataSource = Pasajero.ListaDePasajeros[(Pasajero.ListaDePasajeros.Count - 1)];
            }
            catch (Exception ex)
            {
                lbl_errorExcep.Text = ex.Message;
                rtb_DatosDelCliente.Clear();    

            }



 


            // pasajero.CargarEquipaje(txt_equipajeUno.Text);
            // pasajero.CargarEquipaje(txt_EquipajeDos.Text);





        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}