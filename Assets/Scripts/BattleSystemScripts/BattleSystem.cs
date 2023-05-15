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
        GameObject player2Go = Instantiate(player2Prefab, playerTransform);
        GameObject player3Go = Instantiate(player3Prefab, playerTransform);

        GameObject HeroGO = GameObject.FindWithTag("Hero");
        GameObject ArcherGo = GameObject.FindWithTag("Archer");
        GameObject MageGO = GameObject.FindWithTag("Mage");

        playerUnit = HeroGO.GetComponent<Unit>();
        player2Unit = ArcherGo.GetComponent<Unit>();
        player3Unit = MageGO.GetComponent<Unit>();

        GameObject enemyGO = Instantiate(enemyPrefab, enemyTransform);
        enemyUnit = enemyGO.GetComponent<Unit>();


        playerHUD.SetHUD(playerUnit,playerSlider);
        player2HUD.SetHUD(player2Unit,player2Slider);
        player3HUD.SetHUD(player3Unit,player3Slider);
        enemyHUD.SetHUD(enemyUnit,enemySlider);

        yield return new WaitForSeconds(0f);

    }

    public void OnAttackButton()
    {
        StartCoroutine(state.Attack());
    }

    public void OnHealButton(){
        StartCoroutine(state.Heal());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
