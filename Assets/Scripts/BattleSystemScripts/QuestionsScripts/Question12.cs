using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question12 : Question
{
    public Question12(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {   
        battleSystem.text.fontSize = 1.8f;
        battleSystem.text.text = "At how many points will (x<sup>2</sup> - 2) / (x<sup>2</sup> -4) approach -Infinity";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 2;
        battleSystem.answer1Text.text = "0";
        battleSystem.answer2Text.text = "2";
        battleSystem.answer3Text.text = "4";
    }
}
