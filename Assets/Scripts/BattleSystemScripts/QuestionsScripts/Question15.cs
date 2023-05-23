using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question15 : Question
{
    public Question15(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {
        battleSystem.text.text = "What is k(x) = lim x -> 3 h(x) + lim x -> 1.5 f(x)";
        battleSystem.SetupAnswers();
        battleSystem.SetupImage();
        Sprite graphSprite = battleSystem.CreateSprite("Assets/Scripts/BattleSystemScripts/QuestionsScripts/Graphs/Graph3.PNG");

        battleSystem.QuestionImage.sprite = graphSprite;
        battleSystem.correctAnswer = 3;
        battleSystem.answer1Text.text = "3";
        battleSystem.answer2Text.text = "9.5";
        battleSystem.answer3Text.text = "2.5";
    }
}
