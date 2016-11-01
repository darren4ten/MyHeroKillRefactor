using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card.Equipment
{
    /// <summary>
    /// 防具接口
    /// </summary>
    public interface IArmor
    {
        //是否免疫该牌
        bool Check(AbstractCard card, AbstractPlayer player);
    }
}
