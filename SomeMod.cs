using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
              
namespace SomeMod
{
    public class SomeMod : Mod
    {
        public SomeMod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
       
    }
}
