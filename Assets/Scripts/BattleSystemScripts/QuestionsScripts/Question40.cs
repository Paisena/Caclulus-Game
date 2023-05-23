using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question40 : Question
{
    public Question40(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    public override void Start()
    {
        battleSystem.text.fontSize = 1.8f;
        battleSystem.text.text = "Find the Derivative of ∫cos<sup>-1</sup>t with bounds (0,x)";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 2;
        battleSystem.answer1Text.text = "-arccos<sup>-1</sup>t";
        battleSystem.answer2Text.text = "arccos<sup>-1</sup>x";
        battleSystem.answer3Text.text = "-1/Square Root(1-x<sup>2</sup>)";
    }
}
