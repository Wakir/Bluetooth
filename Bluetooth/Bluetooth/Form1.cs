using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System.Windows.Forms;

namespace Bluetooth
{
    public partial class Form1 : Form
    {
        BluetoothDeviceInfo[] list;
        BluetoothAddress adres;
        public Form1()
        {
            InitializeComponent();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            BluetoothClient client = new BluetoothClient();
            list = client.DiscoverDevices();
            for(int i = 0; i < list.Length; i++)
            {
                listBox1.Items.Add(list[i].DeviceName);
            }
        }

        private void bpair_Click(object sender, EventArgs e)
        {
            string pin = "4321";
            BluetoothDeviceInfo device = list[listBox1.SelectedIndex];
            BluetoothSecurity.PairRequest(device.DeviceAddress, pin);
            adres = device.DeviceAddress;
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sciezka = fileDialog.FileName.Substring(fileDialog.FileName.LastIndexOf("\\"));
                Uri uri = new Uri("obex://" + adres.ToString() + "/" + sciezka);
                ObexWebRequest request = new ObexWebRequest(uri);
                request.ReadFile(fileDialog.FileName);
                ObexWebResponse response = (ObexWebResponse)request.GetResponse();
                response.Close();
            }
        }
    }
}
