using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card
{
    /// <summary>
    /// 组合牌接口
    /// </summary>
    public interface IComboCard
    {
        //获取真实牌
        List<AbstractCard> GetRealCards();
        //获取该虚拟牌的替代值
        int GetCardType();
        //主动使用
        void Use(AbstractPlayer p, AbstractPlayer toP);
    }
}
