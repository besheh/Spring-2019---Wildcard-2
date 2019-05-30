using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public List<Item> itemList = new List<Item>();

    public GameObject itemHolderPrefab;
    public Transform grid;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FillList()
    {
        for (int i = 0; i < itemList.Count; i++ )
        {
            GameObject holder = Instantiate(itemHolderPrefab, grid);
            ItemHolder holderScript = holder.GetComponent<ItemHolder>();

            holderScript.itemName.text = itemList[i].itemName;
            holderScript.itemPrice.text = "$ " + itemList[i].price.ToString("N2");
            holderScript.itemID = itemList[i].ID;
            holderScript.itemIcon.sprite = itemList[i].icon;


        }
    }

    void BuyItem()
    {

    }
}
