using NewHeroKill.Player;
namespace NewHeroKill.Service.AI
{


    /// <summary>
    /// AĮ����
    /// @author user
    /// 
    /// </summary>
    public class AISpeakService
    {
        /// <summary>
        /// �ҳ�������
        /// </summary>
        public static void sayFuckBoss(AbstractPlayer speaker)
        {
            string word = "[AI]" + speaker.GetInfo().GetName() + ":���SB����";
            ViewManagement.Instance.printChatMsg(word);
        }
    }

}