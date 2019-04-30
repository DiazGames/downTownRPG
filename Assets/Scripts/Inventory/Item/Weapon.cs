using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DiazDTRPG
{
    /// <summary>
    /// 武器类
    /// </summary>
    public class Weapon : Item
    {
        /// <summary>
        /// 攻击力
        /// </summary>
        /// <value>The damage.</value>
        public int Damage { get; set; }
        /// <summary>
        /// 武器类型
        /// </summary>
        /// <value>The type of the wp.</value>
        public WeaponType WpType { get; set; }

        public Weapon(int id, string name, ItemType type, ItemQuality quality, string description, int capacity, int buyPrice, int sellPrice, string sprite,
            int damage, WeaponType wpType)
            : base(id, name, type, quality, description, capacity, buyPrice, sellPrice, sprite)
        {
            Damage = damage;
            WpType = wpType;
        }

        public override string GetToolTipText()
        {
            string text = base.GetToolTipText();

            string wpTypeText = "";

            switch (WpType)
            {
                case WeaponType.OffHand:
                    wpTypeText = "副手";
                    break;
                case WeaponType.MainHand:
                    wpTypeText = "主手";
                    break;
            }

            string newText = string.Format("{0}\n\n<color=blue>武器类型：{1}\n攻击力：{2}</color>", text, wpTypeText, Damage);

            return newText;
        }
    }

    public enum WeaponType
    {
        None,
        OffHand,    // 副手
        MainHand    // 主手
    }
}