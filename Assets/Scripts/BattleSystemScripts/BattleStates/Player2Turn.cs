using System.Collections;
using UnityEngine;

public class Player2Turn : State
{

    bool moveCommited = false;

    public Player2Turn(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override IEnumerator Start()
    {

        if (battleSystem.player2Unit.currentHp <= 0)
        {
            battleSystem.SetState(new Player3Turn(battleSystem));
            yield break;

        }
        
        battleSystem.text.text = $"{battleSystem.player2Unit.name}'s turn";
        yield break;
    }

    public override IEnumerator Attack()
    {
        bool? isDead = false;

        if(!moveCommited)
        {
            //Debug.Log(battleSystem.enemyUnit.TakeDamage(battleSystem.playerUnit.damage,battleSystem.enemySlider));
            isDead = battleSystem.enemyUnit.TakeDamage(battleSystem.player2Unit.damage,battleSystem.enemySlider);
            battleSystem.text.text = $"You attack for {battleSystem.player2Unit.damage} damage!";
            moveCommited = true;
        }

        yield return new WaitForSeconds(1f);

        if (isDead == true)
        {
            battleSystem.button1.enabled = false;
            moveCommited = false;
            battleSystem.SetState(new Won(battleSystem));
        }
        else
        {
            moveCommited = false;
            battleSystem.SetState(new Player3Turn(battleSystem));
        }

        
    }

    public override IEnumerator Heal()
    {
        battleSystem.text.text = "healed!";

        yield return new WaitForSeconds(1f);

        battleSystem.SetState(new EnemyTurn(battleSystem));
    }
}