using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question30 : Question
{
    public Question30(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    public override void Start()
    {
        battleSystem.text.text = "Solve ∫lnx/x<sup>2</sup>";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 3;
        battleSystem.answer1Text.text = "lnx/x<sup>2</sup> + 1/x<sup>2</sup> + C";
        battleSystem.answer2Text.text = "-lnx/x<sup>2</sup> + 1/x + C";
        battleSystem.answer3Text.text = "-lnx/x - 1/x + C";
    }
}
