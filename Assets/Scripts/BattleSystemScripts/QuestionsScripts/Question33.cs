using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question33 : Question
{
    public Question33(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    public override void Start()
    {
        battleSystem.text.fontSize = 1.8f;
        battleSystem.text.text = "Find the area bounded by the curves y = -x<sup>3</sup> + 3, y = 1/x";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 1;
        battleSystem.answer1Text.text = "0.828";
        battleSystem.answer2Text.text = "0.765";
        battleSystem.answer3Text.text = "0.925";
    }
}
