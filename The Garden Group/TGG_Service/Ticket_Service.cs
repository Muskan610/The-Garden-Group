using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGG_DAL;
using TGG_Model;


namespace TGG_Service
{
    public class Ticket_Service
    {
        private Ticket_DAO DAO_Tickets = new Ticket_DAO();

        //calls method in dao layer to get all incident tickets
        public List<Ticket> GetAllTickets()
        {
            try
            {
                return DAO_Tickets.db_TicketsList();
            }
            catch (Exception e)
            {
                throw new Exception(" " + e.Message);
            }
            
        }
        // returns total count of incident tickets
        public int IncidentCount(List<Ticket> incidents)
        {
            int count=incidents.Count;
            
            return count;
        }
        //returns total count of unresolved tickets
        public int UnresolvedCount(List<Ticket> incidents)
        {
            int count = 0;
            foreach (Ticket t in incidents)
            {
                if (t.GetStatus()==Status.Pending)
                {
                    count++;
                }
               
            }
            return count;
        }
        //returns total count of tickets which are past their deadline
        public int PastDeadlineCount(List<Ticket> incidents)
        {
            int count = 0;
            foreach (Ticket t in incidents)
            {
                if (t.GetStatus() == Status.PastDeadline)
                {
                    count++;
                }

            }
            return count;
        }
    }
}
