using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tytuł zadania jest wymagany")]
        [StringLength(100, ErrorMessage = "Tytuł nie może być dłuższy niż 100 znaków.")]
        public string? Title { get; set; }

        [StringLength(500, ErrorMessage = "Opis nie może być dłuższy niż 500 znaków.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Termin wykonania jest wymagany")]
        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Priorytet jest wymagany")]
        [StringLength(10)]
        public string? Priority { get; set; } // Niski, Średni, Wysoki

        [Required(ErrorMessage = "Kategoria jest wymagana")]
        [StringLength(50)]
        public string? Category { get; set; } // Osobiste, Praca, etc.

        public bool IsCompleted { get; set; } = false; // Czy zadanie zostało ukończone?
    }
}
