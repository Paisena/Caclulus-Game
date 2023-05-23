using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question32 : Question
{
    public Question32(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    public override void Start()
    {        
        battleSystem.text.fontSize = 1.8f;
        battleSystem.text.text = "Find the area bounded by the curves y = e<sup>2x</sup>, y = -x<sup>2</sup> + 2 and the y-axis";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 2;
        battleSystem.answer1Text.text = "0.1973";
        battleSystem.answer2Text.text = "0.1808";
        battleSystem.answer3Text.text = "0.1256";
    }
}
