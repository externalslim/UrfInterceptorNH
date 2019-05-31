namespace MSM.Data.NhDatabase.NhModels
{
    public class MailTemplateSchema : Entity
    {
        public virtual int MailTemplateGroupId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Subject { get; set; }
        public virtual string Body { get; set; }
    }
}
