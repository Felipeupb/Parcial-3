using System;

namespace Punto3_Entrega3
{
    class MainC
    {
        static void Main(string[] args)
        {
            Cat* hopkins = CAT_create("Hopkins");
            Dog* alfred = DOG_create("Alfred");
            Canary* tweeaty = Canary_create("Tweety");

            alfred->smell(alfred, hopkins);
            tweety->see(tweety, hopkins);

            hopkins->speak(hopkins);

            return EXIT_SUCCESS;
        }
    }
}
