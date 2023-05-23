using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question10 : Question
{
    public Question10(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {
        battleSystem.text.fontSize = 1.8f;
        battleSystem.text.text = "What function is the same as the function f(x) = ∫(2x<sup>2</sup> + 16x - 8)";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 3;
        battleSystem.answer1Text.text = "x<sup>3</sup> + 16x + C";
        battleSystem.answer2Text.text = "4x<sup>3</sup> + 16x<sup>2</sup> + 4x + C";
        battleSystem.answer3Text.text = "2(∫(x<sup>2</sup>) + ∫(8x) - ∫(4))";
    }
}
