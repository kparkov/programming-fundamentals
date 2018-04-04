using System.Threading;

namespace Gladiator
{
    public static class C
    {
        public const double TIME_FACTOR = 1;

        public static void Wait(int ms, bool suppressFactor = false)
        {
            var target = (int) (ms * (suppressFactor ? 1 : TIME_FACTOR));
            Thread.Sleep(target);
        }
    }
}