namespace ModbusTCP
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox_modbustcp = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_Listen = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_FFP_R3 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_FFP_R2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_FFP_R1 = new System.Windows.Forms.TextBox();
            this.txt_FFP_Z = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txt_FFP_Y = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txt_FFP_X = new System.Windows.Forms.TextBox();
            this.btn_ModbustcpSend = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_FFP_Status = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_modbustcp = new System.Windows.Forms.Label();
            this.lab_socket = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_socket = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.btn_TCPSend = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_TCP_JobID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_TCP_PartSelector = new System.Windows.Forms.TextBox();
            this.txt_TCP_R3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_TCP_TimeStamp = new System.Windows.Forms.TextBox();
            this.txt_TCP_ModeID = new System.Windows.Forms.TextBox();
            this.txt_TCP_R2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_TCP_R1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_TCP_Z = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TCP_Y = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TCP_X = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SaveSetting = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_IP_Comm = new System.Windows.Forms.TextBox();
            this.txt_Port_Comm = new System.Windows.Forms.TextBox();
            this.textBox_TCP = new System.Windows.Forms.TextBox();
            this.bgw_TCP = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox_modbustcp.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox_socket.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lab_modbustcp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lab_socket, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.097928F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.90207F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1237, 580);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox_modbustcp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(621, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 528);
            this.panel2.TabIndex = 3;
            // 
            // groupBox_modbustcp
            // 
            this.groupBox_modbustcp.Controls.Add(this.comboBox1);
            this.groupBox_modbustcp.Controls.Add(this.groupBox4);
            this.groupBox_modbustcp.Controls.Add(this.groupBox3);
            this.groupBox_modbustcp.Controls.Add(this.dataGridView1);
            this.groupBox_modbustcp.Controls.Add(this.label1);
            this.groupBox_modbustcp.Location = new System.Drawing.Point(1, 3);
            this.groupBox_modbustcp.Name = "groupBox_modbustcp";
            this.groupBox_modbustcp.Size = new System.Drawing.Size(609, 525);
            this.groupBox_modbustcp.TabIndex = 1;
            this.groupBox_modbustcp.TabStop = false;
            this.groupBox_modbustcp.Text = "Modbustcp";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Signed",
            "Unsigned",
            "Hex",
            "Binary",
            "Long AB CD",
            "Long CD AB",
            "Long BA DC",
            "Long DC BA",
            "Float AB CD",
            "Float CD AB",
            "Float BA DC",
            "Float DC BA"});
            this.comboBox1.Location = new System.Drawing.Point(6, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 20);
            this.comboBox1.TabIndex = 58;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.btn_Listen);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(197, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(412, 352);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "信息监控：";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(17, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 116);
            this.listBox1.TabIndex = 37;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(17, 222);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(177, 118);
            this.textBox5.TabIndex = 36;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(216, 222);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(177, 118);
            this.textBox4.TabIndex = 35;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(216, 72);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 116);
            this.textBox3.TabIndex = 34;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(216, 196);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(127, 14);
            this.label28.TabIndex = 32;
            this.label28.Text = "数据区写入信息：";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(14, 196);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(142, 14);
            this.label29.TabIndex = 30;
            this.label29.Text = "客户端写请求信息：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(213, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(142, 14);
            this.label21.TabIndex = 28;
            this.label21.Text = "客户端读请求信息：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 14);
            this.label19.TabIndex = 26;
            this.label19.Text = "已接入客户端：";
            // 
            // btn_Listen
            // 
            this.btn_Listen.Location = new System.Drawing.Point(355, 13);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(48, 44);
            this.btn_Listen.TabIndex = 25;
            this.btn_Listen.Text = "启动监听";
            this.btn_Listen.UseVisualStyleBackColor = true;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(188, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 14);
            this.label17.TabIndex = 24;
            this.label17.Text = "端口号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "IP:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(255, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 23);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "503";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(44, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 22);
            this.comboBox2.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_FFP_R3);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txt_FFP_R2);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.txt_FFP_R1);
            this.groupBox3.Controls.Add(this.txt_FFP_Z);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.txt_FFP_Y);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.txt_FFP_X);
            this.groupBox3.Controls.Add(this.btn_ModbustcpSend);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txt_FFP_Status);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(197, 374);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 142);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据：";
            // 
            // txt_FFP_R3
            // 
            this.txt_FFP_R3.Location = new System.Drawing.Point(278, 49);
            this.txt_FFP_R3.Name = "txt_FFP_R3";
            this.txt_FFP_R3.Size = new System.Drawing.Size(79, 23);
            this.txt_FFP_R3.TabIndex = 65;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(261, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 14);
            this.label20.TabIndex = 64;
            this.label20.Text = ",";
            // 
            // txt_FFP_R2
            // 
            this.txt_FFP_R2.Location = new System.Drawing.Point(178, 49);
            this.txt_FFP_R2.Name = "txt_FFP_R2";
            this.txt_FFP_R2.Size = new System.Drawing.Size(79, 23);
            this.txt_FFP_R2.TabIndex = 63;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(161, 52);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 14);
            this.label22.TabIndex = 62;
            this.label22.Text = ",";
            // 
            // txt_FFP_R1
            // 
            this.txt_FFP_R1.Location = new System.Drawing.Point(78, 49);
            this.txt_FFP_R1.Name = "txt_FFP_R1";
            this.txt_FFP_R1.Size = new System.Drawing.Size(79, 23);
            this.txt_FFP_R1.TabIndex = 61;
            // 
            // txt_FFP_Z
            // 
            this.txt_FFP_Z.Location = new System.Drawing.Point(278, 15);
            this.txt_FFP_Z.Name = "txt_FFP_Z";
            this.txt_FFP_Z.Size = new System.Drawing.Size(79, 23);
            this.txt_FFP_Z.TabIndex = 60;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(261, 18);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(15, 14);
            this.label31.TabIndex = 59;
            this.label31.Text = ",";
            // 
            // txt_FFP_Y
            // 
            this.txt_FFP_Y.Location = new System.Drawing.Point(178, 15);
            this.txt_FFP_Y.Name = "txt_FFP_Y";
            this.txt_FFP_Y.Size = new System.Drawing.Size(79, 23);
            this.txt_FFP_Y.TabIndex = 58;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(161, 18);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(15, 14);
            this.label32.TabIndex = 57;
            this.label32.Text = ",";
            // 
            // txt_FFP_X
            // 
            this.txt_FFP_X.Location = new System.Drawing.Point(78, 15);
            this.txt_FFP_X.Name = "txt_FFP_X";
            this.txt_FFP_X.Size = new System.Drawing.Size(79, 23);
            this.txt_FFP_X.TabIndex = 56;
            // 
            // btn_ModbustcpSend
            // 
            this.btn_ModbustcpSend.Location = new System.Drawing.Point(219, 88);
            this.btn_ModbustcpSend.Name = "btn_ModbustcpSend";
            this.btn_ModbustcpSend.Size = new System.Drawing.Size(79, 29);
            this.btn_ModbustcpSend.TabIndex = 66;
            this.btn_ModbustcpSend.Text = "发送结果";
            this.btn_ModbustcpSend.Click += new System.EventHandler(this.btn_ModbustcpSend_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(361, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 14);
            this.label18.TabIndex = 40;
            this.label18.Text = ")";
            // 
            // txt_FFP_Status
            // 
            this.txt_FFP_Status.Location = new System.Drawing.Point(130, 92);
            this.txt_FFP_Status.Name = "txt_FFP_Status";
            this.txt_FFP_Status.Size = new System.Drawing.Size(80, 23);
            this.txt_FFP_Status.TabIndex = 53;
            this.txt_FFP_Status.Text = "1";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(51, 95);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(63, 14);
            this.label36.TabIndex = 54;
            this.label36.Text = "Status:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 53);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 14);
            this.label23.TabIndex = 35;
            this.label23.Text = " Rot  :(";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(361, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(15, 14);
            this.label24.TabIndex = 31;
            this.label24.Text = ")";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(11, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 14);
            this.label27.TabIndex = 22;
            this.label27.Text = "Trans:(";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(6, 57);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(186, 444);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "保持寄存器数值";
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "HoldingRegister：";
            // 
            // lab_modbustcp
            // 
            this.lab_modbustcp.AutoSize = true;
            this.lab_modbustcp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lab_modbustcp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_modbustcp.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_modbustcp.Location = new System.Drawing.Point(621, 0);
            this.lab_modbustcp.Name = "lab_modbustcp";
            this.lab_modbustcp.Size = new System.Drawing.Size(613, 46);
            this.lab_modbustcp.TabIndex = 1;
            this.lab_modbustcp.Text = "与PLC的Modbustcp通讯";
            this.lab_modbustcp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_socket
            // 
            this.lab_socket.AutoSize = true;
            this.lab_socket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lab_socket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_socket.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_socket.Location = new System.Drawing.Point(3, 0);
            this.lab_socket.Name = "lab_socket";
            this.lab_socket.Size = new System.Drawing.Size(612, 46);
            this.lab_socket.TabIndex = 0;
            this.lab_socket.Text = "与3D-Locate软件SOCKET通讯";
            this.lab_socket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_socket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 528);
            this.panel1.TabIndex = 2;
            // 
            // groupBox_socket
            // 
            this.groupBox_socket.Controls.Add(this.groupBox2);
            this.groupBox_socket.Controls.Add(this.groupBox1);
            this.groupBox_socket.Controls.Add(this.textBox_TCP);
            this.groupBox_socket.Location = new System.Drawing.Point(0, 3);
            this.groupBox_socket.Name = "groupBox_socket";
            this.groupBox_socket.Size = new System.Drawing.Size(609, 516);
            this.groupBox_socket.TabIndex = 0;
            this.groupBox_socket.TabStop = false;
            this.groupBox_socket.Text = "Socket";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.txt_send);
            this.groupBox2.Controls.Add(this.btn_TCPSend);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txt_TCP_JobID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_TCP_PartSelector);
            this.groupBox2.Controls.Add(this.txt_TCP_R3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_TCP_TimeStamp);
            this.groupBox2.Controls.Add(this.txt_TCP_ModeID);
            this.groupBox2.Controls.Add(this.txt_TCP_R2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_TCP_R1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_TCP_Z);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_TCP_Y);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_TCP_X);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(213, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 221);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据：";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(85, 194);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 14);
            this.label25.TabIndex = 45;
            this.label25.Text = "Send:";
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(135, 189);
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(48, 23);
            this.txt_send.TabIndex = 44;
            // 
            // btn_TCPSend
            // 
            this.btn_TCPSend.Location = new System.Drawing.Point(246, 164);
            this.btn_TCPSend.Name = "btn_TCPSend";
            this.btn_TCPSend.Size = new System.Drawing.Size(82, 30);
            this.btn_TCPSend.TabIndex = 43;
            this.btn_TCPSend.Text = "触发";
            this.btn_TCPSend.UseVisualStyleBackColor = true;
            this.btn_TCPSend.Click += new System.EventHandler(this.btn_TCPSend_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 14);
            this.label16.TabIndex = 42;
            this.label16.Text = "JobID:";
            // 
            // txt_TCP_JobID
            // 
            this.txt_TCP_JobID.Location = new System.Drawing.Point(98, 117);
            this.txt_TCP_JobID.Name = "txt_TCP_JobID";
            this.txt_TCP_JobID.Size = new System.Drawing.Size(48, 23);
            this.txt_TCP_JobID.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 14);
            this.label7.TabIndex = 34;
            this.label7.Text = "PartSelector:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 14);
            this.label12.TabIndex = 40;
            this.label12.Text = ")";
            // 
            // txt_TCP_PartSelector
            // 
            this.txt_TCP_PartSelector.Location = new System.Drawing.Point(135, 152);
            this.txt_TCP_PartSelector.Name = "txt_TCP_PartSelector";
            this.txt_TCP_PartSelector.Size = new System.Drawing.Size(48, 23);
            this.txt_TCP_PartSelector.TabIndex = 32;
            // 
            // txt_TCP_R3
            // 
            this.txt_TCP_R3.Location = new System.Drawing.Point(278, 50);
            this.txt_TCP_R3.Name = "txt_TCP_R3";
            this.txt_TCP_R3.Size = new System.Drawing.Size(79, 23);
            this.txt_TCP_R3.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 30;
            this.label8.Text = "ModeID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(261, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 14);
            this.label13.TabIndex = 38;
            this.label13.Text = ",";
            // 
            // txt_TCP_TimeStamp
            // 
            this.txt_TCP_TimeStamp.Location = new System.Drawing.Point(135, 82);
            this.txt_TCP_TimeStamp.Name = "txt_TCP_TimeStamp";
            this.txt_TCP_TimeStamp.Size = new System.Drawing.Size(167, 23);
            this.txt_TCP_TimeStamp.TabIndex = 23;
            // 
            // txt_TCP_ModeID
            // 
            this.txt_TCP_ModeID.Location = new System.Drawing.Point(261, 118);
            this.txt_TCP_ModeID.Name = "txt_TCP_ModeID";
            this.txt_TCP_ModeID.Size = new System.Drawing.Size(48, 23);
            this.txt_TCP_ModeID.TabIndex = 27;
            // 
            // txt_TCP_R2
            // 
            this.txt_TCP_R2.Location = new System.Drawing.Point(178, 50);
            this.txt_TCP_R2.Name = "txt_TCP_R2";
            this.txt_TCP_R2.Size = new System.Drawing.Size(79, 23);
            this.txt_TCP_R2.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 14);
            this.label6.TabIndex = 25;
            this.label6.Text = "TimeStamp:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(161, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 14);
            this.label14.TabIndex = 36;
            this.label14.Text = ",";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 14);
            this.label15.TabIndex = 35;
            this.label15.Text = " Rot  :(";
            // 
            // txt_TCP_R1
            // 
            this.txt_TCP_R1.Location = new System.Drawing.Point(78, 50);
            this.txt_TCP_R1.Name = "txt_TCP_R1";
            this.txt_TCP_R1.Size = new System.Drawing.Size(79, 23);
            this.txt_TCP_R1.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 14);
            this.label11.TabIndex = 31;
            this.label11.Text = ")";
            // 
            // txt_TCP_Z
            // 
            this.txt_TCP_Z.Location = new System.Drawing.Point(278, 17);
            this.txt_TCP_Z.Name = "txt_TCP_Z";
            this.txt_TCP_Z.Size = new System.Drawing.Size(79, 23);
            this.txt_TCP_Z.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 14);
            this.label10.TabIndex = 28;
            this.label10.Text = ",";
            // 
            // txt_TCP_Y
            // 
            this.txt_TCP_Y.Location = new System.Drawing.Point(178, 17);
            this.txt_TCP_Y.Name = "txt_TCP_Y";
            this.txt_TCP_Y.Size = new System.Drawing.Size(79, 23);
            this.txt_TCP_Y.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 14);
            this.label9.TabIndex = 24;
            this.label9.Text = ",";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 22;
            this.label5.Text = "Trans:(";
            // 
            // txt_TCP_X
            // 
            this.txt_TCP_X.Location = new System.Drawing.Point(78, 17);
            this.txt_TCP_X.Name = "txt_TCP_X";
            this.txt_TCP_X.Size = new System.Drawing.Size(79, 23);
            this.txt_TCP_X.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SaveSetting);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_IP_Comm);
            this.groupBox1.Controls.Add(this.txt_Port_Comm);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(7, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通讯设置：";
            // 
            // btn_SaveSetting
            // 
            this.btn_SaveSetting.Location = new System.Drawing.Point(16, 152);
            this.btn_SaveSetting.Name = "btn_SaveSetting";
            this.btn_SaveSetting.Size = new System.Drawing.Size(101, 30);
            this.btn_SaveSetting.TabIndex = 8;
            this.btn_SaveSetting.Text = "保存设置";
            this.btn_SaveSetting.UseVisualStyleBackColor = true;
            this.btn_SaveSetting.Click += new System.EventHandler(this.btn_SaveSetting_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "端口号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "IP:";
            // 
            // txt_IP_Comm
            // 
            this.txt_IP_Comm.Location = new System.Drawing.Point(12, 54);
            this.txt_IP_Comm.Name = "txt_IP_Comm";
            this.txt_IP_Comm.Size = new System.Drawing.Size(174, 23);
            this.txt_IP_Comm.TabIndex = 4;
            this.txt_IP_Comm.Text = "127.0.0.1";
            // 
            // txt_Port_Comm
            // 
            this.txt_Port_Comm.Location = new System.Drawing.Point(94, 96);
            this.txt_Port_Comm.Name = "txt_Port_Comm";
            this.txt_Port_Comm.Size = new System.Drawing.Size(91, 23);
            this.txt_Port_Comm.TabIndex = 5;
            this.txt_Port_Comm.Text = "502";
            // 
            // textBox_TCP
            // 
            this.textBox_TCP.Location = new System.Drawing.Point(6, 20);
            this.textBox_TCP.Multiline = true;
            this.textBox_TCP.Name = "textBox_TCP";
            this.textBox_TCP.Size = new System.Drawing.Size(597, 263);
            this.textBox_TCP.TabIndex = 0;
            // 
            // bgw_TCP
            // 
            this.bgw_TCP.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_TCP_DoWork_DoWork);
            this.bgw_TCP.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_TCP_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 580);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "ModbusTCP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox_modbustcp.ResumeLayout(false);
            this.groupBox_modbustcp.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox_socket.ResumeLayout(false);
            this.groupBox_socket.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lab_socket;
        private System.Windows.Forms.Label lab_modbustcp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_modbustcp;
        private System.Windows.Forms.GroupBox groupBox_socket;
        private System.Windows.Forms.TextBox textBox_TCP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_TCPSend;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_TCP_JobID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_TCP_PartSelector;
        private System.Windows.Forms.TextBox txt_TCP_R3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_TCP_TimeStamp;
        private System.Windows.Forms.TextBox txt_TCP_ModeID;
        private System.Windows.Forms.TextBox txt_TCP_R2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_TCP_R1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_TCP_Z;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_TCP_Y;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TCP_X;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SaveSetting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_IP_Comm;
        private System.Windows.Forms.TextBox txt_Port_Comm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_ModbustcpSend;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_FFP_Status;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label27;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txt_FFP_R3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_FFP_R2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_FFP_R1;
        private System.Windows.Forms.TextBox txt_FFP_Z;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txt_FFP_Y;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txt_FFP_X;
        private System.ComponentModel.BackgroundWorker bgw_TCP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_send;

    }
}

