using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDEMO
{
    internal class ContactFinder
    {
        public List<Person> GetContactBy(string name)
        {
            List<Person> contacts = new ContactDataService().GetContactsBy(name);
            for (int i = contacts.Count -1; i >=0; i++)
            {
                if (!contacts[i].FirstName.Contains(name))
                {
                    contacts.RemoveAt(i);
                }
            }
            return contacts;
        }
    }
}
