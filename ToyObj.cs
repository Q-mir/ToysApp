using System.ComponentModel.DataAnnotations;


namespace ToysApp
{
    public class ToyObj
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; } = null!;

        [MaxLength(100)]
        public string DateOfСreation { get; set; } = DateTime.Now.ToString();

        
        [MaxLength(100)] 
        public string Producter { get; set; } = null!;

        [Range(1,150000)]
        public int Price { get; set; } = 0;

        [Range(1, 1000)]
        public int Weight { get; set; } = 0;
        
        [MaxLength(100)]
        public int AgeLimit { get; set; } = 0;
        
        [MaxLength(100)]
        public string DateOfLastSale { get; set; } = DateTime.Now.ToString();
    }
}
