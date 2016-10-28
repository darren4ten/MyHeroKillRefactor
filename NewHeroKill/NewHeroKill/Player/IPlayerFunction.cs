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
        // 获取上家
        AbstractPlayer GetLastPlayer();

        // 是否满血
        bool IsFullHP();

        // 是否空血
        void IsNullHP();

        // 计算两家之间的距离
        int GetDistance(AbstractPlayer p);

        // 获取场上全部玩家
        List<AbstractPlayer> GetAllPlayers();

        // 获取全部玩家的手牌
        List<String> GetAllPlayersHandCard();

        // 翻开一张判定牌进行花色判定
        bool CheckRollCard(AbstractCard card, params ECardColorTypes[] colors);

        // 翻开一张判定牌进行数值判定
        bool CheckRollCard(AbstractCard card, int max, int min);

        //攻击范围
        int GetAttackDistance();

        //防守距离
        int GetDefenceDistance();

        //锦囊使用范围
        int GetKitUseDistance();

        bool IsInRange(AbstractPlayer target);

        //是否同一国家
        bool IsSameCountry(AbstractPlayer target);
        //是否同性别
        bool IsSameSex(AbstractPlayer target);
    }
}
