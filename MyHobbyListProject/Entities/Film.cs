using MyHobbyListProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHobbyListProject.Entities
{
    public class Film : Hobby
    {
        public EnumClassificationFilmAndSerie ClassificationFilm { get; set; }

        public Film(string name, string resume, EnumStatus enumStatus, EnumScore enumScore, EnumClassificationFilmAndSerie classificationFilm) : base(name, resume, enumStatus, enumScore)
        {
            ClassificationFilm = classificationFilm;
           
        }

    }
}
