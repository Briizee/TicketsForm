
namespace TicketsForm
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
            this.components = new System.ComponentModel.Container();
            this.grpTickNumCanEnter = new System.Windows.Forms.GroupBox();
            this.lblTicksCanEnter = new System.Windows.Forms.Label();
            this.grpTickAvailability = new System.Windows.Forms.GroupBox();
            this.btnIssueTicket = new System.Windows.Forms.Button();
            this.lblNextAvailTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTickOutsanding = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstVwTickets = new System.Windows.Forms.ListView();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpTickNumCanEnter.SuspendLayout();
            this.grpTickAvailability.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTickNumCanEnter
            // 
            this.grpTickNumCanEnter.Controls.Add(this.lblTicksCanEnter);
            this.grpTickNumCanEnter.Location = new System.Drawing.Point(29, 28);
            this.grpTickNumCanEnter.Name = "grpTickNumCanEnter";
            this.grpTickNumCanEnter.Size = new System.Drawing.Size(296, 57);
            this.grpTickNumCanEnter.TabIndex = 0;
            this.grpTickNumCanEnter.TabStop = false;
            this.grpTickNumCanEnter.Text = "Guests with the following tickets may now enter:";
            // 
            // lblTicksCanEnter
            // 
            this.lblTicksCanEnter.AutoSize = true;
            this.lblTicksCanEnter.Location = new System.Drawing.Point(17, 23);
            this.lblTicksCanEnter.Name = "lblTicksCanEnter";
            this.lblTicksCanEnter.Size = new System.Drawing.Size(0, 15);
            this.lblTicksCanEnter.TabIndex = 0;
            // 
            // grpTickAvailability
            // 
            this.grpTickAvailability.Controls.Add(this.btnIssueTicket);
            this.grpTickAvailability.Controls.Add(this.lblNextAvailTime);
            this.grpTickAvailability.Controls.Add(this.label2);
            this.grpTickAvailability.Controls.Add(this.lblTickOutsanding);
            this.grpTickAvailability.Controls.Add(this.label1);
            this.grpTickAvailability.Location = new System.Drawing.Point(29, 104);
            this.grpTickAvailability.Name = "grpTickAvailability";
            this.grpTickAvailability.Size = new System.Drawing.Size(296, 100);
            this.grpTickAvailability.TabIndex = 1;
            this.grpTickAvailability.TabStop = false;
            this.grpTickAvailability.Text = "Ticket Availability";
            // 
            // btnIssueTicket
            // 
            this.btnIssueTicket.Location = new System.Drawing.Point(17, 61);
            this.btnIssueTicket.Name = "btnIssueTicket";
            this.btnIssueTicket.Size = new System.Drawing.Size(120, 22);
            this.btnIssueTicket.TabIndex = 4;
            this.btnIssueTicket.Text = "Issue Ticket";
            this.btnIssueTicket.UseVisualStyleBackColor = true;
            // 
            // lblNextAvailTime
            // 
            this.lblNextAvailTime.AutoSize = true;
            this.lblNextAvailTime.Location = new System.Drawing.Point(162, 43);
            this.lblNextAvailTime.Name = "lblNextAvailTime";
            this.lblNextAvailTime.Size = new System.Drawing.Size(0, 15);
            this.lblNextAvailTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Next available entry:";
            // 
            // lblTickOutsanding
            // 
            this.lblTickOutsanding.AutoSize = true;
            this.lblTickOutsanding.Location = new System.Drawing.Point(162, 19);
            this.lblTickOutsanding.Name = "lblTickOutsanding";
            this.lblTickOutsanding.Size = new System.Drawing.Size(0, 15);
            this.lblTickOutsanding.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total tickets outstanding:";
            // 
            // lstVwTickets
            // 
            this.lstVwTickets.HideSelection = false;
            this.lstVwTickets.Location = new System.Drawing.Point(29, 226);
            this.lstVwTickets.Name = "lstVwTickets";
            this.lstVwTickets.Size = new System.Drawing.Size(296, 165);
            this.lstVwTickets.TabIndex = 2;
            this.lstVwTickets.UseCompatibleStateImageBehavior = false;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(29, 411);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 3;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(249, 410);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnIssueTicket;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lstVwTickets);
            this.Controls.Add(this.grpTickAvailability);
            this.Controls.Add(this.grpTickNumCanEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpTickNumCanEnter.ResumeLayout(false);
            this.grpTickNumCanEnter.PerformLayout();
            this.grpTickAvailability.ResumeLayout(false);
            this.grpTickAvailability.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTickNumCanEnter;
        private System.Windows.Forms.GroupBox grpTickAvailability;
        private System.Windows.Forms.Label lblNextAvailTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTickOutsanding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTicksCanEnter;
        private System.Windows.Forms.Button btnIssueTicket;
        private System.Windows.Forms.ListView lstVwTickets;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer1;
    }
}

