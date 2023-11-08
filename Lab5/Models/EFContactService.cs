using DataForLab5;

namespace Lab5.Models
{
    public class EFContactService : IContactService
    {
        private readonly AppDbContext _context;

        public EFContactService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Contact contact)
        {
            _context.ContactEntities.Add(ContactMapper.ToEntity(contact));
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var find = _context.ContactEntities.Find(id);
            if (find is not null)
            {
                _context.ContactEntities.Remove(find);
            }
        }

        public void DeleteById(Contact model)
        {
            //to do
            throw new NotImplementedException();
        }

        public List<Contact> FindAll()
        {
            return _context.ContactEntities.Select(e => ContactMapper.FromEntity(e)).ToList();
        }

        public Contact? FindById(int id)
        {
            throw new NotImplementedException();
            // to do
            
        }

        public void Update(Contact model)
        {
            throw new NotImplementedException();
            //to do 
        }
    }
}
