using DiaryApp.Constants;
using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        [Key]
        public int EntryId { get; set; }


        [Required(ErrorMessage = "Please provide a title for your diary entry.")]
        [MinLength(DiaryEntryConstants.TitleMinLength, ErrorMessage = "Your title must be at least 3 characters long.")]
        [MaxLength(DiaryEntryConstants.TitleMaxLength, ErrorMessage = "Your title can be up to 50 characters long. Keep it short and sweet!")]
        public string Title { get; set; } = string.Empty;


        [Required(ErrorMessage = "Don't forget to write some content for your entry!")]
        [MinLength(DiaryEntryConstants.ContentMinLength, ErrorMessage = "Your entry should be at least 10 characters. Tell us more!")]
        [MaxLength(DiaryEntryConstants.ContentMaxLength, ErrorMessage = "Your content can be up to 1000 characters long. Share your thoughts, but keep it concise!")]
        public string Content { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please select a date for your diary entry.")]
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
