using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Benutzername ist erforderlich.")]
    [RegularExpression(@"^[a-zA-Z0-9_-]+$", ErrorMessage = "Benutzername darf nur Buchstaben, Zahlen, '_' oder '-' enthalten.")]
    [StringLength(20, ErrorMessage = "Benutzername darf maximal 20 Zeichen lang sein.")]
    public string Username { get; set; } = string.Empty;


    [Required(ErrorMessage = "Email ist erforderlich.")]
    [EmailAddress(ErrorMessage = "Ungültige Email-Adresse.")]
    public string Email { get; set; } = String.Empty;

    [Required]
    [StringLength(255)]
    public string PasswordHash { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Beziehung zu Posts (Ein Benutzer kann viele Posts haben)
    public List<Post> Posts { get; set; } = new();
}