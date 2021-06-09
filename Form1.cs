using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; // Add for UART communication
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //temparature:33
        //humidity:40
        string data_in; // 아두이노로부터 \n을 만날 때까지 읽어들인 데이터를 저장하는 공간
        string[] InputSensorData;
        string tmp; //온도값을 저장
        string wet; //습도값을 저장

        int htmp = 0; int ltmp = 40;
        int hwet = 0; int lwet = 80;

        int[] temperArray = new int[30]; // 온도값 table array
        int[] humiArray = new int[30]; // 습도값 table array

        bool Aircon_Execute = false;
        bool Heater_Execute = false;

        int i = 0;

        //서버와 연결
        string connStr = String.Format("server={0};user={1};database={2};port=3306;password={3}"
                   , "192.168.56.1", "Park", "php_db", "4415");

        public MySqlDb mySqlDb
        {
            get; set;
        }
        public Form1()
        {
            InitializeComponent();

            //Set up
            getAbilablePorts();
            //timer 주기를 생성
            timer1.Interval = 1000; //1000ms 설정
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tmp != null || wet != null)
            {
                // table display
                monitor_table();
                // chart display
                monitor_chart();
                // DB save <- 본인이 직접 수행
                DB_save();
            }
        }

        void monitor_table()
        {
            ListViewItem item = new ListViewItem(tmp.ToString());

            // item.Subitems.Add
            //item.SubItems.Add(tmp);
            item.SubItems.Add(wet);
            string now_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            item.SubItems.Add(now_date);

            listView1.Items.Add(item);
        }
        
        void monitor_chart()
        {
            //배열 마지막 칸에 값을 넣는다
            temperArray[temperArray.Length - 1] = int.Parse(tmp);
            humiArray[humiArray.Length - 1] = int.Parse(wet);

            //값을 한칸씩 앞으로 당긴다
            for (int i = 0; i < temperArray.Length - 1; i++)
            {
                temperArray[i] = temperArray[i + 1];
                humiArray[i] = humiArray[i + 1];
            }

            chart1.Series[0].Points.Clear(); //온도그래프
            chart1.Series[1].Points.Clear(); //습도그래프

            for (int i = 0; i < temperArray.Length - 1; i++)
            {
                chart1.Series[0].Points.AddXY(i, temperArray[i]);
                chart1.Series[1].Points.AddXY(i, humiArray[i]);
            }
        }

        void DB_save()
        {
            
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            
            string now_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            String query = String.Format("INSERT INTO sensors (tmp, wet, data_day) VALUES ('{0}', '{1}',  '{2}')",
                            tmp, wet, now_date);

            MySqlCommand cmd_insert = new MySqlCommand(query, conn);

            cmd_insert.ExecuteNonQuery();

        }

        //PC에 연결된 COM Port List를 가져옴.
        void getAbilablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox_Port.Items.AddRange(ports);
        }


        // 아두이노로부터 1byte가 수신되면 자동으로 수행되는 rx interrupt 서비스 루틴
        // call back function
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //아두이노로부터 들어온 data 전체를 읽어 들임
            // data_in = serialPort1.ReadExisting();

            //아두이노로부터 \n을 만날때까지만의 dat를 읽어 들임
            data_in = serialPort1.ReadLine();

            //ReadLine 이 ReadExisting 보다 안정적이고 programming 에도 용이

            // 현재 전송 속도가 9600bps로 설정되어 있음. 1byte를 받아 들이는데 약 1ms 소요
            // 전송속도가 115200bps로 되어 있으면 1byte를 받아 들이는데 약 0.1ms 소요
            // 전송 속도와 비교하여 시간이 over되지 않도록 program 작성에 유의
            // 속도 지연이 되면 수신된 data를 놓일 수 있다.

            this.Invoke(new EventHandler(ShowData));
        }
        private void ShowData(object sender, EventArgs e)
        {
            textBox_ReceiveData.Text += data_in;

            if (data_in.Contains("temperature:") == true)  //온도 정보 읽기
            {
                InputSensorData = data_in.Split(':');
                tmp = InputSensorData[1].ToString();
                label_ptmp.Text = tmp;

                //int tmp_int = Convert.ToInt32(tmp);

                if (htmp < Convert.ToInt32(tmp)) // 최고 온도값 저장
                {
                    htmp = Convert.ToInt32(tmp);
                    label_htmp.Text = htmp.ToString();
                }
                if (ltmp > Convert.ToInt32(tmp)) // 최저 온도값 저장
                {
                    ltmp = Convert.ToInt32(tmp);
                    label_ltmp.Text = ltmp.ToString();
                }

            }
            if (data_in.Contains("humidity:") == true) //습도 정보 읽기
            {
                InputSensorData = data_in.Split(':');
                wet = InputSensorData[1].ToString();
                label_pwet.Text = wet;

                if (hwet < Convert.ToInt32(wet)) // 최고 습도값 저장
                {
                    hwet = Convert.ToInt32(wet);
                    label_hwet.Text = hwet.ToString();
                }
                if (lwet > Convert.ToInt32(wet)) // 최저 습도값 저장
                {
                    lwet = Convert.ToInt32(wet);
                    label_lwet.Text = lwet.ToString();
                }
            }
            if (Convert.ToInt32(tmp) >= 25 && Convert.ToInt32(wet) >= 60)
            {
                button_Aircon.Enabled = true;
            }
            if(Convert.ToInt32(tmp)<25 || Convert.ToInt32(wet)<60)
            {
                button_Aircon.Enabled = false;
                Aircon_Execute = false;
                button_Aircon.Text = "에어컨 가동";
            }
            if (Convert.ToInt32(tmp) < 10)
            {
                button_Heater.Enabled = true;
            }
            if(Convert.ToInt32(tmp) >= 10)
            {
                button_Heater.Enabled = false;
                Heater_Execute = false;
                button_Heater.Text = "난방기 가동";
            }
        }

        private void button_OpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_Port.Text == "" || comboBox_BPS.Text == "")
                {
                    textBox_ReceiveData.Text = "UART Com Port Select!" + Environment.NewLine;
                }
                else
                {
                    serialPort1.PortName = comboBox_Port.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox_BPS.Text);
                    serialPort1.Open(); //예외 처리 집어넣기
                    progressBar_PortStatus.Value = 100;
                    label_Comport.Text = "ON";
                    label_Comport.ForeColor = Color.Green;
                    //버튼 활성화 혹은 비활성화
                    button_Send.Enabled = true;
                    button_Clear.Enabled = true;
                    textBox_SendData.Enabled = true;
                    textBox_ReceiveData.Enabled = true;
                    button_OpenPort.Enabled = false;
                    button_ClosePort.Enabled = true;

                    timer1.Start();     //실시간으로 chart listview를 보여 줌

                    //DB 연결 확인 루틴 여기에 insert

                }
            }
            catch (UnauthorizedAccessException)
            {
                textBox_ReceiveData.Text = "URAT Open Exception Error" + Environment.NewLine;
            }
        }



        private void button_ClosePort_Click(object sender, EventArgs e)
        {
            serialPort1.Close(); //예외 처리 집어넣기
            progressBar_PortStatus.Value = 100;
            label_Comport.Text = "OFF";
            label_Comport.ForeColor = Color.Red;

            //버튼 활성화 혹은 비활성화
            button_Send.Enabled = false;
            textBox_SendData.Enabled = false;
            textBox_ReceiveData.Enabled = false;
            button_OpenPort.Enabled = true;
            button_ClosePort.Enabled = false;

            timer1.Stop();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_ReceiveData.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();

            
            //monitoring list view
            listView1.View = View.Details;
            listView1.Columns.Add("온도", 40);
            listView1.Columns.Add("습도", 40);
            listView1.Columns.Add("측정시각", 130);

            listView2.View = View.Details;
            listView2.Columns.Add("온도", 40);
            listView2.Columns.Add("습도", 40);
            listView2.Columns.Add("측정시각", 160);
        }

        private void button_Aircon_Click(object sender, EventArgs e)
        {
            Aircon_Execute = !Aircon_Execute;
            if (Aircon_Execute == true)
                button_Aircon.Text = "에어컨 중지";
            else
                button_Aircon.Text = "에어컨 가동";
            
        }

        private void button_Heater_Click(object sender, EventArgs e)
        {
            Heater_Execute = !Heater_Execute;
            if (Heater_Execute == true)
                button_Heater.Text = "난방기 중지";
            else
                button_Heater.Text = "난방기 가동";
        }


        private void button_SelectAll_Click(object sender, EventArgs e)
        {
            
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            listView2.Items.Clear();
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            i = 0;

            string sql_sel = string.Format("select * from sensors");

            MySqlCommand cmd = new MySqlCommand(sql_sel, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                
                ListViewItem selecteditem = new ListViewItem(rdr[1].ToString());

                selecteditem.SubItems.Add(rdr[2].ToString());
                selecteditem.SubItems.Add(rdr[3].ToString());

                listView2.Items.Add(selecteditem);

                chart2.Series[0].Points.AddXY(i, rdr[1]);
                chart2.Series[1].Points.AddXY(i, rdr[2]);
                i++;

            }

            rdr.Close();

            string call_Maxtmp = string.Format("select max(tmp) from sensors");
            MySqlCommand cmd_maxt = new MySqlCommand(call_Maxtmp, conn);
            MySqlDataReader rd_maxt = cmd_maxt.ExecuteReader();
            rd_maxt.Read();
            Max_tmp.Text = rd_maxt[0].ToString();
            rd_maxt.Close();

            string call_Mintmp = string.Format("select min(tmp) from sensors");
            MySqlCommand cmd_mint = new MySqlCommand(call_Mintmp, conn);
            MySqlDataReader rd_mint = cmd_mint.ExecuteReader();
            rd_mint.Read();
            Min_tmp.Text = rd_mint[0].ToString();
            rd_mint.Close();

            string call_Maxwet = string.Format("select max(wet) from sensors");
            MySqlCommand cmd_maxw = new MySqlCommand(call_Maxwet, conn);
            MySqlDataReader rd_maxw = cmd_maxw.ExecuteReader();
            rd_maxw.Read();
            Max_wet.Text = rd_maxw[0].ToString();
            rd_maxw.Close();

            string call_Minwet = string.Format("select min(wet) from sensors");
            MySqlCommand cmd_minw = new MySqlCommand(call_Minwet, conn);
            MySqlDataReader rd_minw = cmd_minw.ExecuteReader();
            rd_minw.Read();
            Min_wet.Text = rd_minw[0].ToString();
            rd_minw.Close();

        }

        private void button_Select_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            listView2.Items.Clear();

            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            i = 0;

            DateTime date_from = DTP_Start_Date.Value.Date + DTP_Start_Time.Value.TimeOfDay;
            DateTime date_to = DTP_End_Date.Value.Date + DTP_End_Time.Value.TimeOfDay;

            String date_start = date_from.ToString("yyyy-MM-dd HH:mm:ss");
            String date_end = date_to.ToString("yyyy-MM-dd HH:mm:ss");

            string sql_sel = string.Format("select * from sensors where data_day >= '{0}' and data_day <='{1}';", date_start,date_end);

            MySqlCommand cmd = new MySqlCommand(sql_sel, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                ListViewItem selecteditem = new ListViewItem(rdr[1].ToString());

                selecteditem.SubItems.Add(rdr[2].ToString());
                selecteditem.SubItems.Add(rdr[3].ToString());

                listView2.Items.Add(selecteditem);

                chart2.Series[0].Points.AddXY(i, rdr[1]);
                chart2.Series[1].Points.AddXY(i, rdr[2]);
                i++;

            }
            rdr.Close();

            string call_Max_tmp = string.Format("select max(tmp) FROM sensors WHERE data_day >= '{0}' AND data_day <= '{1}'"
                , date_start, date_end);
            MySqlCommand cmd_maxt = new MySqlCommand(call_Max_tmp, conn);
            MySqlDataReader rd_maxt = cmd_maxt.ExecuteReader();
            rd_maxt.Read();
            Max_tmp.Text = rd_maxt[0].ToString();
            rd_maxt.Close();

            
            string call_Min_tmp = string.Format("select min(tmp) FROM sensors WHERE data_day >= '{0}' AND data_day <= '{1}'"
                , date_start, date_end);
            MySqlCommand cmd_mint = new MySqlCommand(call_Min_tmp, conn);
            MySqlDataReader rd_mint = cmd_mint.ExecuteReader();
            rd_mint.Read();
            Min_tmp.Text = rd_mint[0].ToString();
            rd_mint.Close();

            string call_Max_wet = string.Format("select max(wet) FROM sensors WHERE data_day >= '{0}' AND data_day <= '{1}'"
                , date_start, date_end);
            MySqlCommand cmd_maxw = new MySqlCommand(call_Max_wet, conn);
            MySqlDataReader rd_maxw = cmd_maxw.ExecuteReader();
            rd_maxw.Read();
            Max_wet.Text = rd_maxw[0].ToString();
            rd_maxw.Close();

            string call_Min_wet = string.Format("select min(wet) FROM sensors WHERE data_day >= '{0}' AND data_day <= '{1}'"
                , date_start, date_end);
            MySqlCommand cmd_minw = new MySqlCommand(call_Min_wet, conn);
            MySqlDataReader rd_minw = cmd_minw.ExecuteReader();
            rd_minw.Read();
            Min_wet.Text = rd_minw[0].ToString();
            rd_minw.Close();

        }

    }
}
