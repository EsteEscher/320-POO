using System.Text;
using Drones;
namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Drone> fleet = new List<Drone>();
            for (int i = 0; i < 1; i++)
                fleet.Add(new Drone(Config.AIRSPACE_WIDTH / 2, Config.AIRSPACE_HEIGHT / 2, "Le Joe" + i));
        }
    }
}
