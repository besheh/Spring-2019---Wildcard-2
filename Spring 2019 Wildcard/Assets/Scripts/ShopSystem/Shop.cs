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

    void fillList()
    {
        for (int i = 0, i < itemList.Count; i++ )
        {
            GameObject holder = Instantiate(itemHolderPrefab, grid);


        }
    }

    void BuyItem()
    {

    }
}
