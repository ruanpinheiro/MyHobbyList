using MyHobbyListProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHobbyListProject.Entities
{
    public class Serie : Hobby
    {
        public EnumClassificationFilmAndSerie ClassificationSerie { get; set; }
        public int QtdEpisodes { get; set; }

        public Serie(string name, int qtdEpisodes, string resume, EnumStatus enumStatus, EnumScore enumScore, EnumClassificationFilmAndSerie classificationSerie) : base(name, resume, enumStatus, enumScore)
        {
            ClassificationSerie = classificationSerie;
            QtdEpisodes = qtdEpisodes;
        }
    }
}
