using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Player
{
    public interface IPlayerAction
    {

        //使用杀
        bool Sha(AbstractPlayer p);

        //带技能杀
        void ShaWithSkill();

        //带装备杀
        void ShaWithEquipment();

        //使用闪
        void Shan();

        //使用桃
        void Tao();

        //是否回避杀
        bool AvoidSha(AbstractPlayer murder, Card_Sha card);

        //决斗
        bool JueDou(AbstractPlayer p);

        //救人
        void TaoSave(AbstractPlayer p);

        //加血
        void AddHP(int num);

        //扣血
        void LoseHP(int num, AbstractPlayer murderer);

        //将制定牌添加到手牌中
        void AddCardToHandCard(AbstractCard c);

        //从牌堆摸1张牌
        void AddOneCardFromList();

        //丢失手牌
        void LoseHandCard(int num);

        //删除手牌
        void RemoveCard(int index);

        //删除指定手牌
        void RemoveCard(AbstractCard c);

        //装载装备
        void LoadEquipmentCard(AbstractCard c);

        //丢失装备
        void UnloadEquipmentCard(AbstractCard c);

        //发动锦囊效果
        void Magic();

        //处理判定牌
        AbstractCard DealWithCheckCard(AbstractCard c);

        //死亡
        void Dead(AbstractPlayer murderer);
    }
}
