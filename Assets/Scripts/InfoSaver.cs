using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoSaver : MonoBehaviour
{
    public PlayerController playerController;
    [SerializeField]
    Transform playerTransform;
    [SerializeField]
    Transform movePointTransform;
     [SerializeField]
    PlayerInfo playerInfo;
    static bool gameStarted = false;

    public void SaveData()
    {
        Debug.Log("Player info saved!");
        playerInfo.position = playerTransform.localPosition;
        playerInfo.movePointPosition = movePointTransform.localPosition;
    }


    public void ResetPlayer()
    {
        if(!gameStarted)
        {
            gameStarted = true;
            return;
        }
        playerTransform.localPosition = playerInfo.position;
        movePointTransform.localPosition = playerInfo.movePointPosition;
    }

    public void moveToOtherSide()
    {
        // calculate the distance to the other side, then move it there
        if(movePointTransform.position.x + playerController.facing.x < -8)
        {
            playerInfo.position = new Vector3(8.15f, movePointTransform.position.y, movePointTransform.position.z);
            playerInfo.movePointPosition = new Vector3(8.15f, movePointTransform.position.y, movePointTransform.position.z);
        }
        if(movePointTransform.position.x + playerController.facing.x > 7)
        {
            playerInfo.position = new Vector3(-7.85f, movePointTransform.position.y, movePointTransform.position.z);
            playerInfo.movePointPosition = new Vector3(-7.85f, movePointTransform.position.y, movePointTransform.position.z);
        }
        if(movePointTransform.position.y + playerController.facing.y > 5)
        {
            playerInfo.position = new Vector3(movePointTransform.position.x, -3.6f, movePointTransform.position.z);
            playerInfo.movePointPosition = new Vector3(movePointTransform.position.x, -3.6f, movePointTransform.position.z);
        }
        if(movePointTransform.position.y + playerController.facing.y < -4)
        {
            playerInfo.position = new Vector3(movePointTransform.position.x, 4.4f, movePointTransform.position.z);
            playerInfo.movePointPosition = new Vector3(movePointTransform.position.x, 4.4f, movePointTransform.position.z);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // public void OnFadeCompleted(object source, EventArgs args)
    // {
    //     SaveData();
    // }

    public void GoingToBattle(object source, EventArgs e)
    {
        SaveData();
    }
}
