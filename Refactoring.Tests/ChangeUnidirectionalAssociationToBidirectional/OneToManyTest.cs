using System.Linq;
using Refactoring.ChangeUnidirectionalAssociationToBidirectional;
using Xunit;

namespace Refactoring.Tests.ChangeUnidirectionalAssociationToBidirectional
{
    public class OneToManyTest
    {
        [Fact]
        public void should_get_company_from_engagement()
        {
            var engagement = new Engagement("hasting1") {Client = new Client("Hasting")};
            Assert.Equal("Hasting", engagement.Client.name);
        }

        [Fact]
        public void should_get_engagement_from_company()
        {
            var company = new Client("IBM");
            var engagement = new Engagement("ibm1") {Client = company};
            var engagement2 = new Engagement("ibm2") { Client = company};
            Assert.Equal(2, company.FriendEngagements.Count());
        }

        [Fact]
        public void should_add_engagement_for_one_client()
        {
            var client = new Client("test");
            client.AddEngagement(new Engagement("name"));
            Assert.Equal(1, client.FriendEngagements.Count);
        }
    }
}
