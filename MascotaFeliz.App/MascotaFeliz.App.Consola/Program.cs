using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            //AddDueno();
           // AddVeterinario();
           // AddMascota();
           //BuscarDueno();
           //ListarDuenos();
           ListarMascota();
        }
        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Juan",
                Apellidos = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                Correo = "juansinmiedo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                //Cedula = "1212",
                Nombres = "Alvaro",
                Apellidos = "Torres",
                Direccion = "Encima de un puente",
                Telefono = "987456321",
                TarjetaProfesional = "Zootecnia"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

private static void AddMascota()
        {
            var mascota = new Mascota
            {
               
                Nombre = "Wendy",
                Color="Negro",
                Raza = "Yorky",
                Especie = "Canino",
                
            };
            _repoMascota.AddMascota(mascota);
        }

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine( dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
        }

private static void ListarDuenos()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos);
            }
        }
private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine( mascota.Nombre + " " + mascota.Color + " " + mascota.Raza + " " + mascota.Especie);
        }

private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota d in mascotas)
            {
                Console.WriteLine(d.Nombre + " " + d.Raza+ " " +d.Especie);
            }
        }


    }
}
