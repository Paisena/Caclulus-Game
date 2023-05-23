using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question36 : Question
{
    public Question36(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    public override void Start()
    {
        battleSystem.text.fontSize = 1.8f;
        battleSystem.text.text = "Find the area bounded by the curves y = e<sup>1+x</sup>, y = e<sup>1-x</sup> + 1, and the y-axis";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 3;
        battleSystem.answer1Text.text = "0.0871";
        battleSystem.answer2Text.text = "0.0790";
        battleSystem.answer3Text.text = "0.0917";
    }
}
