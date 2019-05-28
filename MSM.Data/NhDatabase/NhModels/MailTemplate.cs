namespace MSM.Data.NhDatabase.NhModels
{
    public class MailTemplate : Entity
    {
        public virtual int UserId { get; set; }
        public virtual int MailTemplateGroupId { get; set; }
        public virtual string Name { get; set; }
    }
}
