namespace WinAuth
{
	public static class Steam
	{
		public enum EUniverse
		{
			k_EUniverseInvalid = 0,
			k_EUniversePublic = 1,
			k_EUniverseBeta = 2,
			k_EUniverseInternal = 3,
			k_EUniverseDev = 4,
			k_EUniverseMax
		};

		/// <summary>
		/// URLs for all mobile services
		/// </summary>
		public static EUniverse UNIVERSE;
		public const string COOKIE_COMMUNITY_BASE = "https://steamcommunity.com";
		public static string COMMUNITY_BASE;
		public static string WEBAPI_BASE;
		public static string OAUTH_CLIENT_ID;
		public static string TWOFACTOR_SYNC_URL;

#pragma warning disable 162
		static Steam() {
			UNIVERSE = EUniverse.k_EUniversePublic;
			switch(UNIVERSE)
			{
				case EUniverse.k_EUniversePublic:
					COMMUNITY_BASE = "https://steamcommunity.com";
					WEBAPI_BASE = "https://api.steampowered.com";
					OAUTH_CLIENT_ID = "DE45CD61";
					break;
			}
			TWOFACTOR_SYNC_URL = WEBAPI_BASE + "/ITwoFactorService/QueryTime/v0001";
		}

	}
}
