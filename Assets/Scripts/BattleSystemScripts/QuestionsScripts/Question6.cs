using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question6 : Question
{
    public Question6(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {
        battleSystem.text.fontSize = 1.8f;
        battleSystem.text.text = "Which is function is the same as the function f(x) = ∫(6h(x) + 6k(x))";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 3;
        battleSystem.answer1Text.text = "6 * ∫(h(x)*f(x))";
        battleSystem.answer2Text.text = "∫(h(x) - k(x))";
        battleSystem.answer3Text.text = "6 * ∫(h(x) + k(x))";
    }
}
