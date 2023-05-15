using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUDTextMananger : MonoBehaviour
{

    [SerializeField]
    public TextMeshPro HUDtext;
    [SerializeField]
    Unit unit;

    private void Start() {
        
    }

    public void SetHUD(Unit unit, Slider slider)
    {
        HUDtext.text = unit.unitName;
        slider.maxValue = unit.mapHP;
        slider.value = unit.currentHp;
    }
}
