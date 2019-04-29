using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
using UnityEngine.UI;
using UniRx;

namespace DiazDTRPG
{
    public class Slot : MonoBehaviour
    {
        public GameObject itemPrefab;

        public Button BtnSlot;

        public void BtnSlotClick()
        {
            UIInvertoryPanel.Instance.ShowToolTip(transform.GetChild(0).GetComponent<ItemUI>().Item.Name);
        }

        /// <summary>
        /// 把item放在自身下面
        /// 如果自身下面已经有item了，amount++
        /// 如果没有 根据itemprefab去实例化一个item，放在下面
        /// </summary>
        /// <param name="item">Item.</param>
        public void StoreItem(Item item)
        {
            if(transform.childCount == 0)
            {
                GameObject itemObj = Instantiate(itemPrefab) as GameObject;
                itemObj.transform.SetParent(transform);
                //itemObj.transform.localPosition = Vector3.zero;
                itemObj.transform.LocalIdentity();
                itemObj.GetComponent<ItemUI>().SetItemUI(item);
            }
            else
            {
                transform.GetChild(0).GetComponent<ItemUI>().AddAmount();
            }
        }

        /// <summary>
        /// 获取物品槽现在放置物品的类型
        /// </summary>
        /// <returns>The item type.</returns>
        public ItemType GetItemType()
        {
            return transform.GetChild(0).GetComponent<ItemUI>().Item.Type;
        }

        /// <summary>
        /// 获取物品槽现在放置物品的ID
        /// </summary>
        /// <returns>The item type.</returns>
        public int GetItemID()
        {
            return transform.GetChild(0).GetComponent<ItemUI>().Item.ID;
        }

        public bool IsFilled()
        {
            ItemUI itemUI = transform.GetChild(0).GetComponent<ItemUI>();
            return itemUI.Amount >= itemUI.Item.Capacity;   //当前放置的数量=容量（物品槽已满）
        }
    }
}