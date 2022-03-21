using MyHobbyListProject.Enums;

namespace MyHobbyListProject.Entities
{
    public abstract class Hobby
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Resume { get; set; }
        public EnumStatus EnumStatus { get; set; }
        public EnumScore EnumScore { get; set; }

    }
}
