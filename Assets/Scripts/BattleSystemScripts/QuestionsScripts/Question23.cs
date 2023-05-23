using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question23 : Question
{
    public Question23(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    //∫ with bounds(0,x)
    public override void Start()
    {
        battleSystem.text.text = "∫f(x) with bounds(a,b) is equal to:";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 1;
        battleSystem.answer1Text.text = "F(b) - F(a)";
        battleSystem.answer2Text.text = "F(a) - F(b)";
        battleSystem.answer3Text.text = "f(a) + f(b)";
    }
}
