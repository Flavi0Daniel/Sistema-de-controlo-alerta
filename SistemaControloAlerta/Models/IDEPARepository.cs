using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControloAlerta.Models
{
    public interface IDepaRepository
    {
        void Add(DepaModel depa);
        void Edit(DepaModel depa);
        void Delete(int id);
        IEnumerable<DepaModel> GetAll();
        int CountAlerts();
        IEnumerable<DepaModel> GetAllNotifications();
        IEnumerable<DepaModel> GetByValue(string value); // Searchs
    }
}
