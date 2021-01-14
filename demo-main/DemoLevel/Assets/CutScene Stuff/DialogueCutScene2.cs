using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueCutScene2 : MonoBehaviour
{

    private Queue<string> sentences;
    public Text nameText;
    public Text dialogueText;
    
  
    public float delay = 0.001f;
    private int namenumber = 0;
    private string sentence = "";


    // Start is called before the first frame update
    void Awake()
    {
        sentences = new Queue<string>();
        


    }
    

    public void StartDialogue(Dialogue dialogue)
    {

        nameText.text = "You";


        

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }


        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        Debug.Log(namenumber);
        namenumber++;
        if (namenumber % 2 == 0)
        {
            Debug.Log("Starting conversation with Martha");
            nameText.text = "Martha";
        }
        if (namenumber % 2 != 0)
        {
            Debug.Log("Starting conversation with You");
            nameText.text = "You";
        }

      
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(delay);
        }
    }

    void EndDialogue()
    {

        Debug.Log("End of conversation");
        SceneManager.LoadScene("level2");
    }
}
