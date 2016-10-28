using NewHeroKill.Card;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Player
{
    public interface IPlayerAction
    {

        /// <summary>
        /// 使用杀
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        bool Sha(AbstractPlayer p);

        /// <summary>
        /// 带技能杀
        /// </summary>
        void ShaWithSkill();

        /// <summary>
        /// 带装备杀
        /// </summary>
        void ShaWithEquipment();

        /// <summary>
        /// 使用闪
        /// </summary>
        void Shan();

        /// <summary>
        /// 使用桃
        /// </summary>
        void Tao();

        /// <summary>
        /// 是否回避杀
        /// </summary>
        /// <param name="murder"></param>
        /// <param name="card"></param>
        /// <returns></returns>
        bool AvoidSha(AbstractPlayer murder, Card_Sha card);

        /// <summary>
        /// 决斗
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        bool JueDou(AbstractPlayer p);

        /// <summary>
        /// 救人
        /// </summary>
        /// <param name="p"></param>
        void TaoSave(AbstractPlayer p);

        /// <summary>
        /// 加血
        /// </summary>
        /// <param name="num"></param>
        void AddHP(int num);

        /// <summary>
        /// 扣血
        /// </summary>
        /// <param name="num"></param>
        /// <param name="murderer"></param>
        void LoseHP(int num, AbstractPlayer murderer);

        /// <summary>
        /// 将制定牌添加到手牌中
        /// </summary>
        /// <param name="c"></param>
        void AddCardToHandCard(AbstractCard c);

        /// <summary>
        /// 从牌堆摸1张牌
        /// </summary>
        void AddOneCardFromList();

        /// <summary>
        /// 丢失手牌
        /// </summary>
        /// <param name="num"></param>
        void LoseHandCard(int num);

        /// <summary>
        /// 删除手牌
        /// </summary>
        /// <param name="index"></param>
        void RemoveCard(int index);

        /// <summary>
        /// 删除指定手牌
        /// </summary>
        /// <param name="c"></param>
        void RemoveCard(AbstractCard c);

        /// <summary>
        /// 装载装备
        /// </summary>
        /// <param name="c"></param>
        void LoadEquipmentCard(AbstractCard c);

        /// <summary>
        /// 丢失装备
        /// </summary>
        /// <param name="c"></param>
        void UnloadEquipmentCard(AbstractCard c);

        /// <summary>
        /// 发动锦囊效果
        /// </summary>
        void Magic();

        /// <summary>
        /// 处理判定牌
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        AbstractCard DealWithCheckCard(AbstractCard c);

        /// <summary>
        /// 死亡
        /// </summary>
        /// <param name="murderer"></param>
        void Dead(AbstractPlayer murderer);
    }
}
