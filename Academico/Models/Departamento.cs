using System.ComponentModel.DataAnnotations;

namespace Academico.Models
{
    public class Departamento
    {
            public long DepartamentoID { get; set; }
            public string Nome { get; set; }
            public string Telefone { get; set; }
            [Display(Name = ("E-mail"))]
            public string Email { get; set; }
            [Display(Name = ("Institução"))]  
            public int InstituicaoId { get; set; }
            public Instituicao? InstituicaoOrigem { get; set; }
            [Display(Name = ("Coordenador"))]
            public string NomeCoordenador { get; set; }
    }
}


