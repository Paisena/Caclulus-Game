using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question5 : Question
{
    public Question5(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {
        battleSystem.text.text = "Find the derivative of (f(x)*h(x))/f(x)";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 1;
        battleSystem.answer1Text.text = "((f'(x)*h(x) + f(x)*h'(x))f(x) - f(x)*h(x)*f'(x)) / (f(x))<sup>2</sup>";
        battleSystem.answer2Text.text = "f(x) + h(x) / f(x)<sup>2</sup>";
        battleSystem.answer3Text.text = "f'(x)*h'(x)/(f(x)))<sup>2</sup>";
    }
}
