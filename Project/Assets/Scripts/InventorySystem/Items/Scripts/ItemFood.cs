using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Inventory System/Items/Food")]
public class ItemFoods: ConsumableItem
{
    public int ItemFood;

    public override void Use(IConsume consumer)
    {
        consumer.UseFood(this);
    }
}