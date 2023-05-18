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
        Debug.Log("started");
        battleSystem.text.text = "Find the Derivative of e<sup>3x</sup> yea";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 1;
    }
}
