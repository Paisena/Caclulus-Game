using System.Collections;
using UnityEngine;

internal class Lost : State
{

    public Animator FadeInOutAnimator;
    public Lost(BattleSystem battleSystem) : base(battleSystem)
    {
        
    }

    public override IEnumerator Start()
    {
        battleSystem.text.text = "You Lost";

        yield return new WaitForSeconds(5f);
        GameObject.Destroy(GameObject.FindWithTag("Enemy"));

        Application.Quit();
        battleSystem.levelChanger.ReturnToLastScene();
    }
}