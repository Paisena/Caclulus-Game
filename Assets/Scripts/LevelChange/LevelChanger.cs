using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Linq;

public class LevelChanger : MonoBehaviour
{
    [SerializeField]
    FadeInOutControl fadeInOutControl;
    public Animator animator;

    [SerializeField]
    public LevelChangeInfo[] levelChangeInfoList;

    [SerializeField]
    Transform player;

    [SerializeField]
    InfoSaver infoSaver;


    private static int previousSceneIndex = 0;
    private static bool returnToLastSceneBool = false;

    private void Start()
    {
        
    }

    private void Update()
    {

    }

    public void OnFadeCompleted(object source, EventArgs e)
    {
        if (returnToLastSceneBool)
        {
            SceneManager.LoadScene(previousSceneIndex);
            returnToLastSceneBool = false;
        }
        else
        {
            infoSaver.SaveData();
            LevelChangeInfo info = GetLevelChangeInfo();
            Scene scene = SceneManager.GetActiveScene();
            if(info.levelChangeType == LevelChangeInfo.LevelChangeType.NextLevel)
            {
                infoSaver.moveToOtherSide();
            }

            previousSceneIndex = scene.buildIndex;
            SceneManager.LoadScene(info.levelIndex);
        }
    }

    public LevelChangeInfo GetLevelChangeInfo()
    {
        //find the distances of all the level change tiles and then the closest one will be the one that you selected
        //Not a full proof plan but it will work

        Vector2[] levelChangeIPoints = new Vector2[levelChangeInfoList.Length];
        float[] distances = new float[levelChangeInfoList.Length];

        for (int i = 0; i < levelChangeInfoList.Length; i++)
        {
            levelChangeIPoints[i] = new Vector2(levelChangeInfoList[i].transform.position.x, levelChangeInfoList[i].transform.position.y);
            distances[i] = Vector2.Distance(player.position, levelChangeIPoints[i]);
        }


        int minIndex = Array.IndexOf(distances, distances.Min());
        return levelChangeInfoList[minIndex];
    }

    public void ReturnToLastScene()
    {
        returnToLastSceneBool = true;
        animator.SetBool("FadeOut", true);
    }
   
}