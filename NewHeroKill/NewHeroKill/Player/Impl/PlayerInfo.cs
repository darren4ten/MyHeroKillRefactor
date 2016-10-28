using NewHeroKill.Data.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Player.Impl
{
    public class PlayerInfo
    {
        //人物名称
        protected String name;
        //血量上限
        protected int maxHP;
        //人物性别 真-男；假-女
        protected bool sex;
        //所属势力
        protected ECountry country;
        //头像
        protected Image headImg;
        //免疫的牌
        protected List<int> immuneCard = new List<int>();
        //主动技能的类名
        protected List<String> skillName = new List<String>();
        //锁定技类名
        protected List<String> lockingSkill = new List<String>();

        public PlayerInfo()
        {

        }


        public String GetName()
        {
            return name;
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public int GetMaxHP()
        {
            return maxHP;
        }

        public void SetMaxHP(int maxHP)
        {
            this.maxHP = maxHP;
        }

        public bool GetSex()
        {
            return sex;
        }

        public void SetSex(bool sex)
        {
            this.sex = sex;
        }

        public ECountry GetCountry()
        {
            return country;
        }

        public void SetCountry(ECountry country)
        {
            this.country = country;
        }

        public Image GetHeadImg()
        {
            return headImg;
        }

        public void SetHeadImg(Image headImg)
        {
            this.headImg = headImg;
        }

        public List<int> GetImmuneCard()
        {
            return immuneCard;
        }


        public void SetImmuneCard(List<int> immuneCard)
        {
            this.immuneCard = immuneCard;
        }


        public List<String> GetSkillName()
        {
            return skillName;
        }


        public void SetSkillName(List<String> skillName)
        {
            this.skillName = skillName;
        }


        public List<String> GetLockingSkill()
        {
            return lockingSkill;
        }


        public void SetLockingSkill(List<String> lockingSkill)
        {
            this.lockingSkill = lockingSkill;
        }

    }
}
