using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question37 : Question
{
    public Question37(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    public override void Start()
    {
        battleSystem.text.fontSize = 1.8f;
        battleSystem.text.text = "What derivative rules can be used to find the derivative of f(x) = (2xf(x<sup>2</sup>))";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 3;
        battleSystem.answer1Text.text = "Product Rule, Quotient Rule";
        battleSystem.answer2Text.text = "Quotient Rule, Chain Rule";
        battleSystem.answer3Text.text = "Product Rule, Chain Rule";
    }
}
