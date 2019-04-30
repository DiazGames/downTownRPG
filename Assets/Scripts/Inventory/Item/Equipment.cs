using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DiazDTRPG
{
    /// <summary>
    /// 装备类
    /// </summary>
    public class Equipment : Item
    {
        /// <summary>
        /// 力量
        /// </summary>
        /// <value>The strength.</value>
        public int Strength { get; set; }    // 力量
        /// <summary>
        /// 智力
        /// </summary>
        /// <value>The intellect.</value>
        public int Intellect { get; set; }    // 智力
        /// <summary>
        /// 敏捷
        /// </summary>
        /// <value>The agility.</value>
        public int Agility { get; set; }    // 敏捷
        /// <summary>
        /// 体力
        /// </summary>
        /// <value>The stamina.</value>
        public int Stamina { get; set; }    // 体力
        /// <summary>
        /// 装备类型
        /// </summary>
        /// <value>The type of the equip.</value>
        public EquipmentType EquipType { get; set; }    // 装备类型

        public Equipment(int id, string name, ItemType type, ItemQuality quality, string description, int capacity, int buyPrice, int sellPrice, string sprite,
            int strength, int intellect, int agility, int stamina, EquipmentType equipType)
            : base(id, name, type, quality, description, capacity, buyPrice, sellPrice, sprite)
        {
            Strength = strength;
            Intellect = intellect;
            Agility = agility;
            Stamina = stamina;
            EquipType = equipType;
        }

        public override string GetToolTipText()
        {
            string text = base.GetToolTipText();

            string equipTypeText = "";
            switch (EquipType)
            {
                case EquipmentType.Head:
                    equipTypeText = "头部";
                    break;
                case EquipmentType.Neck:
                    equipTypeText = "脖子";
                    break;
                case EquipmentType.Chest:
                    equipTypeText = "胸部";
                    break;
                case EquipmentType.Ring:
                    equipTypeText = "戒指";
                    break;
                case EquipmentType.Leg:
                    equipTypeText = "腿部";
                    break;
                case EquipmentType.Bracer:
                    equipTypeText = "护腕";
                    break;
                case EquipmentType.Boots:
                    equipTypeText = "靴子";
                    break;
                case EquipmentType.Shoulder:
                    equipTypeText = "护肩";
                    break;
                case EquipmentType.Belt:
                    equipTypeText = "腰带";
                    break;
                case EquipmentType.OffHand:
                    equipTypeText = "副手";
                    break;
            }

            string newText = string.Format("{0}\n\n<color=blue>装备类型：{1}\n力量：{2}\n智力：{3}\n敏捷：{4}\n体力：{5}</color>", text, equipTypeText, Strength, Intellect, Agility, Stamina);

            return newText;
        }
    }

    /// <summary>
    /// 装备类型
    /// </summary>
    public enum EquipmentType
    {
        None,
        Head,// 头部（helmets）
        Neck,// 脖子（necklace）
        Chest,// 胸部 （armor）
        Ring,// 戒指（rings）
        Leg,// 腿（pants）
        Bracer,// 护腕（bracers）
        Boots,// 靴子（boots）
        Trinket,// 饰品
        Shoulder,// 肩膀（shoulders）
        Belt,// 腰带（belts）
        OffHand// 副手（gloves）
    }

}