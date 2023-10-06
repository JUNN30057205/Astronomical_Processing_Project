using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClientApp_ServiceContract
{
    public partial class AstroClient : Form
    {
        public AstroClient()
        {
            InitializeComponent();
        }
        //define IAstroContract channel field.
        private IAstroContract channel;

        #region Calculate Button        
        private void Button_StarVelocity_Click(object sender, EventArgs e)
        {
            string address = "net.pipe://localhost/";
            NetNamedPipeBinding binding =
            new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
            try
            {

                if (!string.IsNullOrEmpty(TextBox_Observed.Text) ||
                    !string.IsNullOrEmpty(TextBox_Rest.Text))
                {
                    ListViewItem listViewItem = new ListViewItem(channel.StarVelocity(
                    double.Parse(TextBox_Observed.Text),
                    double.Parse(TextBox_Rest.Text)).ToString() + " m/s");
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add("");
                    listView.Items.Add(listViewItem);
                    StatusMessage("");

                }
                else
                {
                    StatusMessage("Enter Valid Number in the TextBoxes");
                }
            }
            catch (Exception)
            {
                StatusMessage("Connection Error");
            }
        }

        private void Button_StarDistance_Click(object sender, EventArgs e)
        {
            try
            {
                string address = "net.pipe://localhost/";
                NetNamedPipeBinding binding =
                new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
                EndpointAddress ep = new EndpointAddress(address);
                channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
                            
                if (!string.IsNullOrEmpty(TextBox_StarDistance.Text))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.SubItems.Add(channel.StarDistance(double.Parse(TextBox_StarDistance.Text)).ToString() + " persec");
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add("");
                    listView.Items.Add(listViewItem);
                    StatusMessage("");
                }
                else
                {
                    StatusMessage("Enter Valid Number in the TextBox");
                }
            }
            catch (Exception)
            {
                StatusMessage("Connection Error");
            }
        }

        private void Button_Temperature_Click(object sender, EventArgs e)
        {
            try
            {
                string address = "net.pipe://localhost/";
                NetNamedPipeBinding binding =
                new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
                EndpointAddress ep = new EndpointAddress(address);
                channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

                if (!string.IsNullOrEmpty(TextBox_Temperature.Text))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add(channel.TemparatureCoveter(double.Parse(TextBox_Temperature.Text)).ToString() + " K");
                    listViewItem.SubItems.Add("");                    
                    listView.Items.Add(listViewItem);
                    StatusMessage("");
                }
                else
                {
                    StatusMessage("Enter Valid Number in the TextBox");
                }
            }
            catch
            {
                StatusMessage("Connection Error");
            }
        }

        private void Button_EventHorizon_Click(object sender, EventArgs e)
        {
            try
            {
                string address = "net.pipe://localhost/";
                NetNamedPipeBinding binding =
                new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
                EndpointAddress ep = new EndpointAddress(address);
                channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

                if (!string.IsNullOrEmpty(TextBox_EventHorizon.Text) ||
                    !string.IsNullOrEmpty(TextBox_Power.Text))
                {
                    double EventHorizen = double.Parse(TextBox_EventHorizon.Text);
                    double Power = double.Parse(TextBox_Power.Text);

                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add(channel.EventHorizon(EventHorizen * Math.Pow(10, Power)).ToString("0.0e+00") + " metres");
                    listView.Items.Add(listViewItem);
                    StatusMessage("");
                }
                else
                {
                    StatusMessage("Enter Valid Number in the TextBoxes");
                }
            }
            catch
            {
                StatusMessage("Connection Error");
            }
            
        }

        private void StatusMessage(string msg)
        {
            StatusLabel.Text = msg;
            StatusLabel.ForeColor = Color.Crimson;
            StatusLabel.BackColor = Color.LightYellow;
        }
        #endregion

        #region KeyPress
        private void TextBox_KeyPress (object sender, KeyPressEventArgs e, System.Windows.Forms.TextBox text)
        {
            //avoid character & symbols
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            //accept negative digit at the start of textboxes
            if (e.KeyChar == '-' && text.SelectionStart != 0)
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBox_Observed_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e, TextBox_Observed);
        }

        private void TextBox_Rest_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e, TextBox_Rest);
        }

        private void TextBox_StarDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e, TextBox_StarDistance);
        }

        private void TextBox_Temperature_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e, TextBox_Temperature);
        }

        private void TextBox_EventHorizon_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e, TextBox_EventHorizon);
        }

        private void TextBox_Power_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e, TextBox_Power);
        }
        #endregion

        #region Languages
        private void ChangeLanguage(string language)
        {
            //Clear background color
            BackColor = DefaultBackColor;
            switch (language)
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
                    break;
                case "German":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
                    break;

                case "France":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
                    break;
            }
            Controls.Clear();
            InitializeComponent();
            this.BackColor = default(Color);
            this.ForeColor = default(Color);
        }

        private void Button_English_Click(object sender, EventArgs e)
        {
            ChangeLanguage("English");
        }

        private void Button_German_Click(object sender, EventArgs e)
        {
            ChangeLanguage("German");
        }

        private void Button_French_Click(object sender, EventArgs e)
        {
            ChangeLanguage("France");
        }

        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("English");
        }

        private void DueutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("German");
        }

        private void FrenchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangeLanguage("France");
        }

        #endregion

        #region Color Theme
        private void ColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                BackgroundImage = null;
                BackColor = colorDialog.Color;
                byte r = (byte)(255 - BackColor.R);
                byte g = (byte)(255 - BackColor.G);
                byte b = (byte)(255 - BackColor.B);
                //byte a = (byte)(255 - BackColor.A);
                ForeColor = Color.FromArgb(r, g, b);
                foreach (var textBox in Controls.OfType<System.Windows.Forms.TextBox>())
                {
                    textBox.ForeColor = Color.FromArgb(r, g, b);
                }
            }
        }

        private void DarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeToDarkMode();
        }
        private void LightToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ChangeToLightMode();
        }
        private void ChangeToLightMode()
        {
            BackgroundImage = null;
            BackColor = Color.LightCyan;
            ForeColor = Color.DarkViolet;
        }
        private void ChangeToDarkMode()
        {
            BackgroundImage = null;
            BackColor = Color.DarkGray;
            ForeColor = Color.DarkBlue;
        }
        
        #endregion
    }
}
