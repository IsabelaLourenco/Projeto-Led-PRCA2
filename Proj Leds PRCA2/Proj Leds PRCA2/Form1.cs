using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Leds_PRCA2
{
    public partial class Form1 : Form
    {
        private  Leds leds;
        public Form1()
        {
            InitializeComponent();
            leds = new Leds();
            atualizaInterface();
        }

        private void atualizaInterface()
        {
            picLed1.Image =
                             (leds.getEstado(0) ?
                             Proj_Leds_PRCA2.Properties.Resources.red_led_on_hi :
                             Proj_Leds_PRCA2.Properties.Resources.led_off_hi);
            btnLed1.Text = (leds.getEstado(0) ? "Desligar" : "Ligar");
            picLed2.Image =
                                (leds.getEstado(1) ?
                                Proj_Leds_PRCA2.Properties.Resources.red_led_on_hi :
                                Proj_Leds_PRCA2.Properties.Resources.led_off_hi);
            btnLed2.Text = (leds.getEstado(1) ? "Desligar" : "Ligar");
            picLed3.Image =
                          (leds.getEstado(2) ?
                          Proj_Leds_PRCA2.Properties.Resources.red_led_on_hi :
                          Proj_Leds_PRCA2.Properties.Resources.led_off_hi);
            btnLed3.Text = (leds.getEstado(2) ? "Desligar" : "Ligar");
            picLed4.Image =
                          (leds.getEstado(3) ?
                          Proj_Leds_PRCA2.Properties.Resources.red_led_on_hi :
                          Proj_Leds_PRCA2.Properties.Resources.led_off_hi);
            btnLed4.Text = (leds.getEstado(3) ? "Desligar" : "Ligar");
            picLed5.Image =
                          (leds.getEstado(4) ?
                          Proj_Leds_PRCA2.Properties.Resources.red_led_on_hi :
                          Proj_Leds_PRCA2.Properties.Resources.led_off_hi);
            btnLed5.Text = (leds.getEstado(4) ? "Desligar" : "Ligar");
            picLed6.Image =
                         (leds.getEstado(5) ?
                         Proj_Leds_PRCA2.Properties.Resources.red_led_on_hi :
                         Proj_Leds_PRCA2.Properties.Resources.led_off_hi);
            btnLed6.Text = (leds.getEstado(5) ? "Desligar" : "Ligar");
            picLed7.Image =
                                     (leds.getEstado(6) ?
                                     Proj_Leds_PRCA2.Properties.Resources.red_led_on_hi :
                                     Proj_Leds_PRCA2.Properties.Resources.led_off_hi);
            btnLed7.Text = (leds.getEstado(6) ? "Desligar" : "Ligar");
            picLed8.Image =
                                     (leds.getEstado(7) ?
                                     Proj_Leds_PRCA2.Properties.Resources.red_led_on_hi :
                                     Proj_Leds_PRCA2.Properties.Resources.led_off_hi);
            btnLed8.Text = (leds.getEstado(7) ? "Desligar" : "Ligar");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void onoff1(object sender, EventArgs e)
        {
            if (leds.getEstado(0))
            {
                leds.apagar(1);
            }
            else
            {
                leds.acender(1);
            }
            picLed1.Image =
                            (leds.getEstado(0) ?
                            Proj_Leds_PRCA2.Properties.Resources.red_led_on_hi :
                            Proj_Leds_PRCA2.Properties.Resources.led_off_hi);
            btnLed1.Text = (leds.getEstado(0) ? "Desligar" : "Ligar");
        }

        private void onoff2(object sender, EventArgs e)
        {
            if (leds.getEstado(1))
            {
                leds.apagar(2);
            }
            else
            {
                leds.acender(2);
            }
            picLed2.Image =
                            (leds.getEstado(1) ?
                            Proj_Leds_PRCA2.Properties.Resources.red_led_on_hi :
                            Proj_Leds_PRCA2.Properties.Resources.led_off_hi);
            btnLed2.Text = (leds.getEstado(1) ? "Desligar" : "Ligar");
        }

        private void onoff3(object sender, EventArgs e)
        {
            if (leds.getEstado(2))
            {
                leds.apagar(3);
            }
            else
            {
                leds.acender(3);
            }
            picLed3.Image =
                            (leds.getEstado(2) ?
                            Proj_Leds_PRCA2.Properties.Resources.red_led_on_hi :
                            Proj_Leds_PRCA2.Properties.Resources.led_off_hi);
            btnLed3.Text = (leds.getEstado(2) ? "Desligar" : "Ligar");
        }

        private void onoff4(object sender, EventArgs e)
        {
            if (leds.getEstado(3))
            {
                leds.apagar(4);
            }
            else
            {
                leds.acender(4);
            }
            picLed4.Image =
                            (leds.getEstado(3) ?
                            Proj_Leds_PRCA2.Properties.Resources.red_led_on_hi :
                            Proj_Leds_PRCA2.Properties.Resources.led_off_hi);
            btnLed4.Text = (leds.getEstado(3) ? "Desligar" : "Ligar");
        }

        private void onoff5(object sender, EventArgs e)
        {
            if (leds.getEstado(4))
            {
                leds.apagar(5);
            }
            else
            {
                leds.acender(5);
            }
            picLed5.Image =
                            (leds.getEstado(4) ?
                            Proj_Leds_PRCA2.Properties.Resources.red_led_on_hi :
                            Proj_Leds_PRCA2.Properties.Resources.led_off_hi);
            btnLed5.Text = (leds.getEstado (4) ? "Desligar" : "Ligar");
        }

        private void onoff6(object sender, EventArgs e)
        {
            if (leds.getEstado(5))
            {
                leds.apagar(6);
            }
            else
            {
                leds.acender(6);
            }
            picLed6.Image =
                            (leds.getEstado(5) ?
                            Proj_Leds_PRCA2.Properties.Resources.red_led_on_hi :
                            Proj_Leds_PRCA2.Properties.Resources.led_off_hi);
            btnLed6.Text = (leds.getEstado(5) ? "Desligar" : "Ligar");
        }

        private void onoff7(object sender, EventArgs e)
        {
            if (leds.getEstado(6))
            {
                leds.apagar(7);
            }
            else
            {
                leds.acender(7);
            }
            picLed7.Image =
                            (leds.getEstado(6) ?
                            Proj_Leds_PRCA2.Properties.Resources.red_led_on_hi :
                            Proj_Leds_PRCA2.Properties.Resources.led_off_hi);
            btnLed7.Text = (leds.getEstado(6) ? "Desligar" : "Ligar");
        }

        private void onoff8(object sender, EventArgs e)
        {
            if (leds.getEstado(7))
            {
                leds.apagar(8);
            }
            else
            {
                leds.acender(8);
            }
            picLed8.Image =
                            (leds.getEstado(7) ?
                            Proj_Leds_PRCA2.Properties.Resources.red_led_on_hi :
                            Proj_Leds_PRCA2.Properties.Resources.led_off_hi);
            btnLed8.Text = (leds.getEstado(8) ? "Desligar" : "Ligar");
        }
    }
   
} 
