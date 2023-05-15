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
        Debug.Log("enemy turn");
        battleSystem.text.text = "Enemy Turn";

        yield return new WaitForSeconds(1f);

        int target = battleSystem.enemyUnit.chooseTarget();

        Debug.Log(target);
        bool? isDead = null;
        switch (target)
        {
            case 1:
                isDead = battleSystem.playerUnit.TakeDamage(battleSystem.enemyUnit.damage,battleSystem.playerSlider);
                battleSystem.text.text = $"Hero takes {battleSystem.enemyUnit.damage} damage";
                break;
            
            case 2:
                isDead = battleSystem.player2Unit.TakeDamage(battleSystem.enemyUnit.damage,battleSystem.player2Slider);
                battleSystem.text.text = $"Archer takes {battleSystem.enemyUnit.damage} damage";
                break;
            case 3:
                isDead = battleSystem.player3Unit.TakeDamage(battleSystem.enemyUnit.damage,battleSystem.player3Slider);
                battleSystem.text.text = $"Mage take {battleSystem.enemyUnit.damage} damage";
                break;

            default:
                isDead = battleSystem.playerUnit.TakeDamage(battleSystem.enemyUnit.damage,battleSystem.playerSlider);
                battleSystem.text.text = $"Hero take {battleSystem.enemyUnit.damage} damage";
            break;
        }
        

        yield return new WaitForSeconds(1f);

        if (isDead == true)
        {
            switch (target)
            {
                case 1:
                    battleSystem.SetState(new Player1Dead(battleSystem));
                    break;
                case 2:
                    battleSystem.SetState(new Player2Dead(battleSystem));
                    break;
                case 3:
                    battleSystem.SetState(new Player3Dead(battleSystem));
                    break;

                default:
                    battleSystem.SetState(new Lost(battleSystem));
                break;
            }
            
        }
        else
        {
            battleSystem.SetState(new PlayerTurn(battleSystem));
        }
    }
}