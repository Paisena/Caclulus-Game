using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PointerControl : MonoBehaviour
{
    [SerializeField]
    private Transform pointerTransform;
    [SerializeField]
    Animator menuAnimator;

    private bool moveToStartPoint = false;
    private bool moveToHidden = true;

    MenuSetup menuSetup;

    private void Start() {

    }

    private void Update() {
        if(moveToStartPoint){
            if(pointerTransform.position == new Vector3(pointerTransform.position.x, 1.1f, pointerTransform.position.z))
            {
                moveToStartPoint = false;
            }
            pointerTransform.position = Vector3.MoveTowards(pointerTransform.position, new Vector3(pointerTransform.position.x, 1.1f, pointerTransform.position.z), 50 * Time.deltaTime);
        }
        if(moveToHidden){
            if(pointerTransform.position == new Vector3(pointerTransform.position.x, -10, pointerTransform.position.z))
            {
                moveToHidden = false;
            }
            pointerTransform.position = Vector3.MoveTowards(pointerTransform.position, new Vector3(pointerTransform.position.x, -10, pointerTransform.position.z), 50 * Time.deltaTime);
        }
    }

    public void move(GameObject target)
    {
        transform.position = new Vector3(target.transform.position.x -3, target.transform.position.y - 0.052993f, transform.position.z);
    }

    public void OnMenuOpened(object source, EventArgs e)
    {
        if(pointerTransform.position.y < 0 )
        moveToStartPoint = true;

        if(pointerTransform.position.y > 0)
        moveToHidden = true;
    }
}
