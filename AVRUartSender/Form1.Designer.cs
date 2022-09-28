
namespace AVRUartSender
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Stopbit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Databit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Parity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_BaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Port_Select = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.port_connect_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.to_led_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.clear_inptextbox_btn = new System.Windows.Forms.Button();
            this.asc_textbox = new System.Windows.Forms.TextBox();
            this.clr_asc_btn = new System.Windows.Forms.Button();
            this.send_asc_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.op1_btn = new System.Windows.Forms.Button();
            this.op2_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Stopbit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_Databit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_Parity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_BaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_Port_Select);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM port settings";
            // 
            // cb_Stopbit
            // 
            this.cb_Stopbit.FormattingEnabled = true;
            this.cb_Stopbit.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_Stopbit.Location = new System.Drawing.Point(84, 163);
            this.cb_Stopbit.Name = "cb_Stopbit";
            this.cb_Stopbit.Size = new System.Drawing.Size(151, 28);
            this.cb_Stopbit.TabIndex = 11;
            this.cb_Stopbit.SelectedIndexChanged += new System.EventHandler(this.cb_Stopbit_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stop bit";
            // 
            // cb_Databit
            // 
            this.cb_Databit.FormattingEnabled = true;
            this.cb_Databit.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cb_Databit.Location = new System.Drawing.Point(84, 125);
            this.cb_Databit.Name = "cb_Databit";
            this.cb_Databit.Size = new System.Drawing.Size(151, 28);
            this.cb_Databit.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data bits";
            // 
            // cb_Parity
            // 
            this.cb_Parity.FormattingEnabled = true;
            this.cb_Parity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cb_Parity.Location = new System.Drawing.Point(84, 91);
            this.cb_Parity.Name = "cb_Parity";
            this.cb_Parity.Size = new System.Drawing.Size(151, 28);
            this.cb_Parity.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parity bit";
            // 
            // cb_BaudRate
            // 
            this.cb_BaudRate.FormattingEnabled = true;
            this.cb_BaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200"});
            this.cb_BaudRate.Location = new System.Drawing.Point(84, 57);
            this.cb_BaudRate.Name = "cb_BaudRate";
            this.cb_BaudRate.Size = new System.Drawing.Size(151, 28);
            this.cb_BaudRate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rate";
            // 
            // cb_Port_Select
            // 
            this.cb_Port_Select.FormattingEnabled = true;
            this.cb_Port_Select.Location = new System.Drawing.Point(84, 20);
            this.cb_Port_Select.Name = "cb_Port_Select";
            this.cb_Port_Select.Size = new System.Drawing.Size(151, 28);
            this.cb_Port_Select.TabIndex = 3;
            this.cb_Port_Select.SelectedIndexChanged += new System.EventHandler(this.cb_Port_Select_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM Port";
            // 
            // port_connect_btn
            // 
            this.port_connect_btn.Location = new System.Drawing.Point(12, 226);
            this.port_connect_btn.Name = "port_connect_btn";
            this.port_connect_btn.Size = new System.Drawing.Size(94, 29);
            this.port_connect_btn.TabIndex = 1;
            this.port_connect_btn.Text = "Connect";
            this.port_connect_btn.UseVisualStyleBackColor = true;
            this.port_connect_btn.Click += new System.EventHandler(this.port_connect_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.to_led_textbox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.input_textbox);
            this.groupBox2.Location = new System.Drawing.Point(332, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 119);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "send String to LED";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Your input";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "ASCII ";
            // 
            // to_led_textbox
            // 
            this.to_led_textbox.Location = new System.Drawing.Point(122, 55);
            this.to_led_textbox.MaxLength = 16;
            this.to_led_textbox.Name = "to_led_textbox";
            this.to_led_textbox.ReadOnly = true;
            this.to_led_textbox.Size = new System.Drawing.Size(328, 27);
            this.to_led_textbox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "enter the string";
            // 
            // input_textbox
            // 
            this.input_textbox.Location = new System.Drawing.Point(122, 21);
            this.input_textbox.MaxLength = 16;
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(328, 27);
            this.input_textbox.TabIndex = 0;
            this.input_textbox.TextChanged += new System.EventHandler(this.input_textbox_TextChanged);
            // 
            // clear_inptextbox_btn
            // 
            this.clear_inptextbox_btn.Location = new System.Drawing.Point(332, 172);
            this.clear_inptextbox_btn.Name = "clear_inptextbox_btn";
            this.clear_inptextbox_btn.Size = new System.Drawing.Size(152, 29);
            this.clear_inptextbox_btn.TabIndex = 4;
            this.clear_inptextbox_btn.Text = "Clear input textbox";
            this.clear_inptextbox_btn.UseVisualStyleBackColor = true;
            this.clear_inptextbox_btn.Click += new System.EventHandler(this.clear_inptextbox_btn_Click);
            // 
            // asc_textbox
            // 
            this.asc_textbox.Location = new System.Drawing.Point(454, 100);
            this.asc_textbox.MaxLength = 16;
            this.asc_textbox.Name = "asc_textbox";
            this.asc_textbox.ReadOnly = true;
            this.asc_textbox.Size = new System.Drawing.Size(328, 27);
            this.asc_textbox.TabIndex = 5;
            // 
            // clr_asc_btn
            // 
            this.clr_asc_btn.Location = new System.Drawing.Point(490, 172);
            this.clr_asc_btn.Name = "clr_asc_btn";
            this.clr_asc_btn.Size = new System.Drawing.Size(149, 29);
            this.clr_asc_btn.TabIndex = 6;
            this.clr_asc_btn.Text = "Clear ASCII Textbox";
            this.clr_asc_btn.UseVisualStyleBackColor = true;
            this.clr_asc_btn.Click += new System.EventHandler(this.clr_asc_btn_Click);
            // 
            // send_asc_btn
            // 
            this.send_asc_btn.Location = new System.Drawing.Point(332, 226);
            this.send_asc_btn.Name = "send_asc_btn";
            this.send_asc_btn.Size = new System.Drawing.Size(149, 29);
            this.send_asc_btn.TabIndex = 7;
            this.send_asc_btn.Text = "Send to LED (ASCII)";
            this.send_asc_btn.UseVisualStyleBackColor = true;
            this.send_asc_btn.Click += new System.EventHandler(this.send_asc_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "number of op.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Number of op. - send bit to UART";
            // 
            // op1_btn
            // 
            this.op1_btn.Location = new System.Drawing.Point(454, 132);
            this.op1_btn.Name = "op1_btn";
            this.op1_btn.Size = new System.Drawing.Size(94, 29);
            this.op1_btn.TabIndex = 11;
            this.op1_btn.Text = "operation1";
            this.op1_btn.UseVisualStyleBackColor = true;
            this.op1_btn.Click += new System.EventHandler(this.op1_btn_Click);
            // 
            // op2_btn
            // 
            this.op2_btn.Location = new System.Drawing.Point(554, 133);
            this.op2_btn.Name = "op2_btn";
            this.op2_btn.Size = new System.Drawing.Size(94, 29);
            this.op2_btn.TabIndex = 12;
            this.op2_btn.Text = "operation2";
            this.op2_btn.UseVisualStyleBackColor = true;
            this.op2_btn.Click += new System.EventHandler(this.op2_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.op2_btn);
            this.Controls.Add(this.op1_btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.send_asc_btn);
            this.Controls.Add(this.clr_asc_btn);
            this.Controls.Add(this.asc_textbox);
            this.Controls.Add(this.clear_inptextbox_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.port_connect_btn);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "EasyAVR UART Sender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button port_connect_btn;
        private System.Windows.Forms.ComboBox cb_Stopbit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Databit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Parity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_BaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Port_Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox to_led_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox input_textbox;
        private System.Windows.Forms.Button clear_inptextbox_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox asc_textbox;
        private System.Windows.Forms.Button clr_asc_btn;
        private System.Windows.Forms.Button send_asc_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button op1_btn;
        private System.Windows.Forms.Button op2_btn;
    }
}

