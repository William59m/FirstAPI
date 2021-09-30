namespace ContosoPizza.Models
{
    public class Pizza
    {
        internal object id;

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsGlutenFree { get; set; }
    }
}
