using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DiazDTRPG
{
    public class ProductGemModel
    {
        public int ProductID { get; set; }

        public string ProductiOSID { get; set; }
        public string ProductGoogleID { get; set; }
        public string ProductSamsungID { get; set; }
        public string ProductAmazonID { get; set; }
        public string ProductXiaomiID { get; set; }

        public string ProductName { get; set; }

        /// <summary>
        /// purple 描述图片
        /// </summary>
        /// <value>The sprite.</value>
        public string ProductPurpleSprite { get; set; }
        /// <summary>
        /// purple 描述文字
        /// </summary>
        /// <value>The sprite.</value>
        public string ProductPurpleDesc { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        /// <value>The description.</value>
        public string ProductDesc { get; set; }

        /// <summary>
        /// 商品图片
        /// </summary>
        /// <value>The sprite.</value>
        public string ProductSprite { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        /// <value>The sprite.</value>
        public int ProductNum { get; set; }

        /// <summary>
        /// 商品优惠 百分比
        /// </summary>
        /// <value>The sprite.</value>
        public int ProductBouns { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        /// <value>The capacity.</value>
        public float ProductPrice { get; set; }

        public ProductGemModel(string productID)
        {
            ProductID = -1;
        }

        public ProductGemModel(int productID, string productiOSID, string productGoogleID, string productSamsungID, string productAmazonID, string productXiaomiID,
        string productName, string productPurpleSprite, string productPurpleDesc, string productDesc, 
            string productSprite, int productNum, int productBouns, float productPrice)
        {
            ProductID = productID;
            ProductiOSID = productiOSID;
            ProductGoogleID = productGoogleID;
            ProductSamsungID = productSamsungID;
            ProductAmazonID = productAmazonID;
            ProductXiaomiID = productXiaomiID;
            ProductName = productName;
            ProductPurpleSprite = productPurpleSprite;
            ProductPurpleDesc = productPurpleDesc;
            ProductDesc = productDesc;
            ProductSprite = productSprite;
            ProductNum = productNum;
            ProductBouns = productBouns;
            ProductPrice = productPrice;
        }
    }
}