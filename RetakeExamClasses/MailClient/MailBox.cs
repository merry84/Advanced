using System.ComponentModel;
using System;
using System.Text;

namespace MailClient
{
    public class MailBox
    {
        //Next, you have a MailBox class that contains Inbox and Archive(collections for storing mails).
        //All entries inside the repository have the same properties.The MailBox class should have the following properties:
        //•	Capacity - int
        //•	Inbox – List<Mail>
        //•	Archive – List<Mail>

        //The class constructor should receive capacity and initialize the Inbox and Archive with new instances of the collections.
        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }

        public int Capacity { get; set; }
        public List<Mail> Inbox { get; set; }

        public List<Mail> Archive { get; set; }

        //•	Method IncomingMail(Mail mail) – adds an entry to the Inbox collection, if the Capacity allows it.
        // •	Method DeleteMail(string sender) – Finds and removes the first mail from the Inbox by a given sender, if such exists, and returns boolean (true if it is removed, otherwise – false)
        // •	Method ArchiveInboxMessages() – The method moves all inbox mails to the Archive. Returns the number of mails moved.
        // •	Method GetLongestMessage() – returns the ToString() method of the Mail with the longest Body.
        // •	Method InboxView() – returns a string in the following format:
        // o	"Inbox:
        // {Mail1}
        // {Mail2}
        // {…}
        // {Mailn}"
        // Constraints
        // •	You will always have mails added before receiving commands manipulating the collections in the MailBox.
        // •	The Capacity property is related to the Inbox only.
        public void IncomingMail(Mail mail) //adds an entry to the Inbox collection, if the Capacity allows it.
        {
            if (Inbox.Count < Capacity) Inbox.Add(mail);
        }

        public bool
            DeleteMail(string sender) // Finds and removes the first mail from the Inbox by a given sender, if such exists, and returns boolean (true if it is removed, otherwise – false)
            => Inbox.Remove(Inbox.Find(m => m.Sender == sender));

        public int ArchiveInboxMessages() //The method moves all inbox mails to the Archive. Returns the number of mails moved.
        {
            int countMassages = Inbox.Count;
            Archive.AddRange(Inbox);
            Inbox = new List<Mail>();
            return countMassages;

        }
        //returns the ToString() method of the Mail with the longest Body.
        public string GetLongestMessage() => Inbox.OrderByDescending(m => m.Body.Length).FirstOrDefault().ToString();

        public string InboxView()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Inbox:");
            foreach (Mail mail in Inbox)
            {
                sb.AppendLine($"{mail.ToString().TrimEnd()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
