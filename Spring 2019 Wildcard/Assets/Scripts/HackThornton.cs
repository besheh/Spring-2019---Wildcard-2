using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HackThornton : MonoBehaviour
{
    [SerializeField] TMP_InputField usernameInput = null;
    [SerializeField] TMP_InputField passwordInput = null;
    [SerializeField] string email = null;
    [SerializeField] string password = null;
    [SerializeField] string guessedEmail = null;
    [SerializeField] string guessedPassword = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //checks if a given input string is correct
    bool CheckCorrect(string given, string correct)
    {
        if (given == correct)
        {
            return true;
        }
        return false;
    }

    
    public void UsernameChanged(string newText)
    {
        guessedEmail = newText;
    }

    public void PasswordChanged(string newText)
    {
        guessedPassword = newText;
    }

    public void CheckLogin()
    {
        if (CheckCorrect(guessedEmail, email)
            && CheckCorrect(guessedPassword, password))
        {
            //Show the list of students and put the list onto the usb
            Debug.Log("I'm in");
        }
    }
}
