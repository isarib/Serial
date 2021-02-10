﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace Serial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private int verified = 0; //verificacao para conectar 
        private int validated = 0; //verificacao para enviar


        //opçoes para a porta 
        private string[] parityList = {"Nenhuma","Ímpar", "Par"};
        private string[] baudRateStrList = { "300", "1200", "9600", "115200" };
        private int[] baudRateIntList = { 300, 1200, 9600, 115200 };
        private string[] stopBitsStrList = { "1", "2" };
        private System.IO.Ports.StopBits[] stopBitsList = { System.IO.Ports.StopBits.One, System.IO.Ports.StopBits.Two };

        private int miliseconds = 0, seconds = 0, minutes = 0;
        private bool send = false;
        private string[] scalesList = { "Milisegundos", "Segundos", "Minutos" };
        private int sent = 0;

        private string RxString;

        private bool hasInPorts(string Text) //
        {
            string[] ports = SerialPort.GetPortNames();
            for (int i = 0; i < ports.Length; i++)
            {
                if (ports[i] == Text)
                {
                    serialPort.PortName = ports[i]; 
                    return true;
                }
            }
            return false;
        }

        private void Port_DropDown(object sender, EventArgs e) // portas disponiveis 
        {
            string[] ports = SerialPort.GetPortNames();
            Port.Items.Clear();
            Port.Items.AddRange(ports);
        }

        private void Port_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (hasInPorts(Port.Text))
            {
                verified += 1;
                if (verified == 15)
                {
                    Connect.Enabled = true;
                }
            }
        }

        private void Port_Click(object sender, EventArgs e)
        {
            if ((verified & 1) == 1)
            {
                verified -= 1;
            }
            Connect.Enabled = false; 
        }

        private bool hasInParities (string text)
        {
            for (int i = 0; i < parityList.Length; i++)
            {
                if(text == parityList[i])
                {
                    switch (i)
                    {
                        default:
                        case 0:
                            serialPort.Parity = System.IO.Ports.Parity.None;
                            break;
                        case 1:
                            serialPort.Parity = System.IO.Ports.Parity.Odd;
                            break;
                        case 2:
                            serialPort.Parity = System.IO.Ports.Parity.Even;
                            break;
                    }
                    return true; 
                }   
            }
            return false; 
        }

        private void Parity_DropDown(object sender, EventArgs e)
        {
            Parity.Items.Clear();
            Parity.Items.AddRange(parityList);
        }

        private void Parity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (hasInParities(Parity.Text))
            {
                verified += 2;
                if (verified == 15)
                {
                    Connect.Enabled = true;
                }
            }
        }

        private void Parity_Click(object sender, EventArgs e)
        {

            if ((verified & 2) == 2)
            {
                verified -= 2;
            }
            Connect.Enabled = false;
        }

        private bool hasInBauds(string Text)
        {
            for (int i = 0; i < baudRateStrList.Length; i++)
            {
                if (baudRateStrList[i] == Text)
                {
                    serialPort.BaudRate = baudRateIntList[i];
                    return true;
                }
            }
            return false;
        }

        private void BaudRate_DropDown(object sender, EventArgs e)
        {
            BaudRate.Items.Clear();
            BaudRate.Items.AddRange(baudRateStrList);
        }

        private void BaudRate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (hasInBauds(BaudRate.Text))
            {
                verified += 4;
                if (verified == 15)
                {
                    Connect.Enabled = true;
                }
            }
        }

        private void BaudRate_Click(object sender, EventArgs e)
        {

            if ((verified & 4) == 4)
            {
                verified -= 4;
            }
            Connect.Enabled = false;
        }

        private bool hasInStop(string Text)
        {
            for (int i = 0; i < stopBitsStrList.Length; i++)
            {
                if (stopBitsStrList[i] == Text)
                {
                    serialPort.StopBits = stopBitsList[i];
                    return true;
                }
            }
            return false;
        }

        private void StopBits_DropDown(object sender, EventArgs e)
        {
            StopBits.Items.Clear();
            StopBits.Items.AddRange(stopBitsStrList);
        }

        private void StopBits_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (hasInStop(StopBits.Text))
            {
                verified += 8;
                if (verified == 15)
                {
                    Connect.Enabled = true;
                }
            }
        }

        private void StopBits_Click(object sender, EventArgs e)
        {
            if ((verified & 8) == 8)
            {
                verified -= 8;
            }
            Connect.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (send)
            {
                miliseconds += 1;
                if (miliseconds == 1000)
                {
                    seconds += 1;
                    if (seconds == 60)
                    {
                        minutes += 1;
                        if (minutes > 1000)
                        {
                            minutes = 0;
                        }
                        else if ((Scales.Text == scalesList[2]) && (minutes == numericUpDownTempo.Value))
                        {
                            minutes = 0;
                            send_command();
                        }
                    }
                    else if (seconds > 1000)
                    {
                        seconds = 0;
                    }
                    else if ((Scales.Text == scalesList[1]) && (seconds == numericUpDownTempo.Value))
                    {
                        seconds = 0;
                        send_command();
                    }
                }
                else if (miliseconds > 1000)
                {
                    miliseconds = 0;
                }
                else if ((Scales.Text == scalesList[0]) && (miliseconds == numericUpDownTempo.Value))
                {
                    miliseconds = 0;
                    send_command();
                }
            }
        }

        private void Scales_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (hasInScales(Scales.Text))
            {
                validated += 1;
                if (validated == 7)
                {
                    Enviar.Enabled = true;
                }
            }
        }

        private bool hasInScales (string Text) //
        {
            for (int i = 0; i < scalesList.Length; i++)
            {
                if (scalesList[i] == Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void Scales_DropDown(object sender, EventArgs e)
        {
            Scales.Items.Clear();
            Scales.Items.AddRange(scalesList);
        }

        private void Scales_Click(object sender, EventArgs e)
        {
            if ((validated & 1) == 1)
            {
                validated -= 1;
            }
            Enviar.Enabled = false;
        }


        private void Connect_Click(object sender, EventArgs e)
        {
            sent = 0;
            send = false;
            if (serialPort.IsOpen == false)
            {
                if ((validated & 2) == 2)
                {
                    validated -= 2;
                }
                Enviar.Enabled = false;
                try
                {
                    serialPort.Open();
                }
                catch (Exception ex)
                {
                    validated -= 2;
                    MessageBox.Show("Porta inválida.\r\n\r\n" + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if ((validated & 2) == 2)
                {
                    validated += 2;
                }
                if (validated == 7)
                {
                    Enviar.Enabled = true;
                }
                {
                    Connect.Text = "Desconectar";
                    Port.Enabled = false;

                }
            }

        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            send = true;
            send_command();
        }

        private void Command_TextChanged(object sender, EventArgs e)
        {
            if (Command.Text.Length > 0)
            {
                if ((validated & 4) == 4)
                {
                    validated += 4;
                }
            }
            else
            {
                if ((validated & 4) == 4)
                {
                    validated -= 4;
                }
            }
            if (validated == 7)
            {
                Enviar.Enabled = true;
            }
            else
            {

                try
                {
                    serialPort.Close();
                    Port.Enabled = true;
                    Connect.Text = "Conectar";
                }
                catch
                {
                    return;
                }

            }
        }

        private void send_command()
        {
            if (serialPort.IsOpen)
            {
                sent += 1;
                if (sent == numericUpDownQuantidade.Value)
                {
                    send = false;
                    sent = 0;
                }
            }
            else
            {
                sent = 0;
                send = false;
                if ((validated & 2) == 2)
                {
                    validated -= 2;
                }
                Enviar.Enabled = false;
            }
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = serialPort.ReadExisting();              //le o dado disponível na serial
            this.Invoke(new EventHandler(DadoRecebido));   //chama outra thread para escrever o dado no text box
        }
        private void DadoRecebido(object sender, EventArgs e)
        {
            richTextBoxRecebeu.AppendText(RxString);
        }

    }
}
