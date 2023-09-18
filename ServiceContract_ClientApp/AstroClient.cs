using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ServiceContract_ClientApp
{
    public partial class AstroClient : Form
    {
        public AstroClient()
        {
            InitializeComponent();
        }

        #region Buttons
        private void Button_StarVelocity_Click(object sender, EventArgs e)
        {
            string address = "net.pipe://localhost/";
            NetNamedPipeBinding binding =
            new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
            try
            {

                if (!string.IsNullOrEmpty(TextBox_Observed.Text) ||
                !string.IsNullOrEmpty(TextBox_Rest.Text))
                {
                    ListViewItem listViewItem = new ListViewItem(channel.StarVelocity(
                    double.Parse(TextBox_Observed.Text),
                    double.Parse(TextBox_Rest.Text)).ToString());
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add("");
                    listView.Items.Add(listViewItem);

                }
                else
                {
                    //message "textbox empty"
                }
            }
            catch (Exception ex)
            {
                //Error!
            }

        }

        private void Button_StarDistance_Click(object sender, EventArgs e)
        {
            string address = "net.pipe://localhost/";
            NetNamedPipeBinding binding =
            new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

            try
            {
                if (!string.IsNullOrEmpty(TextBox_StarDistance.Text))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.SubItems.Add(channel.StarDistance(double.Parse(TextBox_StarDistance.Text)).ToString());
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add("");
                    listView.Items.Add(listViewItem);
                }
            }
            catch
            {

            }



        }

        private void Button_Temperature_Click(object sender, EventArgs e)
        {
            string address = "net.pipe://localhost/";
            NetNamedPipeBinding binding =
            new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

            try
            {
                if (!string.IsNullOrEmpty(TextBox_Temperature.Text))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add(channel.TemparatureCoveter(double.Parse(TextBox_Temperature.Text)).ToString());
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add("");
                    listView.Items.Add(listViewItem);
                }
            }
            catch
            {

            }


        }

        private void Button_EvenHorizen_Click(object sender, EventArgs e)
        {
            string address = "net.pipe://localhost/";
            NetNamedPipeBinding binding =
            new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

            if (!string.IsNullOrEmpty(TextBox_EventHorizen.Text) ||
                !string.IsNullOrEmpty(TextBox_Power.Text))
            {
                double EventHorizen = double.Parse(TextBox_EventHorizen.Text);
                double Power = double.Parse(TextBox_Power.Text);

                ListViewItem listViewItem = new ListViewItem();
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(channel.EventHorizon(EventHorizen * Math.Pow(10, Power)).ToString("0.0e+00"));
                listView.Items.Add(listViewItem);
            }
        }
        #endregion

        #region KeyPress
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e, TextBox textBox)
        {
            //avoid character & simbols
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
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

        private void TextBox_EventHorizen_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e, TextBox_EventHorizen);
        }

        private void TextBox_Power_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e, TextBox_Power);
        }

        #endregion

        #region Languages
        private void ButtonEnglish_Click(object sender, EventArgs e)
        {
            ChangeLanguage("English");
        }
        private void ButtonGermany_Click(object sender, EventArgs e)
        {
            ChangeLanguage("Germany");
        }
        private void ButtonFrench_Click(object sender, EventArgs e)
        {
            ChangeLanguage("French");
        }
        private void ChangeLanguage(string language)
        {
            //Clear background color
            BackColor = DefaultBackColor;
            switch (language)
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
                    //BackgroundImage = Properties.Resources.Greate_Britain_Image;
                    break;
                case "Germany":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
                    //BackgroundImage = Properties.Resources.Germany_Deutschland_Image;
                    break;

                case "France":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
                    //BackgroundImage = Properties.Resources.French_France_Image;
                    break;
            }

            Controls.Clear();
            InitializeComponent();
        }

        private void EnglishUKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("English");
        }

        private void GermanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("Germany");
        }

        private void FrenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("French");
        }

        #endregion

        #region Colour Theme
        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                BackgroundImage = null;
                BackColor = colorDialog.Color;
                byte r = (byte)(255 - BackColor.R);
                byte g = (byte)(255 - BackColor.G);
                byte b = (byte)(255 - BackColor.B);
                ForeColor = Color.FromArgb(r, g, b);
                foreach (var textBox in Controls.OfType<TextBox>())
                {
                    textBox.ForeColor = Color.FromArgb(r, g, b);
                }
            }
        }



        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = null;
            BackColor = Color.Gray;
            ForeColor = Color.DarkBlue;
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = null;
            BackColor = Color.LightCyan;
            ForeColor = Color.DarkViolet;
        }

        #endregion

        
    }

}
//menu strip or menu bar 
//https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings
//https://www.youtube.com/watch?v=w1FYv3_asTw
//https://www.bing.com/videos/riverview/relatedvideo?&mid=4BBC5B5EACB643DCF8A34BBC5B5EACB643DCF8A3&ajaxhist=
//https://www.bing.com/videos/riverview/relatedvideo?&q=C%23+create+multi+language+App+in+win+form&&mid=EE2003D065CFE43BE9B8EE2003D065CFE43BE9B8&&FORM=VRDGAR