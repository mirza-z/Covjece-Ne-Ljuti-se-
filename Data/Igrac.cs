
namespace Data
{
    public class Igrac
    {
        public int Id { get; set; }
        public List<Pijun> pijuni {  get; set; }
        public Igrac(int id)
        {
            Id=id;
            pijuni = new List<Pijun>();
        }
    }
}
