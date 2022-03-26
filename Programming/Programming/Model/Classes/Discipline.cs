using System;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        public Discipline()
        {
        }
        public Discipline(string informatics,
            string mathematics,
            string foreighnLanguage)
        {
            Informatics = informatics;
            Mathematics = mathematics;
            ForeignLanguage = foreighnLanguage;
        }
        public string Informatics { get; set; }
        public string Mathematics { get; set; }
        public string ForeignLanguage { get; set; }
    }
}
