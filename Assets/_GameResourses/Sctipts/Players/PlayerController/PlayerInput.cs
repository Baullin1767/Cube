using System.Collections.Generic;
using UnityEngine;

public class PlayerInput
{
    Dictionary<string, KeyCode> keyBindings = new Dictionary<string, KeyCode>();

    public void Init(List<ButtonInfo> buttonInfos)
    {
        foreach (var buttonInfo in buttonInfos)
        {
            keyBindings.Add(buttonInfo.action, buttonInfo.keyCode);
        }
    }

    public void Change(string key, KeyCode keyCode)
    {
        keyBindings[key] = keyCode;
    } 
    public bool GetButton(string key)
    {
        return Input.GetKey(keyBindings[key]);
    }
    public bool GetButtonUp(string key)
    {
        return Input.GetKeyUp(keyBindings[key]);
    }
    public bool GetButtonDown(string key)
    {
        return Input.GetKeyDown(keyBindings[key]);
    }
}
