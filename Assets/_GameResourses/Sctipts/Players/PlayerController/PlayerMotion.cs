using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerData))]
[RequireComponent(typeof(PlayerView))]
public class PlayerMotion : MonoBehaviour
{
    PlayerData playerData;
    PlayerView playerView;
    // Start is called before the first frame update
    void Start()
    {
        playerData = GetComponent<PlayerData>();
        playerView = GetComponent<PlayerView>();
        playerData.currentSpeed = playerData.walkSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        playerView.AddVelocity(dir * playerData.currentSpeed * Time.deltaTime);
    }
}
