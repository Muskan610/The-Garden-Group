using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGG_DAL;
using TGG_Model;
using MongoDB.Driver;
using MongoDB.Bson;
using NoDesk;
using MongoDB.Driver.Linq;



namespace TGG_DAL
{
    public class Ticket_DAO
    {
        private Config config;

        //constructor sets new connection with database
        public Ticket_DAO()
        {
            config = new Config();
        }
        //returns list to service layer
        public List<Ticket> db_TicketsList()
        {
            return GetTicketList();
        }

        //returns list to service layer
        public List<Ticket> db_TicketsList_Solved()
        {
            return GetTicketList_Solved();
        }

        // gets all tickets from database 
        private List<Ticket> GetTicketList()
        {
            //create ticket list that will returned
            List<Ticket> tickets = new List<Ticket>();
            
            //sets connection with database and ticket collection
            var database = config.dbClient.GetDatabase("NoDesk");
            var collection = database.GetCollection<BsonDocument>("Tickets");

            //gets all documents from collection and stores them in a list
            var filter = Builders<BsonDocument>.Filter.Empty;
            var result = collection.Find(filter).ToList();

            //stores each ticket in ticket object and adds it to ticket list
            foreach(var r in result)
            {
                if (r.GetValue("status") != "solved")
                {
                    Ticket ticket = new Ticket(r.GetValue("_id").AsObjectId, r.GetValue("requestedBy").AsString, r.GetValue("deadline").ToUniversalTime(), r.GetValue("requestDate").ToUniversalTime(), r.GetValue("subject").AsString, r.GetValue("description").AsString, ConvertStatus(r.GetValue("status").AsString));
                    tickets.Add(ticket);
                }
            }
            //list of tickets is returned
            return tickets;
        }

        // gets all tickets from database 
        private List<Ticket> GetTicketList_Solved()
        {
            //create ticket list that will returned
            List<Ticket> tickets = new List<Ticket>();

            //sets connection with database and ticket collection
            var database = config.dbClient.GetDatabase("NoDesk");
            var collection = database.GetCollection<BsonDocument>("Tickets");

            //gets all documents from collection and stores them in a list
            var filter = Builders<BsonDocument>.Filter.Empty;
            var result = collection.Find(filter).ToList();

            //stores each ticket in ticket object and adds it to ticket list
            foreach (var r in result)
            {
                if (r.GetValue("status") == "solved")
                {
                    Ticket ticket = new Ticket(r.GetValue("_id").AsObjectId, r.GetValue("requestedBy").AsString, r.GetValue("deadline").ToUniversalTime(), r.GetValue("requestDate").ToUniversalTime(), r.GetValue("subject").AsString, r.GetValue("description").AsString, ConvertStatus(r.GetValue("status").AsString));
                    tickets.Add(ticket);
                }
            }
            //list of tickets is returned
            return tickets;
        }

        // converts string data from db into status enum and returns it
        private Status ConvertStatus(string s)
        {
            Status state=Status.Pending;

            if (s=="solved")
            {
                return state = Status.Solved;
            }
            return state;
        }
    }
}
