using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DiazDTRPG
{
    /// <summary>
    /// 消耗品类
    /// </summary>
    public class Consumable : Item
    {
        public int HP { get; set; }
        public int MP { get; set; }


        public Consumable(int id, string name, ItemType type, ItemQuality quality, string description, int capacity, int buyPrice, int sellPrice, string sprite,
            int hp, int mp)
            : base(id, name, type, quality, description, capacity, buyPrice, sellPrice, sprite)
        {
            HP = hp;
            MP = mp;
        }
    }
}