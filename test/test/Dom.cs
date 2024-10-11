namespace test
{
    public class Dom
    {
        public string Typ { get; set; }
        public string Adres { get; set; }
        private int Lokatorzy { get; set; }
        public void SetLokatorzy(int ilosc)
        {
            Lokatorzy = ilosc;
        }
        public int GetLokatorzy()
        {
            return Lokatorzy;
        }
    }

}