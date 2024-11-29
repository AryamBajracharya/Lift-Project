namespace Lift_Project
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
            this.liftTimerUp = new System.Windows.Forms.Timer(this.components);
            this.doorTimer = new System.Windows.Forms.Timer(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.liftTimerDown = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.doorRight_1 = new System.Windows.Forms.PictureBox();
            this.doorLeft_1 = new System.Windows.Forms.PictureBox();
            this.doorRight_G = new System.Windows.Forms.PictureBox();
            this.doorLeft_G = new System.Windows.Forms.PictureBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_G = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mainElevator = new System.Windows.Forms.PictureBox();
            this.fFloorBack = new System.Windows.Forms.PictureBox();
            this.gFloorBack = new System.Windows.Forms.PictureBox();
            this.down_button = new System.Windows.Forms.Button();
            this.groundFloor = new System.Windows.Forms.PictureBox();
            this.up_button = new System.Windows.Forms.Button();
            this.firstFloor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainElevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFloorBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gFloorBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // liftTimerUp
            // 
            this.liftTimerUp.Tick += new System.EventHandler(this.liftTimerUp_Tick);
            // 
            // doorTimer
            // 
            this.doorTimer.Tick += new System.EventHandler(this.door_Timer_Tick);
            // 
            // dataGridView
            // 
            this.dataGridView.AccessibleName = "Datagridview";
            this.dataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(819, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(354, 597);
            this.dataGridView.TabIndex = 14;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // liftTimerDown
            // 
            this.liftTimerDown.Tick += new System.EventHandler(this.liftTimerDown_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(636, 61);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(93, 121);
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(636, 61);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(93, 121);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Lift_Project.Properties.Resources.downArrow;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(636, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 121);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Lift_Project.Properties.Resources.upArrow;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(636, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 121);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(765, 530);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 55);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // doorRight_1
            // 
            this.doorRight_1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doorRight_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doorRight_1.BackgroundImage")));
            this.doorRight_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorRight_1.Location = new System.Drawing.Point(271, 39);
            this.doorRight_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doorRight_1.Name = "doorRight_1";
            this.doorRight_1.Size = new System.Drawing.Size(79, 239);
            this.doorRight_1.TabIndex = 13;
            this.doorRight_1.TabStop = false;
            // 
            // doorLeft_1
            // 
            this.doorLeft_1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.doorLeft_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doorLeft_1.BackgroundImage")));
            this.doorLeft_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorLeft_1.Location = new System.Drawing.Point(198, 39);
            this.doorLeft_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doorLeft_1.Name = "doorLeft_1";
            this.doorLeft_1.Size = new System.Drawing.Size(78, 239);
            this.doorLeft_1.TabIndex = 12;
            this.doorLeft_1.TabStop = false;
            // 
            // doorRight_G
            // 
            this.doorRight_G.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doorRight_G.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doorRight_G.BackgroundImage")));
            this.doorRight_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorRight_G.Location = new System.Drawing.Point(271, 360);
            this.doorRight_G.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doorRight_G.Name = "doorRight_G";
            this.doorRight_G.Size = new System.Drawing.Size(79, 237);
            this.doorRight_G.TabIndex = 11;
            this.doorRight_G.TabStop = false;
            // 
            // doorLeft_G
            // 
            this.doorLeft_G.BackColor = System.Drawing.SystemColors.ControlDark;
            this.doorLeft_G.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doorLeft_G.BackgroundImage")));
            this.doorLeft_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorLeft_G.Location = new System.Drawing.Point(198, 360);
            this.doorLeft_G.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doorLeft_G.Name = "doorLeft_G";
            this.doorLeft_G.Size = new System.Drawing.Size(78, 237);
            this.doorLeft_G.TabIndex = 9;
            this.doorLeft_G.TabStop = false;
            // 
            // btn_Open
            // 
            this.btn_Open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Open.BackgroundImage")));
            this.btn_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Open.Location = new System.Drawing.Point(623, 385);
            this.btn_Open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(51, 50);
            this.btn_Open.TabIndex = 6;
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Location = new System.Drawing.Point(689, 385);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(51, 50);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_1
            // 
            this.btn_1.AccessibleName = "btn_1";
            this.btn_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_1.BackgroundImage")));
            this.btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_1.Location = new System.Drawing.Point(654, 220);
            this.btn_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(57, 58);
            this.btn_1.TabIndex = 4;
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_G
            // 
            this.btn_G.AccessibleName = "btn_G";
            this.btn_G.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_G.BackgroundImage")));
            this.btn_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_G.Location = new System.Drawing.Point(654, 291);
            this.btn_G.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_G.Name = "btn_G";
            this.btn_G.Size = new System.Drawing.Size(57, 58);
            this.btn_G.TabIndex = 3;
            this.btn_G.UseVisualStyleBackColor = true;
            this.btn_G.Click += new System.EventHandler(this.btn_G_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(604, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 597);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // mainElevator
            // 
            this.mainElevator.AccessibleName = "Main Elevator";
            this.mainElevator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainElevator.BackgroundImage")));
            this.mainElevator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainElevator.InitialImage = null;
            this.mainElevator.Location = new System.Drawing.Point(199, 360);
            this.mainElevator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainElevator.Name = "mainElevator";
            this.mainElevator.Size = new System.Drawing.Size(151, 193);
            this.mainElevator.TabIndex = 0;
            this.mainElevator.TabStop = false;
            // 
            // fFloorBack
            // 
            this.fFloorBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fFloorBack.Location = new System.Drawing.Point(198, 39);
            this.fFloorBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fFloorBack.Name = "fFloorBack";
            this.fFloorBack.Size = new System.Drawing.Size(151, 193);
            this.fFloorBack.TabIndex = 19;
            this.fFloorBack.TabStop = false;
            // 
            // gFloorBack
            // 
            this.gFloorBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gFloorBack.Location = new System.Drawing.Point(198, 360);
            this.gFloorBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gFloorBack.Name = "gFloorBack";
            this.gFloorBack.Size = new System.Drawing.Size(151, 193);
            this.gFloorBack.TabIndex = 20;
            this.gFloorBack.TabStop = false;
            // 
            // down_button
            // 
            this.down_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("down_button.BackgroundImage")));
            this.down_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.down_button.Location = new System.Drawing.Point(385, 449);
            this.down_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(27, 25);
            this.down_button.TabIndex = 22;
            this.down_button.UseVisualStyleBackColor = true;
            this.down_button.Click += new System.EventHandler(this.down_button_Click);
            // 
            // groundFloor
            // 
            this.groundFloor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groundFloor.BackgroundImage")));
            this.groundFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groundFloor.Location = new System.Drawing.Point(11, 319);
            this.groundFloor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groundFloor.Name = "groundFloor";
            this.groundFloor.Size = new System.Drawing.Size(526, 278);
            this.groundFloor.TabIndex = 18;
            this.groundFloor.TabStop = false;
            this.groundFloor.Click += new System.EventHandler(this.groundFloor_Click);
            // 
            // up_button
            // 
            this.up_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("up_button.BackgroundImage")));
            this.up_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.up_button.Location = new System.Drawing.Point(385, 114);
            this.up_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(27, 25);
            this.up_button.TabIndex = 23;
            this.up_button.UseVisualStyleBackColor = true;
            this.up_button.Click += new System.EventHandler(this.up_button_Click);
            // 
            // firstFloor
            // 
            this.firstFloor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstFloor.BackgroundImage")));
            this.firstFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstFloor.Location = new System.Drawing.Point(11, 0);
            this.firstFloor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstFloor.Name = "firstFloor";
            this.firstFloor.Size = new System.Drawing.Size(526, 278);
            this.firstFloor.TabIndex = 17;
            this.firstFloor.TabStop = false;
            // 
            // Form1
            // 
            this.AccessibleName = "doorTimer";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 596);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.doorRight_1);
            this.Controls.Add(this.doorLeft_1);
            this.Controls.Add(this.doorRight_G);
            this.Controls.Add(this.doorLeft_G);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_G);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mainElevator);
            this.Controls.Add(this.fFloorBack);
            this.Controls.Add(this.gFloorBack);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.down_button);
            this.Controls.Add(this.groundFloor);
            this.Controls.Add(this.up_button);
            this.Controls.Add(this.firstFloor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heaven\'s Door";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainElevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFloorBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gFloorBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFloor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainElevator;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_G;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Timer liftTimerUp;
        private System.Windows.Forms.PictureBox doorLeft_G;
        private System.Windows.Forms.PictureBox doorRight_G;
        private System.Windows.Forms.Timer doorTimer;
        private System.Windows.Forms.PictureBox doorLeft_1;
        private System.Windows.Forms.PictureBox doorRight_1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer liftTimerDown;
        private System.Windows.Forms.PictureBox firstFloor;
        private System.Windows.Forms.PictureBox groundFloor;
        private System.Windows.Forms.PictureBox fFloorBack;
        private System.Windows.Forms.PictureBox gFloorBack;
        //private System.Windows.Forms.Label lblFloorStatus;
        private System.Windows.Forms.Button down_button;
        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

