using Linreria_Aires_Acondicionados;
namespace Aire_acondicionado
{
    internal class Aire
    {
        static void Main(string[] args)
        {
            AireAcondicionado aireUno = new AireAcondicionado("ventana", "sanyo", 3000, 00);

            AireAcondicionado aireDos = new AireAcondicionado("ventana", "LG", 4500, 00);

            AireAcondicionado aireTres = new AireAcondicionado("split", "Midea", 3000, 00);

            AireAcondicionado aireCuatro = new AireAcondicionado("split inverter", "sanyo", 3000, 00);

            AireAcondicionado aireCinco = new AireAcondicionado("ventana", "hisense", 3500, 00);

            AireAcondicionado aireSeis = new AireAcondicionado("portatil", "surrey", 3800, 00);

            List<AireAcondicionado> ListaAires = new List<AireAcondicionado>();
            ListaAires.Add(aireUno);
            ListaAires.Add(aireDos);
            ListaAires.Add(aireTres);
            
        }
    }
}
