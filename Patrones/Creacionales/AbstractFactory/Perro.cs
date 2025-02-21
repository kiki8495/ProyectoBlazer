namespace MiApp.Patrones.Creacionales.AbstractFactory
{
    public class Perro : Animal
    {
        public override string Cuidar()
        {
            return "Cuidando a un perro: Alimentando, sacando a pasear y jugando.";
        }
    }
}
