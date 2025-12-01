using ListaH1.Domain;
using System.Collections.Generic;

namespace ListaH1.Repositories
{
    public interface ICursoRepository
    {
        List<Curso> GetAll();
        Curso GetById(int id);
        Curso Create(Curso curso);
        Curso Update(Curso curso);
        bool Delete(int id);
    }
}
