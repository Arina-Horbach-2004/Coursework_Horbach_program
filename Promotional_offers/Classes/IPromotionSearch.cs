using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotional_offers.Classes
{
    public interface IPromotionSearch
    {
        List<Promotion> SearchPromotions(string category, string keywords, List<Promotion> promotions);
    }
}
