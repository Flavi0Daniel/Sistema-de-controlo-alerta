using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControloAlerta.Models
{
    public interface IusuarioRepository
    {
        // void Add(UsuarioModel depa);
        void Edit(UsuarioModel depa);
        // void Delete(int id);
        // IEnumerable<UsuarioModel> GetAll();
        UsuarioModel GetById(int id);
        // IEnumerable<NiveisAcesso> GetAccessLevels();
    }
}
