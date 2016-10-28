using NewHeroKill.Card;
using NewHeroKill.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Player
{
    public interface IPlayerFunction
    {
        /// <summary>
        ///  获取上家
        /// </summary>
        /// <returns></returns>
        AbstractPlayer GetLastPlayer();

        /// <summary>
        /// 是否满血
        /// </summary>
        /// <returns></returns>
        bool IsFullHP();

        /// <summary>
        /// 是否空血
        /// </summary>
        void IsNullHP();

        /// <summary>
        /// 计算两家之间的距离
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        int GetDistance(AbstractPlayer p);

        /// <summary>
        /// 获取场上全部玩家
        /// </summary>
        /// <returns></returns>
        List<AbstractPlayer> GetAllPlayers();

        /// <summary>
        /// 获取全部玩家的手牌
        /// </summary>
        /// <returns></returns>
        List<String> GetAllPlayersHandCard();

        /// <summary>
        /// 翻开一张判定牌进行花色判定
        /// </summary>
        /// <param name="card"></param>
        /// <param name="colors"></param>
        /// <returns></returns>
        bool CheckRollCard(AbstractCard card, params ECardColorTypes[] colors);

        /// <summary>
        /// 翻开一张判定牌进行数值判定
        /// </summary>
        /// <param name="card"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        bool CheckRollCard(AbstractCard card, int max, int min);

        /// <summary>
        /// 攻击范围
        /// </summary>
        /// <returns></returns>
        int GetAttackDistance();

        /// <summary>
        /// 防守距离
        /// </summary>
        /// <returns></returns>
        int GetDefenceDistance();

        /// <summary>
        /// 锦囊使用范围
        /// </summary>
        /// <returns></returns>
        int GetKitUseDistance();

        /// <summary>
        /// 是否在攻击范围
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        bool IsInRange(AbstractPlayer target);

        /// <summary>
        /// 是否同一国家
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        bool IsSameCountry(AbstractPlayer target);

        /// <summary>
        /// 是否同性别
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        bool IsSameSex(AbstractPlayer target);
    }
}
