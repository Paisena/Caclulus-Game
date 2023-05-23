using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question20 : Question
{
    public Question20(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {
        battleSystem.text.text = "Find the Antiderivative of dy/dx = x<sup>2</sup>y";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 2;
        battleSystem.answer1Text.text = "y = ln|(1/3)x<sup>3</sup>| + C";
        battleSystem.answer2Text.text = "y = Ce<sup>(x^3/3)</sup>";
        battleSystem.answer3Text.text = "y = (x<sup>3</sup>/3)Ce";
    }
}
