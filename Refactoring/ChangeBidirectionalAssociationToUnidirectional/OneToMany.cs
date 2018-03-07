using System.Collections.Generic;

namespace Refactoring.ChangeBidirectionalAssociationToUnidirectional
{
    public class Engagement
    {
        readonly string name;
        Client client;

        public Engagement(string name)
        {
            this.name = name;
        }

        public Client Client
        {
            get { return client; }
            set
            {
                client = value;
                client.FriendEngagements.Remove(this);
                client.FriendEngagements.Add(this);
            }
        }

    }

    public class Client
    {
        public string name;

        public Client(string name)
        {
            this.name = name;
        }

        private readonly HashSet<Engagement> engagements = new HashSet<Engagement>();

        public HashSet<Engagement> FriendEngagements => engagements;

        public void AddEngagement(Engagement engagement)
        {
            engagement.Client = this;
        }
    }
}
