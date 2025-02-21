namespace MiApp.Patrones.Creacionales.AbstractFactory
{
    public class PerroFactory : AnimalFactory
    {
        public override Animal CrearAnimal()
        {
            return new Perro();
        }
    }
}
