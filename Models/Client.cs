namespace HELMo_bilite.Models
{
    public class Client : User
    {
        public string CompanyName { get; set; }
        public Adress CompanyAdress { get; set; }
    }
}
