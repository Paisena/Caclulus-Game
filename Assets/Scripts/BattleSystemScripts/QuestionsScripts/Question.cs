using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Question
{

    protected BattleSystem battleSystem;
    public Question(BattleSystem battleSystem)
    {
        this.battleSystem = battleSystem;
    }
    public virtual void SetupQuestion()
    {

    }
    // Start is called before the first frame update
    public virtual void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
