using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class FileToUpload
{
    [Key]
    public int Id { get; set; }
    public int Identity { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }
    public string Mobile { get; set; }
    public string Active { get; set; }
}
