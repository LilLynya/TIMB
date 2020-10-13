using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using VIDE_Data;
using UnityEngine.UI;

public class minUIExample : MonoBehaviour {
    public List<Text> textPlayer;
    public List<GameObject> buttonsPlayer;
    public Text textNPC;
    public GameObject DialogeContiner;
    public GameObject[] Hearts;
    public int valueLive;
    FoolPerson _person;

    void Start()
    {
        gameObject.AddComponent<VD>();
        DialogeContiner.SetActive(false);
        foreach (var button in buttonsPlayer)
        {
            button.gameObject.SetActive(false);
        }
    }

    void OnDisable()
    {
        VD.EndDialogue();
    }

    void OnGUI () {
	    if (VD.isActive)
        {
            var data = VD.nodeData; //Quick reference
            
            if (data.isPlayer) // If it's a player node, let's show all of the available options as buttons
            {
                for (int i = 0; i < data.comments.Length; i++)
                {
                    buttonsPlayer[i].gameObject.SetActive(true);
                    textPlayer[i].text = data.comments[i];
                    Debug.Log(data.comments[i]);
                    /*if (GUILayout.Button(data.comments[i])) //When pressed, set the selected option and call Next()
                    {
                        data.commentIndex = i;
                        VD.Next();
                    }*/
                }
            } else //if it's a NPC node, Let's show the comment and add a button to continue
            {
                //GUILayout.Label(data.comments[data.commentIndex]);
                textNPC.text = data.comments[data.commentIndex];
                /*if (GUILayout.Button(">")){
                    VD.Next();
                }*/
            }
			if (data.isEnd) // If it's the end, let's just call EndDialogue
                {
                    VD.EndDialogue();
                }
        } else // Add a button to begin conversation if it isn't started yet
        {
            /*if (GUILayout.Button("Start Convo"))
            {
                VD.BeginDialogue(GetComponent<VIDE_Assign>()); //We've attached a VIDE_Assign to this same gameobject, so we just call the component
            }*/
        }
	}

    public void NextFraseNPC()
    {
        VD.Next();
    }

    public void NextFrase(int number)
    {
       
        VD.nodeData.commentIndex = number;
        VD.Next();
        foreach (var button in buttonsPlayer)
        {
            button.gameObject.SetActive(false);
        }
    }

    public void BegeenDialoge()
    {
        VD.BeginDialogue(GetComponent<VIDE_Assign>());
    } 

    public void CloseDialoge()
    {
        VD.EndDialogue();
        DialogeContiner.SetActive(false);
        _person.SetAlive(true);
    }

    public void Damage()
    {
        Hearts[valueLive].SetActive(false);
        Debug.Log(Hearts[valueLive]);
        valueLive--;
        CloseDialoge();
    }

    public void ShowDialoge()
    {
        DialogeContiner.SetActive(true);
    }

    public void SetTypeDialoge(string nameDialoge, FoolPerson person)
    {
        _person = person;
        GetComponent<VIDE_Assign>().assignedDialogue = nameDialoge;
    }
}
