using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using TGG_Model;
using TGG_Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace TGG_Login
{
    public partial class Gardern_Group_desk : Form
    {
        private Ticket_Service ticket_Service;
        private ListViewColumnSorter lvwColumnSorter;
        List<string> emaillist;
        public Gardern_Group_desk()
        {
            InitializeComponent();

            ticket_Service = new Ticket_Service();

            // Create an instance of a ListView column sorter and assign it 
            // to the ListView control
            lvwColumnSorter = new ListViewColumnSorter();
            this.listView_incidents.ListViewItemSorter = lvwColumnSorter;

            btn_open_ticket.Enabled = false;
            //calls these methods to show overview of all incidents
            DisplayUnresolved();
            DisplayPastDeadline();           
        }
        //shows number of unresolved incidents
        private void DisplayUnresolved()
        {        
            string count = ticket_Service.UnresolvedCount(ticket_Service.GetAllTickets()).ToString();
            string count2 = ticket_Service.IncidentCount(ticket_Service.GetAllTickets()).ToString();

            //sets progress bar min, max and current value of unresolved incidents
            unresolved_ProgressBar.Minimum = 0;
            unresolved_ProgressBar.Value =ticket_Service.UnresolvedCount(ticket_Service.GetAllTickets());
            unresolved_ProgressBar.Maximum = ticket_Service.IncidentCount(ticket_Service.GetAllTickets());
            unresolved_ProgressBar.Text = ticket_Service.UnresolvedCount(ticket_Service.GetAllTickets()).ToString() + "/" + ticket_Service.IncidentCount(ticket_Service.GetAllTickets());
        }
        //shows number if tickets that are past deadline and unresolved
        private void DisplayPastDeadline()
        {

            string count1 = ticket_Service.PastDeadlineCount(ticket_Service.GetAllTickets()).ToString();
            string count2 = ticket_Service.IncidentCount(ticket_Service.GetAllTickets()).ToString();

            past_deadline_circularProgressBar.Minimum = 0;
            past_deadline_circularProgressBar.Value = ticket_Service.PastDeadlineCount(ticket_Service.GetAllTickets());
            past_deadline_circularProgressBar.Maximum = ticket_Service.IncidentCount(ticket_Service.GetAllTickets());
            past_deadline_circularProgressBar.Text = ticket_Service.PastDeadlineCount(ticket_Service.GetAllTickets()).ToString()+"/"+ticket_Service.IncidentCount(ticket_Service.GetAllTickets());
            
        }
        //shows list of all incidents
        private void Show_list_btn_Click(object sender, EventArgs e)
        {
            Dashboard_panel.Hide();
            create_ticket_Panel.Hide();
            panel_incident_management.Show();

            PopulateDashboardIncidentList();
            PopulateDashboardIncidentList_Solved();
        }

        // populates listview with tickets
        private void PopulateDashboardIncidentList()
        {
            listView_incidents.Clear();

            listView_incidents.View = View.Details;
            ColumnHeader columnheader;// Used for creating column headers.

                //creating a list with column names
                List<string> columns = new List<string>();
                columns.Add("Requested By");
                columns.Add("Subject");
                columns.Add("Description");
                columns.Add("Status");
                columns.Add("Priority");
                columns.Add("Request Date");
                columns.Add("Deadline");
                columns.Add("Incident type");

            // Create some column headers for the data. 
            foreach (string col in columns)
                {
                    columnheader = new ColumnHeader();
                    columnheader.Text = col;
                    columnheader.Width = 100;
                    columnheader.TextAlign = HorizontalAlignment.Left;
                    this.listView_incidents.Columns.Add(columnheader);
                }

            foreach (Ticket t in ticket_Service.GetAllUnresolvedTickets(ticket_Service.GetAllTickets()))
            {
                ListViewItem li = new ListViewItem(t.GetRequestedBy());                         
                li.SubItems.Add(t.GetSubject());
                li.SubItems.Add(t.GetDescription());
                li.SubItems.Add(t.GetStatus().ToString());
                li.SubItems.Add(t.GetPriority().ToString());
                li.SubItems.Add(t.GetRequestDate().ToString("yyyy/MM/dd HH:mm:ss"));
                li.SubItems.Add(t.GetDeadline().ToString("yyyy/MM/dd HH:mm:ss"));
                li.SubItems.Add(t.GetTypeOfIncident());

                li.Tag=t;

                listView_incidents.Items.Add(li);
            }
        }

        private void btn_exportCsv_Click(object sender, EventArgs e)
        {
            string[] arr = null;
            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("Requested By, Subject, Description, Status, Priority, Request Date, Deadline, TypeOfIncident");
            
            foreach (Ticket t in ticket_Service.GetAllUnresolvedTickets(ticket_Service.GetAllTickets()))
            {
                string RequestedBy =t.GetRequestedBy();
                string Subject = (t.GetSubject());
                string Description = (t.GetDescription());
                string Status = (t.GetStatus().ToString());
                string Priority = (t.GetPriority().ToString());
                string RequestDate = (t.GetRequestDate().ToString("yyyy/MM/dd HH:mm:ss"));
                string Deadline = (t.GetDeadline().ToString("yyyy/MM/dd HH:mm:ss"));
                string TypeOfIncident = (t.GetTypeOfIncident());
                arr = new string[] { RequestedBy, Subject, Description, Status, Priority, RequestDate, Deadline, TypeOfIncident };
                csvContent.AppendLine(arr[0] + "," + arr[1] + "," + arr[2] + "," + arr[3] + "," + arr[4] + "," + arr[5] + "," + arr[6] + "," + arr[7]);
            }

            export_IncidentsList_ToCSV(arr, csvContent);
            MessageBox.Show("csv file exported to location: `Documents > IncidentsList`");
        }
        private void export_IncidentsList_ToCSV(string[] arr, StringBuilder csvContent)
        {
            string fileName = System.IO.Path.GetRandomFileName();
            //saving the file in a folder in "Documents" with a random name
            string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string csvPath = documents + @"\IncidentsList";

            if (!(Directory.Exists(csvPath)))
            {
                System.IO.Directory.CreateDirectory(csvPath);
            }

            csvPath += @"\Incidents_List_" + fileName + ".csv";
            File.AppendAllText(csvPath, csvContent.ToString());
        }        

        private void txtBox_filterEmail_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBox_filterEmail.Text == null)
            {
                PopulateDashboardIncidentList();
            }
            else
            {
                PopulateIncidentList_ByEmail(txtBox_filterEmail.Text.ToLower());
            }

        }

        private void PopulateIncidentList_ByEmail(string filter)
        {
            listView_incidents.Clear();
            
            listView_incidents.View = View.Details;
            ColumnHeader columnheader;// Used for creating column headers.
            //creating a list with column names
            List<string> columns = new List<string>();
            columns.Add("Requested By");
            columns.Add("Subject");
            columns.Add("Status");
            columns.Add("Priority");
            columns.Add("Request Date");
            columns.Add("Deadline");

            // Create some column headers for the data. 
            foreach (string col in columns)
            {
                columnheader = new ColumnHeader();
                columnheader.Text = col;
                columnheader.Width = 100;
                columnheader.TextAlign = HorizontalAlignment.Left;
                this.listView_incidents.Columns.Add(columnheader);
            }

            foreach (Ticket t in ticket_Service.GetAllUnresolvedTickets(ticket_Service.GetAllTickets()))
            {
                if (t.GetRequestedBy().ToLower().Contains(filter))
                {
                    ListViewItem li = new ListViewItem(t.GetRequestedBy());
                    li.SubItems.Add(t.GetSubject());
                    li.SubItems.Add(t.GetDescription());
                    li.SubItems.Add(t.GetStatus().ToString());
                    li.SubItems.Add(t.GetPriority().ToString());
                    li.SubItems.Add(t.GetRequestDate().ToString("yyyy/MM/dd HH:mm:ss"));
                    li.SubItems.Add(t.GetDeadline().ToString("yyyy/MM/dd HH:mm:ss"));
                    li.Tag = t;
                    listView_incidents.Items.Add(li);
                }
            }
        }

        // populates listview with tickets
        private void PopulateDashboardIncidentList_Solved()
        {
            listView_dashboard_SolvedTickets.Clear();

            listView_dashboard_SolvedTickets.View = View.Details;

            listView_dashboard_SolvedTickets.Columns.Add("Requested By", 100, HorizontalAlignment.Left);
            listView_dashboard_SolvedTickets.Columns.Add("Request Date", 100, HorizontalAlignment.Left);
            listView_dashboard_SolvedTickets.Columns.Add("Deadline", 100, HorizontalAlignment.Left);
            listView_dashboard_SolvedTickets.Columns.Add("subject", 100, HorizontalAlignment.Left);
            listView_dashboard_SolvedTickets.Columns.Add("description", 100, HorizontalAlignment.Left);
            listView_dashboard_SolvedTickets.Columns.Add("status", 100, HorizontalAlignment.Left);
            listView_dashboard_SolvedTickets.Columns.Add("Priority", 100, HorizontalAlignment.Left);
            listView_dashboard_SolvedTickets.Columns.Add("Type", 100, HorizontalAlignment.Left);


            foreach (Ticket t in ticket_Service.GetAllTickets_Solved())
            {
                ListViewItem li = new ListViewItem(t.GetRequestedBy());

                li.SubItems.Add(t.GetRequestDate().ToString("yyyy/MM/dd HH:mm:ss"));
                li.SubItems.Add(t.GetDeadline().ToString("yyyy/MM/dd HH:mm:ss"));
                li.SubItems.Add(t.GetSubject());
                li.SubItems.Add(t.GetDescription());
                li.SubItems.Add(t.GetStatus().ToString());
                li.SubItems.Add(t.GetPriority().ToString());
                li.SubItems.Add(t.GetTypeOfIncident());


                li.Tag = t;

                listView_dashboard_SolvedTickets.Items.Add(li);
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if dasboard menu item is clicked display dashboard panel and hide the rest
            ShowPanel("dashboard");
        }

        private void incidentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("incident_menu");
        }
        // this method shows and hides panels
        private void ShowPanel(string panelName)
        {
           if (panelName=="dashboard")
            {
                dashboardToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
                incidentManagementToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;
                userManagementToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;

                btn_open_ticket.Enabled = false;
                ClearTicketInfo();
                panel_ticketOverview.Hide();
                create_ticket_Panel.Hide();
                panel_incident_management.Hide();
                Dashboard_panel.Show();
            }
            else if(panelName == "incident_menu")
            {
                incidentManagementToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
                dashboardToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;
                userManagementToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;

                btn_open_ticket.Enabled = false;
                ClearTicketInfo();
                panel_ticketOverview.Hide();
                Dashboard_panel.Hide();
                create_ticket_Panel.Hide();
                panel_incident_management.Show();

                PopulateDashboardIncidentList();
            }
        }
        //useless buttons we accidently pressed but no code belongs to.
        private void Dash_back_btn_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void listView_dashboard_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        // displays date and time for every tick of the clock 
        private void Clock_Tick(object sender, EventArgs e)
        {
            lbl_Clock_create_ticket.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            time_clock_display2_lbl.Text= DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }
        // starts the clock and sets it's ticker to every second
        private void Gardern_Group_desk_Load(object sender, EventArgs e)
        {

            Clock.Interval = 1000;
            Clock.Start();
            
        }
       //calls method from services layer and provides it with the information needed to create a ticket
        private void Create_ticket_btn_Click(object sender, EventArgs e)
        {
           
            create_ticket_Panel.Hide();
            panel_incident_management.Show();

            ticket_Service.WriteTicket_service(type_name_textBox.Text, ticket_deadlineTimePicker.Value, DateTime.Now, ticket_subject_textBox.Text, ticket_description_TextBox.Text, Status.Pending,select_priority_ComboBox.Text,add_incident_type_TextBox.Text);

            type_name_textBox.Clear();
            ticket_deadlineTimePicker.Value = DateTime.Now;
            ticket_subject_textBox.Clear();
            ticket_description_TextBox.Clear();
            add_incident_type_TextBox.Clear();

            DisplayUnresolved();
            DisplayPastDeadline();
            PopulateDashboardIncidentList();
        }
        //return user to incident managemnt page and cancels creation of ticket
        private void Btn_cancel_of_create_ticket_Click(object sender, EventArgs e)
        {
            
            create_ticket_Panel.Hide();
            panel_incident_management.Show();

            type_name_textBox.Clear();
            ticket_deadlineTimePicker.Value = DateTime.Now;
            ticket_subject_textBox.Clear();
            ticket_description_TextBox.Clear();
            add_incident_type_TextBox.Clear();

            PopulateDashboardIncidentList();
        }

        private void Go_create_incident_BTN_Click(object sender, EventArgs e)
        {
            Dashboard_panel.Hide();
            panel_incident_management.Hide();
            create_ticket_Panel.Show();
        }
        
        private void listView_incidents_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            ListView myListView = (ListView)sender;

            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            myListView.Sort();
        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            incidentManagementToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;
            dashboardToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;
            userManagementToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
        }

        private void Gardern_Group_desk_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clock.Stop();
            
        }
        // opens ticket info page
        private void Btn_open_ticket_Click_1(object sender, EventArgs e)
        {
            
            panel_incident_management.Hide();
            Dashboard_panel.Hide();
            panel_ticketOverview.Show();

            listView_incidents.Refresh();
        }

        private void ListView_incidents_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }
        //passes all ticket values to ticket info page
        private void listView_incidents_Click(object sender, EventArgs e)
        {
            btn_open_ticket.Enabled = true;

            ClearTicketInfo();

            lbl_ticket_info_reportedBy.Text = listView_incidents.SelectedItems[0].SubItems[0].Text;
            lbl_ticket_info_subject.Text= listView_incidents.SelectedItems[0].SubItems[1].Text;
            lbl_ticket_info_description.Text=listView_incidents.SelectedItems[0].SubItems[2].Text;
            lbl_ticket_info_status.Text=listView_incidents.SelectedItems[0].SubItems[3].Text;
            lbl_ticket_info_priority.Text=listView_incidents.SelectedItems[0].SubItems[4].Text;
            lbl_ticket_info_deadline.Text= listView_incidents.SelectedItems[0].SubItems[6].Text;
            lbl_ticket_info_whenTicketWasSbmt.Text=listView_incidents.SelectedItems[0].SubItems[5].Text;
            lbl_ticket_tyoe_of_incident.Text= listView_incidents.SelectedItems[0].SubItems[7].Text;

        }
        //clears all info of ticket
        private void ClearTicketInfo()
        {
            lbl_ticket_info_reportedBy.Text = null;
            lbl_ticket_info_subject.Text = null;
            lbl_ticket_info_description.Text = null;
            lbl_ticket_info_status.Text = null;
            lbl_ticket_info_priority.Text = null;
            lbl_ticket_info_deadline.Text = null;
            lbl_ticket_info_whenTicketWasSbmt.Text = null;
            lbl_ticket_tyoe_of_incident.Text = null;

        }

        private void btn_Incidentmanagement_ShowSolvedTickets_Click(object sender, EventArgs e)
        {
            listView_incidents.Hide();
            listView_dashboard_SolvedTickets.Show();
            btn_incidentmangement_ShowAllTickers.Show();
            btn_Incidentmanagement_ShowSolvedTickets.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView_incidents.Show();
            listView_dashboard_SolvedTickets.Hide();
            btn_incidentmangement_ShowAllTickers.Hide();
            btn_Incidentmanagement_ShowSolvedTickets.Show();
        }

        private void btn_Ticketstatistics_UpdateTicketStatus_Click(object sender, EventArgs e)
        {
            try
            {
                string updatedticketstatus = comboBox_change_ticket_status.SelectedItem.ToString();
                string UserEmail = lbl_ticket_info_reportedBy.Text;

                ticket_Service.UpdateTicketStatus(UserEmail, updatedticketstatus);

                Notifications_Service notifications = new Notifications_Service();
                notifications.CreateEmail(UserEmail, updatedticketstatus);

                MessageBox.Show("Your ticket status has been changed!", "Succes!!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                panel_ticketOverview.Hide();
                panel_incident_management.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong with changing you ticket status. Make sure you have a stable internet connection and try again.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }


        private void txtBox_filterEmail_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
