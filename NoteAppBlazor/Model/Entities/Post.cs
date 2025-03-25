using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Post
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; } // Fremdschlüssel zu User

    [Required(ErrorMessage = "Dieses Feld darf nicht leer sein.")]
    [StringLength(500, ErrorMessage = "Dieses Feld darf nicht mehr als 500 Zeichen enthalten.")]
    public string Text { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation Property für den Benutzer
    [ForeignKey("UserId")]
    public User User { get; set; }

    [Required]
    public bool IsFavorite { get; set; } = false;
    
    [Required]
    public string Category { get; set; } = string.Empty;
    
    
    public DateTime Deadline { get; set; }
}