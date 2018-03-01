using System.Collections;

namespace Refactoring.ChangeValueToReference
{
    public static class UserFactory
    {
        public static Hashtable _instances = new Hashtable();

        public static User GetByName(string name)
        {
            if (!_instances.ContainsKey(name))
            {
                _instances[name] = new User(name);
            }
            return (User) _instances[name];
        }
    }
}