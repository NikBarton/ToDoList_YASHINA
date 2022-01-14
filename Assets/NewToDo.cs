using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewToDo : MonoBehaviour
{
    public ToDoActive Check;

    public GameObject NewTodoVvod; //2. Есть кнопка "Создать Todo"
    public bool OnNewTodoVvod; //1. Есть область ввода нового Todo


    public Text inputTextNewToDo;

    public bool activeEditInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        NewTodoVvod.SetActive(OnNewTodoVvod);
        if (OnNewTodoVvod == true || activeEditInput == true)
        {
            if (Input.GetKeyDown(KeyCode.Return)) //3. Создание Todo возможно при нажатии на Enter
            {
                if (inputTextNewToDo.text == "" || inputTextNewToDo.text.Length < 2)
                {
                    Debug.Log("Данные введены не корректно"); //4. Создать можно только если Todo не пустое и длина больше 1 символа.
                }
                else
                {

                    Debug.Log("Успешно");
                    OnNewTodoVvod = false;

                    if (Check.toDoActive1 == false)
                    {
                        Check.IndexToDo(1, true);
                        Check.TextToDo(1, inputTextNewToDo.text);

                    }
                    else if (Check.toDoActive2 == false)
                    {
                        Check.IndexToDo(2, true);
                        Check.TextToDo(2, inputTextNewToDo.text);
                    }
                    else if (Check.toDoActive3 == false)
                    {
                        Check.IndexToDo(3, true);
                        Check.TextToDo(3, inputTextNewToDo.text);
                    }
                    else if (Check.toDoActive4 == false)
                    {
                        Check.IndexToDo(4, true);
                        Check.TextToDo(4, inputTextNewToDo.text);
                    }
                    else if (Check.toDoActive5 == false)
                    {
                        Check.IndexToDo(5, true);
                        Check.TextToDo(5, inputTextNewToDo.text);
                    }



                }
            }
        }
    }
    public void planeActive()
    {
        OnNewTodoVvod = true;
    }


    public void newTodo() //3. Создание Todo возможно при клике на кнопку "Создать Todo"
    {
        inputTextNewToDo.text = "";
        
        if (inputTextNewToDo.text == "")
        {
            Debug.Log("Данные введены не корректно"); //4. Создать можно только если Todo не пустое и длина больше 1 символа.
        }
        else
        {

            Debug.Log("Успешно");
            OnNewTodoVvod = false;

            if (Check.toDoActive1 == false)
            {
                Check.IndexToDo(1, true);
                Check.TextToDo(1, inputTextNewToDo.text);

            }
            else if (Check.toDoActive2 == false)
            {
                Check.IndexToDo(2, true);
                Check.TextToDo(2, inputTextNewToDo.text);
            }
            else if (Check.toDoActive3 == false)
            {
                Check.IndexToDo(3, true);
                Check.TextToDo(3, inputTextNewToDo.text);
            }
            else if (Check.toDoActive4 == false)
            {
                Check.IndexToDo(4, true);
                Check.TextToDo(4, inputTextNewToDo.text);
            }
            else if (Check.toDoActive5 == false)
            {
                Check.IndexToDo(5, true);
                Check.TextToDo(5, inputTextNewToDo.text);
            }


        }

    }

}
