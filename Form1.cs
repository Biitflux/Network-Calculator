using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NetzwerkRechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            if(chk_noip.Checked)
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
            if (chk_hostmin.Checked) { 
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
            if( chk_hostmax.Checked)
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
            if(chk_netzid.Checked)
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
            if(chk_bc.Checked)
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
            else if (!chk_mask.Checked && !chk_noip.Checked && !chk_hostmin.Checked && !chk_hostmax.Checked && !chk_netzid.Checked && !chk_bc.Checked ) 
            {
                string message = "At least one must be selected";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error );
                
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



            //calc NetzId
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
            if(!Regex.IsMatch(txt_ip1.Text, @"^([01]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])$"))
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
    }
}
