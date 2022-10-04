using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Data;
using System.Drawing;
using System.Media;

namespace Vista
{
    public static class ManejoDeVista
    {


        public static void BlanqueoVista(TextBox tb)
        {
            tb.Text = String.Empty;
        }


        public static void BlanqueoVista(TextBox tb1, TextBox tb2)
        {
            tb1.Text = String.Empty;
            tb2.Text = String.Empty;

        }

        public static void FechaVista(Label label)
        {
            label.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        public static void ReproducirMusica()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.main_teme);
            soundPlayer.Play();
        }

        
        public static void PausarMusica()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.main_teme);
            soundPlayer.Stop();
        }

    }
}
