namespace Shya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Speaker = new System.Windows.Forms.Button();
            this.button_DoorSwitch = new System.Windows.Forms.Button();
            this.button_SwitchSecond = new System.Windows.Forms.Button();
            this.button_SwitchFirst = new System.Windows.Forms.Button();
            this.label_Owner = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.serialPortCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_setPort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_Speaker);
            this.panel1.Controls.Add(this.button_DoorSwitch);
            this.panel1.Controls.Add(this.button_SwitchSecond);
            this.panel1.Controls.Add(this.button_SwitchFirst);
            this.panel1.Location = new System.Drawing.Point(7, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 112);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "DOOR BELL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "DOOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "BULB-2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "BULB-1";
            // 
            // button_Speaker
            // 
            this.button_Speaker.Image = ((System.Drawing.Image)(resources.GetObject("button_Speaker.Image")));
            this.button_Speaker.Location = new System.Drawing.Point(293, 24);
            this.button_Speaker.Name = "button_Speaker";
            this.button_Speaker.Size = new System.Drawing.Size(75, 60);
            this.button_Speaker.TabIndex = 3;
            this.button_Speaker.UseVisualStyleBackColor = true;
            this.button_Speaker.Click += new System.EventHandler(this.button_Speaker_Click);
            // 
            // button_DoorSwitch
            // 
            this.button_DoorSwitch.Image = ((System.Drawing.Image)(resources.GetObject("button_DoorSwitch.Image")));
            this.button_DoorSwitch.Location = new System.Drawing.Point(198, 24);
            this.button_DoorSwitch.Name = "button_DoorSwitch";
            this.button_DoorSwitch.Size = new System.Drawing.Size(75, 60);
            this.button_DoorSwitch.TabIndex = 2;
            this.button_DoorSwitch.UseVisualStyleBackColor = true;
            this.button_DoorSwitch.Click += new System.EventHandler(this.button_DoorSwitch_Click);
            // 
            // button_SwitchSecond
            // 
            this.button_SwitchSecond.Image = ((System.Drawing.Image)(resources.GetObject("button_SwitchSecond.Image")));
            this.button_SwitchSecond.Location = new System.Drawing.Point(99, 24);
            this.button_SwitchSecond.Name = "button_SwitchSecond";
            this.button_SwitchSecond.Size = new System.Drawing.Size(75, 60);
            this.button_SwitchSecond.TabIndex = 1;
            this.button_SwitchSecond.UseVisualStyleBackColor = true;
            this.button_SwitchSecond.Click += new System.EventHandler(this.button_SwitchSecond_Click);
            // 
            // button_SwitchFirst
            // 
            this.button_SwitchFirst.Image = ((System.Drawing.Image)(resources.GetObject("button_SwitchFirst.Image")));
            this.button_SwitchFirst.Location = new System.Drawing.Point(15, 24);
            this.button_SwitchFirst.Name = "button_SwitchFirst";
            this.button_SwitchFirst.Size = new System.Drawing.Size(75, 60);
            this.button_SwitchFirst.TabIndex = 0;
            this.button_SwitchFirst.UseVisualStyleBackColor = true;
            this.button_SwitchFirst.Click += new System.EventHandler(this.button_SwitchFirst_Click);
            // 
            // label_Owner
            // 
            this.label_Owner.AutoSize = true;
            this.label_Owner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Owner.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Owner.Location = new System.Drawing.Point(0, 220);
            this.label_Owner.Name = "label_Owner";
            this.label_Owner.Size = new System.Drawing.Size(67, 15);
            this.label_Owner.TabIndex = 2;
            this.label_Owner.Text = "Green Syntax";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(337, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Settings";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(274, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Help";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // serialPortCombo
            // 
            this.serialPortCombo.FormattingEnabled = true;
            this.serialPortCombo.Items.AddRange(new object[] {
            "COM5"});
            this.serialPortCombo.Location = new System.Drawing.Point(12, 67);
            this.serialPortCombo.Name = "serialPortCombo";
            this.serialPortCombo.Size = new System.Drawing.Size(106, 21);
            this.serialPortCombo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arduino Port";
            // 
            // button_setPort
            // 
            this.button_setPort.Image = ((System.Drawing.Image)(resources.GetObject("button_setPort.Image")));
            this.button_setPort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_setPort.Location = new System.Drawing.Point(124, 66);
            this.button_setPort.Name = "button_setPort";
            this.button_setPort.Size = new System.Drawing.Size(57, 21);
            this.button_setPort.TabIndex = 6;
            this.button_setPort.Text = "Set";
            this.button_setPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_setPort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 235);
            this.Controls.Add(this.button_setPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serialPortCombo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Owner);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Shya v1.0 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_SwitchSecond;
        private System.Windows.Forms.Button button_SwitchFirst;
        private System.Windows.Forms.Button button_Speaker;
        private System.Windows.Forms.Button button_DoorSwitch;
        private System.Windows.Forms.Label label_Owner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox serialPortCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_setPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;

    }
}

