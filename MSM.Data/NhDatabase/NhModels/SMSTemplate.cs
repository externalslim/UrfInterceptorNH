namespace MSM.Data.NhDatabase.NhModels
{
    public class SMSTemplate : Entity
    {
        public virtual int UserId { get; set; }
        public virtual int SMSTemplateGroupId { get; set; }
        public virtual string Name { get; set; }
    }
}
