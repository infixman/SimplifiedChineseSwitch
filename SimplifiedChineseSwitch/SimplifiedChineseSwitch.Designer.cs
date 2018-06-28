namespace SimplifiedChineseSwitch
{
    partial class SimplifiedChineseSwitch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimplifiedChineseSwitch));
            this.lbl_status = new System.Windows.Forms.Label();
            this.noti_icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_Switch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(93, 17);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(13, 13);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "?";
            // 
            // noti_icon
            // 
            this.noti_icon.Text = "notifyIcon1";
            this.noti_icon.Visible = true;
            this.noti_icon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.noti_icon_MouseClick);
            // 
            // btn_Switch
            // 
            this.btn_Switch.Location = new System.Drawing.Point(12, 12);
            this.btn_Switch.Name = "btn_Switch";
            this.btn_Switch.Size = new System.Drawing.Size(75, 23);
            this.btn_Switch.TabIndex = 3;
            this.btn_Switch.Text = "Switch";
            this.btn_Switch.UseVisualStyleBackColor = true;
            this.btn_Switch.Click += new System.EventHandler(this.btn_Switch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "最小化將隱藏至系統列";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "左鍵點擊系統列Icon可快速切換正體/簡體";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "右鍵點擊系統列Icon可叫出視窗";
            // 
            // SimplifiedChineseSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 91);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Switch);
            this.Controls.Add(this.lbl_status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SimplifiedChineseSwitch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimplifiedChineseSwitch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimplifiedChineseSwitch_FormClosing);
            this.Load += new System.EventHandler(this.SimplifiedChineseSwitch_Load);
            this.Resize += new System.EventHandler(this.SimplifiedChineseSwitch_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.NotifyIcon noti_icon;
        private System.Windows.Forms.Button btn_Switch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

