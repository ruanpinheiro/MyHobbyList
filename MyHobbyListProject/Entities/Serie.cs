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
    }
}
