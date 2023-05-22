using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question4 : Question
{
    public Question4(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {
        battleSystem.text.text = "Find the Derivative of -15log(lnx)";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 2;
        battleSystem.answer1Text.text = "-15/(xln(10))";
        battleSystem.answer2Text.text = "-15/(xln(x)ln(10))";
        battleSystem.answer3Text.text = "-15/(xln(x))";
    }
}
