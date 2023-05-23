using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question17 : Question
{
    public Question17(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {
        battleSystem.text.text = "Find the Antiderivative of dy/dx = x<sup>2</sup>/15y";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 2;
        battleSystem.answer1Text.text = "y = Square Root(2x<sup>3</sup>/15) + C";
        battleSystem.answer2Text.text = "y = Square Root(2x<sup>3</sup>/45) + C";
        battleSystem.answer3Text.text = "y = Square Root(x<sup>2</sup>/15) + C";
    }
}
