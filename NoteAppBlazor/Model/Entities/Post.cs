using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Post
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; } // Fremdschlüssel zu User

    [Required]
    public string Text { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation Property für den Benutzer
    [ForeignKey("UserId")]
    public User User { get; set; }
}