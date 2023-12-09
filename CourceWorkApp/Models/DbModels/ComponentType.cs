namespace CourceWorkApp.Models.DbModels
{
    public class ComponentType
    {
        public static ComponentType Default => new ComponentType("Arbitrary");

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public ComponentType(string name)
        {
            Name = name;
        }
    }
}
