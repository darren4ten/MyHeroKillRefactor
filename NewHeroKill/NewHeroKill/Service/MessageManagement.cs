using NewHeroKill.Data.Enums;
namespace NewHeroKill.Service
{


	/// <summary>
	/// ��Ϣ������
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
				msg = "δ������ʱ��";
				break;
                case EErrorMessageType.cannotUseCause_FullHP:
				msg = "��Ѫ������ʹ��";
				break;
                case EErrorMessageType.hasUsed:
				msg = "�Ѿ�ʹ�ù����޷��ٴ�ʹ��";
				break;
                case EErrorMessageType.hasUsed_Sha:
				msg = "�Ѿ�����ɱ";
				break;
			}
			ViewManagement.Instance.printChatMsg(msg);
		}
	}

}