using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question24 : Question
{
    public Question24(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    //∫ with bounds(0,x)
    public override void Start()
    {
        battleSystem.text.text = "Find the Derivative of ∫e<sup>t^2</sup>/5 with bounds (0,x<sup>3</sup>)";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 1;
        battleSystem.answer1Text.text = "(3x<sup>2</sup>e<sup>x^6</sup>)/5";
        battleSystem.answer2Text.text = "((x<sup>4</sup>/4)e<sup>x^6</sup>)/5";
        battleSystem.answer3Text.text = "(3x<sup>2</sup>e<sup>x^6</sup>)*5";
    }
}
