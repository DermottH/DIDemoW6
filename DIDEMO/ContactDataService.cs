namespace DIDEMO
{
    internal class ContactDataService
    {
        List<Person> _contacts;
        public ContactDataService()
        {
            _contacts = new List<Person>();
            _contacts.Add(new Person("John", "Doe"));
            _contacts.Add(new Person("Derek", "Harkin"));
            _contacts.Add(new Person("Abbey", "Bán"));
            _contacts.Add(new Person("Tammy", "Wynette"));


        }

        public List<Person> GetContacts()
        {
        return _contacts; 
        }
    
    }
}