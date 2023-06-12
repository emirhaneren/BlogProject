using System.ComponentModel.DataAnnotations;
//1. Step
namespace EntitiyLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string? ContactUserNamer { get; set; }
        public string? ContactMail { get; set; }
        public string? ContactSubject { get; set; }
        public string? ContactMessage { get; set; }
        public DateTime ContactDate { get; set; }
        public bool ContactStatus { get; set; }
    }
}
