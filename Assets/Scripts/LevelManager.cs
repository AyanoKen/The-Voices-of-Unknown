using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    string LockScreenPassword = "213668";
    string TempLockScreenPassword = "";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UnlockPhone(){
        Debug.Log("Attempted to Unlock Phone");
        LoadPasswordScreen();
    }

    void LoadPasswordScreen(){
        SceneManager.LoadScene("PasswordScreen");
    }

    public void LoadLockScreen(){
        SceneManager.LoadScene("LockScreen");
    }

    public void UnlockPassword(string key){
        TempLockScreenPassword += key;

        Debug.Log("Current Password: " + TempLockScreenPassword);

        if(TempLockScreenPassword.Length == 6){
            ValidatePassword(TempLockScreenPassword);
        }
    }

    void ValidatePassword(string key){
        if(key == LockScreenPassword){
            Debug.Log("Correct Password!");
            TempLockScreenPassword = "";
            LoadLockScreen();
        }else{
            Debug.Log("Wrong Password!");
            TempLockScreenPassword = "";
            //TODO: Add a screen shake or other animation indicating that the password failed
        }
    }
}
