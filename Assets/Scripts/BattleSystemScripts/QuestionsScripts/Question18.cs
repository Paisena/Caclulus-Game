using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question18 : Question
{
    public Question18(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {
        battleSystem.text.text = "Find the Antiderivative of dy/dx = ysinx";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 1;
        battleSystem.answer1Text.text = "y = Ce<sup>-cosx</sup>";
        battleSystem.answer2Text.text = "y = cosx + c";
        battleSystem.answer3Text.text = "y = Ce<sup>sinx</sup>";
    }
}
