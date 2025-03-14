using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Username { get; set; }

    [Required]
    [StringLength(100)]
    public string Email { get; set; }

    [Required]
    [StringLength(255)]
    public string PasswordHash { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Beziehung zu Posts (Ein Benutzer kann viele Posts haben)
    public List<Post> Posts { get; set; } = new();
}