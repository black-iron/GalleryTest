namespace GalleryTest
{
    partial class FormTets12
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
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radListView1
            // 
            this.radListView1.FullRowSelect = false;
            this.radListView1.ItemSize = new System.Drawing.Size(64, 64);
            this.radListView1.Location = new System.Drawing.Point(51, 145);
            this.radListView1.Name = "radListView1";
            this.radListView1.Size = new System.Drawing.Size(413, 254);
            this.radListView1.TabIndex = 0;
            this.radListView1.Text = "radListView1";
            this.radListView1.ThemeName = "VisualStudio2012Dark";
            this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
            // 
            // FormTets12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 613);
            this.Controls.Add(this.radListView1);
            this.Name = "FormTets12";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FormTets12";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadListView radListView1;
    }
}
