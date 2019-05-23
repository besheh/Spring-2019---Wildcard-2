using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager gameManager = null;

    [SerializeField] private uint bobas = 0;
    //[SerializeField] uint day = 1;

    public TMP_Text bobasText = null;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = this;
        UpdateUI();
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void AddMoney(uint amount)
    {
        bobas += amount;
        UpdateUI();
    }

    public void ReduceMoney(uint amount)
    {
        bobas -= amount;
        UpdateUI();
    }

    public bool RequestMoney(uint amount)
    {
        if (amount <= bobas)
        {
            return true;
        }
        return false;
    }

    void UpdateUI()
    {
        bobasText.text = "Bobas: " + bobas.ToString();
    }

}
