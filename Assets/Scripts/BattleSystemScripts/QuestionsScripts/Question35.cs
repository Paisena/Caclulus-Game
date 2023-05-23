using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question35 : Question
{
    public Question35(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    public override void Start()
    {
        battleSystem.text.fontSize = 1.8f;
        battleSystem.text.text = "Find the area bounded by the curves y = 1/x<sup>2</sup> + 3, y = x^2";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 1;
        battleSystem.answer1Text.text = "0.244";
        battleSystem.answer2Text.text = "0.122";
        battleSystem.answer3Text.text = "0.366";
    }
}
