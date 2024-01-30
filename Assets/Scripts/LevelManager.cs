using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
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
}
