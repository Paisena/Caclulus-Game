using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question9 : Question
{
    public Question9(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {
        battleSystem.text.text = "Find the integral of f(2x) + h(x)";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 1;
        battleSystem.answer1Text.text = "(1/2)F(2x) + H(x)";
        battleSystem.answer2Text.text = "F(2x) + H(x)";
        battleSystem.answer3Text.text = "F(2x) * H(x)";
    }
}
