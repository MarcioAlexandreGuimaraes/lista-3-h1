using ListaH1.Domain;
using System.Collections.Generic;

namespace ListaH1.Repositories
{
    public interface IMatriculaRepository
    {
        List<Matricula> GetAll();
        Matricula GetById(int id);
        Matricula Create(Matricula matricula);
        Matricula Update(Matricula matricula);
        bool Delete(int id);
    }
}
