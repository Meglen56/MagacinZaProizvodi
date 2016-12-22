using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace SeminarskaKNI107
{
    public partial class Magacin : Form
    {

        Socket sck;
        EndPoint epLocal, epRemote;
    
      

        public Magacin(frmMain parent)
        {
            MagacinEventLog.WriteInformationLog("Vlez vo Chat Aplikacija");
            InitializeComponent();

            MdiParent = parent;

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                
            LocalIp.Text = GetLocalIP();
            RemoteIp.Text = GetLocalIP();

        }
        private void Magacin_Load(object sender, EventArgs e)
        {
                    
          

        }

        private string GetLocalIP()
        {
            try {
                IPHostEntry host;
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
            }

            catch (System.Net.Sockets.SocketException sockEx)
            {
                int errorCode = sockEx.ErrorCode;
            }
            
            return "127.0.0.1";
        }


        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                
              
                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);

                    listBox1.Items.Add("Магацин2:" + receivedMessage);
                }
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(LocalIp.Text), Convert.ToInt32(LocalPort.Text));
                sck.Bind(epLocal);
                epRemote = new IPEndPoint(IPAddress.Parse(RemoteIp.Text), Convert.ToInt32(RemotePort.Text));
                sck.Connect(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                button1.Text = "Конектирани сте";
                button1.Enabled = false;
                button2.Enabled = true;
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LocalIp_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(textBox1.Text);
                sck.Send(msg);
                

                listBox1.Items.Add("Магацин 1:" + textBox1.Text);
                textBox1.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        




       
    }
    }
