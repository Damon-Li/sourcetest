using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;

using Cognex.VisionPro;
using Cognex.VisionPro.Comm;
using Cognex.VisionPro3D;
using System.Collections;
using System.Net;

using System.Threading;

using ModbusTCP.Server;

namespace ModbusTCP
{
    public partial class Form1 : Form
    {
        //SynchronizationContext 线程通讯
        SynchronizationContext sc; 
        public Form1()
        {
            InitializeComponent();
            sc = SynchronizationContext.Current; 
        }

        #region TCP Client

        int Port_Client;
        String IP_Client;
        Socket ClientSocket;
        bool b_ConnClient = false;
        string recStr = "";

        #endregion

        #region ModbusTCP

        public ModbusTCP_Server myServer;     

        void myServer_ModbusTCPDataWrittenTo(object sender, ModbusTCPDataEventArgs e)
        {
            string m_Data = "";
            switch (e.ModbusTCPDataType)
            {
                
                case ModbusTCP.Server.RegisterType.HoldRegister:
                    m_Data = "";
                    for (int i = 0; i < e.Data.B.Count; i++)
                    {
                        dataGridView1.Rows[e.StartAddress + i].Cells[1].Value = e.Data.B[i];
                        if (i == 0)
                        {
                            m_Data = e.Data.B[i].ToString();
                        }
                        else
                        {
                            m_Data = m_Data + " , " + e.Data.B[i].ToString();
                        }
                    }
                    comboBox1_SelectedIndexChanged(sender, e);
                    sc.Post(delegate { textBox4.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff ") + e.StartAddress.ToString() + "[" + m_Data + "]"); }, null);
                    sc.Post(delegate { textBox4.AppendText(Environment.NewLine + Environment.NewLine); }, null);
                    
                    break;
                               
                default:
                    break;
            }
        }

        void myServer_ModbusTCPRequestReceived(object sender, ModbusTCPRequestEventArgs e)
        {
            byte fc = e.FunctionCode;
            byte[] byteStartAddress = e.byte_StartAddress;
            byte[] byteNum = e.byte_Data;
            Int16 StartAddress = BitConverter.ToInt16(byteStartAddress, 0);//数据起始位
            Int16 NumOfPoint = BitConverter.ToInt16(byteNum, 0);

            //解析功能码
            switch (fc)
            {
                              
                case (byte)3:
                  
                    //通讯连接成功
                    sc.Post(delegate { dataGridView1.Rows[50].Cells[1].Value = "1"; }, null);

                    sc.Post(delegate{textBox3.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "[Read HoldingRegister] " + " 起始地址:" +
                                                StartAddress.ToString() + " 数据内容：" + NumOfPoint.ToString());}, null);
                    sc.Post(delegate { textBox3.AppendText(Environment.NewLine + Environment.NewLine); }, null);
                    break;
                               
                case (byte)6:
                    //写单个寄存器[Write Single Register]
                    sc.Post(delegate { textBox5.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "[Write Single Register] " + " 起始地址:" +
                                                   StartAddress.ToString() + " 数据内容：" + NumOfPoint.ToString());}, null);
                    
                    sc.Post(delegate { textBox5.AppendText(Environment.NewLine + Environment.NewLine); }, null);
                    break;
                
                case (byte)16:
                    //写多个寄存器[Write Multiple Registers]                   
                    sc.Post(delegate{textBox5.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + " [Write Multiple Registers]" + " 起始地址:" +
                                                   StartAddress.ToString() + " 数据内容：" + NumOfPoint.ToString());}, null);
                    sc.Post(delegate { textBox5.AppendText(Environment.NewLine + Environment.NewLine); }, null);
                    break;
                case (byte)17:
                    //[Report Slave ID]

                    break;
                case (byte)20:
                    //读文件记录
                    break;
                case (byte)21:
                    //写文件记录
                    break;
                case (byte)22:
                    //[Mask Write Register]
                    break;
                case (byte)23:
                    //[Read/Write Multiple Registers]
                    break;
                default:
                    break;
            }
        }

