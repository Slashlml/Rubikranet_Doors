namespace Rubikranet_Doors
{
    partial class puerto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(puerto));
            this.select_puertos = new MetroSet_UI.Controls.MetroSetComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnContinuar = new System.Windows.Forms.PictureBox();
            this.btnRefresca = new System.Windows.Forms.PictureBox();
            this.select_areas = new MetroSet_UI.Controls.MetroSetComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnContinuar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresca)).BeginInit();
            this.SuspendLayout();
            // 
            // select_puertos
            // 
            this.select_puertos.AllowDrop = true;
            this.select_puertos.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.select_puertos.BackColor = System.Drawing.Color.Transparent;
            this.select_puertos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.select_puertos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.select_puertos.CausesValidation = false;
            this.select_puertos.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.select_puertos.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.select_puertos.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.select_puertos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.select_puertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_puertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.select_puertos.FormattingEnabled = true;
            this.select_puertos.ItemHeight = 20;
            this.select_puertos.Location = new System.Drawing.Point(25, 96);
            this.select_puertos.Name = "select_puertos";
            this.select_puertos.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.select_puertos.SelectedItemForeColor = System.Drawing.Color.White;
            this.select_puertos.Size = new System.Drawing.Size(296, 26);
            this.select_puertos.Style = MetroSet_UI.Design.Style.Light;
            this.select_puertos.StyleManager = null;
            this.select_puertos.TabIndex = 4;
            this.select_puertos.ThemeAuthor = "Narwin";
            this.select_puertos.ThemeName = "MetroLite";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(101, 74);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(154, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Selecciona un puerto:";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Transparent;
            this.btnContinuar.Image = ((System.Drawing.Image)(resources.GetObject("btnContinuar.Image")));
            this.btnContinuar.Location = new System.Drawing.Point(196, 207);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(40, 40);
            this.btnContinuar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnContinuar.TabIndex = 5;
            this.btnContinuar.TabStop = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnRefresca
            // 
            this.btnRefresca.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresca.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresca.Image")));
            this.btnRefresca.Location = new System.Drawing.Point(105, 207);
            this.btnRefresca.Name = "btnRefresca";
            this.btnRefresca.Size = new System.Drawing.Size(40, 40);
            this.btnRefresca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRefresca.TabIndex = 6;
            this.btnRefresca.TabStop = false;
            this.btnRefresca.Click += new System.EventHandler(this.btnRefresca_Click);
            // 
            // select_areas
            // 
            this.select_areas.AllowDrop = true;
            this.select_areas.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.select_areas.BackColor = System.Drawing.Color.Transparent;
            this.select_areas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.select_areas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.select_areas.CausesValidation = false;
            this.select_areas.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.select_areas.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.select_areas.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.select_areas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.select_areas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_areas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.select_areas.FormattingEnabled = true;
            this.select_areas.ItemHeight = 20;
            this.select_areas.Location = new System.Drawing.Point(25, 159);
            this.select_areas.Name = "select_areas";
            this.select_areas.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.select_areas.SelectedItemForeColor = System.Drawing.Color.White;
            this.select_areas.Size = new System.Drawing.Size(296, 26);
            this.select_areas.Style = MetroSet_UI.Design.Style.Light;
            this.select_areas.StyleManager = null;
            this.select_areas.TabIndex = 8;
            this.select_areas.ThemeAuthor = "Narwin";
            this.select_areas.ThemeName = "MetroLite";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(101, 137);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(135, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "¿Qué área es esta?";
            // 
            // puerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 260);
            this.ControlBox = false;
            this.Controls.Add(this.select_areas);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnRefresca);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.select_puertos);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(352, 274);
            this.Name = "puerto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.puerto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnContinuar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetComboBox select_puertos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox btnContinuar;
        private System.Windows.Forms.PictureBox btnRefresca;
        private MetroSet_UI.Controls.MetroSetComboBox select_areas;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}