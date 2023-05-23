using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question7 : Question
{
    public Question7(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {
        battleSystem.text.text = "Find the integral of 6x/(x<sup>4</sup>+9)";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 2;
        battleSystem.answer1Text.text = "ln|x<sup>4</sup> + 9| + C";
        battleSystem.answer2Text.text = "Arctan(x<sup>2</sup>/3) + C";
        battleSystem.answer3Text.text = "ln|x<sup>4</sup> + 9| * 4x<sup>3</sup> + C";
    }
}
