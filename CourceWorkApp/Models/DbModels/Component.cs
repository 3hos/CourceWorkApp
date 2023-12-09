using Microsoft.Build.Framework;

namespace CourceWorkApp.Models.DbModels
{
    public class Component
    {
        public int Id { get; set; }

        public ComponentType Type { get; set; } = ComponentType.Default;

        public string Name { get; set; } = "Arbitrary";

        public string? Description { get; set; } = string.Empty;
    }
}
