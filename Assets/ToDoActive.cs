using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToDoActive : MonoBehaviour //5. После создания появляется блок с текстом, кнопкой удалить (Delete или x), кнопкой редактировать (Edit) и checkbox для пометки выполнено
{
    public GameObject ToDo1;
    public Text textToDo1;
    public bool toDoActive1 = false;

    public GameObject ToDo2;
    public Text textToDo2;
    public bool toDoActive2 = false;

    public GameObject ToDo3;
    public Text textToDo3;
    public bool toDoActive3 = false;

    public GameObject ToDo4;
    public Text textToDo4;
    public bool toDoActive4 = false;

    public GameObject ToDo5;
    public Text textToDo5;
    public bool toDoActive5 = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        ToDo1.SetActive(toDoActive1);
        ToDo2.SetActive(toDoActive2);
        ToDo3.SetActive(toDoActive3);
        ToDo4.SetActive(toDoActive4);
        ToDo5.SetActive(toDoActive5);

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
        if (index == 3)
        {
            toDoActive3 = activ;
        }
        if (index == 4)
        {
            toDoActive4 = activ;
        }
        if (index == 5)
        {
            toDoActive5 = activ;
        }

    }

    public void TextToDo(int index, string text)
    {

        if (index == 1)
        {
            textToDo1.text = text;
        }
        if (index == 2)
        {
            textToDo2.text = text;
        }
        if (index == 3)
        {
            textToDo3.text = text;
        }
        if (index == 4)
        {
            textToDo4.text = text;
        }
        if (index == 5)
        {
            textToDo5.text = text;
        }


    }

}
