using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DiazDTRPG
{
    public class ItemUI : MonoBehaviour
    {

        public Item Item { get; set; }
        public int Amount { get; set; }

        private Image itemImage;
        private Text amountText;

        private Image ItemImage
        {
            get
            {
                if (itemImage == null)
                {
                    itemImage = GetComponent<Image>();
                }
                return itemImage;
            }
        }

        private Text AmountText
        {
            get
            {
                if (amountText == null)
                {
                    amountText = GetComponentInChildren<Text>();
                }
                return amountText;
            }
        }

        public void SetItemUI(Item item, int amount = 1)
        {
            Item = item;
            Amount = amount;

            // update UI
            ItemImage.sprite = Resources.Load<Sprite>(Item.Sprite);
            AmountText.text = Amount.ToString();
        }

        public void AddAmount(int amount = 1)
        {
            Amount += amount;
            AmountText.text = Amount.ToString();
        }
    }
}