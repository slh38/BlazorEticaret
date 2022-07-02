using System;
using System.ComponentModel.DataAnnotations;

namespace Blazor.Models
{
    public  class CourseDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Fiyat değerini boş geçmeyiniz..")]
        public decimal CoursePrice { get; set; }
        [Required(ErrorMessage = "Lütfen Durumunu Boş Geçmeyiniz...")]
        public bool IsActive { get; set; }
        public string Description { get; set; }
        [Required]
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public double RegularRate { get; set; }//puanlar
        public string Details { get; set; }
        public string CretaedBy { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string ImageUrl { get; set; }
        public int TotalCount { get; set; }


    }
}
