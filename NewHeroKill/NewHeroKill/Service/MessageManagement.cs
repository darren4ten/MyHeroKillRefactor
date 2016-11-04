using NewHeroKill.Data.Enums;
namespace NewHeroKill.Service
{


	/// <summary>
	/// 消息管理类
	/// @author user
	/// 
	/// </summary>
	public class MessageManagement
	{
		public static void printErroMsg(EErrorMessageType emt)
		{
			string msg = null;
			switch (emt)
			{
                case EErrorMessageType.cannotUseNow:
				msg = "未到发动时机";
				break;
                case EErrorMessageType.cannotUseCause_FullHP:
				msg = "满血，不能使用";
				break;
                case EErrorMessageType.hasUsed:
				msg = "已经使用过，无法再次使用";
				break;
                case EErrorMessageType.hasUsed_Sha:
				msg = "已经出过杀";
				break;
			}
			ViewManagement.Instance.printChatMsg(msg);
		}
	}

}