namespace Lab5.Models
{
    public interface IContactService
    {
        void Add(Contact model);
        void DeleteById(Contact model);
        void Update(Contact model);
        List<Contact> FindAll();
        Contact? FindById(int id);

    }
}
