namespace ServiceContract_ClientApp
{
    partial class AstroClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbStarVelocity = new System.Windows.Forms.GroupBox();
            this.Button_StarVelocity = new System.Windows.Forms.Button();
            this.TextBox_Rest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_Observed = new System.Windows.Forms.TextBox();
            this.gbStarDistance = new System.Windows.Forms.GroupBox();
            this.Button_StarDistance = new System.Windows.Forms.Button();
            this.TextBox_StarDistance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbTemparature = new System.Windows.Forms.GroupBox();
            this.Button_Temperature = new System.Windows.Forms.Button();
            this.TextBox_Temperature = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbEventHorizen = new System.Windows.Forms.GroupBox();
            this.TextBox_Power = new System.Windows.Forms.TextBox();
            this.Button_EvenHorizen = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBox_EventHorizen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonEnglish = new System.Windows.Forms.Button();
            this.ButtonGermany = new System.Windows.Forms.Button();
            this.ButtonFrench = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishUKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gbStarVelocity.SuspendLayout();
            this.gbStarDistance.SuspendLayout();
            this.gbTemparature.SuspendLayout();
            this.gbEventHorizen.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStarVelocity
            // 
            this.gbStarVelocity.Controls.Add(this.Button_StarVelocity);
            this.gbStarVelocity.Controls.Add(this.TextBox_Rest);
            this.gbStarVelocity.Controls.Add(this.label5);
            this.gbStarVelocity.Controls.Add(this.label4);
            this.gbStarVelocity.Controls.Add(this.TextBox_Observed);
            this.gbStarVelocity.Location = new System.Drawing.Point(27, 508);
            this.gbStarVelocity.Name = "gbStarVelocity";
            this.gbStarVelocity.Size = new System.Drawing.Size(328, 174);
            this.gbStarVelocity.TabIndex = 0;
            this.gbStarVelocity.TabStop = false;
            this.gbStarVelocity.Text = "Star Velocity";
            // 
            // Button_StarVelocity
            // 
            this.Button_StarVelocity.Location = new System.Drawing.Point(215, 118);
            this.Button_StarVelocity.Name = "Button_StarVelocity";
            this.Button_StarVelocity.Size = new System.Drawing.Size(93, 35);
            this.Button_StarVelocity.TabIndex = 4;
            this.Button_StarVelocity.Text = "Calculate";
            this.Button_StarVelocity.UseVisualStyleBackColor = true;
            this.Button_StarVelocity.Click += new System.EventHandler(this.Button_StarVelocity_Click);
            // 
            // TextBox_Rest
            // 
            this.TextBox_Rest.Location = new System.Drawing.Point(181, 71);
            this.TextBox_Rest.Name = "TextBox_Rest";
            this.TextBox_Rest.Size = new System.Drawing.Size(129, 26);
            this.TextBox_Rest.TabIndex = 3;
            this.TextBox_Rest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Rest_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Rest Wavelength:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Observed Wavelength:";
            // 
            // TextBox_Observed
            // 
            this.TextBox_Observed.Location = new System.Drawing.Point(181, 31);
            this.TextBox_Observed.Name = "TextBox_Observed";
            this.TextBox_Observed.Size = new System.Drawing.Size(129, 26);
            this.TextBox_Observed.TabIndex = 0;
            this.TextBox_Observed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Observed_KeyPress);
            // 
            // gbStarDistance
            // 
            this.gbStarDistance.Controls.Add(this.Button_StarDistance);
            this.gbStarDistance.Controls.Add(this.TextBox_StarDistance);
            this.gbStarDistance.Controls.Add(this.label6);
            this.gbStarDistance.Location = new System.Drawing.Point(374, 514);
            this.gbStarDistance.Name = "gbStarDistance";
            this.gbStarDistance.Size = new System.Drawing.Size(224, 168);
            this.gbStarDistance.TabIndex = 1;
            this.gbStarDistance.TabStop = false;
            this.gbStarDistance.Text = "Star Distance";
            // 
            // Button_StarDistance
            // 
            this.Button_StarDistance.Location = new System.Drawing.Point(116, 112);
            this.Button_StarDistance.Name = "Button_StarDistance";
            this.Button_StarDistance.Size = new System.Drawing.Size(93, 35);
            this.Button_StarDistance.TabIndex = 5;
            this.Button_StarDistance.Text = "Calculate";
            this.Button_StarDistance.UseVisualStyleBackColor = true;
            this.Button_StarDistance.Click += new System.EventHandler(this.Button_StarDistance_Click);
            // 
            // TextBox_StarDistance
            // 
            this.TextBox_StarDistance.Location = new System.Drawing.Point(80, 65);
            this.TextBox_StarDistance.Name = "TextBox_StarDistance";
            this.TextBox_StarDistance.Size = new System.Drawing.Size(129, 26);
            this.TextBox_StarDistance.TabIndex = 3;
            this.TextBox_StarDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_StarDistance_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Arcseconds Angle:";
            // 
            // gbTemparature
            // 
            this.gbTemparature.Controls.Add(this.Button_Temperature);
            this.gbTemparature.Controls.Add(this.TextBox_Temperature);
            this.gbTemparature.Controls.Add(this.label7);
            this.gbTemparature.Location = new System.Drawing.Point(619, 514);
            this.gbTemparature.Name = "gbTemparature";
            this.gbTemparature.Size = new System.Drawing.Size(192, 168);
            this.gbTemparature.TabIndex = 2;
            this.gbTemparature.TabStop = false;
            this.gbTemparature.Text = "Temperature";
            // 
            // Button_Temperature
            // 
            this.Button_Temperature.Location = new System.Drawing.Point(85, 112);
            this.Button_Temperature.Name = "Button_Temperature";
            this.Button_Temperature.Size = new System.Drawing.Size(93, 35);
            this.Button_Temperature.TabIndex = 5;
            this.Button_Temperature.Text = "Calculate";
            this.Button_Temperature.UseVisualStyleBackColor = true;
            this.Button_Temperature.Click += new System.EventHandler(this.Button_Temperature_Click);
            // 
            // TextBox_Temperature
            // 
            this.TextBox_Temperature.Location = new System.Drawing.Point(49, 68);
            this.TextBox_Temperature.Name = "TextBox_Temperature";
            this.TextBox_Temperature.Size = new System.Drawing.Size(129, 26);
            this.TextBox_Temperature.TabIndex = 4;
            this.TextBox_Temperature.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Temperature_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Celsius:";
            // 
            // gbEventHorizen
            // 
            this.gbEventHorizen.Controls.Add(this.TextBox_Power);
            this.gbEventHorizen.Controls.Add(this.Button_EvenHorizen);
            this.gbEventHorizen.Controls.Add(this.label10);
            this.gbEventHorizen.Controls.Add(this.TextBox_EventHorizen);
            this.gbEventHorizen.Controls.Add(this.label9);
            this.gbEventHorizen.Controls.Add(this.label8);
            this.gbEventHorizen.Location = new System.Drawing.Point(833, 514);
            this.gbEventHorizen.Name = "gbEventHorizen";
            this.gbEventHorizen.Size = new System.Drawing.Size(242, 168);
            this.gbEventHorizen.TabIndex = 3;
            this.gbEventHorizen.TabStop = false;
            // 
            // TextBox_Power
            // 
            this.TextBox_Power.Location = new System.Drawing.Point(186, 42);
            this.TextBox_Power.Name = "TextBox_Power";
            this.TextBox_Power.Size = new System.Drawing.Size(33, 26);
            this.TextBox_Power.TabIndex = 11;
            this.TextBox_Power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Power_KeyPress);
            // 
            // Button_EvenHorizen
            // 
            this.Button_EvenHorizen.Location = new System.Drawing.Point(126, 112);
            this.Button_EvenHorizen.Name = "Button_EvenHorizen";
            this.Button_EvenHorizen.Size = new System.Drawing.Size(93, 35);
            this.Button_EvenHorizen.TabIndex = 10;
            this.Button_EvenHorizen.Text = "Calculate";
            this.Button_EvenHorizen.UseVisualStyleBackColor = true;
            this.Button_EvenHorizen.Click += new System.EventHandler(this.Button_EvenHorizen_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(146, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "x 10";
            // 
            // TextBox_EventHorizen
            // 
            this.TextBox_EventHorizen.Location = new System.Drawing.Point(10, 68);
            this.TextBox_EventHorizen.Name = "TextBox_EventHorizen";
            this.TextBox_EventHorizen.Size = new System.Drawing.Size(129, 26);
            this.TextBox_EventHorizen.TabIndex = 6;
            this.TextBox_EventHorizen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_EventHorizen_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mesured in Kilo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Event Horizen";
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.SystemColors.Window;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(69, 123);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(976, 368);
            this.listView.TabIndex = 7;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Star Velocity";
            this.columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Star Distance";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Temperature";
            this.columnHeader3.Width = 155;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Event Horizen";
            this.columnHeader4.Width = 155;
            // 
            // ButtonEnglish
            // 
            this.ButtonEnglish.Location = new System.Drawing.Point(668, 44);
            this.ButtonEnglish.Name = "ButtonEnglish";
            this.ButtonEnglish.Size = new System.Drawing.Size(112, 58);
            this.ButtonEnglish.TabIndex = 8;
            this.ButtonEnglish.Text = "English(UK)";
            this.ButtonEnglish.UseVisualStyleBackColor = true;
            // 
            // ButtonGermany
            // 
            this.ButtonGermany.Location = new System.Drawing.Point(803, 44);
            this.ButtonGermany.Name = "ButtonGermany";
            this.ButtonGermany.Size = new System.Drawing.Size(112, 58);
            this.ButtonGermany.TabIndex = 9;
            this.ButtonGermany.Text = "Germany";
            this.ButtonGermany.UseVisualStyleBackColor = true;
            // 
            // ButtonFrench
            // 
            this.ButtonFrench.Location = new System.Drawing.Point(933, 44);
            this.ButtonFrench.Name = "ButtonFrench";
            this.ButtonFrench.Size = new System.Drawing.Size(112, 58);
            this.ButtonFrench.TabIndex = 10;
            this.ButtonFrench.Text = "French";
            this.ButtonFrench.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.languageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1086, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "Style";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem,
            this.colourToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 29);
            this.toolStripMenuItem1.Text = "Style";
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(167, 34);
            this.formToolStripMenuItem.Text = "Form";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.darkToolStripMenuItem.Text = "Dark ";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.lightToolStripMenuItem.Text = "Light";
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(167, 34);
            this.colourToolStripMenuItem.Text = "Colour";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishUKToolStripMenuItem,
            this.germanyToolStripMenuItem,
            this.germanyToolStripMenuItem1});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishUKToolStripMenuItem
            // 
            this.englishUKToolStripMenuItem.Name = "englishUKToolStripMenuItem";
            this.englishUKToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.englishUKToolStripMenuItem.Text = "English(UK)";
            // 
            // germanyToolStripMenuItem
            // 
            this.germanyToolStripMenuItem.Name = "germanyToolStripMenuItem";
            this.germanyToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.germanyToolStripMenuItem.Text = "French";
            // 
            // germanyToolStripMenuItem1
            // 
            this.germanyToolStripMenuItem1.Name = "germanyToolStripMenuItem1";
            this.germanyToolStripMenuItem1.Size = new System.Drawing.Size(202, 34);
            this.germanyToolStripMenuItem1.Text = "Germany";
            // 
            // AstroClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 707);
            this.Controls.Add(this.ButtonFrench);
            this.Controls.Add(this.ButtonGermany);
            this.Controls.Add(this.ButtonEnglish);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.gbEventHorizen);
            this.Controls.Add(this.gbTemparature);
            this.Controls.Add(this.gbStarDistance);
            this.Controls.Add(this.gbStarVelocity);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AstroClient";
            this.Text = "Astro_Client";
            this.gbStarVelocity.ResumeLayout(false);
            this.gbStarVelocity.PerformLayout();
            this.gbStarDistance.ResumeLayout(false);
            this.gbStarDistance.PerformLayout();
            this.gbTemparature.ResumeLayout(false);
            this.gbTemparature.PerformLayout();
            this.gbEventHorizen.ResumeLayout(false);
            this.gbEventHorizen.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStarVelocity;
        private System.Windows.Forms.GroupBox gbStarDistance;
        private System.Windows.Forms.GroupBox gbTemparature;
        private System.Windows.Forms.GroupBox gbEventHorizen;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button ButtonEnglish;
        private System.Windows.Forms.Button ButtonGermany;
        private System.Windows.Forms.Button ButtonFrench;
        private System.Windows.Forms.Button Button_StarVelocity;
        private System.Windows.Forms.TextBox TextBox_Rest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_Observed;
        private System.Windows.Forms.Button Button_StarDistance;
        private System.Windows.Forms.TextBox TextBox_StarDistance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Button_Temperature;
        private System.Windows.Forms.TextBox TextBox_Temperature;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Button_EvenHorizen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBox_EventHorizen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishUKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.TextBox TextBox_Power;
    }
}

