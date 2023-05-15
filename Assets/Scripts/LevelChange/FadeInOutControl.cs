using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

public class FadeInOutControl : MonoBehaviour
{
    public delegate void FadeOutCompleteEventHandler(object source, EventArgs args);
    public event FadeOutCompleteEventHandler FadeOutCompleted;
    public Animator animator;
    [SerializeField]
    LevelChanger levelChanger;

    [SerializeField]
    InfoSaver infoSaver;

    // Start is called before the first frame update
    void Start()
    {
        FadeOutCompleted += levelChanger.OnFadeCompleted;
        GameObject fadeSquare = this.gameObject.transform.GetChild(1).gameObject;

        fadeSquare.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FadeOutComplete()
    {
        animator.SetBool("FadeOut", false);
        OnFadeCompleted();
    }

    protected virtual void OnFadeCompleted(){
        if(FadeOutCompleted != null){
            //check to find which level you are changing to
            FadeOutCompleted(this, EventArgs.Empty);
        }
    }
}
