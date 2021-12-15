using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VireiDev.Models
{
    public class CursoModels

    {
        [Key]
        [Display(Name = "ID")]
        public int IdCurso { get; set; }
        [Display(Name = "Descrição do Curso")]
        public string DescricaoCurso { get; set; }

        [Display(Name = "Nome do Curso")]
        public string NomeCurso { get; set; }
        public List<TurmaModels> Turmas { get; set; }
    }
}