        void myServer_ClientDisconnected(object sender, TCPEventArgs e)
        {
           // sc.Post(delegate { listBox1.Items.Add(e._handle.Client.RemoteEndPoint.ToString()); }, null);
            sc.Post(delegate { listBox1.Items.Clear(); }, null);
            sc.Post(delegate { lab_modbustcp.BackColor = Color.Red; }, null); 
        }

        void myServer_ClientConnected(object sender, TCPEventArgs e)
        {
            try
            {              
                sc.Post(delegate { listBox1.Items.Add(e._handle.Client.RemoteEndPoint.ToString()); }, null);
                sc.Post(delegate { lab_modbustcp.BackColor = Color.Green; }, null); 
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            
        }


        #endregion

        string SettingSavePath = "";
        string SettingPath_Comm = "";

        /// <summary>
        /// Writes a string to the text box log in the GUI
        /// </summary>
        private void Log_TCP(string logString, params object[] logStringFormatArgs) //写textbox数据
        {
            textBox_TCP.AppendText(DateTime.Now.ToString("HH:mm:ss:") + DateTime.Now.Millisecond.ToString("000") + " " +
                                   String.Format(logString, logStringFormatArgs));
            textBox_TCP.AppendText(Environment.NewLine + Environment.NewLine);
        }

        public void mds_send()
        {
            Byte[] buf;

            try
            {
                // Create a string defining the pose txt_FFP_X
                String str = txt_TCP_X.Text + ";" +          // Ttanslation_X
                             txt_TCP_Y.Text + ";" +         // Translation_Y
                             txt_TCP_Z.Text + ";" +         // Translation_Z
                             txt_TCP_R1.Text + ";" +
                             txt_TCP_R2.Text + ";" +
                             txt_TCP_R3.Text + ";";

                // Add job, mode and part selector
                str += txt_TCP_JobID.Text + ";" + txt_TCP_ModeID.Text + ";" + txt_TCP_PartSelector.Text + ";";

                System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
                buf = encoding.GetBytes(str);

                // Send it away....
                //ClientSocket.Write(buf, 0, buf.Length);
                ClientSocket.Send(buf);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TCP方式转发数据失败！" + ex.ToString());
            }
        }

        private void btn_SaveSetting_Click(object sender, EventArgs e)  //点击保存设置
        {
            using (StreamWriter sWriter = new StreamWriter(SettingPath_Comm, false, Encoding.Default))
            {
                sWriter.WriteLine(txt_IP_Comm.Text);
                sWriter.WriteLine(txt_Port_Comm.Text);
            }

            DialogResult result = MessageBox.Show("保存成功,必须重启程序才能是配置生效,是否重启?", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
            this.Close();
        }

        /// <summary>
        /// 解析TCP方式收到3D程序发送的结果信息，送界面显示
        /// </summary>
        /// <param name="str">TCP收到的string</param>
        protected void ReceiveJobResult_TCP(string str)  //接收来自3D软件的数据，并反映在界面上
        {

            try
            {
                string[] m = str.Split(' ');
                double n0, n1, n2, n3, n4, n5; int s0, s1, s2, s3,s4,s5;
                Cog3DTransformRigid pos = new Cog3DTransformRigid();

                // The first three numbers are the translation component of the pose
                n0 = double.Parse(m[0]); n1 = double.Parse(m[1]); n2 = double.Parse(m[2]); n3 = double.Parse(m[3]);
                n4 = double.Parse(m[4]); n5 = double.Parse(m[5]);
                n0 = n0 * 1000; n1 = n1 * 1000; n2 = n2 * 1000; n3 = n3 * 1000; n4 = n4 * 1000; n5 = n5 * 1000;
                s0 = Convert.ToInt32(n0); s1 = Convert.ToInt32(n1); s2 = Convert.ToInt32(n2); s3 = Convert.ToInt32(n3);
                s4 = Convert.ToInt32(n4);s5 = Convert.ToInt32(n5);
                Cog3DVect3 trans = new Cog3DVect3(double.Parse(m[0]), double.Parse(m[1]), double.Parse(m[2]));
                // The next three numbers are the EuleXYZ angles
                Cog3DEulerXYZ euler = new Cog3DEulerXYZ(double.Parse(m[3]), double.Parse(m[4]), double.Parse(m[5]));
                Cog3DTransformRotation rot = new Cog3DTransformRotation(euler);
                pos = new Cog3DTransformRigid(rot, trans);

                //结果位标志
                string Result_State = m[6];

                sc.Post(delegate { txt_FFP_X.Text = m[0]; }, null);
                sc.Post(delegate { txt_FFP_Y.Text = m[1]; }, null);
                sc.Post(delegate { txt_FFP_Z.Text = m[2]; }, null);
                sc.Post(delegate { txt_FFP_R1.Text = m[3]; }, null);
                sc.Post(delegate { txt_FFP_R2.Text = m[4]; }, null);
                sc.Post(delegate { txt_FFP_R3.Text = m[5]; }, null);
                sc.Post(delegate { txt_FFP_Status.Text = m[6]; }, null);

                //拍照完成信号的写入

                sc.Post(delegate { dataGridView1.Rows[51].Cells[1].Value = "1"; }, null);

                //更新寄存器数据,加入正负判断
                //if (Convert.ToInt32(m[0]) > 0)  //发送给PLC X值
                //{
                //    sc.Post(delegate { dataGridView1.Rows[32].Cells[1].Value = s0; }, null);
                //    sc.Post(delegate { dataGridView1.Rows[44].Cells[1].Value = "1"; }, null);
                //}
                //else
                //{
                //    int N0 = Convert.ToInt32(m[0]) * (-1);
                //    sc.Post(delegate { dataGridView1.Rows[32].Cells[1].Value = N0; }, null);
                //    sc.Post(delegate { dataGridView1.Rows[44].Cells[1].Value = "2"; }, null);
                //}

               // myServer.SetData(RegisterType.HoldRegister, 44, s0, DisplayType_Cur);


                if (s0 > 0)  //发送给PLC X值
                {
                    sc.Post(delegate { dataGridView1.Rows[32].Cells[1].Value = s0; }, null);
                    sc.Post(delegate { dataGridView1.Rows[44].Cells[1].Value = "1"; }, null);
                }
                else
                {
                    int N0 = s0 * (-1);
                    sc.Post(delegate { dataGridView1.Rows[32].Cells[1].Value = N0; }, null);
                    sc.Post(delegate { dataGridView1.Rows[44].Cells[1].Value = "2"; }, null);
                }

                if (s1 > 0)  //发送给PLC Y值
                {
                    sc.Post(delegate { dataGridView1.Rows[34].Cells[1].Value = s1; }, null);
                    sc.Post(delegate { dataGridView1.Rows[45].Cells[1].Value = "1"; }, null);
                }
                else
                {
                    int N1 = s1 * (-1);
                    sc.Post(delegate { dataGridView1.Rows[34].Cells[1].Value = N1; }, null);
                    sc.Post(delegate { dataGridView1.Rows[45].Cells[1].Value = "2"; }, null);
                }

                if (s2 > 0)  //发送给PLC Z值
                {
                    sc.Post(delegate { dataGridView1.Rows[36].Cells[1].Value = s2; }, null);
                    sc.Post(delegate { dataGridView1.Rows[46].Cells[1].Value = "1"; }, null);
                }
                else
                {
                    int N2 = s2 * (-1);
                    sc.Post(delegate { dataGridView1.Rows[36].Cells[1].Value = N2; }, null);
                    sc.Post(delegate { dataGridView1.Rows[46].Cells[1].Value = "2"; }, null);
                }

                if (s3 > 0)  //发送给PLC RX值
                {
                    sc.Post(delegate { dataGridView1.Rows[38].Cells[1].Value = s3; }, null);
                    sc.Post(delegate { dataGridView1.Rows[47].Cells[1].Value = "1"; }, null);
                }
                else
                {
                    int N3 = s3 * (-1);
                    sc.Post(delegate { dataGridView1.Rows[38].Cells[1].Value = N3; }, null);
                    sc.Post(delegate { dataGridView1.Rows[47].Cells[1].Value = "2"; }, null);
                }

                if (s4 > 0)  //发送给PLC RY值
                {
                    sc.Post(delegate { dataGridView1.Rows[40].Cells[1].Value = s4; }, null);
                    sc.Post(delegate { dataGridView1.Rows[48].Cells[1].Value = "1"; }, null);
                }
                else
                {
                    int N4 = s4 * (-1);
                    sc.Post(delegate { dataGridView1.Rows[40].Cells[1].Value = N4; }, null);
                    sc.Post(delegate { dataGridView1.Rows[48].Cells[1].Value = "2"; }, null);
                }


                if (s5 > 0)  //发送给PLC RZ值
                {
                    sc.Post(delegate { dataGridView1.Rows[42].Cells[1].Value = s5; }, null);
                    sc.Post(delegate { dataGridView1.Rows[12].Cells[1].Value = "1"; }, null);
                }
                else
                {
                    int N5 = s5 * (-1);
                    sc.Post(delegate { dataGridView1.Rows[42].Cells[1].Value = N5; }, null);
                    sc.Post(delegate { dataGridView1.Rows[12].Cells[1].Value = "2"; }, null);
                }



                //if (Convert.ToInt32(m[1]) > 0)  //发送给PLC Y值
                //{
                //    sc.Post(delegate { dataGridView1.Rows[34].Cells[1].Value = m[1]; }, null);
                //    sc.Post(delegate { dataGridView1.Rows[45].Cells[1].Value = "1"; }, null);
                //}
                //else
                //{
                //    int N1 = Convert.ToInt32(m[1]) * (-1);
                //    sc.Post(delegate { dataGridView1.Rows[34].Cells[1].Value = N1; }, null);
                //    sc.Post(delegate { dataGridView1.Rows[45].Cells[1].Value = "2"; }, null);
                //}

                //if (Convert.ToInt32(m[2]) > 0)  //发送给PLC Z值
                //{
                //    sc.Post(delegate { dataGridView1.Rows[36].Cells[1].Value = m[2]; }, null);
                //    sc.Post(delegate { dataGridView1.Rows[46].Cells[1].Value = "1"; }, null);
                //}
                //else
                //{
                //    int N2 = Convert.ToInt32(m[2]) * (-1);
                //    sc.Post(delegate { dataGridView1.Rows[36].Cells[1].Value = N2; }, null);
                //    sc.Post(delegate { dataGridView1.Rows[46].Cells[1].Value = "2"; }, null);
                //}

                //if (Convert.ToInt32(m[3]) > 0)  //发送给PLC RX值
                //{
                //    sc.Post(delegate { dataGridView1.Rows[38].Cells[1].Value = m[3]; }, null);
                //    sc.Post(delegate { dataGridView1.Rows[47].Cells[1].Value = "1"; }, null);
                //}
                //else
                //{
                //    int N3 = Convert.ToInt32(m[3]) * (-1);
                //    sc.Post(delegate { dataGridView1.Rows[38].Cells[1].Value = N3; }, null);
                //    sc.Post(delegate { dataGridView1.Rows[47].Cells[1].Value = "2"; }, null);
                //}

                //if (Convert.ToInt32(m[4]) > 0)  //发送给PLC RY值
                //{
                //    sc.Post(delegate { dataGridView1.Rows[40].Cells[1].Value = m[4]; }, null);
                //    sc.Post(delegate { dataGridView1.Rows[48].Cells[1].Value = "1"; }, null);
                //}
                //else
                //{
                //    int N4 = Convert.ToInt32(m[4]) * (-1);
                //    sc.Post(delegate { dataGridView1.Rows[40].Cells[1].Value = N4; }, null);
                //    sc.Post(delegate { dataGridView1.Rows[48].Cells[1].Value = "2"; }, null);
                //}


                //if (Convert.ToInt32(m[5]) > 0)  //发送给PLC RZ值
                //{
                //    sc.Post(delegate { dataGridView1.Rows[42].Cells[1].Value = m[5]; }, null);
                //    sc.Post(delegate { dataGridView1.Rows[12].Cells[1].Value = "1"; }, null);
                //}
                //else
                //{
                //    int N5 = Convert.ToInt32(m[5]) * (-1);
                //    sc.Post(delegate { dataGridView1.Rows[42].Cells[1].Value = N5; }, null);
                //    sc.Post(delegate { dataGridView1.Rows[12].Cells[1].Value = "2"; }, null);
                //}
                //结果标志位
                sc.Post(delegate { dataGridView1.Rows[6].Cells[1].Value = m[6]; }, null);
                //往寄存器里面写入数值
                WriteModbusTCPIP();
            }
            catch (Exception ex)
            {
                MessageBox.Show("解析TCP收到字符串失败！" + ex.ToString());
            }
        }
        public bool IsConnected(Socket TCPSocket)  //连接方法
        {
            if (TCPSocket == null)
                return false;
            // 另外说明：tcpc.Connected同tcpc.Client.Connected；
            // tcpc.Client.Connected只能表示Socket上次操作(send,recieve,connect等)时是否能正确连接到资源,
            // 不能用来表示Socket的实时连接状态。
            try
            {
                if ((TCPSocket.Poll(20, SelectMode.SelectRead)) && (TCPSocket.Available == 0))
                    return false;
            }
            //catch (SocketException e)
            //{
            //    if (e.NativeErrorCode != 10035)
            //        return false;
            //}
            catch
            {
                return false;
            }
            return true;

        }  

        private void timer1_Tick(object sender, EventArgs e) //定时器
        {
           // btn_Listen.PerformClick();
            if (!bgw_TCP.IsBusy)
            {
                bgw_TCP.RunWorkerAsync();
            }


        }

        private void bgw_TCP_DoWork_DoWork(object sender, DoWorkEventArgs e) //线程运行事件
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                IPAddress ip = IPAddress.Parse(IP_Client);
                IPEndPoint ipe = new IPEndPoint(ip, Port_Client);
                if (ClientSocket == null)
                {
                    ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    ClientSocket.Connect(ipe);
                }
                if (IsConnected(ClientSocket))
                {
                    sc.Post(delegate { lab_socket.BackColor = Color.Green; }, null); 
                    b_ConnClient = true;
                }
                else
                {
                    sc.Post(delegate { lab_socket.BackColor = Color.Red; }, null); 
                    b_ConnClient = false;
                }

                int i_Size = ClientSocket.ReceiveBufferSize;
                byte[] recByte = new byte[i_Size];
                int bytes = ClientSocket.Receive(recByte, recByte.Length, 0);
                recStr += Encoding.Default.GetString(recByte, 0, bytes);
                if (recStr == "")
                {
                    sc.Post(delegate { lab_socket.BackColor = Color.Red; }, null);                   
                    b_ConnClient = false;
                }
                else
                {

                }
            }
            catch (Exception)
            {
                sc.Post(delegate { lab_socket.BackColor = Color.Red; }, null);                
            }
        }

