﻿namespace tpmodul5_103022300153
{
    class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }

    class Program
    {
        static void Main()
        {
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser("Dina");
        }
    }
}
