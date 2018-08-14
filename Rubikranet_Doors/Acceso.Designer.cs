namespace Rubikranet_Doors
{
    partial class Acceso
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceso));
            this.txtRFID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblAcceso = new MaterialSkin.Controls.MaterialLabel();
            this.lblMensaje = new MaterialSkin.Controls.MaterialLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.serialCod = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgAcceso = new System.Windows.Forms.PictureBox();
            this.imguser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAcceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRFID
            // 
            this.txtRFID.Depth = 0;
            this.txtRFID.Enabled = false;
            this.txtRFID.Hint = "";
            this.txtRFID.Location = new System.Drawing.Point(3, 13);
            this.txtRFID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.PasswordChar = '\0';
            this.txtRFID.SelectedText = "";
            this.txtRFID.SelectionLength = 0;
            this.txtRFID.SelectionStart = 0;
            this.txtRFID.Size = new System.Drawing.Size(279, 23);
            this.txtRFID.TabIndex = 0;
            this.txtRFID.UseSystemPasswordChar = true;
            this.txtRFID.TextChanged += new System.EventHandler(this.txtRFID_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(35, 74);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(264, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Por favor pasa tu tarjeta para acceder:";
            // 
            // lblAcceso
            // 
            this.lblAcceso.AutoSize = true;
            this.lblAcceso.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceso.Depth = 0;
            this.lblAcceso.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAcceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAcceso.Location = new System.Drawing.Point(46, 183);
            this.lblAcceso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAcceso.Name = "lblAcceso";
            this.lblAcceso.Size = new System.Drawing.Size(131, 19);
            this.lblAcceso.TabIndex = 2;
            this.lblAcceso.Text = "¡Acceso Correcto!";
            this.lblAcceso.Visible = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Depth = 0;
            this.lblMensaje.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensaje.Location = new System.Drawing.Point(46, 234);
            this.lblMensaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(174, 19);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "Hola Usuario Bienvenido";
            this.lblMensaje.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // serialCod
            // 
            this.serialCod.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialCod_DataReceived);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtRFID);
            this.panel1.Location = new System.Drawing.Point(49, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 51);
            this.panel1.TabIndex = 8;
            // 
            // imgAcceso
            // 
            this.imgAcceso.BackColor = System.Drawing.Color.Transparent;
            this.imgAcceso.BackgroundImage = global::Rubikranet_Doors.Properties.Resources.cross;
            this.imgAcceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgAcceso.Location = new System.Drawing.Point(3, 172);
            this.imgAcceso.Name = "imgAcceso";
            this.imgAcceso.Size = new System.Drawing.Size(40, 40);
            this.imgAcceso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAcceso.TabIndex = 7;
            this.imgAcceso.TabStop = false;
            this.imgAcceso.Visible = false;
            // 
            // imguser
            // 
            this.imguser.BackColor = System.Drawing.Color.Transparent;
            this.imguser.BackgroundImage = global::Rubikranet_Doors.Properties.Resources.user;
            this.imguser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imguser.Location = new System.Drawing.Point(3, 223);
            this.imguser.Name = "imguser";
            this.imguser.Size = new System.Drawing.Size(40, 40);
            this.imguser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imguser.TabIndex = 6;
            this.imguser.TabStop = false;
            this.imguser.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.materialRadioButton2);
            this.groupBox1.Controls.Add(this.materialRadioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(358, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 87);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checar";
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(3, 15);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(76, 30);
            this.materialRadioButton1.TabIndex = 0;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Entrada";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(3, 49);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(67, 30);
            this.materialRadioButton2.TabIndex = 1;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "Salida";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 274);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imgAcceso);
            this.Controls.Add(this.imguser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblAcceso);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(352, 274);
            this.Name = "Acceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.Acceso_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAcceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imguser;
        private System.Windows.Forms.PictureBox imgAcceso;
        private System.Windows.Forms.Timer timer1;
        public MaterialSkin.Controls.MaterialLabel lblAcceso;
        public MaterialSkin.Controls.MaterialLabel lblMensaje;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtRFID;
        private System.Windows.Forms.Timer timer2;
        private System.IO.Ports.SerialPort serialCod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
    }
}