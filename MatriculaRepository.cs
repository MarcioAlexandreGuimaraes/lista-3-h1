using ListaH1.Data;
using ListaH1.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ListaH1.Repositories
{
    public class MatriculaRepository : IMatriculaRepository
    {
        private readonly EscolaContext _context;

        public MatriculaRepository(EscolaContext context)
        {
            _context = context;
        }

        public List<Matricula> GetAll() => _context.Matriculas.ToList();

        public Matricula GetById(int id) => _context.Matriculas.Find(id);

        public Matricula Create(Matricula matricula)
        {
            _context.Matriculas.Add(matricula);
            _context.SaveChanges();
            return matricula;
        }

        public Matricula Update(Matricula matricula)
        {
            _context.Matriculas.Update(matricula);
            _context.SaveChanges();
            return matricula;
        }

        public bool Delete(int id)
        {
            var matricula = _context.Matriculas.Find(id);
            if (matricula == null) return false;

            _context.Matriculas.Remove(matricula);
            _context.SaveChanges();
            return true;
        }
    }
}
