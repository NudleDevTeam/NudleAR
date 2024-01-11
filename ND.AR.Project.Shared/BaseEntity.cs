namespace ND.AR.Project.Shared
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }

        public virtual DateTime CreatedDate { get; }
        public virtual DateTime ModifiedDate { get; }
    }
}