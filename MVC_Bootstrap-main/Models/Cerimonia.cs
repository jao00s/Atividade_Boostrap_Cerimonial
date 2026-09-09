using System.ComponentModel.DataAnnotations;

namespace CerimonialCasamentos.Models
{
public class Cerimonia
{
    public int Id {get;set;}
    
    [Required(ErrorMessage = "O campo Noiva é obrigatório")]
    public string? Noiva{get;set;}

    [Required(ErrorMessage = "O campo Noivo é obrigatório")]
    public string? Noivo{get;set;}
    [Required(ErrorMessage = "O campo Data é obrigatório")]
    [DataType(DataType.Date)]
    public DateTime Data{get;set;}
     [Required(ErrorMessage = "O campo Local é obrigatório")]
    public string? Local {get;set;}

    [Range(1,100, ErrorMessage ="Informe uma quantidade válida.")]
    [Display(Name ="Quantidade de Convidados")]
    public int QuantidadeConvidados {get;set;}

}

}