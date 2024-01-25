using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControloAlerta.Models
{
    public interface IDEPARepository
    {
        void Add(DEPA depa);
        void Edit(DEPA depa);
        void Delete(int id);
        IEnumerable<DEPA> GetAll();
        IEnumerable<DEPA> GetByValues(); // Search
    }
}
