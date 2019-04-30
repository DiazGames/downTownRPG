// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace DiazDTRPG
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using QFramework;
    using UnityEngine;
    using UnityEngine.UI;
    using UniRx;
    
    public class UIInventoryNewPanelData : QFramework.UIPanelData
    {
    }
    
    public partial class UIInventoryNewPanel : QFramework.UIPanel
    {
        //private UISolt[] slotList;

        private List<UISolt> mSlotList;

        /// <summary>
        /// 已使用的物品槽数量
        /// </summary>
        public int InventoryUsedCount;

        protected override void RegisterUIEvent()
        {
            Observable.EveryUpdate().Subscribe(_ =>
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    int id = UnityEngine.Random.Range(1, 6);
                    StoreItem(id);
                }
            });

            BtnInventoryAdd.OnClickAsObservable().Subscribe(_ =>
            {
                Debug.Log("BtnInventoryAdd =============");
                UIMgr.OpenPanel<UIAddInventoryPanel>();
            });
        }

        protected override void ProcessMsg(int eventId, QFramework.QMsg msg)
        {
            throw new System.NotImplementedException ();
        }
        
        protected override void OnInit(QFramework.IUIData uiData)
        {
            mData = uiData as UIInventoryNewPanelData ?? new UIInventoryNewPanelData();
            // please add init code here

            ShowInventoryList();

            ShowUsedTextCount();

        }
        
        protected override void OnOpen(QFramework.IUIData uiData)
        {
        }
        
        protected override void OnShow()
        {
        }
        
        protected override void OnHide()
        {
        }
        
        protected override void OnClose()
        {
        }

        public bool StoreItem(int id)
        {
            Debug.Log("随机出来的ID是 ================ " + id);
            Item item = ItemsData.GetItemByID(id);
            if (item.IsNotNull())
            {
                return StoreItem(ItemsData.GetItemByID(id));
            }
            else
            {
                Debug.Log("没有找到对应id的item··");
                return false;
            }
        }

        /// <summary>
        /// 物品放入到物品槽内
        /// </summary>
        /// <returns><c>true</c>, if item was stored, <c>false</c> otherwise.</returns>
        /// <param name="item">Item.</param>
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
                UISolt slot = FindEmptySlot();
                if (slot == null)
                {
                    Debug.LogWarning("没有空的物品槽");
                    // 跳转到失败界面
                    UIMgr.OpenPanel<UIDataUpdateSucceedPanel>(new UIDataUpdateSucceedPanelData
                    {
                        SuccessModel = new DataUpdateSuccessModel
                        {
                            StrTitle = "失败了",
                            StrDesc = "没有空的物品槽~",
                            IsSucceed = false
                        }
                    });
                    return false;
                }
                else
                {
                    slot.StoreItem(item);
                    // 显示已使用数量
                    ShowUsedTextCount();
                }
            }
            else
            {
                // 查找相同类型物品槽
                UISolt slot = FindSameTypeSlot(item);
                if (slot != null)
                {
                    slot.StoreItem(item);
                }
                else
                {
                    UISolt emptySlot = FindEmptySlot();
                    if (emptySlot != null)
                    {
                        emptySlot.StoreItem(item);
                        // 显示已使用数量
                        ShowUsedTextCount();
                    }
                    else
                    {
                        Debug.LogWarning("没有空的物品槽");
                        // 跳转到失败界面
                        UIMgr.OpenPanel<UIDataUpdateSucceedPanel>(new UIDataUpdateSucceedPanelData
                        {
                            SuccessModel = new DataUpdateSuccessModel
                            {
                                StrTitle = "失败了",
                                StrDesc = "没有空的物品槽~",
                                IsSucceed = false
                            }
                        });
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
        private UISolt FindEmptySlot()
        {
            foreach (UISolt slot in mSlotList)
            {
                if (slot.UIItem.Amount == 0)
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
        private UISolt FindSameTypeSlot(Item item)
        {
            foreach (UISolt slot in mSlotList)
            {
                if (slot.UIItem.Amount >= 1   // 物品槽中已经放置物体
                && slot.GetItemID() == item.ID  // 放置的物品ID一致
                    && slot.IsFilled() == false)    // 物品槽没有放满
                {
                    return slot;
                }
            }
            return null;
        }

        /// <summary>
        /// 显示背包列表
        /// </summary>
        public void ShowInventoryList()
        {
            mSlotList = new List<UISolt>();
            for (int i = 0; i < GameData.InventoryCount; i++)
            {
                UISolt.Instantiate()
                .Parent(Content)
                .LocalIdentity()
                .ApplySelfTo(self =>
                {
                    //self.Init();
                    self.Show();
                    mSlotList.Add(self);
                });

            }
        }

        /// <summary>
        /// 显示新增背包列表
        /// </summary>
        public void ShowAddNewInventoryList()
        {
            for (int i = 0; i < 10; i++)
            {
                UISolt.Instantiate()
                .Parent(Content)
                .LocalIdentity()
                .ApplySelfTo(self =>
                {
                    //self.Init();
                    self.Show();
                    mSlotList.Add(self);
                });

            }
        }

        /// <summary>
        /// 显示背包使用数量，根据物品槽中的item实际是否存在判断
        /// </summary>
        public void ShowUsedTextCount()
        {
            InventoryUsedCount = 0;
            // 初始化已使用的物品槽
            foreach (UISolt solt in mSlotList)
            {
                if (solt.UIItem.Amount >= 1)
                {
                    InventoryUsedCount = InventoryUsedCount + 1;
                }
            }

            TxtUsedCount.text = InventoryUsedCount.ToString();
            TxtAllCount.text = "/ " + GameData.InventoryCount.ToString();
        }

        /// <summary>
        /// 更新状态条上的数据
        /// </summary>
        public void UpdateTopStautsValue()
        {
            // 更新本页数据
            UITopStatus.ShowValueChaged();
            // 更新首页数据
            UIMgr.GetPanel<UIHomePanel>().UpdateTopStautsValue();
        }

    }
}
