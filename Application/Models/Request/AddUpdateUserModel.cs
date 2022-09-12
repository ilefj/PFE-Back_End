namespace Application.Models
{
    public class AddUpdateUserModel
    {        
        public string UserName { get; set; }
        public string Prenom { get; set; }

        public string Adresse { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nom_Entreprise { get; set; }
        public string telephone { get; set; }
        public string Activite_Entreprise { get; set; }
        public string Taille_Entreprise { get; set; }
        public string Role { get; set; }

        public string Code_Fiscale { get; set; }
    }
}
