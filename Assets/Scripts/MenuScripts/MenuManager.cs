using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


// _TODO_: Add system where when I press to go into a option of a menu, let say party, the MenuOptions hashtable will update with all the possible options there
public class MenuManager : MonoBehaviour
{

    public delegate void MenuOpenEventHandler(object source, EventArgs args);
    public event MenuOpenEventHandler MenuOpened;

    int count = 0;

    public PlayerMovment controls;
    [SerializeField]
    private PlayerController playerController;
    private InputAction menu;
    private InputAction select;
    private InputAction choice;
    public Animator animator;
    private InputAction move;
    private Vector2 dir;
    public static Dictionary<int , GameObject> MenuOptions = new Dictionary<int, GameObject>();
    public static int optionSelected = 1;

    public static int minClamp = 1;
    public static int maxClamp = 3;

    [SerializeField]
    public PointerControl pointerControl;
    [SerializeField]
    Transform partyTransform;

    MenuSetup menuSetup;

    public static MenuManager Instance { get; private set; }

    // Start is called before the first frame update
    private void Awake()
    {
        controls = new PlayerMovment();

        if(Instance != null && Instance != this )
        {
            Debug.Log("duplicate created");
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        MenuOpened += playerController.OnMenuOpened;
        MenuOpened += pointerControl.OnMenuOpened;

        menuSetup = gameObject.GetComponent<MenuSetup>();

        menuSetup.ChangeOptionsMain();

    }

    private void OnEnable()
    {
        // Enable the input system objects
        move = controls.Main.Movment;
        move.Enable();
        move.performed += moveMenuPointer;

        menu = controls.Menu.OpenMenu;
        menu.Enable();
        menu.performed += OpenMenu;

        select = controls.Menu.SelectOption;
        select.Enable();
        select.performed += selectOption;

        choice = controls.Menu.ChoiceOption;
        choice.Enable();
        choice.performed += chooseOption;
    }

    private void OnDisable()
    {
        move.Disable();
        menu.Disable();
        select.Disable();
        choice.Disable();
    }

    private void Update()
    {

       
    }

    private void chooseOption(InputAction.CallbackContext context)
    {

    }

    private void selectOption(InputAction.CallbackContext context)
    {
        GameObject selected = MenuOptions[optionSelected];
        selected.GetComponent<MenuChoice>().SetUpCall();

        
    }



    private void moveMenuPointer(InputAction.CallbackContext context)
    {
        dir = move.ReadValue<Vector2>();

        updateMenuOptionSelected(dir);

        GameObject target = MenuOptions[optionSelected];

        pointerControl.move(target);
    }

    private void updateMenuOptionSelected(Vector2 dir)
    {
        if (dir == Vector2.down)
        {
            optionSelected += 1;
        }
        else if (dir == Vector2.up)
        {
            optionSelected -= 1;
        }
        optionSelected = Math.Clamp(optionSelected, minClamp, maxClamp);
    }

    private void OpenMenu(InputAction.CallbackContext context)
    {
        
        // if (count == 2)
        //     count = 0;
        // if (count == 0)
        // {
        //     optionSelected = 1;
        //     OpenTheMenu();
        //     OnMenuOpened();
        // }
        // count++;
    }

    private void OpenTheMenu()
    {
        if (!animator.GetBool("isOpen"))
        {
            animator.SetBool("isOpen", true);
        }
        else if (animator.GetBool("isOpen"))
        {
            CloseMenu();
            //count = -1;
        }

    }

    private void CloseMenu()
    {
        animator.SetBool("isOpen", false);
    }

    protected virtual void OnMenuOpened()
    {
        if (MenuOpened != null)
        {
            //check to find which level you are changing to
            MenuOpened(this, EventArgs.Empty);
        }
    }
}
