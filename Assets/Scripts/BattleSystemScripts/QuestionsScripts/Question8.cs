using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question8 : Question
{
    public Question8(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {
        battleSystem.text.text = "Find the integral of 5x<sup>2</sup>+3x-15";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 1;
        battleSystem.answer1Text.text = "5x<sup>3</sup>/3 + 3x<sup>2</sup>/2 - 15x + C";
        battleSystem.answer2Text.text = "15x<sup>3</sup> + 6x<sup>2</sup> - 15x + C";
        battleSystem.answer3Text.text = "5x<sup>3</sup> + 3x<sup>2</sup> - 15x + C";
    }
}
