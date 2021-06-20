using ClassLibraryHuman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic_registry
{
    public class Medic : Human
    {
        public string specialty { get; set; }
        public string position { get; set; }
        public DateTime dateOfCommencement { get; set; }
        public List<Treatment> treatments { get; set; }

        public Medic() : base()
        {
            specialty = "Uncnown";
            position = "Uncnown";
            dateOfCommencement = new DateTime(1900, 01, 01);
            treatments = new List<Treatment>();
        }

        public Medic(string fio, Gender g, DateTime bd, string spec, string pos, DateTime dcom, List<Treatment> treatments)
            : base(fio, g, bd)
        {
            specialty = spec;
            position = pos;
            dateOfCommencement = dcom;
            this.treatments = treatments;
        }

        public override string GetInfo()
        {
            return string.Format("- {0}\n" +
                                 "- Пол: {1}\n" +
                                 "- Дата рождения: {2}\n" +
                                 "- Специальность: {3}\n" +
                                 "- Должность: {4}\n" +
                                 "- Дата начала работы: {5}\n" +
                                 "- Количество обращений: {6}\n",
                                 fio, Gender.мужской, birthdate, specialty, position, dateOfCommencement, treatments.Count);
        }
    }
}
