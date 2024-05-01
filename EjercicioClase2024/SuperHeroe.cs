namespace EjercicioClase2024
{
    public class SuperHeroe
    {
        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad {  get; set; }
        public bool PuedeVolar {  get; set; }
        public Superpoder SuperPoder { get; set; }

        public SuperHeroe(string nombre, string identidadSecreta, string ciudad, bool puedeVolar ,Superpoder superPoder)
        {
            Nombre = nombre;
            IdentidadSecreta = identidadSecreta;
            Ciudad = ciudad;
            PuedeVolar = puedeVolar;
            SuperPoder = superPoder;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"¿Puede volar?: {(PuedeVolar ? "Si" : "No")}");
            Console.WriteLine($"Super poder: {SuperPoder.Nombre}");
            Console.WriteLine($"Descripción: {SuperPoder.Descripcion}");
            Console.WriteLine($"Nivel: {SuperPoder.Nivel}");
        }
    }
}
