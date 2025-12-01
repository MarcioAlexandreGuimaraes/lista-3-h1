using ListaH1.Data;
using ListaH1.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ListaH1.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        private readonly EscolaContext _context;

        public CursoRepository(EscolaContext context)
        {
            _context = context;
        }

        public List<Curso> GetAll() => _context.Cursos.ToList();

        public Curso GetById(int id) => _context.Cursos.Find(id);

        public Curso Create(Curso curso)
        {
            _context.Cursos.Add(curso);
            _context.SaveChanges();
            return curso;
        }

        public Curso Update(Curso curso)
        {
            _context.Cursos.Update(curso);
            _context.SaveChanges();
            return curso;
        }

        public bool Delete(int id)
        {
            var curso = _context.Cursos.Find(id);
            if (curso == null) return false;

            _context.Cursos.Remove(curso);
            _context.SaveChanges();
            return true;
        }
    }
}
