using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question14 : Question
{
    public Question14(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {
        battleSystem.text.text = "What is lim x -> 1 of h(x) = 2f(x) + 5";
        battleSystem.SetupAnswers();
        battleSystem.SetupImage();
        Sprite graphSprite = battleSystem.CreateSprite("Assets/Scripts/BattleSystemScripts/QuestionsScripts/Graphs/Graph2.PNG");

        battleSystem.QuestionImage.sprite = graphSprite;
        battleSystem.correctAnswer = 2;
        battleSystem.answer1Text.text = "8";
        battleSystem.answer2Text.text = "11";
        battleSystem.answer3Text.text = "3";
    }
}
