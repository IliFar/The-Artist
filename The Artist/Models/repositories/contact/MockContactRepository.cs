using System.Collections.Generic;

namespace The_Artist.Models.repositories
{
    public class MockContactRepository : IContactRepository<Contact>
    {
        List<Contact> Contacts;
        
        public MockContactRepository()
        {
            Contacts = new List<Contact>()
            {
                new Contact {Email = "theartist@info.com", PhoneNumber = "+46 700000008" }
            };
        }

        public IList<Contact> List()
        {
            return Contacts;
        }
    }
}
