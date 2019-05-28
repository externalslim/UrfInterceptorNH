namespace MSM.Data.NhDatabase.NhModels
{
    public class User : Entity
    {
        public virtual int PersonId { get; set; }
        public virtual int ProjectId { get; set; }
        public virtual int RoleId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Password { get; set; }
    }
}
