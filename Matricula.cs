using System;
using System.ComponentModel.DataAnnotations;

namespace ListaH1.Domain
{
    public class Matricula
    {
        [Key]
        public int IdMatricula { get; set; }
        public int IdAluno { get; set; }
        public int IdCurso { get; set; }
        public DateTime DataMatricula { get; set; }
        public bool Ativa { get; set; }
    }
}
