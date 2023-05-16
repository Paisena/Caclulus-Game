using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    // Controls how and what dialogue is shown 


    public Text nameText; // Text box for name
    public Text dialogueText; // Text box for dialogue

    public Animator animator; // Animator for moving the text box

    private Queue<string> sentences; // Where the sentences are stored
    [SerializeField]
    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>(); 
        //playerController = new PlayerController();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("isOpen", true); // Call the animator to do the "move the textbox up animation"

        Debug.Log("starting conversation with " + dialogue.name);

        nameText.text = dialogue.name; // set the name to the name text box

        sentences.Clear(); // Clear the queue of any previous dialogues

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence); // Place new dialogue taken from the object the dialogue trigger came from into the queue
        }

        DisplayNextSentence(); // Start the dialouge
    }



    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            // Ends the dialogue if it runs out of dialouge
            EndDialogue(); 
            return;
        }

        string sentence = sentences.Dequeue(); // Remove dialouge from queue one by one and place into setence string which will be displayed
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence)); // Actually puts dialogue in text put as a flow of words
    }

    IEnumerator TypeSentence(string sentence)
    {
        // Places indivusial letter from dialogue into text box
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(.04f);
        }
    }

    void EndDialogue()
    {
        // Ends the Dialogue and moves dialogue box out of screen through animation
        animator.SetBool("isOpen", false); 
    }
}
