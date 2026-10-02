using Drones.Helpers;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Cr�ation de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            for(int i = 0; i < 1; i++)
                fleet.Add(new Drone(Config.AIRSPACE_WIDTH / 2, Config.AIRSPACE_HEIGHT / 2, "Le Joe" + i));

            List<Charger> charge = new List<Charger>();
            for (int i = 0; i < 1; i++)
                charge.Add(new Charger(Config.AIRSPACE_WIDTH / 2, Config.AIRSPACE_HEIGHT / 2));

            List<Pizzeria> Pizzi = new List<Pizzeria>();
            Pizzeria.RegisterPizzeria(Pizzi);

            List<Client> cliente = new List<Client>();
            for (int i = 0; i < 20; i++)
                cliente.Add(new Client(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));

            // D�marrage
            Application.Run(new AirSpace(fleet, charge, Pizzi, cliente));
        }
    }
}