using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace NetzwerkRechner
{
    public partial class Form1 : Form
    {
        // This is the constructor for the Form1 class
        public Form1()
        {
            // This method call is required for Windows Forms designer support
            InitializeComponent();
        }

        // This is a simple class that represents an object with a label and a value
        public class MyObject
        {
            // This is the property for the label of the object
            public string Label { get; set; }

            // This is the property for the value of the object
            public string Value { get; set; }
        }


        // This event is triggered when the state of chk_mask checkbox changes
        private void chk_mask_CheckedChanged(object sender, EventArgs e)
        {
            // Set the visibility of txt_mask and lbl_mask to the state of the checkbox
            txt_mask.Visible = chk_mask.Checked;
            lbl_mask.Visible = chk_mask.Checked;
        }

        // This event is triggered when the state of chk_noip checkbox changes
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // Set the visibility of txt_noip and lbl_noip to the state of the checkbox
            txt_noip.Visible = chk_noip.Checked;
            lbl_noip.Visible = chk_noip.Checked;
        }

        // This event is triggered when the state of chk_hostmin checkbox changes
        private void chk_substeps_CheckedChanged(object sender, EventArgs e)
        {
            // Set the visibility of txt_hostmin and lbl_hostmin to the state of the checkbox
            txt_hostmin.Visible = chk_hostmin.Checked;
            lbl_hostmin.Visible = chk_hostmin.Checked;
        }

        // This event is triggered when the state of chk_hostmax checkbox changes
        private void chk_asub_CheckedChanged(object sender, EventArgs e)
        {
            // Set the visibility of txt_hostmax and lbl_hostmax to the state of the checkbox
            txt_hostmax.Visible = chk_hostmax.Checked;
            lbl_hostmax.Visible = chk_hostmax.Checked;
        }

        // This event is triggered when the state of chk_netzid checkbox changes
        private void chk_netzid_CheckedChanged(object sender, EventArgs e)
        {
            // Set the visibility of txt_netzid and lbl_netzid to the state of the checkbox
            txt_netzid.Visible = chk_netzid.Checked;
            lbl_netzid.Visible = chk_netzid.Checked;
        }

        // This event is triggered when the state of chk_bc checkbox changes
        private void chk_bc_CheckedChanged(object sender, EventArgs e)
        {
            // Set the visibility of txt_bc and lbl_bc to the state of the checkbox
            txt_bc.Visible = chk_bc.Checked;
            lbl_bc.Visible = chk_bc.Checked;
        }

        // This event is triggered when the state of chk_bin_ip checkbox 
        private void chk_bin_ip_CheckedChanged(object sender, EventArgs e)
        {
            // Set the visibility of txt_bin_ip and lbl_bin_ip to the state of the checkbox
            txt_bin_ip.Visible = chk_bin_ip.Checked;
            lbl_bin_ip.Visible = chk_bin_ip.Checked;
        }


        // This event is triggered when the state of chk_bin_mask checkbox changes
        private void chk_bin_mask_CheckedChanged(object sender, EventArgs e)
        {
            // Set the visibility of txt_bin_mask and lbl_bin_mask to the state of the checkbox
            txt_bin_mask.Visible = chk_bin_mask.Checked;
            lbl_bin_mask.Visible = chk_bin_mask.Checked;
        }

        // This event is triggered when the state of chk_bin_netzid checkbox changes
        private void chk_bin_netzid_CheckedChanged(object sender, EventArgs e)
        {
            // Set the visibility of txt_bin_netzid and lbl_bin_netzid to the state of the checkbox
            txt_bin_netzid.Visible = chk_bin_netzid.Checked;
            lbl_bin_netzid.Visible = chk_bin_netzid.Checked;
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }


        private void btn_calc_Click(object sender, EventArgs e)
        {
            // Check if any part of the IP address is empty
            string[] ipParts = { txt_ip1.Text, txt_ip2.Text, txt_ip3.Text, txt_ip4.Text };
            if (ipParts.Any(string.IsNullOrEmpty))
            {
                MessageBox.Show("Your entered IP address is invalid, \nplease correct your entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Check if none of the checkboxes are checked
            else if (new[] { chk_mask, chk_noip, chk_hostmin, chk_hostmax, chk_netzid, chk_bc }.All(chk => !chk.Checked))
            {
                MessageBox.Show("At least one must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Check if the mask box is empty
            else if (string.IsNullOrEmpty(cobo_mask.Text))
            {
                MessageBox.Show("At least one mask must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Calculate the subnet mask
                int subnetBits = cobo_mask.SelectedIndex;
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
                    txt_mask.Text = "Invalid Input";
                }
            }


            // Split the subnet mask into octets
            string subnetMask = txt_mask.Text;
            string[] octets = subnetMask.Split('.');

            // Initialize arrays to hold the octet values and their binary representations
            int[] octetValues = new int[4];
            string[] binaryOctets = new string[4];

            for (int i = 0; i < 4; i++)
            {
                // Check if the array 'octets' and its element 'octets[i]' are not NULL
                if (octets != null && i < octets.Length && octets[i] != null)
                {
                    // Try to parse the octet value
                    if (int.TryParse(octets[i], out int result))
                    {
                        // If successful, store the octet value and its binary representation
                        octetValues[i] = result;
                        binaryOctets[i] = Convert.ToString(octetValues[i], 2).PadLeft(8, '0');
                    }
                }
            }

            // Initialize totalZeroes
            int totalZeroes = 0;

            // Check if binaryOctets is not null
            if (binaryOctets != null)
            {
                // Iterate over each binary octet
                for (int i = 0; i < binaryOctets.Length; i++)
                {
                    // Check if binaryOctets[i] is not null
                    if (binaryOctets[i] != null)
                    {
                        // Count the number of zeroes in the current binary octet
                        int zeroCount = binaryOctets[i].Count(c => c == '0');

                        // Add the number of zeroes in the current binary octet to the total
                        totalZeroes += zeroCount;
                    }
                }
            }


            // Calculate the number of IP addresses
            double numberOfIPs = Math.Pow(2, totalZeroes) - 2;

            // Display the number of IP addresses in the txt_noip text box
            if (numberOfIPs > 0) 
            { txt_noip.Text = numberOfIPs.ToString(); }
            else if(cobo_mask.SelectedIndex == 30)
            {
                txt_noip.Text = "0";
            }
            else if (cobo_mask.SelectedIndex == 31)
            {
                txt_noip.Text = "1";
            }



            // Initialize the IP address parts
            string[] ipAddressParts = { txt_ip1.Text, txt_ip2.Text, txt_ip3.Text, txt_ip4.Text };

            // Validate each part
            for (int i = 0; i < 4; i++)
            {
                if (!int.TryParse(ipAddressParts[i], out int part) || part < 0 || part > 255)
                {
                    // If the part is not a valid number between 0 and 255, exit the method
                    return;
                }
            }

            // Combine the four parts of the IP address into a single string
            string ip = string.Join(".", ipAddressParts);



            // Parse the IP and subnet mask strings into IPAddress objects
            IPAddress ipAddr = IPAddress.Parse(ip);
            IPAddress subnetMaskAddr = IPAddress.Parse(subnetMask);

            // Get the byte arrays of the IP and subnet mask
            byte[] ipBytes = ipAddr.GetAddressBytes();
            byte[] subnetBytes = subnetMaskAddr.GetAddressBytes();

            // Initialize byte arrays for the broadcast and network addresses
            byte[] broadcastBytes = new byte[ipBytes.Length];
            byte[] networkBytes = new byte[ipBytes.Length];

            // Calculate the broadcast and network addresses
            for (int i = 0; i < broadcastBytes.Length; i++)
            {
                broadcastBytes[i] = (byte)(ipBytes[i] | (subnetBytes[i] ^ 255));
                networkBytes[i] = (byte)(ipBytes[i] & subnetBytes[i]);
            }

            // Convert the broadcast and network byte arrays back to IPAddresses
            IPAddress broadcastAddr = new IPAddress(broadcastBytes);
            IPAddress networkAddr = new IPAddress(networkBytes);

            // Calculate the first and last valid IP addresses in the subnet
            byte[] firstValidBytes = networkBytes;
            firstValidBytes[firstValidBytes.Length - 1]++;
            IPAddress firstValidAddr = new IPAddress(firstValidBytes);

            byte[] lastValidBytes = broadcastBytes;
            lastValidBytes[lastValidBytes.Length - 1]--;
            IPAddress lastValidAddr = new IPAddress(lastValidBytes);

            // Display the calculated addresses in the text boxes
            txt_bc.Text = broadcastAddr.ToString();
            txt_netzid.Text = networkAddr.ToString();
            txt_hostmin.Text = firstValidAddr.ToString();
            txt_hostmax.Text = lastValidAddr.ToString();


            // Split the IP address into octets
            string binaryIP = "";

            // Convert each octet of the IP address to binary
            foreach (string part in ipParts)
            {
                int partInt = Int32.Parse(part);
                binaryIP += Convert.ToString(partInt, 2).PadLeft(8, '0') + ".";
            }

            binaryIP = binaryIP.TrimEnd('.');
            txt_bin_ip.Text = binaryIP; // Store the binary IP

            // Split the subnet mask into octets
            string[] maskParts = txt_mask.Text.Split('.');
            string binaryMask = "";

            // Convert each octet of the subnet mask to binary
            foreach (string part in maskParts)
            {
                int partInt = Int32.Parse(part);
                binaryMask += Convert.ToString(partInt, 2).PadLeft(8, '0') + ".";
            }

            binaryMask = binaryMask.TrimEnd('.');
            txt_bin_mask.Text = binaryMask; // Store the binary subnet mask

            // Split the network ID into octets
            string[] netidParts = txt_netzid.Text.Split('.');
            string binaryNetid = "";

            // Convert each octet of the network ID to binary
            foreach (string part in netidParts)
            {
                int partInt = Int32.Parse(part);
                binaryNetid += Convert.ToString(partInt, 2).PadLeft(8, '0') + ".";
            }

            binaryNetid = binaryNetid.TrimEnd('.');
            txt_bin_netzid.Text = binaryNetid; // Store the binary network ID










        }


        private void txt_ip_TextChanged(object sender, EventArgs e)
        {
            // Cast the sender to a TextBox
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            // Check if the cast was successful and the text is not a valid IP segment
            if (textBox != null && !string.IsNullOrEmpty(textBox.Text) && !Regex.IsMatch(textBox.Text, @"^([01]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])$"))
            {
                // Define the error message
                string message = "Only Numbers from 0-255\nare allowed!\n\nTry again!";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                // Show the error message
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }


        private void showHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Define a message box to provide help information
            string message = "For help, contact me via Discord: bitflux_\nID: (266266567157874700)\nVersion - 1.0.1 09.11.2023 ";
            string title = "Help";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Show the message box
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of Form1
            var frm = new Form1();

            // Show the new form
            frm.Show();
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the user is trying to close the form
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Define a message box to confirm the closing
                string message = "Do you want to save?";
                string title = "Close window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                // If the user clicks 'Yes', cancel the closing event
                if (result == DialogResult.Yes)
                {
                    Boolean SaveResult = SaveData();
                    if (!SaveResult)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }



        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private bool SaveData()
        {
            // Create a list of objects to be saved
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
                new MyObject { Label = "IP Address Binary", Value = txt_bin_ip.Text},
                new MyObject { Label = "Netmask Binary", Value = txt_bin_mask.Text},
                new MyObject { Label = "Netzid Binary", Value = txt_bin_netzid.Text},
             };

            // Create a new save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TXT files (*.txt)|*.txt";

            // Show the save file dialog and check if user clicked OK
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Store the name of the selected file
                string selectedFileName = saveFileDialog.FileName;
                saveFileDialog.RestoreDirectory = true;

                // Create a new StreamWriter to write to the file
                using (StreamWriter writer = new StreamWriter(selectedFileName))
                {
                    // Write each object to the file
                    foreach (var item in myObjects)
                    {
                        writer.WriteLine($"{item.Label}: {item.Value}");
                    }

                    // Show a message box indicating the file was saved
                    string message = "Your file was saved.";
                    string title = "Saved";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                }
                return true;
            }
            return false;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            // Show the file dialog and check if user clicked OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Store the path of the selected file
                string filePath = openFileDialog.FileName;

                // Open the selected file
                var fileStream = openFileDialog.OpenFile();

                // Create a new StreamReader to read the file
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    string line;

                    // Read the file line by line
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Check if the line starts with a specific string and update the corresponding textbox
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
                        else if (line.StartsWith("IP Address Binary:"))
                        {
                            txt_bin_ip.Text = line.Substring("IP Address Binary:".Length).Trim();
                        }
                        else if (line.StartsWith("Netmask Binary:"))
                        {
                            txt_bin_mask.Text = line.Substring("Netmask Binary:".Length).Trim();
                        }
                        else if (line.StartsWith("Netzid Binary:"))
                        {
                            txt_bin_netzid.Text = line.Substring("Netzid Binary:".Length).Trim();
                        }
                    }
                }
            }
        }

        
        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            string[] txtfields = {
        "txt_ip1",
        "txt_ip2",
        "txt_ip3",
        "txt_ip4",
        "txt_mask",
        "txt_noip",
        "txt_netzid",
        "txt_bc",
        "txt_hostmin",
        "txt_hostmax",
        "txt_bin_ip",
        "txt_bin_mask",
        "txt_bin_netzid"
                         };

            foreach (string field in txtfields)
            {
                Control[] controls = this.Controls.Find(field, true);
                if (controls.Length > 0)
                {
                    TextBox textBox = controls[0] as TextBox;
                    if (textBox != null)
                    {
                        textBox.Text = String.Empty;
                    }
                }
            }
            cobo_mask.SelectedIndex = -1;
        }

        
    }
}


