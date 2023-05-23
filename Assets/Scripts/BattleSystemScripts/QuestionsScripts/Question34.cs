using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question34 : Question
{
    public Question34(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    public override void Start()
    {
        battleSystem.text.fontSize = 1.8f;
        battleSystem.text.text = "Find the area bounded by the curves y = ln(2x), y = e<sup>2x</sup> -3";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 2;
        battleSystem.answer1Text.text = "0.123";
        battleSystem.answer2Text.text = "0.225";
        battleSystem.answer3Text.text = "0.300";
    }
}
