using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables
{
    private string AppToOpen = "";

    public void SetAppToOpen(string AppName){
        AppToOpen = AppName;
    }

    public string GetAppToOpen(){
        return AppToOpen;
    }
}
