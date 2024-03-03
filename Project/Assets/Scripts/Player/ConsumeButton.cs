using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumeButton : MonoBehaviour
{
    public LifebarController _lifeBarController;
    //public ItemSelected _itemSelected;
    public Inventory _playerInventory;

    public void Use() //faltaría hacer que revise si hay items consumibles y si hay, lo destruya (bueno, y que elimine el objeto seleccionado y que si no hay ningún objeto seleccionado no ejecute el metodo, aunque eso maybe en otro script)
    {
        //if ()
        //{
        //    Debug.Log("I have been healed!");

        //    _lifeBarController.Heal();
        //}

        for (int i = 0; i <= _playerInventory.Slots.Count - 1; i++)
        {
            if (_playerInventory.GetSlot(i).Item.isSelected)
            {
                _playerInventory.GetSlot(i).Destroy();
            }
        }
    }
}
