using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using TGG_Model;
using TGG_Service;
using System;

namespace TGG_Login
{
    public partial class Gardern_Group_desk : Form
    {
        private Ticket_Service ticket_Service;
        private ListViewColumnSorter lvwColumnSorter;

        public Gardern_Group_desk()
        {
            InitializeComponent();

            ticket_Service = new Ticket_Service();

            lvwColumnSorter = new ListViewColumnSorter();
            this.listView_incidents.ListViewItemSorter = lvwColumnSorter;
            //calls these methods to show overview of all incidents
            DisplayUnresolved();
            DisplayPastDeadline();
        }
        //shows number of unresolved incidents
        private void DisplayUnresolved()
        {        
            string count = ticket_Service.UnresolvedCount(ticket_Service.GetAllTickets()).ToString();
            string count2 = ticket_Service.IncidentCount(ticket_Service.GetAllTickets()).ToString();

            unresolved_incidents_TXT.Text = count + "/" + count2;
        }
        //shows number if tickets that are past deadline and unresolved
        private void DisplayPastDeadline()
        {

            string count1 = ticket_Service.PastDeadlineCount(ticket_Service.GetAllTickets()).ToString();
            string count2 = ticket_Service.IncidentCount(ticket_Service.GetAllTickets()).ToString();

            past_deadline_TXT.Text = count1 + "/" + count2;
        }
        //shows list of all incidents
        private void Show_list_btn_Click(object sender, EventArgs e)
        {
            Dashboard_panel.Hide();
            create_ticket_Panel.Hide();
            panel_dashboardViewTicketList.Show();

            PopulateDashboardIncidentList();
            PopulateDashboardIncidentList_Solved();
        }
        // populates listview with tickets
        private void PopulateDashboardIncidentList()
        {
            listView_incidents.Clear();

            listView_incidents.View = View.Details;

            listView_incidents.Columns.Add("Requested By", 100, HorizontalAlignment.Left);         
            listView_incidents.Columns.Add("Subject", 100, HorizontalAlignment.Left);
            //listView_dashboard.Columns.Add("Description", 100, HorizontalAlignment.Left);
            listView_incidents.Columns.Add("Status", 100, HorizontalAlignment.Left);
            listView_incidents.Columns.Add("Priority", 100, HorizontalAlignment.Left);
            listView_incidents.Columns.Add("Request Date", 100, HorizontalAlignment.Left);
            listView_incidents.Columns.Add("Deadline", 100, HorizontalAlignment.Left);
            //listView_dashboard.Columns.Add("Type", 100, HorizontalAlignment.Left);

            foreach (Ticket t in ticket_Service.GetAllUnresolvedTickets(ticket_Service.GetAllTickets()))
            {
                ListViewItem li = new ListViewItem(t.GetRequestedBy());                         
                li.SubItems.Add(t.GetSubject());
                //li.SubItems.Add(t.GetDescription());
                li.SubItems.Add(t.GetStatus().ToString());
                li.SubItems.Add(t.GetPriority().ToString());
                li.SubItems.Add(t.GetRequestDate().ToString("yyyy/MM/dd HH:mm:ss"));
                li.SubItems.Add(t.GetDeadline().ToString("yyyy/MM/dd HH:mm:ss"));
                //li.SubItems.Add(t.GetType().ToString());

                li.Tag=t;

                listView_incidents.Items.Add(li);
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
                li.SubItems.Add(t.GetType().ToString());


                li.Tag = t;

                listView_dashboard_SolvedTickets.Items.Add(li);
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if dasboard menu item is clicked display dashboard panel and hide the rest
            ShowPanel("dashboard");
            //panel_dashboardViewTicketList.Hide();
        }

        private void incidentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("incident_menu");
            Dashboard_panel.Hide();
            create_ticket_Panel.Hide();
            panel_dashboardViewTicketList.Show();

            PopulateDashboardIncidentList();
            //PopulateDashboardIncidentList_Solved();
        }
        // this method shows and hides 
        private void ShowPanel(string panelName)
        {
           if (panelName=="dashboard")
            {
               Dashboard_panel.Show();
            }
        }
        //useless buttons we accidently pressed but no code belongs to.
        private void Dash_back_btn_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void listView_dashboard_SelectedIndexChanged(object sender, EventArgs e) { }

        private void Clock_Tick(object sender, EventArgs e)
        {
            lbl_Clock_create_ticket.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private void Gardern_Group_desk_Load(object sender, EventArgs e)
        {

            Clock.Interval = 1000;
            Clock.Start();
        }
       
        private void Create_ticket_btn_Click(object sender, EventArgs e)
        {
            PopulateDashboardIncidentList();
            create_ticket_Panel.Hide();
            panel_dashboardViewTicketList.Show();

            ticket_Service.WriteTicket_service(type_name_textBox.Text, ticket_deadlineTimePicker.Value, DateTime.Now, ticket_subject_textBox.Text, ticket_description_TextBox.Text, Status.Pending,select_priority_ComboBox.SelectedItem.ToString(),add_incident_type_TextBox.Text);

            DisplayUnresolved();
            DisplayPastDeadline();
        }

        private void Btn_cancel_of_create_ticket_Click(object sender, EventArgs e)
        {
            PopulateDashboardIncidentList();
            create_ticket_Panel.Hide();
            panel_dashboardViewTicketList.Show();

            type_name_textBox.Clear();
            ticket_deadlineTimePicker.Value = DateTime.Now;
            ticket_subject_textBox.Clear();
            ticket_description_TextBox.Clear();
            add_incident_type_TextBox.Clear();
        }

        private void Go_create_incident_BTN_Click(object sender, EventArgs e)
        {
            Dashboard_panel.Hide();
            panel_dashboardViewTicketList.Hide();
            create_ticket_Panel.Show();
        }
        //this.listView_incidents.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_incidents_ColumnClick);
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
    }
}
