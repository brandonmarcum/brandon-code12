using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactApp.Library.Models;

namespace ContactApp.Library
{
    public class ContactHelper<T> where T : Person
    {
        private List<T> container = new List<T>();

        public void Add(T p)
        {
            container.Add(p);
        }
        public void Update(T p)
        {
            container.Remove(p);
            container.Add(p);
            container.Sort();
        }
        public void Delete(T p)
        {
            container.Remove(p);
        }

    }
}
