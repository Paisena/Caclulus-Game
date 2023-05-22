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
        battleSystem.button2.interactable = true;
        battleSystem.button3.interactable = true;
        battleSystem.button4.interactable = true;
        battleSystem.button5.interactable = true;
        battleSystem.button6.interactable = true;
        battleSystem.button7.interactable = true;
        battleSystem.button8.interactable = true;

        if (battleSystem.playerUnit.currentHp <= 0)
        {
            //battleSystem.SetState(new Player2Turn(battleSystem));
            //yield break;
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
        int question = PickQuestion(1);
        switch(question)
        {
            case 0:
                battleSystem.SetQuestion(new QuestionOne(battleSystem));
                break;
            case 1:
                battleSystem.SetQuestion(new Question2(battleSystem));
                break;
            case 2:
                battleSystem.SetQuestion(new Question3(battleSystem));
                break;
            case 3:
                battleSystem.SetQuestion(new Question4(battleSystem));
                break;
            case 4:
                battleSystem.SetQuestion(new Question4(battleSystem));
                break;
            default:
                break;
        }
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
        battleSystem.SetQuestion(new Question13(battleSystem));
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

    public int PickQuestion(int concept)
    {
        int value = Random.Range(0,5);
        Debug.Log("Question: " + value);
        switch(concept)
        {
            case 1:
                if((bool)battleSystem.concept1List[value] == true)
                {
                    battleSystem.concept1List[value] = false;
                    return value;
                }
                else
                {
                    PickQuestion(concept);
                }
                break;
            case 2:
                if((bool)battleSystem.concept2List[value] == true)
                {
                    battleSystem.concept2List[value] = false;
                    return value;
                }
                else
                {
                    PickQuestion(concept);
                }
                break;
            case 3:
                if((bool)battleSystem.concept3List[value] == true)
                {
                    battleSystem.concept3List[value] = false;
                    return value;
                }
                else
                {
                    PickQuestion(concept);
                }
                break;
            case 4:
                if((bool)battleSystem.concept4List[value] == true)
                {
                    battleSystem.concept4List[value] = false;
                    return value;
                }
                else
                {
                    PickQuestion(concept);
                }
                break;
            case 5:
                if((bool)battleSystem.concept5List[value] == true)
                {
                    battleSystem.concept5List[value] = false;
                    return value;
                }
                else
                {
                    PickQuestion(concept);
                }
                break;
            case 6:
                if((bool)battleSystem.concept6List[value] == true)
                {
                    battleSystem.concept6List[value] = false;
                    return value;
                }
                else
                {
                    PickQuestion(concept);
                }
                break;
            case 7:
                if((bool)battleSystem.concept7List[value] == true)
                {
                    battleSystem.concept7List[value] = false;
                    return value;
                }
                else
                {
                    PickQuestion(concept);
                }
                break;
            case 8:
                if((bool)battleSystem.concept8List[value] == true)
                {
                    battleSystem.concept8List[value] = false;
                    return value;
                }
                else
                {
                    PickQuestion(concept);
                }
                break;
            default:
                Debug.Log("randomized wrong number");
                break;
        }
        return -1;
    }
}