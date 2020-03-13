namespace TGG_Login
{
    partial class Dashboard
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
            this.Dashboard_panel = new System.Windows.Forms.Panel();
            this.past_deadline_TXT = new System.Windows.Forms.Label();
            this.unresolved_incidents_TXT = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.show_list_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_dashboardViewTicketList = new System.Windows.Forms.Panel();
            this.dash_back_btn = new System.Windows.Forms.Button();
            this.listView_dashboard = new System.Windows.Forms.ListView();
            this.Dashboard_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_dashboardViewTicketList.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dashboard_panel
            // 
            this.Dashboard_panel.Controls.Add(this.past_deadline_TXT);
            this.Dashboard_panel.Controls.Add(this.unresolved_incidents_TXT);
            this.Dashboard_panel.Controls.Add(this.label9);
            this.Dashboard_panel.Controls.Add(this.label8);
            this.Dashboard_panel.Controls.Add(this.label7);
            this.Dashboard_panel.Controls.Add(this.label6);
            this.Dashboard_panel.Controls.Add(this.label5);
            this.Dashboard_panel.Controls.Add(this.show_list_btn);
            this.Dashboard_panel.Controls.Add(this.menuStrip1);
            this.Dashboard_panel.Location = new System.Drawing.Point(1, 0);
            this.Dashboard_panel.Name = "Dashboard_panel";
            this.Dashboard_panel.Size = new System.Drawing.Size(476, 405);
            this.Dashboard_panel.TabIndex = 8;
            // 
            // past_deadline_TXT
            // 
            this.past_deadline_TXT.AutoSize = true;
            this.past_deadline_TXT.Location = new System.Drawing.Point(336, 226);
            this.past_deadline_TXT.Name = "past_deadline_TXT";
            this.past_deadline_TXT.Size = new System.Drawing.Size(31, 13);
            this.past_deadline_TXT.TabIndex = 10;
            this.past_deadline_TXT.Text = "????";
            // 
            // unresolved_incidents_TXT
            // 
            this.unresolved_incidents_TXT.AutoSize = true;
            this.unresolved_incidents_TXT.Location = new System.Drawing.Point(62, 226);
            this.unresolved_incidents_TXT.Name = "unresolved_incidents_TXT";
            this.unresolved_incidents_TXT.Size = new System.Drawing.Size(31, 13);
            this.unresolved_incidents_TXT.TabIndex = 9;
            this.unresolved_incidents_TXT.Text = "????";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "These tickets need imidiate attention";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "All tickets currently open";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(266, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Incidents past deadline";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Unresolved incidents";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current incidents";
            // 
            // show_list_btn
            // 
            this.show_list_btn.Location = new System.Drawing.Point(336, 51);
            this.show_list_btn.Name = "show_list_btn";
            this.show_list_btn.Size = new System.Drawing.Size(75, 23);
            this.show_list_btn.TabIndex = 1;
            this.show_list_btn.Text = "Show List";
            this.show_list_btn.UseVisualStyleBackColor = true;
            this.show_list_btn.Click += new System.EventHandler(this.Show_list_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.incidentManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(476, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // incidentManagementToolStripMenuItem
            // 
            this.incidentManagementToolStripMenuItem.Name = "incidentManagementToolStripMenuItem";
            this.incidentManagementToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.incidentManagementToolStripMenuItem.Text = "Incident Management";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // panel_dashboardViewTicketList
            // 
            this.panel_dashboardViewTicketList.Controls.Add(this.listView_dashboard);
            this.panel_dashboardViewTicketList.Controls.Add(this.dash_back_btn);
            this.panel_dashboardViewTicketList.Location = new System.Drawing.Point(0, 27);
            this.panel_dashboardViewTicketList.Name = "panel_dashboardViewTicketList";
            this.panel_dashboardViewTicketList.Size = new System.Drawing.Size(476, 378);
            this.panel_dashboardViewTicketList.TabIndex = 11;
            // 
            // dash_back_btn
            // 
            this.dash_back_btn.Location = new System.Drawing.Point(336, 21);
            this.dash_back_btn.Name = "dash_back_btn";
            this.dash_back_btn.Size = new System.Drawing.Size(75, 23);
            this.dash_back_btn.TabIndex = 0;
            this.dash_back_btn.Text = "Back";
            this.dash_back_btn.UseVisualStyleBackColor = true;
            this.dash_back_btn.Click += new System.EventHandler(this.Dash_back_btn_Click);
            // 
            // listView_dashboard
            // 
            this.listView_dashboard.GridLines = true;
            this.listView_dashboard.HideSelection = false;
            this.listView_dashboard.Location = new System.Drawing.Point(42, 81);
            this.listView_dashboard.Name = "listView_dashboard";
            this.listView_dashboard.Size = new System.Drawing.Size(385, 240);
            this.listView_dashboard.TabIndex = 1;
            this.listView_dashboard.UseCompatibleStateImageBehavior = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 405);
            this.Controls.Add(this.Dashboard_panel);
            this.Controls.Add(this.panel_dashboardViewTicketList);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Dashboard_panel.ResumeLayout(false);
            this.Dashboard_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_dashboardViewTicketList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Dashboard_panel;
        private System.Windows.Forms.Label past_deadline_TXT;
        private System.Windows.Forms.Label unresolved_incidents_TXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button show_list_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.Panel panel_dashboardViewTicketList;
        private System.Windows.Forms.ListView listView_dashboard;
        private System.Windows.Forms.Button dash_back_btn;
    }
}