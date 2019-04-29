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
    }

    /// <summary>
    /// 装备类型
    /// </summary>
    public enum EquipmentType
    {
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