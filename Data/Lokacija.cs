namespace Data
{
    public class Lokacija
    {
        public int Left{ get; set; }
        public int Top { get; set; }

        public Lokacija() { }
        public Lokacija(int left, int top)
        {
            Left = left;
            Top = top;
        }
    }
}