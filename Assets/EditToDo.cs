using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditToDo : MonoBehaviour
{
    public ToDoActive Check;
    public GameObject editInput;
    public bool activeeditInput = false;

    public Text inputTextEditToDo;
    public int indexEditToDo;

    // Start is called before the first frame update
    void Start()
    {
        editInput.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void editToDo(int index) //11. Редактирование Todo возможно при клике на кнопку Edit - открывает отдельное окно или всплывающее окно с двумя кнопками - Ok/Cancel
    {
        editInput.SetActive(true);
        activeeditInput = true;
        indexEditToDo = index;
    }

    public void saveEdit()
    {
        if (inputTextEditToDo.text == ""|| inputTextEditToDo.text.Length < 2) //11. условия редактирование такие же как и создания - поле не пустое, длина текста больше одного символа
        {
            Debug.Log("Данные введены не корректно");
        }
        else
        {
            Check.IndexToDo(indexEditToDo, true);
            Check.TextToDo(indexEditToDo, inputTextEditToDo.text);
            editInput.SetActive(false);
            activeeditInput = false; //12. Ok редактирует поле
        }
    }


    public void CancelEditToDo()
    {
        editInput.SetActive(false);
        activeeditInput = false; //12. Cancel закрывает окно.
    }
}
