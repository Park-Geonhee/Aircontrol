
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_Send = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_SendData = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_ReceiveData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_DBstatus = new System.Windows.Forms.Label();
            this.button_ClosePort = new System.Windows.Forms.Button();
            this.button_OpenPort = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Comport = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar_PortStatus = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_BPS = new System.Windows.Forms.ComboBox();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_Heater = new System.Windows.Forms.Button();
            this.button_Aircon = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_lwet = new System.Windows.Forms.Label();
            this.label_hwet = new System.Windows.Forms.Label();
            this.label_pwet = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_ltmp = new System.Windows.Forms.Label();
            this.label_htmp = new System.Windows.Forms.Label();
            this.label_ptmp = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.Min_wet = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.Max_wet = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Max_tmp = new System.Windows.Forms.Label();
            this.Min_tmp = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label12 = new System.Windows.Forms.Label();
            this.DTP_End_Date = new System.Windows.Forms.DateTimePicker();
            this.DTP_Start_Date = new System.Windows.Forms.DateTimePicker();
            this.DTP_End_Time = new System.Windows.Forms.DateTimePicker();
            this.DTP_Start_Time = new System.Windows.Forms.DateTimePicker();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_SelectAll = new System.Windows.Forms.Button();
            this.button_Select = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(12, 61);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 317);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_Send);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.button_Clear);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label_DBstatus);
            this.tabPage1.Controls.Add(this.button_ClosePort);
            this.tabPage1.Controls.Add(this.button_OpenPort);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.progressBar_PortStatus);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox_BPS);
            this.tabPage1.Controls.Add(this.comboBox_Port);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(752, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(658, 164);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 13;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_SendData);
            this.groupBox4.Location = new System.Drawing.Point(250, 152);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 121);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Send Data";
            // 
            // textBox_SendData
            // 
            this.textBox_SendData.Location = new System.Drawing.Point(14, 21);
            this.textBox_SendData.Name = "textBox_SendData";
            this.textBox_SendData.Size = new System.Drawing.Size(364, 21);
            this.textBox_SendData.TabIndex = 0;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(658, 43);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 11;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textBox_ReceiveData);
            this.groupBox2.Location = new System.Drawing.Point(250, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 122);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receive Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(7, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // textBox_ReceiveData
            // 
            this.textBox_ReceiveData.Location = new System.Drawing.Point(7, 21);
            this.textBox_ReceiveData.Multiline = true;
            this.textBox_ReceiveData.Name = "textBox_ReceiveData";
            this.textBox_ReceiveData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ReceiveData.Size = new System.Drawing.Size(371, 92);
            this.textBox_ReceiveData.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.label6.Location = new System.Drawing.Point(102, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 37);
            this.label6.TabIndex = 9;
            this.label6.Text = "Open";
            // 
            // label_DBstatus
            // 
            this.label_DBstatus.AutoSize = true;
            this.label_DBstatus.Location = new System.Drawing.Point(29, 244);
            this.label_DBstatus.Name = "label_DBstatus";
            this.label_DBstatus.Size = new System.Drawing.Size(60, 12);
            this.label_DBstatus.TabIndex = 8;
            this.label_DBstatus.Text = "DB Status";
            // 
            // button_ClosePort
            // 
            this.button_ClosePort.Enabled = false;
            this.button_ClosePort.Location = new System.Drawing.Point(19, 191);
            this.button_ClosePort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ClosePort.Name = "button_ClosePort";
            this.button_ClosePort.Size = new System.Drawing.Size(77, 34);
            this.button_ClosePort.TabIndex = 7;
            this.button_ClosePort.Text = "Close Port";
            this.button_ClosePort.UseVisualStyleBackColor = true;
            this.button_ClosePort.Click += new System.EventHandler(this.button_ClosePort_Click);
            // 
            // button_OpenPort
            // 
            this.button_OpenPort.Location = new System.Drawing.Point(19, 152);
            this.button_OpenPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_OpenPort.Name = "button_OpenPort";
            this.button_OpenPort.Size = new System.Drawing.Size(77, 34);
            this.button_OpenPort.TabIndex = 7;
            this.button_OpenPort.Text = "Open Port";
            this.button_OpenPort.UseVisualStyleBackColor = true;
            this.button_OpenPort.Click += new System.EventHandler(this.button_OpenPort_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Comport);
            this.groupBox1.Location = new System.Drawing.Point(102, 152);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(89, 72);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComPort";
            // 
            // label_Comport
            // 
            this.label_Comport.AutoSize = true;
            this.label_Comport.Font = new System.Drawing.Font("맑은 고딕", 20.25F);
            this.label_Comport.Location = new System.Drawing.Point(6, 15);
            this.label_Comport.Name = "label_Comport";
            this.label_Comport.Size = new System.Drawing.Size(64, 37);
            this.label_Comport.TabIndex = 0;
            this.label_Comport.Text = "OFF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Port status";
            // 
            // progressBar_PortStatus
            // 
            this.progressBar_PortStatus.Location = new System.Drawing.Point(100, 107);
            this.progressBar_PortStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar_PortStatus.Name = "progressBar_PortStatus";
            this.progressBar_PortStatus.Size = new System.Drawing.Size(121, 18);
            this.progressBar_PortStatus.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "BPS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port";
            // 
            // comboBox_BPS
            // 
            this.comboBox_BPS.FormattingEnabled = true;
            this.comboBox_BPS.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox_BPS.Location = new System.Drawing.Point(100, 66);
            this.comboBox_BPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_BPS.Name = "comboBox_BPS";
            this.comboBox_BPS.Size = new System.Drawing.Size(121, 20);
            this.comboBox_BPS.TabIndex = 1;
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(100, 24);
            this.comboBox_Port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Port.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_Heater);
            this.tabPage2.Controls.Add(this.button_Aircon);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.label_lwet);
            this.tabPage2.Controls.Add(this.label_hwet);
            this.tabPage2.Controls.Add(this.label_pwet);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label_ltmp);
            this.tabPage2.Controls.Add(this.label_htmp);
            this.tabPage2.Controls.Add(this.label_ptmp);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(752, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Monitoring";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_Heater
            // 
            this.button_Heater.Location = new System.Drawing.Point(664, 193);
            this.button_Heater.Name = "button_Heater";
            this.button_Heater.Size = new System.Drawing.Size(60, 51);
            this.button_Heater.TabIndex = 4;
            this.button_Heater.Text = "난방기 가동";
            this.button_Heater.UseVisualStyleBackColor = true;
            this.button_Heater.Click += new System.EventHandler(this.button_Heater_Click);
            // 
            // button_Aircon
            // 
            this.button_Aircon.Location = new System.Drawing.Point(664, 121);
            this.button_Aircon.Name = "button_Aircon";
            this.button_Aircon.Size = new System.Drawing.Size(60, 51);
            this.button_Aircon.TabIndex = 4;
            this.button_Aircon.Text = "에어컨 가동";
            this.button_Aircon.UseVisualStyleBackColor = true;
            this.button_Aircon.Click += new System.EventHandler(this.button_Aircon_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(261, 59);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "온도";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "습도";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(485, 227);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // label_lwet
            // 
            this.label_lwet.AutoSize = true;
            this.label_lwet.Location = new System.Drawing.Point(662, 44);
            this.label_lwet.Name = "label_lwet";
            this.label_lwet.Size = new System.Drawing.Size(11, 12);
            this.label_lwet.TabIndex = 2;
            this.label_lwet.Text = "0";
            // 
            // label_hwet
            // 
            this.label_hwet.AutoSize = true;
            this.label_hwet.Location = new System.Drawing.Point(440, 44);
            this.label_hwet.Name = "label_hwet";
            this.label_hwet.Size = new System.Drawing.Size(11, 12);
            this.label_hwet.TabIndex = 2;
            this.label_hwet.Text = "0";
            // 
            // label_pwet
            // 
            this.label_pwet.AutoSize = true;
            this.label_pwet.Location = new System.Drawing.Point(178, 44);
            this.label_pwet.Name = "label_pwet";
            this.label_pwet.Size = new System.Drawing.Size(11, 12);
            this.label_pwet.TabIndex = 2;
            this.label_pwet.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(618, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 2;
            this.label18.Text = "습도 : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(396, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "습도 : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(134, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "습도 : ";
            // 
            // label_ltmp
            // 
            this.label_ltmp.AutoSize = true;
            this.label_ltmp.Location = new System.Drawing.Point(574, 44);
            this.label_ltmp.Name = "label_ltmp";
            this.label_ltmp.Size = new System.Drawing.Size(11, 12);
            this.label_ltmp.TabIndex = 2;
            this.label_ltmp.Text = "0";
            // 
            // label_htmp
            // 
            this.label_htmp.AutoSize = true;
            this.label_htmp.Location = new System.Drawing.Point(352, 44);
            this.label_htmp.Name = "label_htmp";
            this.label_htmp.Size = new System.Drawing.Size(11, 12);
            this.label_htmp.TabIndex = 2;
            this.label_htmp.Text = "0";
            // 
            // label_ptmp
            // 
            this.label_ptmp.AutoSize = true;
            this.label_ptmp.Location = new System.Drawing.Point(90, 44);
            this.label_ptmp.Name = "label_ptmp";
            this.label_ptmp.Size = new System.Drawing.Size(11, 12);
            this.label_ptmp.TabIndex = 2;
            this.label_ptmp.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(530, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "온도 : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(308, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "온도 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "온도 : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 10F);
            this.label15.Location = new System.Drawing.Point(549, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 14);
            this.label15.TabIndex = 1;
            this.label15.Text = "최저 온도, 습도";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 10F);
            this.label9.Location = new System.Drawing.Point(327, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 14);
            this.label9.TabIndex = 1;
            this.label9.Text = "최고 온도, 습도";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 10F);
            this.label7.Location = new System.Drawing.Point(79, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 14);
            this.label7.TabIndex = 1;
            this.label7.Text = "현재 온도, 습도";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(232, 224);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.Min_wet);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.Max_wet);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.Max_tmp);
            this.tabPage3.Controls.Add(this.Min_tmp);
            this.tabPage3.Controls.Add(this.listView2);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.DTP_End_Date);
            this.tabPage3.Controls.Add(this.DTP_Start_Date);
            this.tabPage3.Controls.Add(this.DTP_End_Time);
            this.tabPage3.Controls.Add(this.DTP_Start_Time);
            this.tabPage3.Controls.Add(this.chart2);
            this.tabPage3.Controls.Add(this.button_SelectAll);
            this.tabPage3.Controls.Add(this.button_Select);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(752, 291);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "History";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(660, 221);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 12);
            this.label25.TabIndex = 8;
            this.label25.Text = "최저 습도 :";
            // 
            // Min_wet
            // 
            this.Min_wet.AutoSize = true;
            this.Min_wet.Location = new System.Drawing.Point(723, 221);
            this.Min_wet.Name = "Min_wet";
            this.Min_wet.Size = new System.Drawing.Size(11, 12);
            this.Min_wet.TabIndex = 8;
            this.Min_wet.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(660, 190);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 8;
            this.label24.Text = "최고 습도 :";
            // 
            // Max_wet
            // 
            this.Max_wet.AutoSize = true;
            this.Max_wet.Location = new System.Drawing.Point(723, 190);
            this.Max_wet.Name = "Max_wet";
            this.Max_wet.Size = new System.Drawing.Size(11, 12);
            this.Max_wet.TabIndex = 8;
            this.Max_wet.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(660, 128);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 8;
            this.label23.Text = "최고 온도 :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(660, 159);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 8;
            this.label22.Text = "최저 온도 :";
            // 
            // Max_tmp
            // 
            this.Max_tmp.AutoSize = true;
            this.Max_tmp.Location = new System.Drawing.Point(723, 128);
            this.Max_tmp.Name = "Max_tmp";
            this.Max_tmp.Size = new System.Drawing.Size(11, 12);
            this.Max_tmp.TabIndex = 8;
            this.Max_tmp.Text = "0";
            // 
            // Min_tmp
            // 
            this.Min_tmp.AutoSize = true;
            this.Min_tmp.Location = new System.Drawing.Point(723, 159);
            this.Min_tmp.Name = "Min_tmp";
            this.Min_tmp.Size = new System.Drawing.Size(11, 12);
            this.Min_tmp.TabIndex = 8;
            this.Min_tmp.Text = "0";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(20, 74);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(264, 212);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 10F);
            this.label12.Location = new System.Drawing.Point(266, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 14);
            this.label12.TabIndex = 6;
            this.label12.Text = "~";
            // 
            // DTP_End_Date
            // 
            this.DTP_End_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_End_Date.Location = new System.Drawing.Point(290, 47);
            this.DTP_End_Date.Name = "DTP_End_Date";
            this.DTP_End_Date.Size = new System.Drawing.Size(117, 21);
            this.DTP_End_Date.TabIndex = 5;
            // 
            // DTP_Start_Date
            // 
            this.DTP_Start_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Start_Date.Location = new System.Drawing.Point(20, 47);
            this.DTP_Start_Date.Name = "DTP_Start_Date";
            this.DTP_Start_Date.Size = new System.Drawing.Size(117, 21);
            this.DTP_Start_Date.TabIndex = 5;
            this.DTP_Start_Date.Value = new System.DateTime(2021, 6, 8, 0, 0, 0, 0);
            // 
            // DTP_End_Time
            // 
            this.DTP_End_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_End_Time.Location = new System.Drawing.Point(411, 47);
            this.DTP_End_Time.Name = "DTP_End_Time";
            this.DTP_End_Time.ShowUpDown = true;
            this.DTP_End_Time.Size = new System.Drawing.Size(119, 21);
            this.DTP_End_Time.TabIndex = 5;
            // 
            // DTP_Start_Time
            // 
            this.DTP_Start_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_Start_Time.Location = new System.Drawing.Point(141, 47);
            this.DTP_Start_Time.Name = "DTP_Start_Time";
            this.DTP_Start_Time.ShowUpDown = true;
            this.DTP_Start_Time.Size = new System.Drawing.Size(119, 21);
            this.DTP_Start_Time.TabIndex = 5;
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(290, 74);
            this.chart2.Name = "chart2";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "온도";
            series7.YValuesPerPoint = 4;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "습도";
            this.chart2.Series.Add(series7);
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(456, 212);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // button_SelectAll
            // 
            this.button_SelectAll.Location = new System.Drawing.Point(610, 47);
            this.button_SelectAll.Name = "button_SelectAll";
            this.button_SelectAll.Size = new System.Drawing.Size(123, 21);
            this.button_SelectAll.TabIndex = 2;
            this.button_SelectAll.Text = "전체 기간 검색";
            this.button_SelectAll.UseVisualStyleBackColor = true;
            this.button_SelectAll.Click += new System.EventHandler(this.button_SelectAll_Click);
            // 
            // button_Select
            // 
            this.button_Select.Location = new System.Drawing.Point(545, 47);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(59, 21);
            this.button_Select.TabIndex = 2;
            this.button_Select.Text = "검색";
            this.button_Select.UseVisualStyleBackColor = true;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(17, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(162, 16);
            this.label20.TabIndex = 0;
            this.label20.Text = "저장 데이터 불러오기";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(752, 291);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Control";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Size = new System.Drawing.Size(752, 291);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Warehouse";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage6.Size = new System.Drawing.Size(752, 291);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Exit";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(752, 291);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Calculater";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(308, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "공조관리시스템";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(707, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "ver 1.0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "공조관리시스템";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_DBstatus;
        private System.Windows.Forms.Button button_ClosePort;
        private System.Windows.Forms.Button button_OpenPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Comport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar_PortStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_BPS;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_SendData;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_ReceiveData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label_lwet;
        private System.Windows.Forms.Label label_hwet;
        private System.Windows.Forms.Label label_pwet;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_ltmp;
        private System.Windows.Forms.Label label_htmp;
        private System.Windows.Forms.Label label_ptmp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button button_Aircon;
        private System.Windows.Forms.Button button_Heater;
        private System.Windows.Forms.DateTimePicker DTP_Start_Time;
        private System.Windows.Forms.DateTimePicker DTP_Start_Date;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker DTP_End_Date;
        private System.Windows.Forms.DateTimePicker DTP_End_Time;
        private System.Windows.Forms.Button button_SelectAll;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label Min_wet;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label Max_wet;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label Max_tmp;
        private System.Windows.Forms.Label Min_tmp;
    }
}

