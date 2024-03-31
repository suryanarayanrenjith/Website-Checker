namespace Website_Checker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            notifyIcon1 = new NotifyIcon(components);
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(478, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(12, 96);
            button1.Name = "button1";
            button1.Size = new Size(478, 29);
            button1.TabIndex = 1;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(478, 27);
            textBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(12, 212);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Apply";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 17);
            label1.TabIndex = 4;
            label1.Text = "Enter Website:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, -4);
            label2.Name = "label2";
            label2.Size = new Size(79, 24);
            label2.TabIndex = 5;
            label2.Text = "Advanced";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 152);
            label3.Name = "label3";
            label3.Size = new Size(81, 17);
            label3.TabIndex = 6;
            label3.Text = "Useragent:";
            // 
            // button3
            // 
            button3.Location = new Point(112, 212);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(229, 212);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 29);
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(-1, 3);
            label4.Name = "label4";
            label4.Size = new Size(242, 20);
            label4.TabIndex = 0;
            label4.Text = "Website Link Checker v1.0.0";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(190, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(115, 21);
            panel2.TabIndex = 9;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Historic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(388, 148);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(92, 21);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Tray Icon";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 253);
            Controls.Add(checkBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Website Checker";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private NotifyIcon notifyIcon1;
        private CheckBox checkBox1;
    }
}
