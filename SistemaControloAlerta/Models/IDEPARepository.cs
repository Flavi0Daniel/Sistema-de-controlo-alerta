using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControloAlerta.Models
{
    public interface IDEPARepository
    {
        void Add(DEPAModel depa);
        void Edit(DEPAModel depa);
        void Delete(int id);
        IEnumerable<DEPAModel> GetAll();
        IEnumerable<DEPAModel> GetByValue(string value); // Searchs
    }
}
