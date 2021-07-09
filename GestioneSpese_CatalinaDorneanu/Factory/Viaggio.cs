namespace GestioneSpese_CatalinaDorneanu.Factory
{
    internal class Viaggio : ICategory
    {
        public double Rimborso(double importo)
        {
            return importo + 50;
        }
    }
}