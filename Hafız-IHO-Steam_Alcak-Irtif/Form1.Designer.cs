﻿
namespace Hafız_IHO_Steam_Alcak_Irtif
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComPortCloseButton = new System.Windows.Forms.Button();
            this.ComPortBox = new System.Windows.Forms.ComboBox();
            this.ComPortStatus = new System.Windows.Forms.ProgressBar();
            this.ComPortOpenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGpsErr = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ndKurtarma = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.stKurtarma = new System.Windows.Forms.Button();
            this.lblKonum = new System.Windows.Forms.Label();
            this.lblIrtifa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.seriP1 = new System.IO.Ports.SerialPort(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblenlem = new System.Windows.Forms.Label();
            this.lblboylam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(473, 498);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(12, 12);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(453, 474);
            this.map.TabIndex = 1;
            this.map.Zoom = 0D;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.ComPortCloseButton);
            this.groupBox1.Controls.Add(this.ComPortBox);
            this.groupBox1.Controls.Add(this.ComPortStatus);
            this.groupBox1.Controls.Add(this.ComPortOpenButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(563, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(136, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Ayarları";
            // 
            // ComPortCloseButton
            // 
            this.ComPortCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComPortCloseButton.Location = new System.Drawing.Point(8, 100);
            this.ComPortCloseButton.Name = "ComPortCloseButton";
            this.ComPortCloseButton.Size = new System.Drawing.Size(120, 38);
            this.ComPortCloseButton.TabIndex = 7;
            this.ComPortCloseButton.Text = "Bağlantıyı Kes";
            this.ComPortCloseButton.UseVisualStyleBackColor = true;
            this.ComPortCloseButton.Click += new System.EventHandler(this.ComPortCloseButton_Click);
            // 
            // ComPortBox
            // 
            this.ComPortBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComPortBox.FormattingEnabled = true;
            this.ComPortBox.Location = new System.Drawing.Point(8, 31);
            this.ComPortBox.Name = "ComPortBox";
            this.ComPortBox.Size = new System.Drawing.Size(120, 21);
            this.ComPortBox.TabIndex = 6;
            // 
            // ComPortStatus
            // 
            this.ComPortStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComPortStatus.Location = new System.Drawing.Point(8, 144);
            this.ComPortStatus.Name = "ComPortStatus";
            this.ComPortStatus.Size = new System.Drawing.Size(120, 28);
            this.ComPortStatus.TabIndex = 5;
            this.ComPortStatus.Tag = "";
            // 
            // ComPortOpenButton
            // 
            this.ComPortOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComPortOpenButton.Location = new System.Drawing.Point(8, 58);
            this.ComPortOpenButton.Name = "ComPortOpenButton";
            this.ComPortOpenButton.Size = new System.Drawing.Size(120, 36);
            this.ComPortOpenButton.TabIndex = 4;
            this.ComPortOpenButton.Text = "Bağlan ";
            this.ComPortOpenButton.UseVisualStyleBackColor = true;
            this.ComPortOpenButton.Click += new System.EventHandler(this.ComPortOpenButton_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.btnGpsErr);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ndKurtarma);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.stKurtarma);
            this.groupBox2.Controls.Add(this.lblKonum);
            this.groupBox2.Controls.Add(this.lblIrtifa);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(479, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 301);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gelen Veri";
            // 
            // btnGpsErr
            // 
            this.btnGpsErr.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnGpsErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGpsErr.Location = new System.Drawing.Point(11, 141);
            this.btnGpsErr.Name = "btnGpsErr";
            this.btnGpsErr.Size = new System.Drawing.Size(152, 29);
            this.btnGpsErr.TabIndex = 33;
            this.btnGpsErr.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(210, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 31);
            this.label6.TabIndex = 32;
            this.label6.Text = "2. kurtarma";
            // 
            // ndKurtarma
            // 
            this.ndKurtarma.Location = new System.Drawing.Point(210, 241);
            this.ndKurtarma.Name = "ndKurtarma";
            this.ndKurtarma.Size = new System.Drawing.Size(145, 28);
            this.ndKurtarma.TabIndex = 31;
            this.ndKurtarma.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(12, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 31);
            this.label10.TabIndex = 30;
            this.label10.Text = "1. kurtarma";
            // 
            // stKurtarma
            // 
            this.stKurtarma.BackColor = System.Drawing.Color.LightYellow;
            this.stKurtarma.Location = new System.Drawing.Point(12, 241);
            this.stKurtarma.Name = "stKurtarma";
            this.stKurtarma.Size = new System.Drawing.Size(145, 28);
            this.stKurtarma.TabIndex = 29;
            this.stKurtarma.UseVisualStyleBackColor = false;
            // 
            // lblKonum
            // 
            this.lblKonum.AutoSize = true;
            this.lblKonum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKonum.Location = new System.Drawing.Point(6, 107);
            this.lblKonum.Name = "lblKonum";
            this.lblKonum.Size = new System.Drawing.Size(114, 31);
            this.lblKonum.TabIndex = 8;
            this.lblKonum.Text = "Konum: ";
            // 
            // lblIrtifa
            // 
            this.lblIrtifa.AutoSize = true;
            this.lblIrtifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIrtifa.Location = new System.Drawing.Point(6, 16);
            this.lblIrtifa.Name = "lblIrtifa";
            this.lblIrtifa.Size = new System.Drawing.Size(83, 31);
            this.lblIrtifa.TabIndex = 7;
            this.lblIrtifa.Text = "İrtifa: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(821, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(184, 180);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(660, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // seriP1
            // 
            this.seriP1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.seriP1_DataReceived);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            // 
            // lblenlem
            // 
            this.lblenlem.AutoSize = true;
            this.lblenlem.Location = new System.Drawing.Point(33, 13);
            this.lblenlem.Name = "lblenlem";
            this.lblenlem.Size = new System.Drawing.Size(36, 13);
            this.lblenlem.TabIndex = 8;
            this.lblenlem.Text = "Enlem";
            // 
            // lblboylam
            // 
            this.lblboylam.AutoSize = true;
            this.lblboylam.Location = new System.Drawing.Point(33, 28);
            this.lblboylam.Name = "lblboylam";
            this.lblboylam.Size = new System.Drawing.Size(41, 13);
            this.lblboylam.TabIndex = 19;
            this.lblboylam.Text = "Boylam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "E";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "map.position";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1011, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblboylam);
            this.Controls.Add(this.lblenlem);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Hafız İHO Steam Orta İrtifa - Asel 10000 - Ana Aviyonik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar ComPortStatus;
        private System.Windows.Forms.Button ComPortOpenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.IO.Ports.SerialPort seriP1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ComboBox ComPortBox;
        private System.Windows.Forms.Button ComPortCloseButton;
        private System.Windows.Forms.Label lblenlem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblboylam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKonum;
        private System.Windows.Forms.Label lblIrtifa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ndKurtarma;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button stKurtarma;
        private System.Windows.Forms.Button btnGpsErr;
        private System.Windows.Forms.Label label5;
    }
}

