using System.Collections;
using UnityEngine;

public class PlayerTurn : State
{

    bool moveCommited = false;

    public PlayerTurn(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override IEnumerator Start()
    {
        battleSystem.button1.interactable = true;
        if (battleSystem.playerUnit.currentHp <= 0)
        {
        //    battleSystem.SetState(new Player2Turn(battleSystem));
          //  yield break;
        }

        battleSystem.text.text = $"{battleSystem.playerUnit.name}'s turn";
        yield break;
    }

    public override IEnumerator Attack()
    {
        bool? isDead = false;

        if(!moveCommited)
        {
            isDead = battleSystem.enemyUnit.TakeDamage(battleSystem.playerUnit.damage,battleSystem.enemySlider);
            battleSystem.text.text = $"You attack for {battleSystem.playerUnit.damage} damage!";
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
            battleSystem.SetState(new EnemyTurn(battleSystem));
        }

        
    }

    public override IEnumerator Concept1()
    {
        battleSystem.SetQuestion(new QuestionOne(battleSystem));
        yield break;
    }

    public override IEnumerator Concept2()
    {
        Debug.Log("concept 2");
        yield break;
    }

    public override IEnumerator Concept3()
    {
        Debug.Log("concept 3");
        yield break;
    }

    public override IEnumerator Concept4()
    {
        Debug.Log("concept 4");
        yield break;
    }
    
    public override IEnumerator Concept5()
    {
        Debug.Log("concept 5");
        yield break;
    }

    public override IEnumerator Concept6()
    {
        Debug.Log("concept 6");
        yield break;
    }
    
    public override IEnumerator Concept7()
    {
        Debug.Log("concept 7");
        yield break;
    }

    public override IEnumerator Heal()
    {
        battleSystem.text.text = "healed!";

        yield return new WaitForSeconds(1f);

        battleSystem.SetState(new EnemyTurn(battleSystem));
    }
}