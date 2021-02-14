using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{

    private Queue <string> sentences;
    public Text nameText;
    public Text dialogueText;
    public Animator animator;
    public float delay = 0.001f;
    private int namenumber = 0;
    private string sentence = "";


    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();

    }

    public void StartDialogue(Dialogue dialogue)
    {

        nameText.text = "You";
        
        
        animator.SetBool("IsOpen", true);
        

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        
        DisplayNextSentence();
    }
    
    
    
    public void DisplayNextSentence()
    {

        

        /* if (!(dialogueText.text.Equals(sentence)))
        {

            dialogueText.text = "";
            DisplayWholeSentence(sentence);
            return;
        } */

        if (sentences.Count ==0)
        {
            EndDialogue();
            
        }

        sentence = sentences.Dequeue();
        dialogueText.text = sentence;

        

        StopAllCoroutines();
        
        
            
        StartCoroutine(TypeSentence(sentence));
        Debug.Log(namenumber);
        namenumber++;
        if (namenumber > 1 && namenumber % 2 == 0)
        {
            Debug.Log("Starting conversation with You");
            nameText.text = "You";
        }
        if (namenumber > 1 && namenumber % 2 != 0)
        {
            Debug.Log("Starting conversation with Mr. Kramer");
            nameText.text = "King Kramer";
        }
        
        
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(delay);
        }
        
    }

    
   /*public void DisplayWholeSentence(string sentence)
    {
        
        dialogueText.text = sentence;
    }*/

    void EndDialogue()
    {

        Debug.Log("End of conversation");
        SceneManager.LoadScene(1);
    }
}
