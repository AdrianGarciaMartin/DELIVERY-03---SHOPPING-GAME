using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Inventory System/Items/Potions")]
public class ItemPotions : ConsumableItem
{
    public int ItemPotion;

    public override void Use(IConsume consumer)
    {
        consumer.UsePotion(this);
    }
}