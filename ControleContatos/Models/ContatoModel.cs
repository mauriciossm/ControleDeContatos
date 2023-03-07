using System.ComponentModel.DataAnnotations;

namespace ControleContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do contato")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "O e-mail informado não é valido")]
        [Required(ErrorMessage = "Digite o e-mail do contato")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "O celular informado não é valido")]
        [Required(ErrorMessage = "Digite o celular do contato")]
        public string Celular { get; set; }


    }
}
