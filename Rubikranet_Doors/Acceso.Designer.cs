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
            this.lblHola = new MaterialSkin.Controls.MaterialLabel();
            this.lblacceso = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgcorrecto = new System.Windows.Forms.PictureBox();
            this.imguser = new System.Windows.Forms.PictureBox();
            this.imgdenegado = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.serialCod = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgdenegado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRFID
            // 
            this.txtRFID.Depth = 0;
            this.txtRFID.Hint = "";
            this.txtRFID.Location = new System.Drawing.Point(52, 121);
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
            // lblHola
            // 
            this.lblHola.AutoSize = true;
            this.lblHola.BackColor = System.Drawing.Color.Transparent;
            this.lblHola.Depth = 0;
            this.lblHola.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHola.Location = new System.Drawing.Point(52, 182);
            this.lblHola.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHola.Name = "lblHola";
            this.lblHola.Size = new System.Drawing.Size(131, 19);
            this.lblHola.TabIndex = 2;
            this.lblHola.Text = "¡Acceso Correcto!";
            this.lblHola.Visible = false;
            // 
            // lblacceso
            // 
            this.lblacceso.AutoSize = true;
            this.lblacceso.BackColor = System.Drawing.Color.Transparent;
            this.lblacceso.Depth = 0;
            this.lblacceso.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblacceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblacceso.Location = new System.Drawing.Point(52, 235);
            this.lblacceso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblacceso.Name = "lblacceso";
            this.lblacceso.Size = new System.Drawing.Size(174, 19);
            this.lblacceso.TabIndex = 3;
            this.lblacceso.Text = "Hola Usuario Bienvenido";
            this.lblacceso.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // imgcorrecto
            // 
            this.imgcorrecto.BackColor = System.Drawing.Color.Transparent;
            this.imgcorrecto.Image = ((System.Drawing.Image)(resources.GetObject("imgcorrecto.Image")));
            this.imgcorrecto.Location = new System.Drawing.Point(3, 172);
            this.imgcorrecto.Name = "imgcorrecto";
            this.imgcorrecto.Size = new System.Drawing.Size(43, 41);
            this.imgcorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgcorrecto.TabIndex = 5;
            this.imgcorrecto.TabStop = false;
            this.imgcorrecto.Visible = false;
            // 
            // imguser
            // 
            this.imguser.BackColor = System.Drawing.Color.Transparent;
            this.imguser.Image = ((System.Drawing.Image)(resources.GetObject("imguser.Image")));
            this.imguser.Location = new System.Drawing.Point(3, 223);
            this.imguser.Name = "imguser";
            this.imguser.Size = new System.Drawing.Size(43, 41);
            this.imguser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imguser.TabIndex = 6;
            this.imguser.TabStop = false;
            this.imguser.Visible = false;
            // 
            // imgdenegado
            // 
            this.imgdenegado.BackColor = System.Drawing.Color.Transparent;
            this.imgdenegado.Image = ((System.Drawing.Image)(resources.GetObject("imgdenegado.Image")));
            this.imgdenegado.Location = new System.Drawing.Point(3, 172);
            this.imgdenegado.Name = "imgdenegado";
            this.imgdenegado.Size = new System.Drawing.Size(43, 41);
            this.imgdenegado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgdenegado.TabIndex = 7;
            this.imgdenegado.TabStop = false;
            this.imgdenegado.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // serialCod
            // 
            this.serialCod.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialCod_DataReceived);
            // 
            // Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 274);
            this.ControlBox = false;
            this.Controls.Add(this.imgdenegado);
            this.Controls.Add(this.imguser);
            this.Controls.Add(this.imgcorrecto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblacceso);
            this.Controls.Add(this.lblHola);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtRFID);
            this.MaximumSize = new System.Drawing.Size(352, 274);
            this.MinimumSize = new System.Drawing.Size(352, 274);
            this.Name = "Acceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.Acceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgdenegado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgcorrecto;
        private System.Windows.Forms.PictureBox imguser;
        private System.Windows.Forms.PictureBox imgdenegado;
        private System.Windows.Forms.Timer timer1;
        public MaterialSkin.Controls.MaterialLabel lblHola;
        public MaterialSkin.Controls.MaterialLabel lblacceso;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtRFID;
        private System.Windows.Forms.Timer timer2;
        private System.IO.Ports.SerialPort serialCod;
    }
}