using System;
using System.Collections.Generic;
using System.Linq;

namespace Refactoring.ReplaceExceptionWithTest
{
    public class ResourcePool
    {
        List<Resource> Availiable { get;}
        List<Resource> Allocated { get;}

        public ResourcePool(List<Resource> allocated = null, List<Resource> avaliable = null)
        {
            Allocated = allocated?? new List<Resource>();
            Availiable = avaliable?? new List<Resource>();
        }

        public int GetAvaliableResourceCount()
        {
            return Availiable.Count;
        }


        public int GetAllocatedResourceCount()
        {
            return Allocated.Count;
        }

        public Resource GetResource(string name)
        {
            var result = Availiable.FirstOrDefault(a => a.Name == name) ?? new Resource();
                Allocated.Add(result);
                return result;
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
