using UnityEngine;
using UnityEngine.UI;

namespace Minecraft.InventorySystem
{
    public class UIItem : MonoBehaviour
    {
        [SerializeField] Text itemNameText;
        [SerializeField] Text countText;
        [SerializeField] Image pointerImage;

        public void SetData(UIItem_Data data)
        {
            itemNameText.text = data.itemData.displayName;
            countText.text = "X " +  data.itemData.count;
            pointerImage.gameObject.SetActive(data.isSelected);
        }
    }

    //Create a DTO class that hold information of the item and also tell is the item is selected.
    public class UIItem_Data
    {
        public ItemData itemData;
        public bool isSelected;

        public UIItem_Data(ItemData itemData, bool isSelected)
        {
            this.itemData = itemData;
            this.isSelected = isSelected;
        }
    }
}