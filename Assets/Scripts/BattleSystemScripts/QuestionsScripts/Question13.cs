using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Question13 : Question
{
    public Question13(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override void Start()
    {
        Debug.Log("started");
        battleSystem.text.text = "What is the limit at x -> 3 of this graph";
        battleSystem.SetupAnswers();
        battleSystem.SetupImage();
        Sprite graphSprite = battleSystem.CreateSprite("Assets/Scripts/BattleSystemScripts/QuestionsScripts/Graphs/Graph1.PNG");

        battleSystem.QuestionImage.sprite = graphSprite;
        battleSystem.correctAnswer = 2;
        battleSystem.answer1Text.text = "0";
        battleSystem.answer2Text.text = "6";
        battleSystem.answer3Text.text = "DNE";
    }
}
