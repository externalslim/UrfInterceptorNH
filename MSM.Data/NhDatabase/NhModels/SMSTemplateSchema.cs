namespace MSM.Data.NhDatabase.NhModels
{
    public class SMSTemplateSchema : Entity
    {
        public virtual int SMSTemplateGroupId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Body { get; set; }
    }
}
