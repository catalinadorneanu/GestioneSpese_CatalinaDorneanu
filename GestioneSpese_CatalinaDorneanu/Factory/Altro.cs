namespace GestioneSpese_CatalinaDorneanu.Factory
{
    public class Altro : ICategory
    {
        public double Rimborso(double importo)
        {
            return importo * 0.1;
        }
    }
}