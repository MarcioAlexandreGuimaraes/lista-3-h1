using ListaH1.DTOs;
using ListaH1.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ListaH1.Services
{
    public class CursoService : ICursoService
    {
        private readonly ICursoRepository _repo;

        public CursoService(ICursoRepository repo)
        {
            _repo = repo;
        }

        public List<CursoDTO> GetAll()
            => _repo.GetAll().Select(x => new CursoDTO
            {
                IdCurso = x.IdCurso,
                Nome = x.Nome,
                NomeCoordenador = x.NomeCoordenador,
                Ativo = x.Ativo
            }).ToList();
    }
}
