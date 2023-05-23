using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question2 : Question
{
    public Question2(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    public override void Start()
    {
        battleSystem.text.text = "Find the Derivative of f(f(x) * h(x))";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 2;
        battleSystem.answer1Text.text = "f'(f(x) * h(x)) * (f'(x) * h'(x))";
        battleSystem.answer2Text.text = "f'(f(x) * h(x)) * ((f(x) * h'(x) + h(x) * f'(x))";
        battleSystem.answer3Text.text = "f'(f(x) * h(x))";
    }
}
