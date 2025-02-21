namespace MiApp.Patrones.Creacionales.AbstractFactory
{
    public class GatoFactory : AnimalFactory
    {
        public override Animal CrearAnimal()
        {
            return new Gato();
        }
    }
}