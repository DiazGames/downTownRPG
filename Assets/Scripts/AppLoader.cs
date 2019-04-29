using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
using System;

namespace DiazDTRPG
{
    public class AppLoader : MonoBehaviour
    {
        private void Awake()
        {
            ResMgr.Init();
            UIMgr.SetResolution(Screen.width, Screen.height, 1.0f);
            DontDestroyOnLoad(UIManager.Instance);
        }

        private void Start()
        {
            UIMgr.OpenPanel<UIHomePanel>();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public static class GameData
    {
        /// <summary>
        /// 背包数量
        /// </summary>
        /// <value>The inventory count.</value>
        public static int InventoryCount
        {
            get
            {
                return PlayerPrefs.GetInt("INVENTORY_COUNT", 40);
            }
            set
            {
                PlayerPrefs.SetInt("INVENTORY_COUNT", value);
            }
        }

        /// <summary>
        /// 钻石数量
        /// </summary>
        /// <value>The gem count.</value>
        public static int GemCount
        {
            get
            {
                return PlayerPrefs.GetInt("GEM_COUNT", 10000);
            }
            set
            {
                PlayerPrefs.SetInt("GEM_COUNT", value);
            }
        }

        /// <summary>
        /// 金币数量
        /// </summary>
        /// <value>The gold count.</value>
        public static int GoldCount
        {
            get
            {
                return PlayerPrefs.GetInt("GOLD_COUNT", 10000);
            }
            set
            {
                PlayerPrefs.SetInt("GOLD_COUNT", value);
            }
        }
    }

    /// <summary>
    /// 物品信息，从items.json 中读取
    /// </summary>
    public static class ItemsData
    {
        public static List<Item> ItemsDataList
        {
            get
            {
                return GetItems();
            }
        }

        /// <summary>
        /// 根据 ID 获取 Item 对象
        /// </summary>
        /// <returns>The item by identifier.</returns>
        /// <param name="id">Identifier.</param>
        public static Item GetItemByID(int id)
        {
            foreach (Item item in ItemsDataList)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }


        private static List<Item> GetItems()
        {
            List<Item> newItemList = new List<Item>();
            string jsonContent = Resources.Load<TextAsset>("Json/Items").text;
            JSONObject json = new JSONObject(jsonContent);
            foreach (JSONObject temp in json.list)
            {

                string typeStr = temp.GetField("type").str;
                ItemType type = (ItemType)System.Enum.Parse(typeof(ItemType), typeStr);

                int id = (int)temp.GetField("id").n;
                string nameStr = temp.GetField("name").str;
                ItemQuality quality = (ItemQuality)System.Enum.Parse(typeof(ItemQuality), temp.GetField("quality").str);
                string description = temp.GetField("description").str;
                int capacity = (int)temp.GetField("capacity").n;
                int buyPrice = (int)temp.GetField("buyPrice").n;
                int sellPrice = (int)temp.GetField("sellPrice").n;
                string sprite = temp.GetField("sprite").str;

                Item item = null;
                switch (type)
                {
                    case ItemType.Consumable:
                        int hp = (int)temp.GetField("hp").n;
                        int mp = (int)temp.GetField("mp").n;
                        item = new Consumable(
                                id, nameStr, type, quality, description, capacity, buyPrice, sellPrice, sprite, hp, mp
                                );
                        break;
                    case ItemType.Equipment:
                        int strength = (int)temp.GetField("strength").n;
                        int intellect = (int)temp.GetField("intellect").n;
                        int agility = (int)temp.GetField("agility").n;
                        int stamina = (int)temp.GetField("stamina").n;
                        EquipmentType equipType = (EquipmentType)System.Enum.Parse(typeof(EquipmentType), temp.GetField("equipType").str);
                        item = new Equipment(
                                id, nameStr, type, quality, description, capacity, buyPrice, sellPrice, sprite, 
                                strength, intellect, agility, stamina, equipType);

                        break;
                    case ItemType.Material:
                        item = new Item(
                                id, nameStr, type, quality, description, capacity, buyPrice, sellPrice, sprite
                                );
                        break;
                    case ItemType.Weapon:
                        int damage = (int)temp.GetField("damage").n;
                        WeaponType weaponType = (WeaponType)System.Enum.Parse(typeof(WeaponType), temp.GetField("weaponType").str);
                        item = new Weapon(id, nameStr, type, quality, description, capacity, buyPrice, sellPrice, sprite,
                                damage, weaponType
                            );
                        break;
                }

                newItemList.Add(item);
                }
                return newItemList;
        }
    }

    /// <summary>
    /// 钻石商品，从productGem.json 中读取
    /// </summary>
    public static class ProductGemData
    {
        public static List<ProductGemModel> ProductGemDataList
        {
            get
            {
                return GetProducts();
            }
        }

        private static List<ProductGemModel> GetProducts()
        {
            List<ProductGemModel> newItemList = new List<ProductGemModel>();
            string jsonContent = Resources.Load<TextAsset>("Json/productGem").text;
            JSONObject json = new JSONObject(jsonContent);
            foreach (JSONObject item in json.list)
            {
                int ProductID = (int)item.GetField("ProductID").n;
                string ProductName = item.GetField("ProductName").str;
                string ProductPurpleSprite = item.GetField("ProductPurpleSprite").str;
                string ProductPurpleDesc = item.GetField("ProductPurpleDesc").str;
                string ProductDesc = item.GetField("ProductDesc").str;
                string ProductSprite = item.GetField("ProductSprite").str;
                int ProductNum = (int)item.GetField("ProductNum").n;
                int ProductBouns = (int)item.GetField("ProductBouns").n;
                int ProductPrice = (int)item.GetField("ProductPrice").n;

                ProductGemModel gemModel  = new ProductGemModel(ProductID, ProductName, ProductPurpleSprite, ProductPurpleDesc, 
                ProductDesc, ProductSprite, ProductNum, ProductBouns, ProductPrice);

                newItemList.Add(gemModel);
            }

            Debug.Log("product ======== " + newItemList.Count);
            return newItemList;
        }
    }
}