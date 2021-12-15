using System.ComponentModel.DataAnnotations;

namespace VireiDev.Models
{
    public class TurmaModels
    {
        [Key]
        [Display(Name = "ID")]
        public int IdTurma { get; set; }
        [Display(Name = "Descrição")]
        public string DescricaoTurma { get; set; }
        [Display(Name = "Quantidade de Alunos")]
        public int QtdDeAlunos { get; set; }
        [Display(Name = "Ativa")]
        public bool IsActive { get; set; }
        public string Turno { get; set; }
        [Display(Name = "ID")]
        public int IdCurso { get; set; }
    }
}