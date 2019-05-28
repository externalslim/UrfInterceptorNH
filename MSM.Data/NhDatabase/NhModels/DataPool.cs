namespace MSM.Data.NhDatabase.NhModels
{
    public class DataPool : Entity
    {
        public virtual int FromListGroupId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
    }
}
