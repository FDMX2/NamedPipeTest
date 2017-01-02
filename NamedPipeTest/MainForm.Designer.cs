namespace PipeTest
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_pipes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_refresh = new System.Windows.Forms.Button();
            this.b_connect = new System.Windows.Forms.Button();
            this.rtb_Output = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.b_send = new System.Windows.Forms.Button();
            this.cb_Autoscroll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_pipes
            // 
            this.cb_pipes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pipes.FormattingEnabled = true;
            this.cb_pipes.Location = new System.Drawing.Point(90, 12);
            this.cb_pipes.Name = "cb_pipes";
            this.cb_pipes.Size = new System.Drawing.Size(397, 21);
            this.cb_pipes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Named pipes:";
            // 
            // b_refresh
            // 
            this.b_refresh.Location = new System.Drawing.Point(493, 12);
            this.b_refresh.Name = "b_refresh";
            this.b_refresh.Size = new System.Drawing.Size(75, 23);
            this.b_refresh.TabIndex = 2;
            this.b_refresh.Text = "refresh";
            this.b_refresh.UseVisualStyleBackColor = true;
            this.b_refresh.Click += new System.EventHandler(this.b_refresh_Click);
            // 
            // b_connect
            // 
            this.b_connect.Location = new System.Drawing.Point(574, 12);
            this.b_connect.Name = "b_connect";
            this.b_connect.Size = new System.Drawing.Size(75, 23);
            this.b_connect.TabIndex = 3;
            this.b_connect.Text = "connect";
            this.b_connect.UseVisualStyleBackColor = true;
            this.b_connect.Click += new System.EventHandler(this.b_connect_Click);
            // 
            // rtb_Output
            // 
            this.rtb_Output.Location = new System.Drawing.Point(15, 39);
            this.rtb_Output.Name = "rtb_Output";
            this.rtb_Output.ReadOnly = true;
            this.rtb_Output.Size = new System.Drawing.Size(634, 238);
            this.rtb_Output.TabIndex = 4;
            this.rtb_Output.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "input";
            // 
            // tb_input
            // 
            this.tb_input.Enabled = false;
            this.tb_input.Location = new System.Drawing.Point(150, 286);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(442, 20);
            this.tb_input.TabIndex = 6;
            // 
            // b_send
            // 
            this.b_send.Location = new System.Drawing.Point(598, 284);
            this.b_send.Name = "b_send";
            this.b_send.Size = new System.Drawing.Size(51, 23);
            this.b_send.TabIndex = 7;
            this.b_send.Text = "send";
            this.b_send.UseVisualStyleBackColor = true;
            this.b_send.Click += new System.EventHandler(this.b_send_Click);
            // 
            // cb_Autoscroll
            // 
            this.cb_Autoscroll.AutoSize = true;
            this.cb_Autoscroll.Checked = true;
            this.cb_Autoscroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Autoscroll.Location = new System.Drawing.Point(15, 289);
            this.cb_Autoscroll.Name = "cb_Autoscroll";
            this.cb_Autoscroll.Size = new System.Drawing.Size(71, 17);
            this.cb_Autoscroll.TabIndex = 8;
            this.cb_Autoscroll.Text = "autoscroll";
            this.cb_Autoscroll.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 316);
            this.Controls.Add(this.cb_Autoscroll);
            this.Controls.Add(this.b_send);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_Output);
            this.Controls.Add(this.b_connect);
            this.Controls.Add(this.b_refresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_pipes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Namedpipe tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_pipes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_refresh;
        private System.Windows.Forms.Button b_connect;
        private System.Windows.Forms.RichTextBox rtb_Output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Button b_send;
        private System.Windows.Forms.CheckBox cb_Autoscroll;
    }
}

