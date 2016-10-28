using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Data.Type
{

    /**
     * 封装了牌的使用目标对象
     * @author user
     *
     */
    public class Target
    {
        //存储人物模型
        List<AbstractPlayer> list;
        //目标上限
        int limit = 1;
        //是否需要检测
        bool needCheck;

        //构造
        public Target(int limit)
        {
            list = new List<AbstractPlayer>();
            this.limit = limit;
        }

        /**
         * 添加一个
         */
        public void add(AbstractPlayer p)
        {
            //如果重复则返回
            if (list.Contains(p)) return;
            //若达到上限则删除第一个再添加
            if (list.Count() >= limit)
            {
                list.RemoveAt(0);
                list.Add(p);
            }
            else
            {
                list.Add(p);
            }
        }
        /**
         * 判断是否为空
         * @return
         */
        public bool isEmpty()
        {
            return (list == null || list.Count() == 0);
        }
        public List<AbstractPlayer> getList()
        {
            return list;
        }

        public int getLimit()
        {
            return limit;
        }

        public void setLimit(int limit)
        {
            this.limit = limit;
        }

        public void setList(List<AbstractPlayer> list)
        {
            this.list = list;
        }

        public bool isNeedCheck()
        {
            return needCheck;
        }

        public void setNeedCheck(bool needCheck)
        {
            this.needCheck = needCheck;
        }


    }

}
