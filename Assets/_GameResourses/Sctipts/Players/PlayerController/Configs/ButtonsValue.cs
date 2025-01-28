using System;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ButtonSettings", menuName = "GameSettings/ButtonSettings")]

public class ButtonsValue : ScriptableObject
{
    public List<ButtonInfo> buttonsInfo = new List<ButtonInfo>();
}

[Serializable]
public class ButtonInfo
{
    public string action;
    public KeyCode keyCode;
}