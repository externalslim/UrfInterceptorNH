using MSM.Helper.Dtos.Base;
using System.Collections.Generic;

namespace MSM.Helper.Dtos.Person
{
    public class PersonOutput : BaseEntity
    {
        public List<PersonDto> PersonListModel { get; set; }
        public PersonDto PersonModel { get; set; }
    }
}
