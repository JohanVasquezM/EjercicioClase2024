namespace EjercicioClase2024
{
    public class Superpoder
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Nivel { get; set; }

        public Superpoder(string nombre, string descripcion, int nivel)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Nivel = nivel;
        }
    }
}
