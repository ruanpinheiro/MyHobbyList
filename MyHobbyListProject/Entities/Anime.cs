using MyHobbyListProject.Enums;

namespace MyHobbyListProject.Entities
{
    public class Anime : Hobby
    {
        public EnumClassificationAnimes ClassificationAnime { get; set; }
        public int QtdEpisodes { get; set; }

        public Anime(string name,int qtdEpisodes, string resume, EnumStatus enumStatus, EnumScore enumScore, EnumClassificationAnimes classificationAnime) : base(name, resume, enumStatus, enumScore)
        {
            ClassificationAnime = classificationAnime;
            QtdEpisodes = qtdEpisodes;
        }
    }
}
