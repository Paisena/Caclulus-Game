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

    public Button button1;
    
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


        playerHUD.SetHUD(playerUnit,playerSlider);
        enemyHUD.SetHUD(enemyUnit,enemySlider);

        yield return new WaitForSeconds(0f);

    }

    public void OnAttackButton()
    {
        if(this.state is PlayerTurn)
        {
            StartCoroutine(state.Attack());
        }
        else
        {
            Debug.Log("not your turn");
        }
    }

    public void OnHealButton(){
        StartCoroutine(state.Heal());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
