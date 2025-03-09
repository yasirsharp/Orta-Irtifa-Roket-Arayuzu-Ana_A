using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafız_IHO_Steam_Alcak_Irtif
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        #region Unnamed Variables
        string dataIn;
        string LogFilePath = "../../../Logs/Data-Log.txt";
        string errLogFilePath = "../../../Logs/Error-Log.txt";

        sbyte index_of_irtifa, index_of_enlem, index_of_boylam, index_of_kurtarma1, index_of_kurtarma2, index_of_gps_error;
        string irtifa;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] portNames = SerialPort.GetPortNames();
            ComPortBox.Items.AddRange(portNames);
            ComPortBox.Text = portNames[0];
            map.MapProvider = GMapProviders.GoogleMap;
            //map.DragButton = MouseButtons.Left;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        #region Com Port Open
        private void ComPortOpenButton_Click_1(object sender, EventArgs e)
        {
            ComPortOpen();
        }

        private void ComPortOpen()
        {
            try
            {
                seriP1.PortName = ComPortBox.Text;
                seriP1.Open();
                ComPortStatus.Value = 100;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Bir hatanız var!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Com Port Close
        private void ComPortCloseButton_Click(object sender, EventArgs e)
        {
            ComPortClose();
        }

        private void ComPortClose()
        {
            if (seriP1.IsOpen){
                seriP1.Close();
            }
            else
            {
                MessageBox.Show("Seri port zaten kapalı.", "Seri Port", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ComPortStatus.Value = 0;
        }
        #endregion

        #region Data in, print and processing

        #region Veri alma
        private void seriP1_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            dataIn = seriP1.ReadExisting(); //Örnek gelen veri - A1234B40.8401C31.1512FKX
            
            #region index of
            index_of_irtifa     = Convert.ToSByte(dataIn.IndexOf('A'));
            index_of_enlem      = Convert.ToSByte(dataIn.IndexOf('B'));
            index_of_boylam     = Convert.ToSByte(dataIn.IndexOf('C'));
            index_of_kurtarma1  = Convert.ToSByte(dataIn.IndexOf('F'));
            index_of_kurtarma2  = Convert.ToSByte(dataIn.IndexOf('K'));
            index_of_gps_error  = Convert.ToSByte(dataIn.IndexOf('X'));
            #endregion

            DataProcessing();
            LogData();
            this.Invoke(new EventHandler(ShowData));
        }
        #endregion

        #region Veri kayıt etme
        private void LogData() {
            try {
                File.AppendAllText(LogFilePath, $"{dataIn}  |  {DateTime.Now} \n");
            }
            catch (Exception err) {
                File.AppendAllText(errLogFilePath, $"Log Error - {err.Message}  |  {DateTime.Now} \n");
            }
        }
        #endregion

        #region Veri ekrana yazdırma
        private void ShowData(object sender, EventArgs e) {

            #region İrtifa
            try
            {
                if (index_of_enlem <= 0 && index_of_irtifa >= 0)
                {
                    irtifa = dataIn.Substring(index_of_irtifa + 1);
                    lblIrtifa.Text = $"İrtifa: {irtifa}";
                }
                if (index_of_enlem - index_of_irtifa > 7)
                {
                    irtifa = dataIn.Substring(index_of_irtifa + 1, 4);
                    lblIrtifa.Text = $"İrtifa: {irtifa}";
                }
                if (index_of_irtifa >= 0 && index_of_enlem >= 0 && index_of_enlem - index_of_irtifa < 7) {
                    irtifa = dataIn.Substring(index_of_irtifa + 1, (index_of_enlem - index_of_irtifa) - 1);
                    lblIrtifa.Text = $"İrtifa: {irtifa}";
                }
            }
            catch (Exception err)
            {
                File.AppendAllText(errLogFilePath, $"İrtifa - {err.Message}  |  {DateTime.Now} \n");
            }
            #endregion

            #region
            //DataInFromComPort.Text += dataIn;
            //DataInFromComPort.Text += dataIn.Substring(index_of_irtifa + 2, (index_of_enlem - index_of_irtifa) - 2);
            //DataInFromComPort.SelectionStart = DataInFromComPort.Text.Length;
            //DataInFromComPort.ScrollToCaret();
            #endregion
        }
        #endregion

        #region Veri işleme
        private void DataProcessing()
        {
            #region GMap
            try
            {
                if (index_of_enlem >= 0 && index_of_boylam >= 0 && index_of_boylam - index_of_enlem >= 4){
                    lblenlem.Text = dataIn.Replace('.', ',').Substring(index_of_enlem + 1, (index_of_boylam - index_of_enlem) - 1);
                    lblboylam.Text = dataIn.Replace('.', ',').Substring(index_of_boylam + 1, (index_of_boylam - index_of_enlem) - 1);
                    lblKonum.Text = $"Konum: {lblenlem.Text}/{lblboylam.Text}";
                }
                if (lblenlem.Text != "Enlem" && lblboylam.Text != "Boylam"){
                    map.MinZoom = 10;
                    map.MaxZoom = 1000;
                    map.Zoom = 15;
                    map.Position = new GMap.NET.PointLatLng(Convert.ToDouble(lblenlem.Text.Replace('.', ',')), Convert.ToDouble(lblboylam.Text.Replace('.', ',')));
                    label5.Text = map.Position.ToString();
                }
            }
            catch (Exception er)
            {
                File.AppendAllText(errLogFilePath, $"GMap.Net - {er.Message}  |  {DateTime.Now} \n");
            }
            #endregion

            #region Kurtarmalar
            if (index_of_kurtarma1 >= 0)
            {
                stKurtarma.BackColor = Color.LawnGreen;
            }
            if (index_of_kurtarma2 >= 0)
            {
                ndKurtarma.BackColor = Color.LawnGreen;
            }
            if (stKurtarma.BackColor == Color.LawnGreen)
            {
                stKurtarma.Text = "Kurtarma Aktif";
            }
            if (ndKurtarma.BackColor == Color.LawnGreen)
            {
                ndKurtarma.Text = "Kurtarma Aktif";
            }
            #endregion

            #region gps error
            if (index_of_gps_error >= 0 ) {
                btnGpsErr.BackColor = Color.DarkOrange;
                btnGpsErr.Text = "GPS Bağlanmadı";
            }
            #endregion
        }
        #endregion

        #endregion
    }
}