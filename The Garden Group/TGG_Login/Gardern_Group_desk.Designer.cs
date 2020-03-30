namespace TGG_Login
{
    partial class Gardern_Group_desk
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
            this.lbl_Incidentsmanagement_listviewTitle_solved = new System.Windows.Forms.Label();
            this.listView_dashboard_SolvedTickets = new System.Windows.Forms.ListView();
            this.lbl_Incidentsmanagement_listviewTitle_Current = new System.Windows.Forms.Label();
            this.lbl_Title_Incidentmanagement = new System.Windows.Forms.Label();
            this.listView_dashboard = new System.Windows.Forms.ListView();
            this.incident_management_Panel = new System.Windows.Forms.Panel();
            this.go_create_incident_BTN = new System.Windows.Forms.Button();
            this.listView_incidents = new System.Windows.Forms.ListView();
            this.create_ticket_Panel = new System.Windows.Forms.Panel();
            this.add_incident_type_TextBox = new System.Windows.Forms.TextBox();
            this.select_priority_ComboBox = new System.Windows.Forms.ComboBox();
            this.lbl_Clock_create_ticket = new System.Windows.Forms.Label();
            this.ticket_deadlineTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.type_name_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel_of_create_ticket = new System.Windows.Forms.Button();
            this.ticket_description_TextBox = new System.Windows.Forms.RichTextBox();
            this.ticket_subject_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.create_ticket_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.txtBox_filterEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Dashboard_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_dashboardViewTicketList.SuspendLayout();
            this.incident_management_Panel.SuspendLayout();
            this.create_ticket_Panel.SuspendLayout();
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
            this.Dashboard_panel.Location = new System.Drawing.Point(0, 0);
            this.Dashboard_panel.Name = "Dashboard_panel";
            this.Dashboard_panel.Size = new System.Drawing.Size(638, 537);
            this.Dashboard_panel.TabIndex = 8;
            // 
            // past_deadline_TXT
            // 
            this.past_deadline_TXT.AutoSize = true;
            this.past_deadline_TXT.Location = new System.Drawing.Point(415, 226);
            this.past_deadline_TXT.Name = "past_deadline_TXT";
            this.past_deadline_TXT.Size = new System.Drawing.Size(31, 13);
            this.past_deadline_TXT.TabIndex = 10;
            this.past_deadline_TXT.Text = "????";
            // 
            // unresolved_incidents_TXT
            // 
            this.unresolved_incidents_TXT.AutoSize = true;
            this.unresolved_incidents_TXT.Location = new System.Drawing.Point(116, 226);
            this.unresolved_incidents_TXT.Name = "unresolved_incidents_TXT";
            this.unresolved_incidents_TXT.Size = new System.Drawing.Size(31, 13);
            this.unresolved_incidents_TXT.TabIndex = 9;
            this.unresolved_incidents_TXT.Text = "????";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "These tickets need imidiate attention";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "All tickets currently open";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(345, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Incidents past deadline";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Unresolved incidents";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current incidents";
            // 
            // show_list_btn
            // 
            this.show_list_btn.Location = new System.Drawing.Point(250, 57);
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
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // incidentManagementToolStripMenuItem
            // 
            this.incidentManagementToolStripMenuItem.Name = "incidentManagementToolStripMenuItem";
            this.incidentManagementToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.incidentManagementToolStripMenuItem.Text = "Incident Management";
            this.incidentManagementToolStripMenuItem.Click += new System.EventHandler(this.incidentManagementToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // panel_dashboardViewTicketList
            // 
            this.panel_dashboardViewTicketList.Controls.Add(this.lbl_Incidentsmanagement_listviewTitle_solved);
            this.panel_dashboardViewTicketList.Controls.Add(this.listView_dashboard_SolvedTickets);
            this.panel_dashboardViewTicketList.Controls.Add(this.lbl_Incidentsmanagement_listviewTitle_Current);
            this.panel_dashboardViewTicketList.Controls.Add(this.lbl_Title_Incidentmanagement);
            this.panel_dashboardViewTicketList.Controls.Add(this.listView_dashboard);
            this.panel_dashboardViewTicketList.Location = new System.Drawing.Point(0, 0);
            this.panel_dashboardViewTicketList.Name = "panel_dashboardViewTicketList";
            this.panel_dashboardViewTicketList.Size = new System.Drawing.Size(638, 534);
            this.panel_dashboardViewTicketList.TabIndex = 11;
            // 
            // lbl_Incidentsmanagement_listviewTitle_solved
            // 
            this.lbl_Incidentsmanagement_listviewTitle_solved.AutoSize = true;
            this.lbl_Incidentsmanagement_listviewTitle_solved.Location = new System.Drawing.Point(440, 116);
            this.lbl_Incidentsmanagement_listviewTitle_solved.Name = "lbl_Incidentsmanagement_listviewTitle_solved";
            this.lbl_Incidentsmanagement_listviewTitle_solved.Size = new System.Drawing.Size(85, 13);
            this.lbl_Incidentsmanagement_listviewTitle_solved.TabIndex = 5;
            this.lbl_Incidentsmanagement_listviewTitle_solved.Text = "Solved incidents";
            // 
            // listView_dashboard_SolvedTickets
            // 
            this.listView_dashboard_SolvedTickets.GridLines = true;
            this.listView_dashboard_SolvedTickets.HideSelection = false;
            this.listView_dashboard_SolvedTickets.Location = new System.Drawing.Point(440, 137);
            this.listView_dashboard_SolvedTickets.Name = "listView_dashboard_SolvedTickets";
            this.listView_dashboard_SolvedTickets.Size = new System.Drawing.Size(85, 189);
            this.listView_dashboard_SolvedTickets.TabIndex = 4;
            this.listView_dashboard_SolvedTickets.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Incidentsmanagement_listviewTitle_Current
            // 
            this.lbl_Incidentsmanagement_listviewTitle_Current.AutoSize = true;
            this.lbl_Incidentsmanagement_listviewTitle_Current.Location = new System.Drawing.Point(42, 65);
            this.lbl_Incidentsmanagement_listviewTitle_Current.Name = "lbl_Incidentsmanagement_listviewTitle_Current";
            this.lbl_Incidentsmanagement_listviewTitle_Current.Size = new System.Drawing.Size(86, 13);
            this.lbl_Incidentsmanagement_listviewTitle_Current.TabIndex = 3;
            this.lbl_Incidentsmanagement_listviewTitle_Current.Text = "Current incidents";
            // 
            // lbl_Title_Incidentmanagement
            // 
            this.lbl_Title_Incidentmanagement.AutoSize = true;
            this.lbl_Title_Incidentmanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title_Incidentmanagement.Location = new System.Drawing.Point(38, 21);
            this.lbl_Title_Incidentmanagement.Name = "lbl_Title_Incidentmanagement";
            this.lbl_Title_Incidentmanagement.Size = new System.Drawing.Size(138, 20);
            this.lbl_Title_Incidentmanagement.TabIndex = 2;
            this.lbl_Title_Incidentmanagement.Text = "Overview tickets";
            this.lbl_Title_Incidentmanagement.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView_dashboard
            // 
            this.listView_dashboard.GridLines = true;
            this.listView_dashboard.HideSelection = false;
            this.listView_dashboard.Location = new System.Drawing.Point(42, 86);
            this.listView_dashboard.Name = "listView_dashboard";
            this.listView_dashboard.Size = new System.Drawing.Size(369, 358);
            this.listView_dashboard.TabIndex = 1;
            this.listView_dashboard.UseCompatibleStateImageBehavior = false;
            this.listView_dashboard.SelectedIndexChanged += new System.EventHandler(this.listView_dashboard_SelectedIndexChanged);
            // 
            // incident_management_Panel
            // 
            this.incident_management_Panel.Controls.Add(this.label14);
            this.incident_management_Panel.Controls.Add(this.txtBox_filterEmail);
            this.incident_management_Panel.Controls.Add(this.go_create_incident_BTN);
            this.incident_management_Panel.Controls.Add(this.listView_incidents);
            this.incident_management_Panel.Location = new System.Drawing.Point(0, 0);
            this.incident_management_Panel.Name = "incident_management_Panel";
            this.incident_management_Panel.Size = new System.Drawing.Size(635, 540);
            this.incident_management_Panel.TabIndex = 11;
            // 
            // go_create_incident_BTN
            // 
            this.go_create_incident_BTN.Location = new System.Drawing.Point(443, 38);
            this.go_create_incident_BTN.Name = "go_create_incident_BTN";
            this.go_create_incident_BTN.Size = new System.Drawing.Size(116, 52);
            this.go_create_incident_BTN.TabIndex = 1;
            this.go_create_incident_BTN.Text = "CREATE INCIDENT";
            this.go_create_incident_BTN.UseVisualStyleBackColor = true;
            this.go_create_incident_BTN.Click += new System.EventHandler(this.Go_create_incident_BTN_Click);
            // 
            // listView_incidents
            // 
            this.listView_incidents.HideSelection = false;
            this.listView_incidents.Location = new System.Drawing.Point(68, 115);
            this.listView_incidents.Name = "listView_incidents";
            this.listView_incidents.Size = new System.Drawing.Size(489, 413);
            this.listView_incidents.TabIndex = 0;
            this.listView_incidents.UseCompatibleStateImageBehavior = false;
            // 
            // create_ticket_Panel
            // 
            this.create_ticket_Panel.Controls.Add(this.add_incident_type_TextBox);
            this.create_ticket_Panel.Controls.Add(this.select_priority_ComboBox);
            this.create_ticket_Panel.Controls.Add(this.lbl_Clock_create_ticket);
            this.create_ticket_Panel.Controls.Add(this.ticket_deadlineTimePicker);
            this.create_ticket_Panel.Controls.Add(this.label13);
            this.create_ticket_Panel.Controls.Add(this.label12);
            this.create_ticket_Panel.Controls.Add(this.label11);
            this.create_ticket_Panel.Controls.Add(this.type_name_textBox);
            this.create_ticket_Panel.Controls.Add(this.label10);
            this.create_ticket_Panel.Controls.Add(this.label4);
            this.create_ticket_Panel.Controls.Add(this.label1);
            this.create_ticket_Panel.Controls.Add(this.btn_cancel_of_create_ticket);
            this.create_ticket_Panel.Controls.Add(this.ticket_description_TextBox);
            this.create_ticket_Panel.Controls.Add(this.ticket_subject_textBox);
            this.create_ticket_Panel.Controls.Add(this.label3);
            this.create_ticket_Panel.Controls.Add(this.label2);
            this.create_ticket_Panel.Controls.Add(this.create_ticket_btn);
            this.create_ticket_Panel.Location = new System.Drawing.Point(0, 27);
            this.create_ticket_Panel.Name = "create_ticket_Panel";
            this.create_ticket_Panel.Size = new System.Drawing.Size(638, 513);
            this.create_ticket_Panel.TabIndex = 2;
            // 
            // add_incident_type_TextBox
            // 
            this.add_incident_type_TextBox.Location = new System.Drawing.Point(214, 133);
            this.add_incident_type_TextBox.Name = "add_incident_type_TextBox";
            this.add_incident_type_TextBox.Size = new System.Drawing.Size(266, 20);
            this.add_incident_type_TextBox.TabIndex = 28;
            // 
            // select_priority_ComboBox
            // 
            this.select_priority_ComboBox.FormattingEnabled = true;
            this.select_priority_ComboBox.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Normal",
            "High",
            "Very High"});
            this.select_priority_ComboBox.Location = new System.Drawing.Point(217, 203);
            this.select_priority_ComboBox.Name = "select_priority_ComboBox";
            this.select_priority_ComboBox.Size = new System.Drawing.Size(263, 21);
            this.select_priority_ComboBox.TabIndex = 27;
            // 
            // lbl_Clock_create_ticket
            // 
            this.lbl_Clock_create_ticket.AutoSize = true;
            this.lbl_Clock_create_ticket.Location = new System.Drawing.Point(214, 72);
            this.lbl_Clock_create_ticket.Name = "lbl_Clock_create_ticket";
            this.lbl_Clock_create_ticket.Size = new System.Drawing.Size(49, 13);
            this.lbl_Clock_create_ticket.TabIndex = 26;
            this.lbl_Clock_create_ticket.Text = "00:00:00";
            // 
            // ticket_deadlineTimePicker
            // 
            this.ticket_deadlineTimePicker.Location = new System.Drawing.Point(214, 241);
            this.ticket_deadlineTimePicker.Name = "ticket_deadlineTimePicker";
            this.ticket_deadlineTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ticket_deadlineTimePicker.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(171, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(285, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Create new incident ticket";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(65, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Time incident is submited:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(102, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Type of incident:";
            // 
            // type_name_textBox
            // 
            this.type_name_textBox.Location = new System.Drawing.Point(214, 168);
            this.type_name_textBox.Name = "type_name_textBox";
            this.type_name_textBox.Size = new System.Drawing.Size(266, 20);
            this.type_name_textBox.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Priority:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Deadline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Reported by user:";
            // 
            // btn_cancel_of_create_ticket
            // 
            this.btn_cancel_of_create_ticket.Location = new System.Drawing.Point(239, 457);
            this.btn_cancel_of_create_ticket.Name = "btn_cancel_of_create_ticket";
            this.btn_cancel_of_create_ticket.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel_of_create_ticket.TabIndex = 13;
            this.btn_cancel_of_create_ticket.Text = "CANCEL";
            this.btn_cancel_of_create_ticket.UseVisualStyleBackColor = true;
            this.btn_cancel_of_create_ticket.Click += new System.EventHandler(this.Btn_cancel_of_create_ticket_Click);
            // 
            // ticket_description_TextBox
            // 
            this.ticket_description_TextBox.Location = new System.Drawing.Point(176, 303);
            this.ticket_description_TextBox.Name = "ticket_description_TextBox";
            this.ticket_description_TextBox.Size = new System.Drawing.Size(306, 139);
            this.ticket_description_TextBox.TabIndex = 12;
            this.ticket_description_TextBox.Text = "";
            // 
            // ticket_subject_textBox
            // 
            this.ticket_subject_textBox.Location = new System.Drawing.Point(214, 99);
            this.ticket_subject_textBox.Name = "ticket_subject_textBox";
            this.ticket_subject_textBox.Size = new System.Drawing.Size(266, 20);
            this.ticket_subject_textBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Subject:";
            // 
            // create_ticket_btn
            // 
            this.create_ticket_btn.Location = new System.Drawing.Point(368, 460);
            this.create_ticket_btn.Name = "create_ticket_btn";
            this.create_ticket_btn.Size = new System.Drawing.Size(75, 23);
            this.create_ticket_btn.TabIndex = 8;
            this.create_ticket_btn.Text = "SUBMIT";
            this.create_ticket_btn.UseVisualStyleBackColor = true;
            this.create_ticket_btn.Click += new System.EventHandler(this.Create_ticket_btn_Click);
            // 
            // Clock
            // 
            this.Clock.Interval = 10000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // txtBox_filterEmail
            // 
            this.txtBox_filterEmail.Location = new System.Drawing.Point(150, 53);
            this.txtBox_filterEmail.Name = "txtBox_filterEmail";
            this.txtBox_filterEmail.Size = new System.Drawing.Size(195, 20);
            this.txtBox_filterEmail.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(68, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Filter by email";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // Gardern_Group_desk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 540);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.incident_management_Panel);
            this.Controls.Add(this.Dashboard_panel);
            this.Controls.Add(this.create_ticket_Panel);
            this.Controls.Add(this.panel_dashboardViewTicketList);
            this.Name = "Gardern_Group_desk";
            this.Text = "Garden group desk";
            this.Load += new System.EventHandler(this.Gardern_Group_desk_Load);
            this.Dashboard_panel.ResumeLayout(false);
            this.Dashboard_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_dashboardViewTicketList.ResumeLayout(false);
            this.panel_dashboardViewTicketList.PerformLayout();
            this.incident_management_Panel.ResumeLayout(false);
            this.incident_management_Panel.PerformLayout();
            this.create_ticket_Panel.ResumeLayout(false);
            this.create_ticket_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lbl_Title_Incidentmanagement;
        private System.Windows.Forms.Label lbl_Incidentsmanagement_listviewTitle_solved;
        private System.Windows.Forms.ListView listView_dashboard_SolvedTickets;
        private System.Windows.Forms.Label lbl_Incidentsmanagement_listviewTitle_Current;
        private System.Windows.Forms.Panel incident_management_Panel;
        private System.Windows.Forms.Button go_create_incident_BTN;
        private System.Windows.Forms.ListView listView_incidents;
        private System.Windows.Forms.Panel create_ticket_Panel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox type_name_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel_of_create_ticket;
        private System.Windows.Forms.RichTextBox ticket_description_TextBox;
        private System.Windows.Forms.TextBox ticket_subject_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button create_ticket_btn;
        private System.Windows.Forms.ComboBox select_priority_ComboBox;
        private System.Windows.Forms.Label lbl_Clock_create_ticket;
        private System.Windows.Forms.DateTimePicker ticket_deadlineTimePicker;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.TextBox add_incident_type_TextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBox_filterEmail;
    }
}