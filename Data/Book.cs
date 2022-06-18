using System.ComponentModel.DataAnnotations; 

namespace zad6_1.Data;

public class Book {

    public string? Name {get; set;}
    public float Cost {get; set;}
    [DataType(DataType.Date)]
    public DateTime PublishDate {get;set;}
    public string? AuthorName {get;set;}
    public string? Image {get; set;}
    public int ID {get; set;}
}