using System.Collections.Generic;
using UnityEngine;
using QFramework;

namespace DiazDTRPG
{
    public class InventoryManager : MonoBehaviour, ISingleton
    {
        /// <summary>
        /// 物品信息列表
        /// </summary>
        private List<Item> itemList;

        public static InventoryManager Instance
        {
            get
            {
                return MonoSingletonProperty<InventoryManager>.Instance;
            }
        }

        public void OnSingletonInit()
        {
        }


        /// <summary>
        /// 解析物品信息
        /// </summary>
        private void ParseItemJson()
        {
            itemList = new List<Item>();
            string jsonContent = Resources.Load<TextAsset>("Json/Items").text;
            JSONObject json = new JSONObject(jsonContent);
            foreach (JSONObject temp  in json.list)
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
                Debug.Log("=======1=======" + sprite);

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
                        // TODO
                        break;
                    case ItemType.Material:
                        // TODO
                        break;
                    case ItemType.Weapon:
                        // TODO
                        break;
                }

                itemList.Add(item);
                Debug.Log(item);
            }
        }

        /// <summary>
        /// 根据 ID 获取 Item 对象
        /// </summary>
        /// <returns>The item by identifier.</returns>
        /// <param name="id">Identifier.</param>
        public Item GetItemByID(int id)
        {
            foreach (Item item in itemList)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }

        void HandleAddJSONContents(JSONObject self)
        {
        }

        private void Start()
        {
            ParseItemJson();
        }
    }


}