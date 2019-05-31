namespace MSM.Data.NhDatabase.NhModels
{
    public class Person : Entity
    {
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Email { get; set; }
        public virtual string Address { get; set; }
    }
}
