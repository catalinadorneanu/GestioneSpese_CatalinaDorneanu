namespace GestioneSpese_CatalinaDorneanu.Factory
{
    internal class Altro : ICategory
    {
        public double Rimborso(double importo)
        {
            return importo * 0.1;
        }
    }
}