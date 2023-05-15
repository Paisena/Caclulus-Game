using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChangeInfo : MonoBehaviour
{

    private void Start() {
        Transform transform = gameObject.GetComponent<Transform>();
        xPos = transform.localPosition.x;
        yPos = transform.localPosition.y;
    }
    public enum LevelChangeType{
        Battle,
        NextLevel
    }

    [SerializeField]
    public int levelIndex;
    [SerializeField]
    public float xPos;
    [SerializeField]
    public float yPos;
    [SerializeField]
    public LevelChangeType levelChangeType;


}
