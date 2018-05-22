using System;
using System.Collections.Generic;
using System.Linq;

namespace Refactoring.ReplaceExceptionWithTest
{
    public class RespurcePool
    {
        List<Resource> Avaliable { get;}
        List<Resource> Allocated { get;}

        public RespurcePool(List<Resource> allocated = null, List<Resource> avaliable = null)
        {
            Allocated = allocated?? new List<Resource>();
            Avaliable = avaliable?? new List<Resource>();
        }

        public int GetAvaliableResourceCount()
        {
            return Avaliable.Count;
        }


        public int GetAllocatedResourceCount()
        {
            return Allocated.Count;
        }

        public Resource GetResource(string name)
        {
            Resource result;
            try
            {
                result = Avaliable.First(a => a.Name == name);
                Allocated.Add(result);
                return result;
            }
            catch (InvalidOperationException)
            {
                result = new Resource();
                Allocated.Add(result);
                return result;
            }
        }
    }

    public class Resource
    {
        public string Name { get; }

        public Resource(string name = null)
        {
            Name = name;
        }
    }
}
