using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minecraft.InventorySystem
{
    public class UIInventory : MonoBehaviour
    {
        [Header("Category")]
            [SerializeField] Image categoryIconImage;
            [SerializeField] Text categoryText;

            [Header("Current Item")]
            [SerializeField] Image currentItemIconImage;
            [SerializeField] Text descriptionText;

            [Header("Item List")] 
            [SerializeField] UIItemShop itemUIPrefab;
            [SerializeField] List<UIItemShop> itemUIList = new List<UIItemShop>();
            
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}


