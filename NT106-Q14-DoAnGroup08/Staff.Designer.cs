namespace NT106_Q14_DoAnGroup08
{
    partial class Staff
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
            this.ButtonGroup = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ImportGoodButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.ButtonGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonGroup
            // 
            this.ButtonGroup.Controls.Add(this.button3);
            this.ButtonGroup.Controls.Add(this.button5);
            this.ButtonGroup.Controls.Add(this.button4);
            this.ButtonGroup.Controls.Add(this.ImportGoodButton);
            this.ButtonGroup.Controls.Add(this.button2);
            this.ButtonGroup.Controls.Add(this.button1);
            this.ButtonGroup.Location = new System.Drawing.Point(12, 12);
            this.ButtonGroup.Name = "ButtonGroup";
            this.ButtonGroup.Size = new System.Drawing.Size(93, 629);
            this.ButtonGroup.TabIndex = 1;
            this.ButtonGroup.TabStop = false;
            this.ButtonGroup.Text = "Trang";
            this.ButtonGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 60);
            this.button5.TabIndex = 4;
            this.button5.Text = "Chat";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "Hóa đơn";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ImportGoodButton
            // 
            this.ImportGoodButton.Location = new System.Drawing.Point(6, 153);
            this.ImportGoodButton.Name = "ImportGoodButton";
            this.ImportGoodButton.Size = new System.Drawing.Size(75, 60);
            this.ImportGoodButton.TabIndex = 2;
            this.ImportGoodButton.Text = " Nhập hàng";
            this.ImportGoodButton.UseVisualStyleBackColor = true;
            this.ImportGoodButton.Click += new System.EventHandler(this.ImportGoodButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thực đơn";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quản lý máy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UserPanel.Location = new System.Drawing.Point(111, 12);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(1033, 640);
            this.UserPanel.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 60);
            this.button3.TabIndex = 5;
            this.button3.Text = "Tài khoản";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1156, 664);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.ButtonGroup);
            this.Name = "Staff";
            this.Text = "Staff App";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.ButtonGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ButtonGroup;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ImportGoodButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Button button3;
    }
}