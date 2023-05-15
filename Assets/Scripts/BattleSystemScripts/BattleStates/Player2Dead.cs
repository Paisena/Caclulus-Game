using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Dead : State
{
    public Player2Dead(BattleSystem battleSystem) : base(battleSystem)
    {
        
    }

    public override IEnumerator Start()
    {
        battleSystem.text.text = "Archer Dead";

        yield return new WaitForSeconds(5f);

        battleSystem.SetState(new PlayerTurn(battleSystem));
    }
}
