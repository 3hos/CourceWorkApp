using System.ComponentModel.DataAnnotations;
using System.Resources;

namespace CourceWorkApp.Models.DbModels
{
    public class Guitar
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; } = "Guitar";

        [MaxLength(254)]
        public string? Description { get; set; } = string.Empty;

        public List<Component> Components { get; set; } = new List<Component>();
    }
}
