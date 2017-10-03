using Terraria.ModLoader;

namespace Pokarria
{
	class Pokarria : Mod
	{
		public Pokarria()
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
