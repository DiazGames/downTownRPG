using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DiazDTRPG
{
    /// <summary>
    /// 物品类
    /// </summary>
    public class Item
    {

        public int ID { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 物品类型
        /// </summary>
        /// <value>The type of the item.</value>
        public ItemType Type { get; set; }
        /// <summary>
        /// 品质
        /// </summary>
        /// <value>The quality.</value>
        public ItemQuality Quality { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }
        /// <summary>
        /// 容量
        /// </summary>
        /// <value>The capacity.</value>
        public int Capacity { get; set; }
        /// <summary>
        /// 购买价格
        /// </summary>
        /// <value>The buyprice.</value>
        public int BuyPrice { get; set; }
        /// <summary>
        /// 销售价格
        /// </summary>
        /// <value>The sellprice.</value>
        public int SellPrice { get; set; }
        /// <summary>
        /// 物品对应图片
        /// </summary>
        /// <value>The sprite.</value>
        public string Sprite { get; set; }

        public Item()
        {
            ID = -1;
        }

        public Item(int id, string name, ItemType type, ItemQuality quality,
            string description, int capacity, int buyPrice, int sellPrice, string sprite)
        {
            ID = id;
            Name = name;
            Type = type;
            Quality = quality;
            Description = description;
            Capacity = capacity;
            BuyPrice = buyPrice;
            SellPrice = sellPrice;
            Sprite = sprite;
        }

        /// <summary> 
        /// 得到提示面板应该显示什么样的内容
        /// </summary>
        /// <returns></returns>
        public virtual string GetToolTipText()
        {
            string color = "";
            switch (Quality)
            {
                case ItemQuality.Common:
                    color = "white";
                    break;
                case ItemQuality.Uncommon:
                    color = "lime";
                    break;
                case ItemQuality.Rare:
                    color = "navy";
                    break;
                case ItemQuality.Epic:
                    color = "magenta";
                    break;
                case ItemQuality.Legendary:
                    color = "orange";
                    break;
                case ItemQuality.Artifact:
                    color = "red";
                    break;
            }
            string text = string.Format("<color={3}>{0}</color>\n<size=30><color=green>出售价格：{1}</color></size>\n<color=yellow><size=30>{2}</size></color>", Name, SellPrice, Description, color);
            return text;
        }
    }

    /// <summary>
    /// 物品类型
    /// </summary>
    public enum ItemType
    {
        Consumable,                                                             // 消耗品 
        Equipment,                                                              // 装备 
        Weapon,                                                                 // 武器
        Material                                                                // 材料
    }

    /// <summary>
    /// 物品品质
    /// </summary>
    public enum ItemQuality
    {
        Common,                                                                 // 一般
        Uncommon,                                                               // 不一般
        Rare,                                                                   // 稀有的
        Epic,                                                                   // 史诗的
        Legendary,                                                              // 传奇的
        Ancient,                                                                // 远古的
        Artifact                                                                // 人工锻造
    }


}