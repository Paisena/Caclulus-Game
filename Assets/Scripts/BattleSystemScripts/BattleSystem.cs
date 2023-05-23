using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System;

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
    public Transform enemyPosition;
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
    public Button[] buttonArray;
    public TextMeshProUGUI[] buttonTextArray;
    public GameObject listOfButton;
    public Button answer1Button;
    public TextMeshProUGUI answer1Text;
    public Button answer2Button;
    public TextMeshProUGUI answer2Text;
    public Button answer3Button;
    public TextMeshProUGUI answer3Text;
    public GameObject listOfAnswers;

    [SerializeField]
    HUDTextMananger playerHUD;
    [SerializeField]
    HUDTextMananger player2HUD;
    [SerializeField]
    HUDTextMananger player3HUD;
    [SerializeField]
    HUDTextMananger enemyHUD;
    public GameObject enemyHUDBox;
    public GameObject QuestionImageBox;
    public Image QuestionImage;
    public bool[] concept1List = {true, true, true, true, true};
    public bool[] concept2List = {true, true, true, true, true};
    public bool[] concept3List = {true, true, true, true, true};
    public bool[] concept4List = {true, true, true, true, true};
    public bool[] concept5List = {true, true, true, true, true};
    public bool[] concept6List = {true, true, true, true, true};
    public bool[] concept7List = {true, true, true, true, true};
    public bool[] concept8List = {true, true, true, true, true};
    public bool[] ConceptsActive = {true, true, true, true, true, true, true, true};
    public (int,int) selectedQuestion = (-1,-1);
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SetupBattle());
        QuestionImage = QuestionImageBox.GetComponent<Image>();
        buttonArray = new Button[] {button1, button2, button3, button4, button5, button6, button7, button8};
        SetState(new Begin(this));

    }

    //thing
    IEnumerator SetupBattle()
    {
        GameObject playerGo = Instantiate(playerPrefab, playerTransform);

        GameObject HeroGO = GameObject.FindWithTag("Hero");

        playerUnit = HeroGO.GetComponent<Unit>();

        GameObject enemyGO = Instantiate(GameObject.FindWithTag("Enemy"), enemyTransform);
        GameObject.FindWithTag("Enemy").transform.position = enemyPosition.transform.position;
        enemyUnit = GameObject.FindWithTag("Enemy").GetComponent<Unit>();

        enemyGO.transform.position = enemyPosition.transform.position;
        playerHUD.SetHUD(playerUnit, playerSlider);
        enemyHUD.SetHUD(enemyUnit, enemySlider);
        UpdateQuestions();
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
        else
        {
            if (this.state is PlayerTurn)
            {
                SetupQuestions();
                StartCoroutine(state.WrongAnswer());
            }
            else
            {
                Debug.Log("not your turn");
            }
        }
    }

    public void Answer2Selected()
    {
        if(correctAnswer == 2)
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
        else
        {
            if (this.state is PlayerTurn)
            {
                SetupQuestions();
                StartCoroutine(state.WrongAnswer());
            }
            else
            {
                Debug.Log("not your turn");
            }
        }
    }

    public void Answer3Selected()
    {
        if(correctAnswer == 3)
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
        else
        {
            if (this.state is PlayerTurn)
            {
                SetupQuestions();
                StartCoroutine(state.WrongAnswer());
            }
            else
            {
                Debug.Log("not your turn");
            }
        }
    }

    public void SetupAnswers()
    {
        listOfAnswers.SetActive(true);
        listOfButton.SetActive(false);
    }

    public void SetupQuestions()
    {
        QuestionImageBox.SetActive(false);
        listOfAnswers.SetActive(false);
        listOfButton.SetActive(true);
        enemyHUDBox.SetActive(true);
        text.fontSize = 2.46f;
    }

    public void SetupImage()
    {
        QuestionImageBox.SetActive(true);
        enemyHUDBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public Sprite CreateSprite(string filePath)
    {
        byte[] fileData;

        fileData = File.ReadAllBytes(filePath);
        Texture2D tex = new Texture2D(1, 1);
        tex.LoadImage(fileData);
        Sprite image = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f));
        image.name = "Sword of Epic";

        return image;
    }

    public void UpdateQuestions()
    {
        buttonTextArray[0].text = "Derivative " + GetAmountOfQuestions(1) + "/5";
        buttonTextArray[1].text = "Integral " + GetAmountOfQuestions(2) + "/5";
        buttonTextArray[2].text = "Limit " + GetAmountOfQuestions(3) + "/5";
        buttonTextArray[3].text = "Separation of Variables " + GetAmountOfQuestions(4) + "/5";
        buttonTextArray[4].text = "Fundamental Theorem of Calculus " + GetAmountOfQuestions(5) + "/5";
        buttonTextArray[5].text = "Integration By Parts " + GetAmountOfQuestions(6) + "/5";
        buttonTextArray[6].text = "Area " + GetAmountOfQuestions(7) + "/5";
        buttonTextArray[7].text = "Random Questions " + GetAmountOfQuestions(8) + "/5";
    }

    public int GetAmountOfQuestions(int concept)
    {
        int amount = 0;
        switch (concept)
        {
            case 1:
                for (int i = 0; i < concept1List.Length; i++)
                {
                    if(concept1List[i])
                    {
                        amount++;
                    }
                }
                break;
            case 2:
                for (int i = 0; i < concept2List.Length; i++)
                {
                    if(concept2List[i])
                    {
                        amount++;
                    }
                }
                break;
            case 3:
                for (int i = 0; i < concept3List.Length; i++)
                {
                    if(concept3List[i])
                    {
                        amount++;
                    }
                }
                break;
            case 4:
                for (int i = 0; i < concept4List.Length; i++)
                {
                    if(concept4List[i])
                    {
                        amount++;
                    }
                }
                break;
            case 5:
                for (int i = 0; i < concept5List.Length; i++)
                {
                    if(concept5List[i])
                    {
                        amount++;
                    }
                }
                break;
            case 6:
                for (int i = 0; i < concept6List.Length; i++)
                {
                    if(concept6List[i])
                    {
                        amount++;
                    }
                }
                break;
            case 7:
                for (int i = 0; i < concept7List.Length; i++)
                {
                    if(concept7List[i])
                    {
                        amount++;
                    }
                }
                break;
            case 8:
                for (int i = 0; i < concept8List.Length; i++)
                {
                    if(concept8List[i])
                    {
                        amount++;
                    }
                }
                break;
            default:
            break;
        }
        return amount;
    }
}
