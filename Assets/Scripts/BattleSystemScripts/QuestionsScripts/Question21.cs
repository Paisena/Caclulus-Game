using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question21 : Question
{
    public Question21(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    //∫ with bounds(0,x)
    public override void Start()
    {
        battleSystem.text.text = "Find the Derivative of ∫156t<sup>2</sup> with bounds (0,x)";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 2;
        battleSystem.answer1Text.text = "312t<sup>3</sup> + C";
        battleSystem.answer2Text.text = "156x<sup>2</sup> + C";
        battleSystem.answer3Text.text = "312x<sup>3</sup> + C";
    }
}
