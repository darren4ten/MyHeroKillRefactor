using NewHeroKill.Player;
namespace NewHeroKill.Service.AI
{


	/// <summary>
	/// ������AI��һЩ��˼�����ж�
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