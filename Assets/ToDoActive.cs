﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToDoActive : MonoBehaviour
{
    public GameObject ToDo1;
    public Text textToDo1;
    public bool toDoActive1 = false;

    public GameObject ToDo2;
    public Text textToDo2;
    public bool toDoActive2 = false;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 

        ToDo1.SetActive(toDoActive1);
        ToDo2.SetActive(toDoActive2);
       
    }

    public void IndexToDo(int index, bool activ)
    {
        if (index == 1)
        {
            toDoActive1 = activ;
        }
        if (index == 2)
        {
            toDoActive2 = activ;
        }

    }
}