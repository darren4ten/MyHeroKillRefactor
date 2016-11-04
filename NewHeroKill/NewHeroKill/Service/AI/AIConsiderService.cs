using NewHeroKill.Player;
namespace NewHeroKill.Service.AI
{


	/// <summary>
	/// 涵盖了AI的一些简单思考和判断
	/// @author user
	/// 
	/// </summary>
	public class AIConsiderService
	{
		protected internal AbstractPlayer player;
		public AIConsiderService()
		{
		}
		public AIConsiderService(AbstractPlayer player)
		{
			this.player = player;
		}
	}

}