﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class activepanel : MonoBehaviour
{
    public ToDoActive Check;

    public GameObject plane;
    public bool activePlane = false;
    public GameObject editInput;
    public bool activeeditInput = false;


    public Text textNewToDo;
    public Text inputTextNewToDo;

    public Text textEditToDo;
    public Text inputTextEditToDo;

    public GameObject ToDo1;
    public int indexToDo;



    // Start is called before the first frame update
    void Start()
    {
        plane.SetActive(false);
        editInput.SetActive(false);
    }


    private void Update()
    {
        plane.SetActive(activePlane);
        if (activePlane == true || activeeditInput == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (inputTextNewToDo.text == ""|| inputTextNewToDo.text.Length <2)
                {
                    Debug.Log("Данные введены не корректно");
                }
                else
                {

                    Debug.Log("Успешно");
                    textNewToDo.text = inputTextNewToDo.text;
                    activePlane = false;
                    Debug.Log(textNewToDo.text);

                    if (Check.toDoActive1 == false)
                    {
                        Check.IndexToDo(1, true);
                        Check.textToDo2.text = textNewToDo.text;

                    }
                    else if (Check.toDoActive2 == false)
                    {
                        Check.IndexToDo(2, true);
                        Check.textToDo2.text = textNewToDo.text;
                    }


                }
            }
        }
    }

    // Update is called once per frame
    public void planeActive()
    {
        activePlane = true;
    }


    public void newTodo()
    {
        inputTextNewToDo.text = "";
        textNewToDo.text = "";

        if (inputTextNewToDo.text == "")
        {
            Debug.Log("Данные введены не корректно");
        }
        else
        {

            Debug.Log("Успешно");
            textNewToDo.text = inputTextNewToDo.text;
            activePlane = false;
            Debug.Log(textNewToDo.text);

            if (Check.toDoActive1 == false)
            {
                Check.IndexToDo(1, true);
                Check.textToDo2.text = textNewToDo.text;

            }
            else if (Check.toDoActive2 == false)
            {
                Check.IndexToDo(2, true);
                Check.textToDo2.text = textNewToDo.text;
            }
            

        }

    }

    


    public void EditToDo()
    {
        editInput.SetActive(true);
        activeeditInput = true;
    }

    public void saveEdit()
    {
        if (inputTextEditToDo.text == "")
        {
            Debug.Log("Данные введены не корректно");
        }
        else
        {

            Debug.Log("Успешно");
            textEditToDo.text = inputTextEditToDo.text;
            editInput.SetActive(false);
            activeeditInput = false;
            Debug.Log(textNewToDo.text);
        }
    }


    public void CancelEditToDo()
    {
        editInput.SetActive(false);
        activeeditInput = false;
    }



    public void OnCheckbox()
    {

    } 
}