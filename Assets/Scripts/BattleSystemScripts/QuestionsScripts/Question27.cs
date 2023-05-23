using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question27 : Question
{
    public Question27(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    public override void Start()
    {
        battleSystem.text.text = "Solve ∫(x<sup>2</sup> + 3)e<sup>x</sup>";
        battleSystem.SetupAnswers();
        battleSystem.correctAnswer = 2;
        battleSystem.answer1Text.text = "x<sup>2 - 2xe<sup>x</sup> + 5";
        battleSystem.answer2Text.text = "x<sup>2</sup>e<sup>x</sup> - 2xe<sup>x</sup> + 5e<sup>x</sup>";
        battleSystem.answer3Text.text = "x<sup>2</sup>e<sup>x</sup> - 2xe<sup>x</sup> + 5e<sup>x</sup> + 16";
    }
}
