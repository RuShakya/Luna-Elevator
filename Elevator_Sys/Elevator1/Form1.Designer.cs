namespace Elevator1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gfloor = new PictureBox();
            ffloor = new PictureBox();
            pictureBox3 = new PictureBox();
            mainelevator = new PictureBox();
            btnf = new Button();
            btng = new Button();
            btnopen = new Button();
            btnclose = new Button();
            btnfirst = new Button();
            btnground = new Button();
            lifttimer = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            doortimer1 = new System.Windows.Forms.Timer(components);
            doortimer2 = new System.Windows.Forms.Timer(components);
            btnclear = new Button();
            btnexit = new Button();
            datagridviewlogs = new DataGridView();
            doorleft1 = new PictureBox();
            doorright1 = new PictureBox();
            doorright2 = new PictureBox();
            doorleft2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gfloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ffloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainelevator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewlogs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorleft1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorright1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorright2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorleft2).BeginInit();
            SuspendLayout();
            // 
            // gfloor
            // 
            gfloor.Location = new Point(228, 371);
            gfloor.Name = "gfloor";
            gfloor.Size = new Size(330, 273);
            gfloor.TabIndex = 0;
            gfloor.TabStop = false;
            // 
            // ffloor
            // 
            ffloor.Location = new Point(228, 33);
            ffloor.Name = "ffloor";
            ffloor.Size = new Size(330, 273);
            ffloor.TabIndex = 1;
            ffloor.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(781, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(206, 681);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // mainelevator
            // 
            mainelevator.BackgroundImage = (Image)resources.GetObject("mainelevator.BackgroundImage");
            mainelevator.BackgroundImageLayout = ImageLayout.Stretch;
            mainelevator.Location = new Point(229, 371);
            mainelevator.Name = "mainelevator";
            mainelevator.Size = new Size(330, 273);
            mainelevator.TabIndex = 7;
            mainelevator.TabStop = false;
            // 
            // btnf
            // 
            btnf.Location = new Point(791, 291);
            btnf.Name = "btnf";
            btnf.Size = new Size(89, 88);
            btnf.TabIndex = 8;
            btnf.Text = "First Floor";
            btnf.UseVisualStyleBackColor = true;
            btnf.Click += btn_f_click;
            // 
            // btng
            // 
            btng.Location = new Point(891, 291);
            btng.Name = "btng";
            btng.Size = new Size(89, 88);
            btng.TabIndex = 9;
            btng.Text = "Ground Floor";
            btng.UseVisualStyleBackColor = true;
            btng.Click += btn_g_click;
            // 
            // btnopen
            // 
            btnopen.Location = new Point(789, 420);
            btnopen.Name = "btnopen";
            btnopen.Size = new Size(89, 88);
            btnopen.TabIndex = 10;
            btnopen.Text = "Open Button";
            btnopen.UseVisualStyleBackColor = true;
            btnopen.Click += btn_open_click;
            // 
            // btnclose
            // 
            btnclose.Location = new Point(891, 420);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(84, 88);
            btnclose.TabIndex = 11;
            btnclose.Text = "Close Button";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btn_close_click;
            // 
            // btnfirst
            // 
            btnfirst.Location = new Point(573, 216);
            btnfirst.Name = "btnfirst";
            btnfirst.Size = new Size(89, 29);
            btnfirst.TabIndex = 12;
            btnfirst.Text = "First Floor Lift";
            btnfirst.UseVisualStyleBackColor = true;
            btnfirst.Click += btn_first_click;
            // 
            // btnground
            // 
            btnground.Location = new Point(573, 532);
            btnground.Name = "btnground";
            btnground.Size = new Size(89, 29);
            btnground.TabIndex = 13;
            btnground.Text = "Ground Floor Lift";
            btnground.UseVisualStyleBackColor = true;
            btnground.Click += btn_ground_click;
            // 
            // lifttimer
            // 
            lifttimer.Tick += lift_timer_tick;
            // 
            // doortimer1
            // 
            doortimer1.Tick += door_timer_tick_1;
            // 
            // doortimer2
            // 
            doortimer2.Tick += door_timer_tick_2;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(1084, 12);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(94, 29);
            btnclear.TabIndex = 14;
            btnclear.Text = "Clear ";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += delete_data_click;
            // 
            // btnexit
            // 
            btnexit.BackgroundImageLayout = ImageLayout.None;
            btnexit.Location = new Point(1194, 12);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 29);
            btnexit.TabIndex = 15;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += close_click;
            // 
            // datagridviewlogs
            // 
            datagridviewlogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewlogs.Location = new Point(1032, 47);
            datagridviewlogs.Name = "datagridviewlogs";
            datagridviewlogs.RowHeadersWidth = 51;
            datagridviewlogs.Size = new Size(345, 633);
            datagridviewlogs.TabIndex = 16;
            datagridviewlogs.CellContentClick += datagridviewlogs_CellContentClick;
            // 
            // doorleft1
            // 
            doorleft1.BackgroundImage = Properties.Resources.leftdoor3;
            doorleft1.BackgroundImageLayout = ImageLayout.Stretch;
            doorleft1.Location = new Point(229, 33);
            doorleft1.Name = "doorleft1";
            doorleft1.Size = new Size(166, 273);
            doorleft1.TabIndex = 17;
            doorleft1.TabStop = false;
            // 
            // doorright1
            // 
            doorright1.BackgroundImage = Properties.Resources.leftdoor13;
            doorright1.BackgroundImageLayout = ImageLayout.Stretch;
            doorright1.Location = new Point(392, 33);
            doorright1.Name = "doorright1";
            doorright1.Size = new Size(166, 273);
            doorright1.TabIndex = 18;
            doorright1.TabStop = false;
            // 
            // doorright2
            // 
            doorright2.BackgroundImage = Properties.Resources.leftdoor13;
            doorright2.BackgroundImageLayout = ImageLayout.Stretch;
            doorright2.Location = new Point(392, 371);
            doorright2.Name = "doorright2";
            doorright2.Size = new Size(166, 273);
            doorright2.TabIndex = 19;
            doorright2.TabStop = false;
            // 
            // doorleft2
            // 
            doorleft2.BackgroundImage = Properties.Resources.leftdoor3;
            doorleft2.BackgroundImageLayout = ImageLayout.Stretch;
            doorleft2.Location = new Point(229, 371);
            doorleft2.Name = "doorleft2";
            doorleft2.Size = new Size(166, 273);
            doorleft2.TabIndex = 20;
            doorleft2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 677);
            Controls.Add(doorleft2);
            Controls.Add(doorright2);
            Controls.Add(doorright1);
            Controls.Add(doorleft1);
            Controls.Add(datagridviewlogs);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btnclose);
            Controls.Add(btnopen);
            Controls.Add(btng);
            Controls.Add(btnf);
            Controls.Add(pictureBox3);
            Controls.Add(mainelevator);
            Controls.Add(gfloor);
            Controls.Add(ffloor);
            Controls.Add(btnfirst);
            Controls.Add(btnground);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gfloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)ffloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainelevator).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewlogs).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorleft1).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorright1).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorright2).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorleft2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox gfloor;
        private PictureBox ffloor;
        private PictureBox pictureBox3;
        private PictureBox mainelevator;
        private Button btnf;
        private Button btng;
        private Button btnopen;
        private Button btnclose;
        private Button btnfirst;
        private Button btnground;
        private System.Windows.Forms.Timer lifttimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer doortimer1;
        private System.Windows.Forms.Timer doortimer2;
        private Button btnclear;
        private Button btnexit;
        private DataGridView datagridviewlogs;
        private PictureBox doorleft1;
        private PictureBox doorright1;
        private PictureBox doorright2;
        private PictureBox doorleft2;
    }
}