        private void bgw_TCP_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) //线程完成事件
        {
            if (!b_ConnClient)
            {
                ClientSocket = null;
            }
            else
            {
                Log_TCP("Receive:" + recStr);
                ReceiveJobResult_TCP(recStr.Split('\r')[0]);
                recStr = "";
            }
        }

        private void btn_TCPSend_Click(object sender, EventArgs e)  //将数据发送给双目软件
        {
            mds_send();           
        }

        private void Form1_Load(object sender, EventArgs e)  //界面加载
        {
            // 192.168.0.31
            comboBox2.Items.Add("127.0.0.1");

            //comboBox2.Items.Add("192.168.0.31");
            comboBox2.SelectedIndex = 0;
            //comboBox2.Text = ("127.0.0.1");
            //程序启动自动监听
            if (comboBox2.SelectedIndex == -1)
            {
                //端口号 5    502
                myServer = new ModbusTCP_Server(new IPEndPoint(IPAddress.Any, 503));
            }
            else
            {
                myServer = new ModbusTCP_Server(comboBox2.Text, 503);
            }
            myServer.ClientConnected += new EventHandler<TCPEventArgs>(myServer_ClientConnected);
            myServer.ClientDisconnected += new EventHandler<TCPEventArgs>(myServer_ClientDisconnected);
            myServer.ModbusTCPRequestReceived += new EventHandler<ModbusTCPRequestEventArgs>(myServer_ModbusTCPRequestReceived);
            myServer.ModbusTCPDataWrittenTo += new EventHandler<ModbusTCPDataEventArgs>(myServer_ModbusTCPDataWrittenTo);
            lab_modbustcp.BackColor = Color.Red;
            myServer.Start();

            btn_Listen.Text = "停止监听";

            for (int i = 0; i < 64; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].SetValues(i, 0);
            }


            timer1.Enabled = false;
            SettingSavePath = System.Windows.Forms.Application.StartupPath + "\\Settings";
            try
            {
                if (!Directory.Exists(SettingSavePath))
                {
                    Directory.CreateDirectory(SettingSavePath);
                }
            }
            catch (Exception)
            {
            }
            SettingPath_Comm = SettingSavePath + "\\Comm" + ".ini";
            using (StreamReader sReader = File.OpenText(SettingPath_Comm))
            {
                //从配置文件中逐行读取配置数据
                txt_IP_Comm.Text = sReader.ReadLine();
                txt_Port_Comm.Text = sReader.ReadLine();
                IP_Client = txt_IP_Comm.Text;
                try
                {
                    Port_Client = Convert.ToInt32(txt_Port_Comm.Text);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            timer1.Enabled = true;

            string strHostName = Dns.GetHostName();  //得到本机的主机名
            IPHostEntry ipEntry = Dns.GetHostByName(strHostName); //取得本机IP
            for (int i = 0; i < ipEntry.AddressList.Length; i++)
            {
                comboBox1.Items.Add(ipEntry.AddressList[i].ToString());
            }
            //192.168.0.31
            //comboBox2.Items.Add("127.0.0.1");
            comboBox1.SelectedIndex = 1;
            //comboBox3.SelectedIndex = 1;
            //comboBox4.SelectedIndex = 0;
            //comboBox5.SelectedIndex = 0;
            
        }

        private void btn_ModbustcpSend_Click(object sender, EventArgs e)  //双目发送数据给modbus-TCP/IP服务器
        {
            Byte[] buf;
            // Create a string defining the pose 
            String str = txt_FFP_X.Text + ";" +          // Ttanslation_X
                         txt_FFP_Y.Text + ";" +         // Translation_Y
                         txt_FFP_Z.Text + ";" +         // Translation_Z
                         txt_FFP_R1.Text + ";" +
                         txt_FFP_R2.Text + ";" +
                         txt_FFP_R3.Text + ";";

            // Add job, mode and part selector
            str += txt_FFP_Status.Text;
            Console.WriteLine(str);
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            buf = encoding.GetBytes(str);

            // Send it away....
            //ClientSocket.Write(buf, 0, buf.Length);
            ClientSocket.Send(buf);
        }

        private void btn_Listen_Click(object sender, EventArgs e) //modbustcp监听
        {
            if (btn_Listen.Text == "启动监听")
            {
                
                if (comboBox2.SelectedIndex == -1)
                {
                    //端口号 502
                    myServer = new ModbusTCP_Server(new IPEndPoint(IPAddress.Any, 503));
                }
                else
                {
                    myServer = new ModbusTCP_Server(comboBox2.Text, 503);
                }
                myServer.ClientConnected += new EventHandler<TCPEventArgs>(myServer_ClientConnected);
                myServer.ClientDisconnected += new EventHandler<TCPEventArgs>(myServer_ClientDisconnected);
                myServer.ModbusTCPRequestReceived += new EventHandler<ModbusTCPRequestEventArgs>(myServer_ModbusTCPRequestReceived);
                myServer.ModbusTCPDataWrittenTo += new EventHandler<ModbusTCPDataEventArgs>(myServer_ModbusTCPDataWrittenTo);
                myServer.Start();

                btn_Listen.Text = "停止监听";

                for (int i = 0; i < 63; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].SetValues(i, 0);
                }

            }
            else
            {
                myServer.Stop();
                btn_Listen.Text = "启动监听";
            }   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            DisplayType DisplayType_Cur = new DisplayType();
            foreach (DisplayType item in Enum.GetValues(typeof(DisplayType)))
            {
                if (GetDescription.description(item) == comboBox1.Text)
                {
                    DisplayType_Cur = item;
                    break;
                }
             }
            if (myServer != null)
            {
                string[] mNewData = myServer.DataFormatting(ModbusTCP.Server.RegisterType.HoldRegister, DisplayType_Cur, 1, dataGridView1.Rows.Count);
                for (int i = 0; i < mNewData.Length; i++)
                {
                    if (mNewData[i] == "")
                    {
                        dataGridView1.Rows[i].Cells[1].Value = "--";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[1].Value = mNewData[i];
                        //接收来自plc的数据的起始地址  ylf
                       
                        //显示PLC传过来的数据信息
                        if (i == 21)
                        {
                            string s1 = mNewData[i];

                            if (s1 == "1")
                            {
                                txt_TCP_X.Text = mNewData[15];
                            }
                            else {

                                double Dx = Convert.ToDouble(mNewData[15]);
                                Dx = Dx * (-1);
                                txt_TCP_X.Text = Dx.ToString();
                            }
                        }

                        if (i == 22)
                        {
                            string s1 = mNewData[i];

                            if (s1 == "1")
                            {
                                txt_TCP_Y.Text = mNewData[16];
                            }
                            else
                            {

                                double Dy = Convert.ToDouble(mNewData[16]);
                                Dy = Dy * (-1);
                                txt_TCP_Y.Text = Dy.ToString();
                            }
                        }


                        if (i == 23)
                        {
                            string s1 = mNewData[i];

                            if (s1 == "1")
                            {
                                txt_TCP_Z.Text = mNewData[17];
                            }
                            else
                            {

                                double Dq = Convert.ToDouble(mNewData[17]);
                                Dq = Dq * (-1);
                                txt_TCP_Z.Text = Dq.ToString();
                            }
                        }

                        if (i == 24)
                        {
                            string s1 = mNewData[i];

                            if (s1 == "1")
                            {
                                txt_TCP_R1.Text = mNewData[18];
                            }
                            else
                            {

                                double R1 = Convert.ToDouble(mNewData[18]);
                                R1 = R1 * (-1);
                                txt_TCP_R1.Text = R1.ToString();
                            }
                        }

                        if (i == 25)
                        {
                            string s1 = mNewData[i];

                            if (s1 == "1")
                            {
                                txt_TCP_R2.Text = mNewData[19];
                            }
                            else
                            {

                                double R2 = Convert.ToDouble(mNewData[19]);
                                R2 = R2 * (-1);
                                txt_TCP_R1.Text = R2.ToString();
                            }
                        }

                        if (i == 26)
                        {
                            string s1 = mNewData[i];

                            if (s1 == "1")
                            {
                                txt_TCP_R3.Text = mNewData[20];
                            }
                            else
                            {

                                double R3 = Convert.ToDouble(mNewData[20]);
                                R3 = R3 * (-1);
                                txt_TCP_R1.Text = R3.ToString();
                            }
                        }


                       if (i == 27)
                        {
                            txt_TCP_JobID.Text = mNewData[i];
                        }
                        else if (i == 28)
                        {
                            txt_TCP_ModeID.Text = mNewData[i];
                        }
                        else if (i == 29)
                        {
                            txt_TCP_PartSelector.Text = mNewData[i];
                        }
                        else if (i == 30)
                        {
                            txt_send.Text = mNewData[i];
                            if (txt_send.Text == "1")
                            {
                                mds_send();
                            }
                        }
                        
                    }
                }
                 
            }
        }   //寄存器数据显示格式

        #region dataGridView具体单元格双击修改
        DisplayType DisplayType_Cur = new DisplayType();
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            foreach (DisplayType item in Enum.GetValues(typeof(DisplayType)))
            {
                if (GetDescription.description(item) == comboBox2.Text)
                {
                    DisplayType_Cur = item;
                    break;
                }
            }
            if (e.ColumnIndex == 1)
            {
                FormEditRegister m = new FormEditRegister(this, dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value, 1, e.RowIndex, DisplayType_Cur);
                m.ShowDialog(this);
            }
        }
        
        #endregion
        //更新表格数据
        public bool UpdateDataGridView(DataGridView m_DataGridView, RegisterType RegisterType_Edit, DisplayType DisplayType_Cur)
        {
            bool bool_UpdateResult = false;
            try
            {
                string[] mNewData = myServer.DataFormatting(RegisterType_Edit, DisplayType_Cur, 1, m_DataGridView.Rows.Count);

                for (int i = 0; i < m_DataGridView.Rows.Count; i++)
                {
                    if (mNewData[i] == "")
                    {
                        m_DataGridView.Rows[i].Cells[1].Value = "--";
                    }
                    else
                    {
                        m_DataGridView.Rows[i].Cells[1].Value = mNewData[i];
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            bool_UpdateResult = true;
            return bool_UpdateResult;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (myServer != null)
                {
                    myServer.Stop();
                    myServer.ClientConnected -= new EventHandler<TCPEventArgs>(myServer_ClientConnected);
                    myServer.ClientDisconnected -= new EventHandler<TCPEventArgs>(myServer_ClientDisconnected);
                    myServer.ModbusTCPRequestReceived -= new EventHandler<ModbusTCPRequestEventArgs>(myServer_ModbusTCPRequestReceived);
                    myServer.ModbusTCPDataWrittenTo -= new EventHandler<ModbusTCPDataEventArgs>(myServer_ModbusTCPDataWrittenTo);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void WriteModbusTCPIP() {


            Control.CheckForIllegalCrossThreadCalls = false;
            DisplayType DisplayType_Cur = new DisplayType();
            foreach (DisplayType item in Enum.GetValues(typeof(DisplayType)))
            {
                if (GetDescription.description(item) == comboBox1.Text)
                {
                    DisplayType_Cur = item;
                    break;
                }
            }
            if (myServer != null)
            {
                string[] mNewData = myServer.DataFormatting(ModbusTCP.Server.RegisterType.HoldRegister, DisplayType_Cur, 1, dataGridView1.Rows.Count);

                //Form1 m_Form;
                //int m_Index;
                //DisplayType m_Type;
                //m_Index = RowIndex;
                //m_Form = mForm;
                //m_Type = mType;

                myServer.SetData(RegisterType.HoldRegister, dataGridView1.Rows.Count, mNewData, DisplayType_Cur);

                for (int i = 0; i < mNewData.Length; i++)
                {
                    if (mNewData[i] == "")
                    {
                        dataGridView1.Rows[i].Cells[1].Value = "--";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[1].Value = mNewData[i];
                        //接收来自plc的数据的起始地址

                    }
                }

            }
        
        
        }
 
        }
    }

