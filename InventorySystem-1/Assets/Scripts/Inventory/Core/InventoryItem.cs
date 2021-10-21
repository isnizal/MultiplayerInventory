using Mirror;
using UnityEngine;

namespace InventorySystem
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Inventory/InventoryItem")]
    public class InventoryItem : ScriptableObject
    {
        public string Name;
        public Sprite Sprite;
    }

    public static class InventoryItemSerializer
    {
        public static void WriteInventoryItem(NetworkWriter writer, InventoryItem inventoryItem)
        {
            writer.WriteString(inventoryItem.name);
        }

        public static InventoryItem ReadInventoryItem(NetworkReader reader)
        {
           return (InventoryItem)Resources.Load(reader.ReadString());
        }
    }
}
