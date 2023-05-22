using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuestionOne : Question
{
    public QuestionOne(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {
        battleSystem.text.text = "Find the Derivative of e<sup>3x</sup> yea";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 1;
        battleSystem.answer1Text.text = "3e<sup>3x</sup>";
        battleSystem.answer2Text.text = "e<sup>3x</sup>";
        battleSystem.answer3Text.text = "(1/3)e<sup>3x</sup>";
    }
}
