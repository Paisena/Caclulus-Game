using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question31 : Question
{
    public Question31(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    public override void Start()
    {        
        battleSystem.text.fontSize = 1.8f;
        battleSystem.text.text = "What is the area under the curve of x<sup>2</sup> + 2 from the interval (0,1)";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 3;
        battleSystem.answer1Text.text = "2";
        battleSystem.answer2Text.text = "8/5";
        battleSystem.answer3Text.text = "7/3";
    }
}
