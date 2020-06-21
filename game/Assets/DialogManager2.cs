using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager2 : MonoBehaviour
{
    public Text nameText;
    public Text dialogText;
    public bool m_Jump;
    public bool end = true;
    public bool Text;

    public GameObject Player1;
    public GameObject Player2;

    public Animator animator;
    public Animator animator2;

    public Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }

    void Update()
    {
        m_Jump = Input.GetKeyDown(KeyCode.F);
        if (m_Jump && end == true)
        {
            DisplayNextSentence2();
        }
    }


    public void StartDialog2(Dialog dialog)
    {
        animator.SetBool("isOne", true);
        nameText.text = dialog.name;
        sentences.Clear();
        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence2();

    }

    public void DisplayNextSentence2()
    {
        if (sentences.Count == 0)
        {
            EndDialog2();
            return;
        }
        end = false;
        string sentence = sentences.Dequeue();
        StartCoroutine(TypeSentence(sentence));

    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogText.text += letter;
            yield return null;
        }
        end = true;

    }

    public void EndDialog2()
    {
        animator.SetBool("isOne", false);
        Player1.SetActive(false);
        Player2.SetActive(true);
        Text = true;
    }

    void OnGUI()
    {
        if (Text == true)
        {
            GUIStyle styleTime = new GUIStyle();
            styleTime.fontSize = 25;
            styleTime.normal.textColor = Color.yellow;
            GUI.Label(new Rect(Screen.width / 2 - 60, Screen.height / 2 - 400, 80, 60), "Ложитесь спать", styleTime);
        }


    }
}
