using System.ComponentModel.DataAnnotations;


namespace Site_Venda_Lanche.ViewModels
{
    public class LoginViewModel
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }


        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
