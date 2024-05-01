using EjercicioClase2024;
{
    {
        SuperHeroe Mujer_Maravilla = new SuperHeroe(
            "Mujer Maravilla",
            "Diana Prince",
            "Themyscira",
            false,
            new Superpoder("Super fuerza y agilidad", "Capacidad de levanta objetos muy pesados y agilidad sobrehumana", 9));

        SuperHeroe Batman = new SuperHeroe(
            "Batman",
            "Bruce Wayne",
            "Gotham",
            false,
            new Superpoder("Inteligencia superior","Capacidad de resolver problemas complejos y estrategia", 7));

        SuperHeroe Flash = new SuperHeroe(
            "Flash",
            "Barry Allen",
            "Central City",
            false,
            new Superpoder("Super velocidad", "Capacidad de moverse a velocidades inimaginables", 10));

        Mujer_Maravilla.MostrarInformacion();
        Console.WriteLine();
        Batman.MostrarInformacion();
        Console.WriteLine();
        Flash.MostrarInformacion();
    }
}