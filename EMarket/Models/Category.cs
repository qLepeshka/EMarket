using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EMarket.Models
{
    [Table("Categories")]
    public class Category
    {        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? RootId { get; set; }

        public required string Name { get; set; }

        public DateTime Created { get; set; }

    }
}
