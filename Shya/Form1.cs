using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Shya
{
    public partial class Form1 : Form
    {
        SerialPort myPort;

        private string _switchOne { get; set; }
        private string _switchTwo { get; set; }
        private string _switchThree { get; set; }
        private string _switchFour { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set Button
            button_SwitchFirst.Image = Image.FromFile(@"C:\Users\gr33n\Desktop\Shya\Shya\Images\bulb_off.png");
            button_SwitchFirst.ImageAlign = ContentAlignment.MiddleCenter;
            _switchOne = "OFF";

            // Set Arduino Serial Port
            ArduinoSetup();

            PolpulateSerialPort();
        }

        private void PolpulateSerialPort()
        {
           foreach(string serial in SerialPort.GetPortNames())
           {
               serialPortCombo.Items.Add(serial);
           }
        }

        void ArduinoSetup()
        {
            try
            {
                myPort = new SerialPort();
                myPort.BaudRate = 9600; // Baud Rate
                myPort.PortName = serialPortCombo.SelectedItem.ToString();
            }
            catch(NullReferenceException ex)
            {
                myPort.PortName = "COM5";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Serial Port Exception");
            }
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int state_first=0; //OFF
        private void button_SwitchFirst_Click(object sender, EventArgs e)
        {
            // Button First
            if(state_first==0)
            {
                //On
                button_SwitchFirst.Image = Image.FromFile(@"C:\Users\gr33n\Desktop\Shya\Shya\Images\bulb_on.png");
                state_first = 1; 

                try
                {
                     //SerialPort
                    if(myPort.IsOpen==false)
                    {
                        myPort.Open();
                        myPort.WriteLine("9"); //Bulb-1 ON
                        myPort.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error Bulb1 : "+ex.Message);
                }
               
            }
            else
            {
                //Off
                button_SwitchFirst.Image = Image.FromFile(@"C:\Users\gr33n\Desktop\Shya\Shya\Images\bulb_off.png");
                state_first = 0;

                try
                {
                    //SerialPort
                    if (myPort.IsOpen == false)
                    {
                        myPort.Open();
                        myPort.WriteLine("2"); //Bulb-1 OFF
                        myPort.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error Bulb 1 : "+ex.Message);
                }
                
            }
            

        }

        int state_second = 0; //off
        private void button_SwitchSecond_Click(object sender, EventArgs e)
        {
            if (state_second == 0)
            {
                //On
                button_SwitchSecond.Image = Image.FromFile(@"C:\Users\gr33n\Desktop\Shya\Shya\Images\bulb_on.png");
                state_second = 1;

                try
                {
                    //SerialPort
                    if (myPort.IsOpen == false)
                    {
                        myPort.Open();
                        myPort.WriteLine("3"); //Bulb-2 ON
                        myPort.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Bulb 2 : " + ex.Message);
                }
            }
            else
            {
                //Off
                button_SwitchSecond.Image = Image.FromFile(@"C:\Users\gr33n\Desktop\Shya\Shya\Images\bulb_off.png");
                state_second = 0;

                try
                {
                    //SerialPort
                    if (myPort.IsOpen == false)
                    {
                        myPort.Open();
                        myPort.WriteLine("4"); //Bulb-2 OFF
                        myPort.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Bulb 2 : " + ex.Message);
                }

            }
        }

        int state_door = 0; //Closed
        private void button_DoorSwitch_Click(object sender, EventArgs e)
        {
            if (state_door == 0)
            {
                //Door Open
                button_DoorSwitch.Image = Image.FromFile(@"C:\Users\gr33n\Desktop\Shya\Shya\Images\door_open.png");
                state_door = 1;

                try
                {
                    //SerialPort
                    if (myPort.IsOpen == false)
                    {
                        myPort.Open();
                        myPort.WriteLine("6"); //DOOR ON
                        myPort.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Door : " + ex.Message);
                }
            }
            else
            {
                //Door Close
                button_DoorSwitch.Image = Image.FromFile(@"C:\Users\gr33n\Desktop\Shya\Shya\Images\door_closed.png");
                state_door = 0;

                try
                {
                    //SerialPort
                    if (myPort.IsOpen == false)
                    {
                        myPort.Open();
                        myPort.WriteLine("7"); //DOOR OFF
                        myPort.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DOOR : " + ex.Message);
                }
            }
        }

        private void button_Speaker_Click(object sender, EventArgs e)
        {
            // Beep Buzzer
            try
            {
                    //SerialPort
                    if (myPort.IsOpen == false)
                    {
                        myPort.Open();
                        myPort.WriteLine("5"); //Bulb-1 OFF
                        myPort.Close();
                    }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
