using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelected : MonoBehaviour //detectar el item sobre el que hago click, que haya una variable bool publica que marque si la iteración está seleccionada, y pasarla por el método use de los objetos consumibles (hay como 3 buena suerte) y si es true hacer el método (también que revise que solo se puedan consumir los que estén en el playerinventory
    // y pasarle los scripts del sell, buy y consume para que al seleccionar un objeto y luego pulsar algo haga la accion designada
    // y depende de la acción el dinero se modifica, ten en mente eso también 
{
    public Inventory _inventory; //maybe hay que crear un segundo inventory (el del shop) y revisar ambos
    public bool _selected = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(_selected);

        //for (int i = 0; i <= _inventory.Slots.Count; i++) //out of range exception (maybe en lugar de _inventory.Length mejor poner _inventory.Slots.Length pero para eso hay que hacer que la lista Slots sea publica (no se si afectará en algo al código))
        //{
        //    Debug.Log(_inventory.GetSlot(i));
        //}
    }

    private void OnMouseDown()
    {
        _selected = true;
    }
}
