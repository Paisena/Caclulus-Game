using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question11 : Question
{
    public Question11(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {
        battleSystem.text.fontSize = 1.8f;
        battleSystem.text.text = "What makes a point on a function continuous?";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 3;
        battleSystem.answer1Text.text = "When the limit exists";
        battleSystem.answer2Text.text = "When the point exists";
        battleSystem.answer3Text.text = "When the point equals the limit";
    }
}
