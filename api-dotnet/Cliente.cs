using System.ComponentModel.DataAnnotations;

public class Cliente
{
    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Pais { get; set; }
}