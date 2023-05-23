using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections.Generic;

internal class Won : State
{
    public Animator FadeInOutAnimator;

    GameObject playerInventoryGO = GameObject.FindWithTag("Inventory");



    public Won(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override IEnumerator Start()
    {
        //get loot pool from enemy and then pick item from loot pool

        battleSystem.text.text = "You win";

        GameObject enemy = GameObject.FindWithTag("Enemy");

        DropTable enemyDropTable = enemy.GetComponent<DropTable>();

        List<Item> dropTable = enemyDropTable.GetDropTable();

        Inventory playerInventory = playerInventoryGO.GetComponent<Inventory>();

        int selectedDrop = (int)Random.Range(0, dropTable.Count);

        playerInventory.CreateEquipableItem(dropTable[selectedDrop]);
        Object.Destroy(enemy);

        yield return new WaitForSeconds(1f);

        PlayerController.returnToPreviousSpot = true;

        battleSystem.text.text = "Thanks for playing!";

        yield return new WaitForSeconds(2f);

        battleSystem.text.text = "quitting";

        yield return new WaitForSeconds(2f);

        Application.Quit();
        battleSystem.levelChanger.ReturnToLastScene();
    }
}