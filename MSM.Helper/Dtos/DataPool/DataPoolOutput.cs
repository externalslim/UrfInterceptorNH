using MSM.Helper.Dtos.Base;
using System.Collections.Generic;

namespace MSM.Helper.Dtos.DataPool
{
    public class DataPoolOutput : BaseEntity
    {
        public List<DataPoolDto> DataPoolListModel { get; set; }
        public DataPoolDto DataPoolModel { get; set; }
    }
}
