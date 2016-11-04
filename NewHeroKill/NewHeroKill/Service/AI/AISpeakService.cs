using NewHeroKill.Player;
namespace NewHeroKill.Service.AI
{


    /// <summary>
    /// AI台词类
    /// @author user
    /// 
    /// </summary>
    public class AISpeakService
    {
        /// <summary>
        /// 忠臣喷主公
        /// </summary>
        public static void sayFuckBoss(AbstractPlayer speaker)
        {
            string word = "[AI]" + speaker.GetInfo().GetName() + ":你个SB主公";
            ViewManagement.Instance.printChatMsg(word);
        }
    }

}