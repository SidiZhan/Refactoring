using System.Collections.Generic;

namespace Refactoring.ChangeUnidirectionalAssociationToBidirectional
{
    public class Engagement
    {
        Client client;

        public Client Client
        {
            get { return client; }
            set
            {
                client.FriendEngagements.Remove(this);
                client = value;
                client.FriendEngagements.Add(this);
            }
        }

    }

    public class Client
    {
        private readonly HashSet<Engagement> engagements = new HashSet<Engagement>();
        public string name;

        public Client(string name)
        {
            this.name = name;
        }

        public IEnumerable<Engagement> Engagements => engagements;

        internal HashSet<Engagement> FriendEngagements => engagements;

    }
}
