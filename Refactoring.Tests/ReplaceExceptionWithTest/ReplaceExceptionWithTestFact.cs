using System.Collections.Generic;
using Refactoring.ReplaceExceptionWithTest;
using Xunit;

namespace Refactoring.Tests.ReplaceExceptionWithTest
{
    public class ReplaceExceptionWithTestFact
    {
        [Fact]
        public void Get_resource_from_resource_pool()
        {
            var resource1 = new Resource("Resource1");
            var avaliable = new List<Resource>() {resource1};
            var respurcePool = new RespurcePool(null, avaliable);

            respurcePool.GetResource("Resource1");
            Assert.Equal(1, respurcePool.GetAllocatedResourceCount());
        }

        [Fact]
        public void Get_resource_from_resource_pool_when_has_no_avaliable()
        {
            var respurcePool = new RespurcePool();
            Assert.Equal(0, respurcePool.GetAvaliableResourceCount());
            Assert.Equal(0, respurcePool.GetAllocatedResourceCount());

            respurcePool.GetResource("Resource1");
            Assert.Equal(0, respurcePool.GetAvaliableResourceCount());
            Assert.Equal(1, respurcePool.GetAllocatedResourceCount());
        }
    }
}
