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
	public partial class UIItem : UIElement
	{
        public Item Item { get; set; }
        public int Amount { get; set; }

        public Image imgItem;

        private Image ImgItem
        {
            get
            {
                if (imgItem == null)
                {
                    imgItem = GetComponent<Image>();
                }
                return imgItem;
            }
        }

        private void Awake()
		{

		}

        /// <summary>
        /// 显示物品
        /// </summary>
        /// <param name="item">Item.</param>
        /// <param name="amount">Amount.</param>
        public void SetItemUI(Item item, int amount = 1)
        {
            Item = item;
            Amount = amount;

            // update UI
            ImgItem.sprite = Resources.Load<Sprite>(Item.Sprite);
            TxtItemCount.text = Amount.ToString();
            if (Amount > 1)
            {
                TxtItemCount.Show();
                ImgItemCount.Show();
            }
            else
            {
                TxtItemCount.Hide();
                ImgItemCount.Hide();
            }
        }

        /// <summary>
        /// 增加物品数量
        /// </summary>
        /// <param name="amount">Amount.</param>
        public void AddAmount(int amount = 1)
        {
            Amount += amount;
            TxtItemCount.text = Amount.ToString();
            if (Amount > 1)
            {
                TxtItemCount.Show();
                ImgItemCount.Show();
            }
            else
            {
                TxtItemCount.Hide();
                ImgItemCount.Hide();
            }
        }











        protected override void OnBeforeDestroy()
        {
        }
    }
}