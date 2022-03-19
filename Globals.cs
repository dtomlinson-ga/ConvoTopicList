using StardewModdingAPI;

namespace ConvoTopicList
{
	internal class Globals
	{
		public static IManifest Manifest { get; set; }
		public static IModHelper Helper { get; set; }
		public static string UUID => Manifest.UniqueID;

		internal static void InitializeGlobals(ModEntry modEntry)
		{
			Manifest = modEntry.ModManifest;
			Helper = modEntry.Helper;
			Log.Monitor = modEntry.Monitor;
		}
	}
}