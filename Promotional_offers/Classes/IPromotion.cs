using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotional_offers.Classes
{
    public interface IPromotion
    {
        int ID { get; set; }
        string Shop { get; set; }
        string Category { get; set; }
        string Code { get; set; }
        DateTime ExpiryDate { get; set; }
        string Photo { get; set; }
        string Description { get; set; }

        bool IsUsed { get; }

        public bool UsePromotion(string promoCode);

        public bool EditPromotion(int id, string shop, string category, string code, DateTime expiryDate, string photo, string description);

        public void DisplayDetails(bool isAuthenticated);
    }
}
