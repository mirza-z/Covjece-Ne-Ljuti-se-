
namespace Data
{
    public class Igrac
    {
        public int Id { get; set; }
        public bool Pobijedio { get; set; }
        public int UKucici {  get; set; }  
        public List<Pijun> pijuni {  get; set; }
        public Igrac(int id)
        {
            Id=id;
            Pobijedio =false;
            UKucici = 0;
            pijuni = new List<Pijun>();
        }
    }
}
