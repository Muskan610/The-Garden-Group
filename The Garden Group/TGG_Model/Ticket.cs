using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace TGG_Model
{
    public class Ticket
    {
        // All incident ticket variables
        private ObjectId id;
        private string requestedBy;
        private DateTime deadline;
        private DateTime requestDate;
        private string subject;
        private string description;
        private Status status;

        // values are passed into the constructor first to create a ticket object
        public Ticket(ObjectId ID, string RequestedBy,DateTime Deadline, DateTime RequestDate, string Subject, string Description, Status Status)
        {
            this.id = ID;
            this.requestedBy = RequestedBy;
            this.deadline = Deadline;
            this.requestDate = RequestDate;

            // calls method to check if deadline is passed and and checks if ticket is also unresolved
            if (CheckDeadlinePassed(Deadline)&&Status==Status.Pending)
            {
                status = Status.PastDeadline;
            }
            
            this.description = Description;
            this.subject = Subject;

        }
        //checks if deadline is passed and returns true
        public bool CheckDeadlinePassed(DateTime Deadline)
        {
            bool check = false;

            if (deadline < DateTime.Now)
            {
                return true;
            }
            return check;
        }
        //getters for almost all variables
        public Status GetStatus()
        {
            return status;
        }
        public string GetRequestedBy()
        {
            return requestedBy;
        }
        public DateTime GetDeadline()
        {
            return deadline;
        }
        public DateTime GetRequestDate()
        {
            return requestDate;
        }
        public string GetSubject()
        {
            return subject;
        }
        public string GetDescription()
        {
            return description;
        }

    }
}
