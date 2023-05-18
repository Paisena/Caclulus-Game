using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class BattleSystem : StateMachine
{
    public GameObject playerPrefab;
    public GameObject player2Prefab;
    public GameObject player3Prefab;
    public GameObject enemyPrefab;

    public Transform playerTransform;
    public Transform enemyTransform;

    public Unit playerUnit;
    public Unit player2Unit;
    public Unit player3Unit;
    public Unit enemyUnit;

    public Slider playerSlider;
    public Slider player2Slider;
    public Slider player3Slider;

    public Slider enemySlider;

    [SerializeField]
    public TextMeshPro text;

    public LevelChanger levelChanger;
    public int selectedAnswer = 0; 
    public int correctAnswer = 0;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public GameObject listOfButton;
    public Button answer1Button;
    public Button answer2Button;
    public Button answer3Button;
    public GameObject listOfAnswers;

    [SerializeField]
    HUDTextMananger playerHUD;
    [SerializeField]
    HUDTextMananger player2HUD;
    [SerializeField]
    HUDTextMananger player3HUD;
    [SerializeField]
    HUDTextMananger enemyHUD;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SetupBattle());
        SetState(new Begin(this));

    }

    //thing
    IEnumerator SetupBattle()
    {
        GameObject playerGo = Instantiate(playerPrefab, playerTransform);

        GameObject HeroGO = GameObject.FindWithTag("Hero");

        playerUnit = HeroGO.GetComponent<Unit>();

        GameObject enemyGO = Instantiate(playerUnit.enemyFighting, enemyTransform);
        enemyUnit = playerUnit.enemyFighting.GetComponent<Unit>();


        playerHUD.SetHUD(playerUnit, playerSlider);
        enemyHUD.SetHUD(enemyUnit, enemySlider);

        yield return new WaitForSeconds(0f);

    }
    

    public void OnAttackButton()
    {
        if (this.state is PlayerTurn)
        {
            StartCoroutine(state.Attack());
        }
        else
        {
            Debug.Log("not your turn");
        }
    }

    public void OnConcept1Button()
    {
        // Derivative
        if (this.state is PlayerTurn)
        {
            StartCoroutine(state.Concept1());
        }
        else
        {
            Debug.Log("not your turn");
        }
    }
    public void OnConcept2Button()
    {
        // Integral
        Debug.Log("Integral");
        if (this.state is PlayerTurn)
        {
            StartCoroutine(state.Concept2());
        }
        else
        {
            Debug.Log("not your turn");
        }
    }
    public void OnConcept3Button()
    {
        // Limit
        Debug.Log("Limit");
        if (this.state is PlayerTurn)
        {
            StartCoroutine(state.Concept3());
        }
        else
        {
            Debug.Log("not your turn");
        }
    }
    public void OnConcept4Button()
    {
        // Series
        Debug.Log("Series");
        if (this.state is PlayerTurn)
        {
            StartCoroutine(state.Concept4());
        }
        else
        {
            Debug.Log("not your turn");
        }
    }
    public void OnConcept5Button()
    {
        // Vectors
        Debug.Log("Vectors");
        if (this.state is PlayerTurn)
        {
            StartCoroutine(state.Concept5());
        }
        else
        {
            Debug.Log("not your turn");
        }
    }
    public void OnConcept6Button()
    {
        // Area
        Debug.Log("Area");
        if (this.state is PlayerTurn)
        {
            StartCoroutine(state.Concept6());
        }
        else
        {
            Debug.Log("not your turn");
        }
    }
    public void OnConcept7Button()
    {
        // Parametric
        Debug.Log("Parametric");
        if (this.state is PlayerTurn)
        {
            StartCoroutine(state.Concept7());
        }
        else
        {
            Debug.Log("not your turn");
        }
    }

    public void OnHealButton()
    {
        StartCoroutine(state.Heal());
    }

    public void Answer1Selected()
    {
        Debug.Log("answer 1 selected");
        if(correctAnswer == 1)
        {
            if (this.state is PlayerTurn)
            {
                SetupQuestions();
                StartCoroutine(state.Attack());
            }
            else
            {
                Debug.Log("not your turn");
            }
        }
    }

    public void Answer2Selected()
    {
        Debug.Log("answer 2 selected");
        if(selectedAnswer == correctAnswer)
        {
            
        }
    }

    public void Answer3Selected()
    {
        Debug.Log("answer 3 selected");
        if(selectedAnswer == correctAnswer)
        {
            
        }
    }

    public void SetupAnswers()
    {
        listOfAnswers.SetActive(true);
        listOfButton.SetActive(false);
    }

    public void SetupQuestions()
    {
        listOfAnswers.SetActive(false);
        listOfButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
