using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question19 : Question
{
    public Question19(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {
        battleSystem.text.text = "Find the Antiderivative of dy/dx = (2+y)/x";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 3;
        battleSystem.answer1Text.text = "y = lnx - 2 + C";
        battleSystem.answer2Text.text = "y = Ce<sup>x + 2</sup>";
        battleSystem.answer3Text.text = "C|x| - 2";
    }
}
