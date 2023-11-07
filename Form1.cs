using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NetzwerkRechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class MyObject
        {
            public string Label { get; set; }
            public string Value { get; set; }
        }

        private void chk_mask_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mask.Checked)
            {
                txt_mask.Visible = true;
                lbl_mask.Visible = true;
            }
            else
            {
                txt_mask.Visible = false;
                lbl_mask.Visible = false;
            }




        }

        private void lbl_what_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_noip.Checked)
            {
                txt_noip.Visible = true;
                lbl_noip.Visible = true;
            }
            else
            {
                txt_noip.Visible = false;
                lbl_noip.Visible = false;
            }
        }

        private void chk_substeps_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hostmin.Checked)
            {
                txt_hostmin.Visible = true;
                lbl_hostmin.Visible = true;
            }
            else
            {
                txt_hostmin.Visible = false;
                lbl_hostmin.Visible = false;
            }
        }

        private void chk_asub_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hostmax.Checked)
            {
                txt_hostmax.Visible = true;
                lbl_hostmax.Visible = true;
            }
            else
            {
                txt_hostmax.Visible = false;
                lbl_hostmax.Visible = false;
            }
        }

        private void chk_netzid_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_netzid.Checked)
            {
                txt_netzid.Visible = true;
                lbl_netzid.Visible = true;
            }
            else
            {
                txt_netzid.Visible = false;
                lbl_netzid.Visible = false;
            }
        }

        private void chk_bc_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_bc.Checked)
            {
                txt_bc.Visible = true;
                lbl_bc.Visible = true;
            }
            else
            {
                txt_bc.Visible = false;
                lbl_bc.Visible = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            this.Close();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            //Error telling

            string ip1 = txt_ip1.Text;
            string ip2 = txt_ip2.Text;
            string ip3 = txt_ip3.Text;
            string ip4 = txt_ip4.Text;


            if (String.IsNullOrEmpty(ip1) || String.IsNullOrEmpty(ip2) || String.IsNullOrEmpty(ip3) || String.IsNullOrEmpty(ip4))
            {
                string message = "Your entered IP address is invalid, \nplease correct your entry.";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }


            // Checking Checked Menu
            else if (!chk_mask.Checked && !chk_noip.Checked && !chk_hostmin.Checked && !chk_hostmax.Checked && !chk_netzid.Checked && !chk_bc.Checked)
            {
                string message = "At least one must be selected";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);

            }
            //Checking is Mask Box empty

            else if (string.IsNullOrEmpty(cobo_mask.Text))
            {
                string message = "At least one mask must be selected";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }

            //Calc Mask
            int subnetBits = int.Parse(cobo_mask.SelectedIndex.ToString());
            if (subnetBits >= 0 && subnetBits <= 31)
            {
                uint decimalMask = (uint.MaxValue << (31 - subnetBits)) & uint.MaxValue;
                byte[] bytes = BitConverter.GetBytes(decimalMask);
                if (BitConverter.IsLittleEndian)
                {
                    Array.Reverse(bytes);
                }
                IPAddress subnetMaskCalc = new IPAddress(bytes);
                txt_mask.Text = subnetMaskCalc.ToString();
            }
            else
            {
                txt_mask.Text = "Ungültige Eingabe";
            }

            //Split Subnetmask

            string subnetMask = txt_mask.Text;
            string[] octets = subnetMask.Split('.');
            int[] octetValues = new int[4];
            string[] binaryOctets = new string[4];

            for (int i = 0; i < 4; i++)
            {
                octetValues[i] = int.Parse(octets[i]);
                binaryOctets[i] = Convert.ToString(octetValues[i], 2).PadLeft(8, '0');
            }


            //Calc how many 0
            string[] binaryOctetsCalc = new string[4];

            int totalZeroes = 0;

            for (int i = 0; i < 4; i++)
            {
                int zeroCount = binaryOctets[i].Count(c => c == '0');
                totalZeroes += zeroCount;
            }

            //Calc how many IpAdresses
            double NumberOfIPsResult = Math.Pow(2, totalZeroes) - 2;


            txt_noip.Text = NumberOfIPsResult.ToString();



            //calc Netid + bc + first & last valid ip
            string ip = ip1 + "." + ip2 + "." + ip3 + "." + ip4;
            IPAddress ipAddr = IPAddress.Parse(ip);
            IPAddress subnetMaskAddr = IPAddress.Parse(subnetMask);

            byte[] ipBytes = ipAddr.GetAddressBytes();
            byte[] subnetBytes = subnetMaskAddr.GetAddressBytes();

            byte[] broadcastBytes = new byte[ipBytes.Length];
            byte[] networkBytes = new byte[ipBytes.Length];

            for (int i = 0; i < broadcastBytes.Length; i++)
            {
                broadcastBytes[i] = (byte)(ipBytes[i] | (subnetBytes[i] ^ 255));
                networkBytes[i] = (byte)(ipBytes[i] & subnetBytes[i]);
            }

            IPAddress broadcastAddr = new IPAddress(broadcastBytes);
            IPAddress networkAddr = new IPAddress(networkBytes);

            byte[] firstValidBytes = networkBytes;
            firstValidBytes[firstValidBytes.Length - 1]++;
            IPAddress firstValidAddr = new IPAddress(firstValidBytes);

            byte[] lastValidBytes = broadcastBytes;
            lastValidBytes[lastValidBytes.Length - 1]--;
            IPAddress lastValidAddr = new IPAddress(lastValidBytes);

            txt_bc.Text = broadcastAddr.ToString();
            txt_netzid.Text = networkAddr.ToString();
            txt_hostmin.Text = firstValidAddr.ToString();
            txt_hostmax.Text = lastValidAddr.ToString();


        }

        private void lb_mask_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_ip_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_ip1.Text, @"^([01]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])$"))
            {
                string message = "Only Numbers from 0-255\nare allowed!\n\nTry again!";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }

        }

        private void txt_ip2_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_ip2.Text, @"^([01]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])$"))
            {
                string message = "Only Numbers from 0-255\nare allowed!\n\nTry again!";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        private void txt_ip3_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_ip3.Text, @"^([01]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])$"))
            {
                string message = "Only Numbers from 0-255\nare allowed!\n\nTry again!";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        private void txt_ip4_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_ip4.Text, @"^([01]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])$"))
            {
                string message = "Only Numbers from 0-255\nare allowed!\n\nTry again!";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        private void cobo_mask_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "For help, contact me via Discord: bitflux_\nID: (266266567157874700) ";
            string title = "Help";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.Show();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                string message = "Do you want to close this window?";
                string title = "Close window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<MyObject> myObjects = new List<MyObject>
            {

                new MyObject { Label = "Subnetzmask", Value = txt_mask.Text },
                new MyObject { Label = "Number of IP's", Value = txt_noip.Text },
                new MyObject { Label = "NetzID", Value = txt_netzid.Text },
                new MyObject { Label = "Broadcast", Value = txt_bc.Text },
                new MyObject { Label = "HostMin", Value = txt_hostmin.Text },
                new MyObject { Label = "HostMax", Value = txt_hostmax.Text },
                new MyObject { Label = "Occupied bits", Value = cobo_mask.Text},
                new MyObject { Label = "IP", Value = txt_ip1.Text + "." + txt_ip2.Text + "." + txt_ip3.Text + "." + txt_ip4.Text },
            };

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "TXT files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = saveFileDialog.FileName;
                saveFileDialog.RestoreDirectory = true;

                using (StreamWriter writer = new StreamWriter(selectedFileName))
                {
                    foreach (var item in myObjects)
                    {
                        writer.WriteLine($"{item.Label}: {item.Value}");
                    }
                    string message = "Your file was saved.";
                    string title = "Saved";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                }
                
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.StartsWith("Subnetzmask:"))
                        {
                            txt_mask.Text = line.Substring("Subnetzmask:".Length).Trim();
                        }
                        else if (line.StartsWith("Number of IP's:"))
                        {
                            txt_noip.Text = line.Substring("Number of IP's:".Length).Trim();
                        }
                        else if (line.StartsWith("NetzID:"))
                        {
                            txt_netzid.Text = line.Substring("NetzID:".Length).Trim();
                        }
                        else if (line.StartsWith("Broadcast:"))
                        {
                            txt_bc.Text = line.Substring("Broadcast:".Length).Trim();
                        }
                        else if (line.StartsWith("HostMin:"))
                        {
                            txt_hostmin.Text = line.Substring("HostMin:".Length).Trim();
                        }
                        else if (line.StartsWith("HostMax:"))
                        {
                            txt_hostmax.Text = line.Substring("HostMax:".Length).Trim();
                        }
                        else if (line.StartsWith("Occupied bits:"))
                        {
                            cobo_mask.Text = line.Substring("Occupied bits:".Length).Trim();
                        }
                        else if (line.StartsWith("IP:"))
                        {
                            string ip = line.Substring("IP:".Length).Trim();
                            string[] ipParts = ip.Split('.');

                            if (ipParts.Length == 4)
                            {
                                txt_ip1.Text = ipParts[0];
                                txt_ip2.Text = ipParts[1];
                                txt_ip3.Text = ipParts[2];
                                txt_ip4.Text = ipParts[3];
                            }
                        }
                    }
                }
            }
        }
    }

}


