using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected BattleSystem battleSystem;
    
    public State(BattleSystem battleSystem){
        this.battleSystem = battleSystem;
    }

    public virtual IEnumerator Start()
    {
        yield break;
    }

    public virtual IEnumerator Attack()
    {
        yield break;
    }

    public virtual IEnumerator Concept1()
    {
        yield break;
    }

    public virtual IEnumerator Concept2()
    {
        yield break;
    }

    public virtual IEnumerator Concept3()
    {
        yield break;
    }

    public virtual IEnumerator Concept4()
    {
        yield break;
    }

    public virtual IEnumerator Concept5()
    {
        yield break;
    }

    public virtual IEnumerator Concept6()
    {
        yield break;
    }

    public virtual IEnumerator Concept7()
    {
        yield break;
    }

    public virtual IEnumerator Heal()
    {
        yield break;
    }

}
