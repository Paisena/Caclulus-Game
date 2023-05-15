using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Unit
{

    GameObject playerInventoryGO;
    private static Hero heroInstance;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (heroInstance == null)
        {
            heroInstance = this;
        }
        else
        {
            Object.Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        playerInventoryGO = GameObject.FindWithTag("Inventory");

        GameObject enemy = GameObject.FindWithTag("Enemy");

        //DropTable enemyDropTable = enemy.GetComponent<DropTable>();

        //List<Item> dropTable = enemyDropTable.GetDropTable();

        Inventory playerInventory = playerInventoryGO.GetComponent<Inventory>();

        playerInventory.CreateEquipableItem(new HelmetOfEpic());
        playerInventory.CreateEquipableItem(new SwordOfEpic());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
