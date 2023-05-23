using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question38 : Question
{
    public Question38(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    public override void Start()
    {
        battleSystem.text.text = "A function has a vertical asymptote when: ";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 3;
        battleSystem.answer1Text.text = "The y value increase as the x value does";
        battleSystem.answer2Text.text = "The limit approaching infinity is a real number";
        battleSystem.answer3Text.text = "The limit approaching a real number is infinity";
    }
}
