using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DiazDTRPG
{
    public class Inventory : MonoBehaviour
    {
        private Slot[] slotList;

        // Use this for initialization
        public virtual void Start()
        {
            slotList = GetComponentsInChildren<Slot>();
        }

        public bool StoreItem(int id)
        {
            Item item = UIInvertoryPanel.Instance.GetItemByID(id);
            return StoreItem(item);
        }

        public bool StoreItem(Item item)
        {
            if (item == null)
            {
                Debug.LogWarning("要存储的物品的ID不存在！");

                return false;
            }

            if (item.Capacity == 1)     // 如果该物品单独占用一个物品槽（slot）
            {
                // 找到一个空的物品槽放进去
                Slot slot = FindEmptySlot();
                if (slot == null)
                {
                    Debug.LogWarning("没有空的物品槽");
                    return false;
                }
                else
                {
                    slot.StoreItem(item);
                }
            }
            else
            {
                // 查找相同类型物品槽
                Slot slot = FindSameTypeSlot(item);
                if (slot != null)
                {
                    slot.StoreItem(item);
                }
                else
                {
                    Slot emptySlot = FindEmptySlot();
                    if (emptySlot != null)
                    {
                        emptySlot.StoreItem(item);
                    }
                    else
                    {
                        Debug.LogWarning("没有空的物品槽");
                        return false;
                    }
                }

            }

            return true;
        }

        /// <summary>
        /// 查找空的物品槽
        /// </summary>
        /// <returns>The empty slot.</returns>
        private Slot FindEmptySlot()
        {
            foreach (Slot slot in slotList)
            {
                if(slot.transform.childCount == 0)
                {
                    return slot;
                }
            }
            return null;
        }

        /// <summary>
        /// 查找同类型的物品槽
        /// </summary>
        /// <returns>The same type slot.</returns>
        /// <param name="item">Item.</param>
        private Slot FindSameTypeSlot(Item item)
        {
            foreach (Slot slot in slotList)
            {
                if(slot.transform.childCount >= 1   // 物品槽中已经放置物体
                && slot.GetItemID() == item.ID  // 放置的物品ID一致
                    && slot.IsFilled() == false)    // 物品槽没有放满
                {
                    return slot;
                }
            }

            return null;
        }

    }
}