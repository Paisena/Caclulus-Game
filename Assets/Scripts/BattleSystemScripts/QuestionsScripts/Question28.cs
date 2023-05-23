using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question28 : Question
{
    public Question28(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    public override void Start()
    {
        battleSystem.text.fontSize = 1.8f;
        battleSystem.text.text = "Could you use the table method the solution: ∫(2x<sup>3</sup> + 3x<sup>2</sup> + x)cosx";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 1;
        battleSystem.answer1Text.text = "Yes";
        battleSystem.answer2Text.text = "No";
        battleSystem.answer3Text.text = "Maybe";
    }
}
