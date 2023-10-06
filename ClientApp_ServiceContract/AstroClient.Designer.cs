namespace ClientApp_ServiceContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AstroClient));
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupBox_StarVelocity = new System.Windows.Forms.GroupBox();
            this.Button_StarVelocity = new System.Windows.Forms.Button();
            this.TextBox_Rest = new System.Windows.Forms.TextBox();
            this.TextBox_Observed = new System.Windows.Forms.TextBox();
            this.label_RestWavelength = new System.Windows.Forms.Label();
            this.label_ObservedWavelength = new System.Windows.Forms.Label();
            this.GroupBox_StarDistance = new System.Windows.Forms.GroupBox();
            this.Button_StarDistance = new System.Windows.Forms.Button();
            this.TextBox_StarDistance = new System.Windows.Forms.TextBox();
            this.label_ArcsecondAngle = new System.Windows.Forms.Label();
            this.GroupBox_Temperature = new System.Windows.Forms.GroupBox();
            this.Button_Temperature = new System.Windows.Forms.Button();
            this.TextBox_Temperature = new System.Windows.Forms.TextBox();
            this.label_Celsius = new System.Windows.Forms.Label();
            this.GroupBox_EventHorizon = new System.Windows.Forms.GroupBox();
            this.Button_EventHorizon = new System.Windows.Forms.Button();
            this.TextBox_Power = new System.Windows.Forms.TextBox();
            this.TextBox_EventHorizon = new System.Windows.Forms.TextBox();
            this.label_Power = new System.Windows.Forms.Label();
            this.label_MeasuredinKilo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dueutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FrenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_French = new System.Windows.Forms.Button();
            this.Button_German = new System.Windows.Forms.Button();
            this.Button_English = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.GroupBox_StarVelocity.SuspendLayout();
            this.GroupBox_StarDistance.SuspendLayout();
            this.GroupBox_Temperature.SuspendLayout();
            this.GroupBox_EventHorizon.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            resources.ApplyResources(this.listView, "listView");
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView.HideSelection = false;
            this.listView.Name = "listView";
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // GroupBox_StarVelocity
            // 
            resources.ApplyResources(this.GroupBox_StarVelocity, "GroupBox_StarVelocity");
            this.GroupBox_StarVelocity.Controls.Add(this.Button_StarVelocity);
            this.GroupBox_StarVelocity.Controls.Add(this.TextBox_Rest);
            this.GroupBox_StarVelocity.Controls.Add(this.TextBox_Observed);
            this.GroupBox_StarVelocity.Controls.Add(this.label_RestWavelength);
            this.GroupBox_StarVelocity.Controls.Add(this.label_ObservedWavelength);
            this.GroupBox_StarVelocity.Name = "GroupBox_StarVelocity";
            this.GroupBox_StarVelocity.TabStop = false;
            // 
            // Button_StarVelocity
            // 
            resources.ApplyResources(this.Button_StarVelocity, "Button_StarVelocity");
            this.Button_StarVelocity.Name = "Button_StarVelocity";
            this.Button_StarVelocity.UseVisualStyleBackColor = true;
            this.Button_StarVelocity.Click += new System.EventHandler(this.Button_StarVelocity_Click);
            // 
            // TextBox_Rest
            // 
            resources.ApplyResources(this.TextBox_Rest, "TextBox_Rest");
            this.TextBox_Rest.Name = "TextBox_Rest";
            this.TextBox_Rest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Rest_KeyPress);
            // 
            // TextBox_Observed
            // 
            resources.ApplyResources(this.TextBox_Observed, "TextBox_Observed");
            this.TextBox_Observed.Name = "TextBox_Observed";
            this.TextBox_Observed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Observed_KeyPress);
            // 
            // label_RestWavelength
            // 
            resources.ApplyResources(this.label_RestWavelength, "label_RestWavelength");
            this.label_RestWavelength.Name = "label_RestWavelength";
            // 
            // label_ObservedWavelength
            // 
            resources.ApplyResources(this.label_ObservedWavelength, "label_ObservedWavelength");
            this.label_ObservedWavelength.Name = "label_ObservedWavelength";
            // 
            // GroupBox_StarDistance
            // 
            resources.ApplyResources(this.GroupBox_StarDistance, "GroupBox_StarDistance");
            this.GroupBox_StarDistance.Controls.Add(this.Button_StarDistance);
            this.GroupBox_StarDistance.Controls.Add(this.TextBox_StarDistance);
            this.GroupBox_StarDistance.Controls.Add(this.label_ArcsecondAngle);
            this.GroupBox_StarDistance.Name = "GroupBox_StarDistance";
            this.GroupBox_StarDistance.TabStop = false;
            // 
            // Button_StarDistance
            // 
            resources.ApplyResources(this.Button_StarDistance, "Button_StarDistance");
            this.Button_StarDistance.Name = "Button_StarDistance";
            this.Button_StarDistance.UseVisualStyleBackColor = true;
            this.Button_StarDistance.Click += new System.EventHandler(this.Button_StarDistance_Click);
            // 
            // TextBox_StarDistance
            // 
            resources.ApplyResources(this.TextBox_StarDistance, "TextBox_StarDistance");
            this.TextBox_StarDistance.Name = "TextBox_StarDistance";
            this.TextBox_StarDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_StarDistance_KeyPress);
            // 
            // label_ArcsecondAngle
            // 
            resources.ApplyResources(this.label_ArcsecondAngle, "label_ArcsecondAngle");
            this.label_ArcsecondAngle.Name = "label_ArcsecondAngle";
            // 
            // GroupBox_Temperature
            // 
            resources.ApplyResources(this.GroupBox_Temperature, "GroupBox_Temperature");
            this.GroupBox_Temperature.Controls.Add(this.Button_Temperature);
            this.GroupBox_Temperature.Controls.Add(this.TextBox_Temperature);
            this.GroupBox_Temperature.Controls.Add(this.label_Celsius);
            this.GroupBox_Temperature.Name = "GroupBox_Temperature";
            this.GroupBox_Temperature.TabStop = false;
            // 
            // Button_Temperature
            // 
            resources.ApplyResources(this.Button_Temperature, "Button_Temperature");
            this.Button_Temperature.Name = "Button_Temperature";
            this.Button_Temperature.UseVisualStyleBackColor = true;
            this.Button_Temperature.Click += new System.EventHandler(this.Button_Temperature_Click);
            // 
            // TextBox_Temperature
            // 
            resources.ApplyResources(this.TextBox_Temperature, "TextBox_Temperature");
            this.TextBox_Temperature.Name = "TextBox_Temperature";
            this.TextBox_Temperature.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Temperature_KeyPress);
            // 
            // label_Celsius
            // 
            resources.ApplyResources(this.label_Celsius, "label_Celsius");
            this.label_Celsius.Name = "label_Celsius";
            // 
            // GroupBox_EventHorizon
            // 
            resources.ApplyResources(this.GroupBox_EventHorizon, "GroupBox_EventHorizon");
            this.GroupBox_EventHorizon.Controls.Add(this.Button_EventHorizon);
            this.GroupBox_EventHorizon.Controls.Add(this.TextBox_Power);
            this.GroupBox_EventHorizon.Controls.Add(this.TextBox_EventHorizon);
            this.GroupBox_EventHorizon.Controls.Add(this.label_Power);
            this.GroupBox_EventHorizon.Controls.Add(this.label_MeasuredinKilo);
            this.GroupBox_EventHorizon.Name = "GroupBox_EventHorizon";
            this.GroupBox_EventHorizon.TabStop = false;
            // 
            // Button_EventHorizon
            // 
            resources.ApplyResources(this.Button_EventHorizon, "Button_EventHorizon");
            this.Button_EventHorizon.Name = "Button_EventHorizon";
            this.Button_EventHorizon.UseVisualStyleBackColor = true;
            this.Button_EventHorizon.Click += new System.EventHandler(this.Button_EventHorizon_Click);
            // 
            // TextBox_Power
            // 
            resources.ApplyResources(this.TextBox_Power, "TextBox_Power");
            this.TextBox_Power.Name = "TextBox_Power";
            this.TextBox_Power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Power_KeyPress);
            // 
            // TextBox_EventHorizon
            // 
            resources.ApplyResources(this.TextBox_EventHorizon, "TextBox_EventHorizon");
            this.TextBox_EventHorizon.Name = "TextBox_EventHorizon";
            this.TextBox_EventHorizon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_EventHorizon_KeyPress);
            // 
            // label_Power
            // 
            resources.ApplyResources(this.label_Power, "label_Power");
            this.label_Power.Name = "label_Power";
            // 
            // label_MeasuredinKilo
            // 
            resources.ApplyResources(this.label_MeasuredinKilo, "label_MeasuredinKilo");
            this.label_MeasuredinKilo.Name = "label_MeasuredinKilo";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // styleToolStripMenuItem
            // 
            resources.ApplyResources(this.styleToolStripMenuItem, "styleToolStripMenuItem");
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem,
            this.colourToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            // 
            // formToolStripMenuItem
            // 
            resources.ApplyResources(this.formToolStripMenuItem, "formToolStripMenuItem");
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            // 
            // darkToolStripMenuItem
            // 
            resources.ApplyResources(this.darkToolStripMenuItem, "darkToolStripMenuItem");
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.DarkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            resources.ApplyResources(this.lightToolStripMenuItem, "lightToolStripMenuItem");
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.LightToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            resources.ApplyResources(this.colourToolStripMenuItem, "colourToolStripMenuItem");
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Click += new System.EventHandler(this.ColourToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.dueutschToolStripMenuItem,
            this.FrenchToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItem_Click);
            // 
            // dueutschToolStripMenuItem
            // 
            resources.ApplyResources(this.dueutschToolStripMenuItem, "dueutschToolStripMenuItem");
            this.dueutschToolStripMenuItem.Name = "dueutschToolStripMenuItem";
            this.dueutschToolStripMenuItem.Click += new System.EventHandler(this.DueutschToolStripMenuItem_Click);
            // 
            // FrenchToolStripMenuItem
            // 
            resources.ApplyResources(this.FrenchToolStripMenuItem, "FrenchToolStripMenuItem");
            this.FrenchToolStripMenuItem.Name = "FrenchToolStripMenuItem";
            this.FrenchToolStripMenuItem.Click += new System.EventHandler(this.FrenchToolStripMenuItem_Click_1);
            // 
            // Button_French
            // 
            resources.ApplyResources(this.Button_French, "Button_French");
            this.Button_French.BackgroundImage = global::ClientApp_ServiceContract.Properties.Resources.French_France_Image;
            this.Button_French.Name = "Button_French";
            this.Button_French.UseVisualStyleBackColor = true;
            this.Button_French.Click += new System.EventHandler(this.Button_French_Click);
            // 
            // Button_German
            // 
            resources.ApplyResources(this.Button_German, "Button_German");
            this.Button_German.BackgroundImage = global::ClientApp_ServiceContract.Properties.Resources.Germany_Deutschland_Image;
            this.Button_German.Name = "Button_German";
            this.Button_German.UseVisualStyleBackColor = true;
            this.Button_German.Click += new System.EventHandler(this.Button_German_Click);
            // 
            // Button_English
            // 
            resources.ApplyResources(this.Button_English, "Button_English");
            this.Button_English.BackgroundImage = global::ClientApp_ServiceContract.Properties.Resources.Greate_Britain_Image;
            this.Button_English.Name = "Button_English";
            this.Button_English.UseVisualStyleBackColor = true;
            this.Button_English.Click += new System.EventHandler(this.Button_English_Click);
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip.Name = "statusStrip";
            // 
            // StatusLabel
            // 
            resources.ApplyResources(this.StatusLabel, "StatusLabel");
            this.StatusLabel.Name = "StatusLabel";
            // 
            // AstroClient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.Button_French);
            this.Controls.Add(this.Button_German);
            this.Controls.Add(this.Button_English);
            this.Controls.Add(this.GroupBox_EventHorizon);
            this.Controls.Add(this.GroupBox_Temperature);
            this.Controls.Add(this.GroupBox_StarDistance);
            this.Controls.Add(this.GroupBox_StarVelocity);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AstroClient";
            this.GroupBox_StarVelocity.ResumeLayout(false);
            this.GroupBox_StarVelocity.PerformLayout();
            this.GroupBox_StarDistance.ResumeLayout(false);
            this.GroupBox_StarDistance.PerformLayout();
            this.GroupBox_Temperature.ResumeLayout(false);
            this.GroupBox_Temperature.PerformLayout();
            this.GroupBox_EventHorizon.ResumeLayout(false);
            this.GroupBox_EventHorizon.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox GroupBox_StarVelocity;
        private System.Windows.Forms.Button Button_StarVelocity;
        private System.Windows.Forms.TextBox TextBox_Rest;
        private System.Windows.Forms.TextBox TextBox_Observed;
        private System.Windows.Forms.Label label_RestWavelength;
        private System.Windows.Forms.Label label_ObservedWavelength;
        private System.Windows.Forms.GroupBox GroupBox_StarDistance;
        private System.Windows.Forms.Button Button_StarDistance;
        private System.Windows.Forms.TextBox TextBox_StarDistance;
        private System.Windows.Forms.Label label_ArcsecondAngle;
        private System.Windows.Forms.GroupBox GroupBox_Temperature;
        private System.Windows.Forms.Button Button_Temperature;
        private System.Windows.Forms.TextBox TextBox_Temperature;
        private System.Windows.Forms.Label label_Celsius;
        private System.Windows.Forms.GroupBox GroupBox_EventHorizon;
        private System.Windows.Forms.Button Button_EventHorizon;
        private System.Windows.Forms.TextBox TextBox_Power;
        private System.Windows.Forms.TextBox TextBox_EventHorizon;
        private System.Windows.Forms.Label label_Power;
        private System.Windows.Forms.Label label_MeasuredinKilo;
        private System.Windows.Forms.Button Button_English;
        private System.Windows.Forms.Button Button_German;
        private System.Windows.Forms.Button Button_French;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dueutschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FrenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

