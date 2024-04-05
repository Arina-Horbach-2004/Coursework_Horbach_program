using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotional_offers.Classes
{
    // Інтерфейс для клонування об'єктів
    public interface ICloneable
    {
        // Метод для створення глибокої копії об'єкта
        object Clone();
    }
}
