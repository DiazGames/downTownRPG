/****************************************************************************
 * 2019.4 风漫云端的MacBook Pro
 ****************************************************************************/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
using UniRx;

namespace DiazDTRPG
{
	public partial class UISolt : UIElement
	{
		private void Awake()
		{
            // 物品槽点击
            GetComponent<Button>()
                .OnClickAsObservable()
                .Subscribe(_ =>
                {
                    if (UIItem.Amount >= 1)
                    {
                        UIMgr.OpenPanel<UIInventoryItemPanel>(new UIInventoryItemPanelData
                        {
                            Solt = this,
                            item = UIItem.Item,
                            Amount = UIItem.Amount
                        });
                    }
                    else
                    {
                        Debug.Log("点击了按钮！！！！！！！！！！！！！但是里面没有放置物品！");
                    }

                });
        }

        /// <summary>
        /// 把item放在自身下面
        /// 如果自身下面已经有item了，amount++
        /// 如果没有 根据itemprefab去实例化一个item，放在下面
        /// </summary>
        /// <param name="item">Item.</param>
        public void StoreItem(Item item)
        {
            if (UIItem.Amount == 0)
            {

                UIItem.SetItemUI(item);
            }
            else
            {
                UIItem.AddAmount();
            }
        }


        public void ReduceItem(int amount)
        {
            UIItem.ReduceAmount(amount);
        }

        /// <summary>
        /// 获取物品槽现在放置物品的类型
        /// </summary>
        /// <returns>The item type.</returns>
        public ItemType GetItemType()
        {
            return UIItem.Item.Type;
        }

        /// <summary>
        /// 获取物品槽现在放置物品的ID
        /// </summary>
        /// <returns>The item type.</returns>
        public int GetItemID()
        {
            return UIItem.Item.ID;
        }

        /// <summary>
        /// 物品槽是否被填满
        /// </summary>
        /// <returns><c>true</c>, if filled was ised, <c>false</c> otherwise.</returns>
        public bool IsFilled()
        {
            return UIItem.Amount >= UIItem.Item.Capacity;   //当前放置的数量=容量（物品槽已满）
        }

        protected override void OnBeforeDestroy()
		{
		}



	}
}