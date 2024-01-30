using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    string LockScreenPassword = "213668";
    string AppLockPassword = "658392642";
    string TempLockScreenPassword = "";
    string TempAppLockPassword = "";
    public static LevelManager instance;
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

    private void LoadPasswordScreen(){
        SceneManager.LoadScene("PasswordScreen");
    }

    private void LoadMainScreen(){
        SceneManager.LoadScene("MainScreen");
    }

    public void LoadLockScreen(){
        SceneManager.LoadScene("LockScreen");
    }

    public void UnlockPassword(string key){
        TempLockScreenPassword += key;

        Debug.Log("Current Password: " + TempLockScreenPassword);

        if(TempLockScreenPassword.Length == LockScreenPassword.Length){
            if(ValidatePassword(TempLockScreenPassword, LockScreenPassword)){
                LoadMainScreen();
            }else{
                SceneManager.LoadScene("LockScreen");
            }
        }
    }

    public void UnlockAppPassword(string key){
        TempAppLockPassword += key;

        Debug.Log("Current Password: " + TempAppLockPassword);

        if(TempAppLockPassword.Length == AppLockPassword.Length){
            if(ValidatePassword(TempAppLockPassword, AppLockPassword)){
                Debug.Log("Open The App");
                Debug.Log("Opening " + PlayerPrefs.GetString("appName"));
            }else{
                SceneManager.LoadScene("MainScreen");
            }
        }
    }

    public void SelectApp(string AppName){
        PlayerPrefs.SetString("appName", AppName);
        PlayerPrefs.Save();
        SceneManager.LoadScene("AppLockScreen");
    }

    bool ValidatePassword(string userinput, string correct){
        if(userinput == correct){
            Debug.Log("Correct Password!");
            TempLockScreenPassword = "";
            TempAppLockPassword = "";

            return true; 
        }else{
            Debug.Log("Wrong Password!");
            TempLockScreenPassword = "";
            TempAppLockPassword = "";

            return false;
            //TODO: Add a screen shake or other animation indicating that the password failed
        }
    }
}
