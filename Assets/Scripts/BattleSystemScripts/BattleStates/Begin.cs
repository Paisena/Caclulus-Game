using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin : State
{
    public Begin(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    // Start is called before the first frame update
    public override IEnumerator Start()
    {
        battleSystem.text.text = "a wild " /*+ battleSystem.enemyUnit.unitName*/ + " appears!";
        
        yield return new WaitForSeconds(0.5f);

        battleSystem.SetState(new PlayerTurn(battleSystem));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
