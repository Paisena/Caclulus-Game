using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question16 : Question
{
    public Question16(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {
        battleSystem.text.text = "Find the Antiderivative of dy/dx = e<sup>x-3y</sup>";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 1;
        battleSystem.answer1Text.text = "y = ((x - ln(1/3)) / 3) + C";
        battleSystem.answer2Text.text = "y = (x / 3)";
        battleSystem.answer3Text.text = "y = e<sup>x</sup> + 3x";
    }
}
