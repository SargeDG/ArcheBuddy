using System;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x0200054D RID: 1357
	public enum GameState : byte
	{
		// Token: 0x04001333 RID: 4915
		NotLogged,
		// Token: 0x04001334 RID: 4916
		ServerSelect,
		// Token: 0x04001335 RID: 4917
		ConnectingToGameServer,
		// Token: 0x04001336 RID: 4918
		CharacterSelect,
		// Token: 0x04001337 RID: 4919
		LoadingGameWorld,
		// Token: 0x04001338 RID: 4920
		Ingame,
		// Token: 0x04001339 RID: 4921
		WaitingQueue
	}
}
