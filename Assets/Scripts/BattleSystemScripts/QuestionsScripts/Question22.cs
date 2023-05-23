using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question22 : Question
{
    public Question22(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    //∫ with bounds(0,x)
    public override void Start()
    {
        battleSystem.text.fontSize = 1.8f;
        battleSystem.text.text = "Find the Derivative of ∫Square Root(1+t) with bounds (0,x<sup>3</sup>)";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 3;
        battleSystem.answer1Text.text = "Square Root(1 + x<sup>3</sup>) + C";
        battleSystem.answer2Text.text = "Square Root(1 + x) + C";
        battleSystem.answer3Text.text = "Square Root(1 + x<sup>3</sup>) * 3x<sup>2</sup> + C";
    }
}
