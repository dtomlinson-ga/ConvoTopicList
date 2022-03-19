using StardewModdingAPI;

namespace ConvoTopicList
{
	public class ModEntry : Mod
	{
		public override void Entry(IModHelper helper)
		{
			Globals.InitializeGlobals(this);
			ConsoleCommandManager.InitializeConsoleCommands();
		}
	}
}