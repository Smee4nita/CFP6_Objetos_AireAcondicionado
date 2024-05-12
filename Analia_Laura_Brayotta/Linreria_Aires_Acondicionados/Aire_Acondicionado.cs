using System.Drawing;
using System.Reflection;

namespace Linreria_Aires_Acondicionados
{
    public class AireAcondicionado
    {
        private string modelo;
        private string marca;
        private int watts;
        private Color color;
        private double temperatura;
     
        public AireAcondicionado(string modelo, string marca, int watts, Color color, double temperatura)
        {
            this.modelo=modelo; 
            this.marca= marca;
            this.watts=watts;
            this.color=color;
            this.temperatura=0;
        }

        public AireAcondicionado(string modelo, string marca, int watts, double temperatura)
        {
            this.modelo=modelo;
            this.marca= marca;
            this.watts=watts;
            this.temperatura=0;
        }

        public string GetMoldelo()
        {
            return modelo;
        }
        public int GetWatts()
        {
            return watts;
        }
        public string GetMarca()
        {
            return marca;
        }

        public Color GetColor()
        {
            return color;
        }

        public double GetTemperatura() 
        {
            return temperatura;
        }

        public void SetColor( Color color)
        {
            this.color = color;
        }
        public void SetTemperatura(double temperatura)
        {
            this.temperatura=temperatura;
        }



        public string ElectrodomesticoToString()
        {
            return $"Electrodomestico: Modelo: {modelo} - Marca: {marca} - Watts: {watts}  - Color: {color} -Temperatura {temperatura} ";

        }
   
    }
}
