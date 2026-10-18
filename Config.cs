using System.ComponentModel;
using Terraria.ModLoader.Config;

#pragma warning disable CS0649

namespace AutoReroll
{
	class Config : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ClientSide;
		[Range(1, 100)]
		[DefaultValue(10)]
		[Increment(1)]
		public int ReforgePerSec;
		[DefaultValue(false)]
		public bool UseDefaultReforgeMenu;
		public override void OnChanged()
		{
			AutoReroll.ForgePerSec = ReforgePerSec;
			AutoReroll.UseDefaultReforgeMenu = UseDefaultReforgeMenu;
		}
	}
}
