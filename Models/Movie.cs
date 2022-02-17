using System.ComponentModel.DataAnnotations;
 
namespace Menghi.Massimo._5H.WebCRUD.Models;
public class Movie
{
    public int Id { get; set; }

    [Display(Name = "Titolo", Prompt = "Inserire il titolo", Description = "Titolo del film")]
    public string? Title { get; set; }
    [DataType(DataType.Date)]

    [Display(Name = "Data di pubblicazione", Prompt = "Inserire la data di pubblicazione", Description = "Data di pubblicazione")]
    public DateTime ReleaseDate { get; set; }

    [Display(Name = "Genere", Prompt = "Inserire il genere", Description = "Genere del film")]
    public string? Genre { get; set; }

    [Display(Name = "Prezzo", Prompt = "Inserire il prezzo", Description = "Prezzo")]
    public decimal Price { get; set; }
}  
