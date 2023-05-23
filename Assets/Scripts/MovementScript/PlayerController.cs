using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.InputSystem;
using System;

public class PlayerController : MonoBehaviour
{
    #region variables
    //Tilemaps
    [SerializeField]
    private Tilemap groundTilemap; // Tilemap which the player moves on

    [SerializeField]
    private Tilemap CollisionTilemap; // Tilemap which the player cannot move on

    [SerializeField]
    private Tilemap InteractTilemap; // Tilemap which the player cna interact with
    [SerializeField]
    private Tilemap EnemyTileMap;
    [SerializeField]
    private Tilemap NewFloorTileMap;

    //movement variables

    [SerializeField]
    private float movementSpeed = 1f; // To change how fast the player goes

    [SerializeField]
    private Transform movePoint; // Used to decide where to player should be going through the MoveTowards function

    [SerializeField]
    private float distanceToNextInput = .0000001f; //  How close the player cna be to the next tile to place another input

    Vector2 dir; // where the player is going
    public Vector2 facing;
    // Dialogue Variables
    public Animator animator;
    public Animator FadeInOutAnimator;
    private bool isChatting;

    //Input system variables
    public PlayerMovment controls; // Main input controller
    private InputAction move; // Movement of the player
    private InputAction interact; // When the player interacts with the game world
    private InputAction menu;
    [SerializeField]
    private InfoSaver infoSaver;
    private bool isMenuOpened = false;
    public static bool returnToPreviousSpot = true;
    public GameObject[] dialogueList;
    public Hero hero;
    

    #endregion

    private void Awake()
    {
        controls = new PlayerMovment();

    }

    private void OnEnable()
    {
        // Enable the input system objects
        move = controls.Main.Movment;
        move.Enable();

        interact = controls.Main.Interact;
        interact.Enable();
        interact.performed += Interact; // Calls the Interact function
    }

    private void OnDisable()
    {
        // Disable the input system objects
        move.Disable();
        controls.Disable();
        interact.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        isChatting = animator.GetBool("isOpen");
        infoSaver.ResetPlayer();
        returnToPreviousSpot = false;

        dialogueList = GameObject.FindGameObjectsWithTag("Dialogue");
        Debug.Log(dialogueList.Length);
    }

    private void Update()
    {
        if (isMenuOpened) return;

        isChatting = animator.GetBool("isOpen");
        if (!isChatting) //if the player is not chatting
        {
            #region Movement
            // Decides which direction to move based on input and goes there
            dir = move.ReadValue<Vector2>();

            // Player can only move on one axis
            if (dir.x == 0 || dir.y == 0)
            {
                // Check to see if the player is close enough to buffer another input and is not going to run into a tile it cant go to
                if (CanMove(dir) && Vector3.Distance(transform.position, movePoint.position) <= distanceToNextInput)
                {
                    movePoint.position = movePoint.position + (Vector3)dir;
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, movePoint.position, movementSpeed * Time.deltaTime); // actually moves the player

            if (dir != Vector2.zero)
                facing = dir;

            #endregion
        }
    }

    private bool CanMove(Vector2 direction)
    {
        // Decides if the player is going to run into a tile that cannot be moved to 

        Vector3Int gridPosition = groundTilemap.WorldToCell(transform.position + (Vector3)direction);

        if (!groundTilemap.HasTile(gridPosition) || CollisionTilemap.HasTile(gridPosition))
            return false;
        
        if(NewFloorTileMap.HasTile(gridPosition))
        {
            FadeInOutAnimator.SetBool("FadeOut", true);
        }
        return true;
    }

    private bool CanInteract(Vector2 direction)
    {
        // Decides if the player is in range of an object that is interactable(basically the CanMove function but for interaction)

        Vector3Int gridPosition = groundTilemap.WorldToCell(transform.position + (Vector3)facing);
        for (int i = 0; i < dialogueList.Length; i++)
        {
            if(dialogueList[i].GetComponent<Tilemap>().HasTile(gridPosition) && !isChatting)
            {
                dialogueList[i].GetComponent<DialogueTrigger>().TriggerDialogue();
                Debug.Log("dialogue triggered");
                return true;
            }
        }
        // if (InteractTilemap.HasTile(gridPosition))
        // {
        //     //Debug.Log("Interact");
        //     return true;
        // }
        return false;
    }

    private void Interact(InputAction.CallbackContext context)
    {
        // Either starts or continues dialogue 
        // if (CanInteract(dir) && !isChatting)
        // {
        //     FindObjectOfType<DialogueTrigger>().TriggerDialogue();
        // }
        CanInteract(dir);
        if (isChatting)
        {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
        }
        if (InteractWithEnemy())
        {
            //start combat
            DontDestroyOnLoad(GameObject.FindWithTag("Enemy"));
            hero.enemyFighting = GameObject.FindWithTag("Enemy");
            Debug.Log("added enemy");
            FadeInOutAnimator.SetBool("FadeOut", true);
        }
    }

    private bool InteractWithEnemy()
    {
        Vector3Int gridPosition = groundTilemap.WorldToCell(transform.position + (Vector3)facing);

        if (EnemyTileMap.HasTile(gridPosition))
        {
            return true;
        }
        return false;
    }

    public void OnMenuOpened(object source, EventArgs e)
    {
        if (isMenuOpened)
        {
            isMenuOpened = false;

        }
        else if (!isMenuOpened)
        {
            isMenuOpened = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Vector3Int gridPosition = groundTilemap.WorldToCell(transform.position + (Vector3)facing);

        if (CollisionTilemap.HasTile(gridPosition))
        {
            FadeInOutAnimator.SetBool("FadeOut", true);
        }
    }
}
