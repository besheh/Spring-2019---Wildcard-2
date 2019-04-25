using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HackThornton : MonoBehaviour
{
    [SerializeField] TMP_InputField usernameInput = null;
    [SerializeField] TMP_InputField passwordInput = null;
    [SerializeField] string username = "Thornton";
    [SerializeField] string password = null;
    [SerializeField] string guessedUsername = null;
    [SerializeField] string guessedPassword = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if (CheckCorrect(guessedUsername, username)
            && CheckCorrect(guessedPassword, password))
        {
            //Show the list of students and put the list onto the usb

            
        }
        
            
        
            
    }

    bool CheckCorrect(string given, string correct)
    {
        if (given == correct)
        {
            return true;
        }

        return false;
    }

    void TextChanged(string newText)
    {
        float temp = float.Parse(newText);
    }
}
