using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogWarning("More then 1 instance of inventory found!");
            return;
        }
        Instance = this;
    }
    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    [SerializeField] private int _space = 20;

    public List<Item> _items = new List<Item>();

    public bool Additem(Item item)
    {
        if(_items.Count >= _space)
        {
            Debug.Log("Not enough space");
            return false;
        }
        _items.Add(item);

        if(onItemChangedCallback != null)
            onItemChangedCallback.Invoke();

        return true;
    }

    public void removeItem(Item item)
    {
        _items.Remove(item);

        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }
}
