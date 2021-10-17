using Sandbox.UI;

namespace MinimalExample {
	/// <summary>
	/// This is the HUD entity. It creates a RootPanel clientside, which can be accessed
	/// via RootPanel on this entity, or Local.Hud.
	/// </summary>
	public partial class MinimalHudEntity : Sandbox.HudEntity<RootPanel> {
		public MinimalHudEntity() {
			if (IsClient) {
				RootPanel.SetTemplate("/minimalhud.html");
			}
		}
	}

}
