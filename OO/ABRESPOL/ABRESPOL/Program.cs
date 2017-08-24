using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ABRESPOL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static List<Platillo> platos = new List<Platillo>();
        public static Persona persona = new Persona("","","");
        [STAThread]
        static void Main(string[] args)
        {
            PlatilloDirector director = new PlatilloDirector();
            PlatilloBuilder arrozCarneBuilder = new PlatilloBuilder();
            PlatilloBuilder sopita = new PlatilloBuilder();
            director.setPlatoBuilder(arrozCarneBuilder);
            director.construirPlato("Arroz con carne", "Rico arroz con carne frita yum :9", 2.5F, "Caliente", "Segundo", "Ejecutivo", "Malicia");
            platos.Add(director.getPlatillo());
            director.setPlatoBuilder(sopita);
            director.construirPlato("Sopita de pollo", "Rico arroz con carne frita yum :9", 2.5F, "Caliente", "Segundo", "Ejecutivo", "Malicia");
            platos.Add(director.getPlatillo());
            Console.WriteLine(platos.Count);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            
            LectorPlatillo programa = new LectorPlatillo();
            programa.ejecutar();
        }
    }
}
