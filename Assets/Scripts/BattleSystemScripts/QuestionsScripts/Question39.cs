using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question39 : Question
{
    public Question39(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    public override void Start()
    {
        battleSystem.text.fontSize = 1.8f;
        battleSystem.text.text = "Find the derivative of 12031f(x) * 12031h(x)";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 1;
        battleSystem.answer1Text.text = "12031(h(x) * f'(x) + f(x) * h'(x))";
        battleSystem.answer2Text.text = "h(12031x) * f'(12031x) + f(12031x) * h'(12031x)";
        battleSystem.answer3Text.text = "12031(h'(12031x) + f'(12031x))";
    }
}
