namespace GestioneSpese_CatalinaDorneanu.Factory
{
    internal class Vitto : ICategory
    {
        public double Rimborso(double importo)
        {
            return importo * 0.7;
        }
    }
}