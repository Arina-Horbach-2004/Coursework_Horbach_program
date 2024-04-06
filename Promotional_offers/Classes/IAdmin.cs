using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotional_offers.Classes
{
    public interface IAdmin
    {
        string Email { get; set; }
        string Password { get; set; }

        bool Authenticate(string login, string password);

        bool CreatePromotion(int id, string store, string category, string promoCode, DateTime expirationDate, string photo, string description);

        bool EditPromotion(int id, string store, string category, string promoCode, DateTime expirationDate, string photo, string description);

        bool DeletePromotion(int id);

        List<Promotion> GetValidPromotions();

        List<Promotion> GetDeletedPromotions();

        List<RegisteredUser> GetRegisteredUsers();
    }
}
