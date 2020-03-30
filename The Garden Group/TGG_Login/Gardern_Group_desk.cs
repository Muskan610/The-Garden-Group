using System;
using System.Windows.Forms;
using TGG_Model;
using TGG_Service;

namespace TGG_Login
{
    public partial class Gardern_Group_desk : Form
    {
        private Ticket_Service ticket_Service;
        public Gardern_Group_desk()
        {
            InitializeComponent();

            ticket_Service = new Ticket_Service();
            
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
            incident_management_Panel.Hide();
            create_ticket_Panel.Hide();
            panel_dashboardViewTicketList.Show();

            PopulateDashboardIncidentList();
            PopulateDashboardIncidentList_Solved();
        }
        // populates listview with tickets
        private void PopulateDashboardIncidentList()
        {
            listView_dashboard.Clear();

            listView_dashboard.View = View.Details;

            listView_dashboard.Columns.Add("Requested By", 100, HorizontalAlignment.Left);
            listView_dashboard.Columns.Add("Request Date", 100, HorizontalAlignment.Left);
            listView_dashboard.Columns.Add("Deadline", 100, HorizontalAlignment.Left);
            listView_dashboard.Columns.Add("Subject", 100, HorizontalAlignment.Left);
            listView_dashboard.Columns.Add("Description", 100, HorizontalAlignment.Left);
            listView_dashboard.Columns.Add("Status", 100, HorizontalAlignment.Left);
            listView_dashboard.Columns.Add("Priority", 100, HorizontalAlignment.Left);
            listView_dashboard.Columns.Add("Type", 100, HorizontalAlignment.Left);

            foreach (Ticket t in ticket_Service.GetAllUnresolvedTickets(ticket_Service.GetAllTickets()))
            {
                ListViewItem li = new ListViewItem(t.GetRequestedBy());

                li.SubItems.Add(t.GetRequestDate().ToString("yyyy/MM/dd HH:mm:ss"));
                li.SubItems.Add(t.GetDeadline().ToString("yyyy/MM/dd HH:mm:ss"));
                li.SubItems.Add(t.GetSubject());
                li.SubItems.Add(t.GetDescription());
                li.SubItems.Add(t.GetStatus().ToString());
                li.SubItems.Add(t.GetPriority().ToString());
                li.SubItems.Add(t.GetType().ToString());

                li.Tag=t;

                listView_dashboard.Items.Add(li);
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
            //if incident management menu item is clicked display panel and hide the rest
            //panel_dashboardViewTicketList.Show();
            ShowPanel("incident_menu");
            //Button Go_create_incident_BTN;
            //Go_create_incident_BTN.visible = false;


            //populate lists if panel gets selected
            PopulateDashboardIncidentList();
            PopulateDashboardIncidentList_Solved();
        }
        // this method shows and hides 
        private void ShowPanel(string panelName)
        {
            if (panelName=="incident_menu")
            {
                Dashboard_panel.Hide();
                incident_management_Panel.Show();         
            }
            else if (panelName=="dashboard")
            {
                incident_management_Panel.Hide();
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
            create_ticket_Panel.Hide();

            ticket_Service.WriteTicket_service(type_name_textBox.Text, ticket_deadlineTimePicker.Value, DateTime.Now, ticket_subject_textBox.Text, ticket_description_TextBox.Text, Status.Pending,select_priority_ComboBox.SelectedItem.ToString(),add_incident_type_TextBox.Text);

            DisplayUnresolved();
            DisplayPastDeadline();

            incident_management_Panel.Show();
        }

        private void Btn_cancel_of_create_ticket_Click(object sender, EventArgs e)
        {
            create_ticket_Panel.Hide();

            type_name_textBox.Clear();
            ticket_deadlineTimePicker.Value = DateTime.Now;
            ticket_subject_textBox.Clear();
            ticket_description_TextBox.Clear();
            add_incident_type_TextBox.Clear();

            incident_management_Panel.Show();
        }

        private void Go_create_incident_BTN_Click(object sender, EventArgs e)
        {
            Dashboard_panel.Hide();
            incident_management_Panel.Hide();
            panel_dashboardViewTicketList.Hide();
            create_ticket_Panel.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
