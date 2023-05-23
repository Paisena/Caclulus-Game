using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question25 : Question
{
    public Question25(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    //∫ with bounds(0,x)
    public override void Start()
    {
        battleSystem.text.fontSize = 1.8f;
        battleSystem.text.text = "Solve the integral ∫2/(1+x<sup>2</sup>) with bounds(0,1))";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 1;
        battleSystem.answer1Text.text = "π/2";
        battleSystem.answer2Text.text = "π/4";
        battleSystem.answer3Text.text = "π/6";
    }
}
