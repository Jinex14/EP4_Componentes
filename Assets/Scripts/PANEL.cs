using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PANEL : MonoBehaviour
{
    public float typingSpeed;
    [TextArea(3,10)] public string[] sentences;
    private GameObject panel;
    private Text texto;
    private int index = 0, timesTalk;
    private bool canTalk;
    // Start is called before the first frame update
    void Start()
    {
        panel = GameObject.Find("PanelD");
        texto = panel.transform.GetChild(0).GetComponent<Text>();
        //panel.SetActive(false);
        StartCoroutine(Typing());
    }
    
    IEnumerator Typing()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            texto.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        yield return new WaitForSeconds(3);
        NextText();
    }

    private void NextText()
    {
        print($"{sentences.Length - 1} - {index}");

        if(index < sentences.Length -1)
        {
            index++;
            texto.text = "";
            StartCoroutine(Typing());
        }else
        {
            panel.SetActive(false);
            GameObject.Find("Player1").GetComponent<movimiento>().startGame();
            GameObject.Find("Player2").GetComponent<movimiento2>().startGame();
        }

        
    }

    void Update()
    {
        
    }
}
