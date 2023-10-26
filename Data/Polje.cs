
namespace Data
{
    public class Polje
    {
        public List<Lokacija> Tabla { get; set; }
        public Polje()
        {
            Tabla = new List<Lokacija>();
            Tabla.Add(new Lokacija() { Left = 240, Top = 495 }); //0
            Tabla.Add(new Lokacija() { Left = 240 - 39 * 0, Top = 495 - 39 * 1 }); //1
            Tabla.Add(new Lokacija() { Left = 240 - 39 * 0, Top = 495 - 39 * 2 }); //2
            Tabla.Add(new Lokacija() { Left = 240 - 39 * 0, Top = 495 - 39 * 3 }); //3
            Tabla.Add(new Lokacija() { Left = 240 - 39 * 0, Top = 495 - 39 * 4 }); //4
            
            Tabla.Add(new Lokacija() { Left = 240 - 39 * 1, Top = 498 - 39 * 5 }); //5
            Tabla.Add(new Lokacija() { Left = 240 - 39 * 2, Top = 498 - 39 * 5 }); //6
            Tabla.Add(new Lokacija() { Left = 240 - 39 * 3, Top = 498 - 39 * 5 }); //7
            Tabla.Add(new Lokacija() { Left = 238 - 39 * 4, Top = 498 - 39 * 5 }); //8

            Tabla.Add(new Lokacija() { Left = 238 - 39 * 5, Top = 499 - 39 * 5 }); //9
            Tabla.Add(new Lokacija() { Left = 237 - 39 * 6, Top = 499 - 39 * 5 }); //10
            Tabla.Add(new Lokacija() { Left = 236 - 39 * 6, Top = 500 - 39 * 6 }); //11
            Tabla.Add(new Lokacija() { Left = 236 - 39 * 6, Top = 500 - 39 * 7 }); //12

            Tabla.Add(new Lokacija() { Left = 237 - 39 * 5, Top = 500 - 39 * 7 }); //13
            Tabla.Add(new Lokacija() { Left = 238 - 39 * 4, Top = 500 - 39 * 7 }); //14
            Tabla.Add(new Lokacija() { Left = 238 - 39 * 3, Top = 500 - 39 * 7 }); //15
            Tabla.Add(new Lokacija() { Left = 238 - 39 * 2, Top = 500 - 39 * 7 }); //16

            Tabla.Add(new Lokacija() { Left = 239 - 39 * 1, Top = 500 - 39 * 7 }); //17
            Tabla.Add(new Lokacija() { Left = 240 - 39 * 0, Top = 501 - 39 * 8 }); //18
            Tabla.Add(new Lokacija() { Left = 240 - 39 * 0, Top = 501 - 39 * 9 }); //19
            Tabla.Add(new Lokacija() { Left = 240 - 39 * 0, Top = 502 - 39 * 10 }); //20

            Tabla.Add(new Lokacija() { Left = 240 - 39 * 0, Top = 505 - 39 * 11 }); //21
            Tabla.Add(new Lokacija() { Left = 240 - 39 * 0, Top = 505 - 39 * 12 }); //22
            Tabla.Add(new Lokacija() { Left = 240 - 39 * 0, Top = 505 - 39 * 13 }); //23
            Tabla.Add(new Lokacija() { Left = 240 + 39 * 1, Top = 505 - 39 * 13 }); //24

            Tabla.Add(new Lokacija() { Left = 240 + 39 * 2, Top = 505 - 39 * 13 }); //25
            Tabla.Add(new Lokacija() { Left = 240 + 39 * 2, Top = 505 - 39 * 12 }); //26
            Tabla.Add(new Lokacija() { Left = 240 + 39 * 2, Top = 505 - 39 * 11 }); //27
            Tabla.Add(new Lokacija() { Left = 240 + 39 * 2, Top = 503 - 39 * 10 }); //28

            Tabla.Add(new Lokacija() { Left = 240 + 39 * 2, Top = 503 - 39 * 9 }); //29
            Tabla.Add(new Lokacija() { Left = 240 + 39 * 2, Top = 502 - 39 * 8 }); //30
            Tabla.Add(new Lokacija() { Left = 241 + 39 * 3, Top = 500 - 39 * 7 }); //31
            Tabla.Add(new Lokacija() { Left = 242 + 39 * 4, Top = 500 - 39 * 7 }); //32

            Tabla.Add(new Lokacija() { Left = 242 + 39 * 5, Top = 500 - 39 * 7 }); //33
            Tabla.Add(new Lokacija() { Left = 242 + 39 * 6, Top = 500 - 39 * 7 }); //34
            Tabla.Add(new Lokacija() { Left = 242 + 39 * 7, Top = 500 - 39 * 7 }); //35
            Tabla.Add(new Lokacija() { Left = 243 + 39 * 8, Top = 500 - 39 * 7 }); //36

            Tabla.Add(new Lokacija() { Left = 243 + 39 * 8, Top = 499 - 39 * 6 }); //37
            Tabla.Add(new Lokacija() { Left = 243 + 39 * 8, Top = 499 - 39 * 5 }); //38
            Tabla.Add(new Lokacija() { Left = 243 + 39 * 7, Top = 499 - 39 * 5 }); //39
            Tabla.Add(new Lokacija() { Left = 243 + 39 * 6, Top = 499 - 39 * 5 }); //40

            Tabla.Add(new Lokacija() { Left = 243 + 39 * 5, Top = 499- 39 * 5 }); //41
            Tabla.Add(new Lokacija() { Left = 243 + 39 * 4, Top = 499 - 39 * 5 }); //42
            Tabla.Add(new Lokacija() { Left = 241 + 39 * 3, Top = 499 - 39 * 5 }); //43
            Tabla.Add(new Lokacija() { Left = 241 + 39 * 2, Top = 499 - 39 * 4 }); //44

            Tabla.Add(new Lokacija() { Left = 240 + 39 * 2, Top = 498 - 39 * 3 }); //45
            Tabla.Add(new Lokacija() { Left = 240 + 39 * 2, Top = 497 - 39 * 2 }); //46
            Tabla.Add(new Lokacija() { Left = 240 + 39 * 2, Top = 496 - 39 * 1 }); //47
            Tabla.Add(new Lokacija() { Left = 240 + 39 * 2, Top = 495 - 39 * 0 }); //48

            Tabla.Add(new Lokacija() { Left = 240 + 39 * 2, Top = 495 + 39 * 1 }); //49
            Tabla.Add(new Lokacija() { Left = 240 + 39 * 1, Top = 495 + 39 * 1 }); //50
            Tabla.Add(new Lokacija() { Left = 240 + 39 * 0, Top = 495 + 39 * 1 }); //51
       
        }
    }
}
