namespace Application.Models.DTO
{
    public class ResponsableDTO
    {

        public ResponsableDTO(string id, string username, string prenom, string adresse, string nom_Entreprise, string email, string telephone, string activite_Entreprise, string taille_Entreprise, string code_Fiscale, string role)
        {
            this.Id = id;
            this.username = username;
            this.Prenom = prenom;
            Adresse = adresse;
            Nom_Entreprise = nom_Entreprise;
            Email = email;
            this.telephone = telephone;
            Activite_Entreprise = activite_Entreprise;
            Taille_Entreprise = taille_Entreprise;
            Code_Fiscale = code_Fiscale;
            Role = role;
        }

       
        public string Id { get; set; }

        public string username { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }

        public string Nom_Entreprise { get; set; }
        public string Email { get; set; }

        public string telephone { get; set; }

        public string Activite_Entreprise { get; set; }

        public string Taille_Entreprise { get; set; }
        public string Code_Fiscale { get; set; }

        public string Role { get; set; }

        public string Token { get; set; }
    }
}
