using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace Lab3_B.Models
{
    public interface IContactService
    {
        int Add(Contact contact);
        Contact? FindById(int id);
        List<Contact> FindAll();
        void DeleteByID(int id);
        void Update(Contact contact);
    }
}
