namespace GestioneSpese_CatalinaDorneanu.Factory
{
    public class Viaggio : ICategory
    {
        public double Rimborso(double importo)
        {
            return importo + 50;
        }
    }
}