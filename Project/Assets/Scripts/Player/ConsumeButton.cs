using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumeButton : MonoBehaviour
{
    public LifebarController _lifeBarController;

    public void Use(/*ConsumableItem item*/) //faltaría hacer que revise si hay items consumibles y si hay, lo destruya (bueno, y que elimine el objeto seleccionado y que si no hay ningún objeto seleccionado no ejecute el metodo, aunque eso maybe en otro script)
    {
        //if (item is ItemHealthPotion)
        //{
        //    Debug.Log("I have been healed!");
        //}

        Debug.Log("I have been healed!");

        _lifeBarController.Heal();
    }
}
