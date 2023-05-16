using System.Collections;
using System;
using UnityEngine;

internal class EnemyTurn : State
{
    System.Random rnd = new System.Random();
    public EnemyTurn(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override IEnumerator Start()
    {
        battleSystem.button1.interactable = false;
        Debug.Log("enemy turn");
        battleSystem.text.text = "Enemy Turn";

        yield return new WaitForSeconds(1f);

        // int target = battleSystem.enemyUnit.chooseTarget();

        // Debug.Log(target);
        bool? isDead = null;

        isDead = battleSystem.playerUnit.TakeDamage(battleSystem.enemyUnit.damage,battleSystem.playerSlider);
        battleSystem.text.text = $"Hero takes {battleSystem.enemyUnit.damage} damage";

        yield return new WaitForSeconds(1f);

        if (isDead == true)
        {
            battleSystem.SetState(new Lost(battleSystem));
        }
        else
        {
            battleSystem.SetState(new PlayerTurn(battleSystem));
        }
    }
}