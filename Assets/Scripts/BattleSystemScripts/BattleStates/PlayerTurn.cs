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

        EnableConcepts();

        if (battleSystem.playerUnit.currentHp <= 0)
        {
            //battleSystem.SetState(new Player2Turn(battleSystem));
            //yield break;
        }

        battleSystem.text.text = $"{battleSystem.playerUnit.name}'s turn";
        yield break;
    }

    private void EnableConcepts()
    {
        for (int i = 0; i < battleSystem.ConceptsActive.Length; i++)
        {
            if(battleSystem.ConceptsActive[i])
            {
                battleSystem.buttonArray[i].interactable = true;
            }
        }
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
        battleSystem.UpdateQuestions();

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
                if(CheckIfEmpty(battleSystem.concept1List))
                {
                    Debug.Log("empty list");
                    break;
                }
                if(battleSystem.concept1List[value] == false)
                {
                    return PickQuestion(concept);
                }
                if(battleSystem.concept1List[value] == true)
                {
                    battleSystem.concept1List[value] = false;
                    Debug.Log("Question found");
                    if(CheckIfEmpty(battleSystem.concept1List))
                    {
                        battleSystem.ConceptsActive[0] = false;
                    }
                    return value;
                }
                break;
            case 2:
                if(CheckIfEmpty(battleSystem.concept2List))
                {
                    Debug.Log("empty list");
                    break;
                }
                if(battleSystem.concept2List[value] == false)
                {
                    return PickQuestion(concept);
                }
                if(battleSystem.concept2List[value] == true)
                {
                    battleSystem.concept2List[value] = false;
                    Debug.Log("Question found");
                    return value;
                }
                break;
            case 3:
                if(CheckIfEmpty(battleSystem.concept3List))
                {
                    Debug.Log("empty list");
                    break;
                }
                if(battleSystem.concept3List[value] == false)
                {
                    return PickQuestion(concept);
                }
                if(battleSystem.concept3List[value] == true)
                {
                    battleSystem.concept3List[value] = false;
                    Debug.Log("Question found");
                    return value;
                }
                break;
            case 4:
                if(CheckIfEmpty(battleSystem.concept4List))
                {
                    Debug.Log("empty list");
                    break;
                }
                if(battleSystem.concept4List[value] == false)
                {
                    return PickQuestion(concept);
                }
                if(battleSystem.concept4List[value] == true)
                {
                    battleSystem.concept4List[value] = false;
                    Debug.Log("Question found");
                    return value;
                }
                break;
            case 5:
                if(CheckIfEmpty(battleSystem.concept5List))
                {
                    Debug.Log("empty list");
                    break;
                }
                if(battleSystem.concept5List[value] == false)
                {
                    return PickQuestion(concept);
                }
                if(battleSystem.concept5List[value] == true)
                {
                    battleSystem.concept5List[value] = false;
                    Debug.Log("Question found");
                    return value;
                }
                break;
            case 6:
                if(CheckIfEmpty(battleSystem.concept6List))
                {
                    Debug.Log("empty list");
                    break;
                }
                if(battleSystem.concept6List[value] == false)
                {
                    return PickQuestion(concept);
                }
                if(battleSystem.concept6List[value] == true)
                {
                    battleSystem.concept6List[value] = false;
                    Debug.Log("Question found");
                    return value;
                }
                break;
            case 7:
                if(CheckIfEmpty(battleSystem.concept7List))
                {
                    Debug.Log("empty list");
                    break;
                }
                if(battleSystem.concept7List[value] == false)
                {
                    return PickQuestion(concept);
                }
                if(battleSystem.concept7List[value] == true)
                {
                    battleSystem.concept7List[value] = false;
                    Debug.Log("Question found");
                    return value;
                }
                break;
            case 8:
                if(CheckIfEmpty(battleSystem.concept8List))
                {
                    Debug.Log("empty list");
                    break;
                }
                if(battleSystem.concept8List[value] == false)
                {
                    return PickQuestion(concept);
                }
                if(battleSystem.concept8List[value] == true)
                {
                    battleSystem.concept8List[value] = false;
                    Debug.Log("Question found");
                    return value;
                }
                break;
            default:
                Debug.Log("randomized wrong number");
                break;
        }
        Debug.Log("No question");
        return -1;
    }

    public bool CheckIfEmpty(bool[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            if(list[i] == true)
            {
                return false;
            }
        }
        Debug.Log("list empty");
        return true;
    }
}