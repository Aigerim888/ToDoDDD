namespace ToDoDDD.DAL.Entitities
{
    public class Priority : BaseEntity
    {
        public string Name { get; set; }
        
        public virtual List<Issue>? Issues { get; set; }

    }
}
