namespace Lab3_B.Models
{

    public class MemoryContactService : IContactService
    {
        private Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>()
        {
            {1, new Contact() {Name="Adam", Email="Adam@gmail.com", Phone="123123123", Priority=Priority.Urgent } }
        };

        private ICurrentDate _currentDate;
        public MemoryContactService(ICurrentDate currentDate)
        {
            _currentDate = currentDate;
        }

        private int id = 2;
        public int Add(Contact model)
        {
            model.Created = _currentDate.CurrentTime;
            model.Id = id++;
            _contacts.Add(model.Id, model);
            return id;
        }

        public void DeleteByID(int id)
        {
          _contacts.Remove(id);
        }

        public List<Contact> FindAll()
        {
            return _contacts.Values.ToList();
        }

        public Contact? FindById(int id)
        {
          return _contacts[id];
        }

        public void Update(Contact contact)
        {
           if (_contacts.ContainsKey(contact.Id)) 
           {
                _contacts[contact.Id] = contact;
           }
        }
    }
}
