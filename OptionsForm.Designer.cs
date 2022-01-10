
namespace TicketsForm
{
    partial class OptionsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinPerWindow = new System.Windows.Forms.TextBox();
            this.txtGuestsPerWindow = new System.Windows.Forms.TextBox();
            this.TimeStart = new System.Windows.Forms.DateTimePicker();
            this.TimeEnd = new System.Windows.Forms.DateTimePicker();
            this.txtFirstTicketNum = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minutes per window:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guests per window:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "End time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "First ticket number:";
            // 
            // txtMinPerWindow
            // 
            this.txtMinPerWindow.Location = new System.Drawing.Point(148, 16);
            this.txtMinPerWindow.Name = "txtMinPerWindow";
            this.txtMinPerWindow.Size = new System.Drawing.Size(100, 23);
            this.txtMinPerWindow.TabIndex = 5;
            this.txtMinPerWindow.Text = "5";
            // 
            // txtGuestsPerWindow
            // 
            this.txtGuestsPerWindow.Location = new System.Drawing.Point(148, 53);
            this.txtGuestsPerWindow.Name = "txtGuestsPerWindow";
            this.txtGuestsPerWindow.Size = new System.Drawing.Size(100, 23);
            this.txtGuestsPerWindow.TabIndex = 6;
            this.txtGuestsPerWindow.Text = "5";
            // 
            // TimeStart
            // 
            this.TimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeStart.Location = new System.Drawing.Point(148, 89);
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.Size = new System.Drawing.Size(100, 23);
            this.TimeStart.TabIndex = 7;
            // 
            // TimeEnd
            // 
            this.TimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeEnd.Location = new System.Drawing.Point(148, 129);
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.Size = new System.Drawing.Size(100, 23);
            this.TimeEnd.TabIndex = 8;
            // 
            // txtFirstTicketNum
            // 
            this.txtFirstTicketNum.Location = new System.Drawing.Point(148, 172);
            this.txtFirstTicketNum.Name = "txtFirstTicketNum";
            this.txtFirstTicketNum.Size = new System.Drawing.Size(100, 23);
            this.txtFirstTicketNum.TabIndex = 9;
            this.txtFirstTicketNum.Text = "1";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(148, 217);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 332);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtFirstTicketNum);
            this.Controls.Add(this.TimeEnd);
            this.Controls.Add(this.TimeStart);
            this.Controls.Add(this.txtGuestsPerWindow);
            this.Controls.Add(this.txtMinPerWindow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinPerWindow;
        private System.Windows.Forms.TextBox txtGuestsPerWindow;
        private System.Windows.Forms.DateTimePicker TimeStart;
        private System.Windows.Forms.DateTimePicker TimeEnd;
        private System.Windows.Forms.TextBox txtFirstTicketNum;
        private System.Windows.Forms.Button btnOk;
    }
}