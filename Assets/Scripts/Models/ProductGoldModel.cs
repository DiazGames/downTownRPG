using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DiazDTRPG
{
    public class ProductGoldModel
    {
        public int ProductGoldID { get; set; }

        public string ProductGoldName { get; set; }

        /// <summary>
        /// purple 描述图片
        /// </summary>
        /// <value>The sprite.</value>
        public string ProductGoldPurpleSprite { get; set; }
        /// <summary>
        /// purple 描述文字
        /// </summary>
        /// <value>The sprite.</value>
        public string ProductGoldPurpleDesc { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        /// <value>The description.</value>
        public string ProductGoldDesc { get; set; }

        /// <summary>
        /// 商品图片
        /// </summary>
        /// <value>The sprite.</value>
        public string ProductGoldSprite { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        /// <value>The sprite.</value>
        public int ProductGoldNum { get; set; }

        /// <summary>
        /// 商品优惠 百分比
        /// </summary>
        /// <value>The sprite.</value>
        public int ProductGoldBouns { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        /// <value>The capacity.</value>
        public int ProductGoldPrice { get; set; }

        public ProductGoldModel(string productGoldID)
        {
            ProductGoldID = -1;
        }

        public ProductGoldModel(int productGoldID,
        string productGoldName, string productGoldPurpleSprite, string productGoldPurpleDesc, string productGoldDesc, 
            string productGoldSprite, int productGoldNum, int productGoldBouns, int productGoldPrice)
        {
            ProductGoldID = productGoldID;
            ProductGoldName = productGoldName;
            ProductGoldPurpleSprite = productGoldPurpleSprite;
            ProductGoldPurpleDesc = productGoldPurpleDesc;
            ProductGoldDesc = productGoldDesc;
            ProductGoldSprite = productGoldSprite;
            ProductGoldNum = productGoldNum;
            ProductGoldBouns = productGoldBouns;
            ProductGoldPrice = productGoldPrice;
        }
    }
}