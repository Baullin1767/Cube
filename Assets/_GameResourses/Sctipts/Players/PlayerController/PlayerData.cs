using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : Initializer
{
    [SerializeField]
    ButtonsValue buttonsValue;
    [SerializeField]
    public float walkSpeed;
    [SerializeField]
    float runSpeed;

    [HideInInspector]
    public float currentSpeed;

    public PlayerInput playerInput;

    public override void Init()
    {
        playerInput = new PlayerInput();
        playerInput.Init(buttonsValue.buttonsInfo);
    }
}
