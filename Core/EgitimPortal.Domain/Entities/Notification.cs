using EgitimPortal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimPortal.Domain.Entities
{
    public class Notification:EntityBase
    {
        public int Id { get; set; } // Otomatik artan bir kimlik
        public string Message { get; set; } // Bildirim mesajı
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
