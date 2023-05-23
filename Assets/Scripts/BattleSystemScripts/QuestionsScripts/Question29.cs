using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question29 : Question
{
    public Question29(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    public override void Start()
    {
        battleSystem.text.text = "Can you use table method to solve: e<sup>x</sup>sinx";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 2;
        battleSystem.answer1Text.text = "Yes";
        battleSystem.answer2Text.text = "No";
        battleSystem.answer3Text.text = "Maybe So";
    }
}
