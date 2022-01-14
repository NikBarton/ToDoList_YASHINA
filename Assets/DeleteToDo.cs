using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteToDo : MonoBehaviour //5. После создания появляется блок с кнопкой удалить
{
    public GameObject planeDelete;

    public GameObject textRecovery;

    public ToDoActive Check;

    public int indexToDo;

    public Checkbox Done;
    

    public float timerStart = 10;
    public Text sec;
    public int indexUndo;
    // Start is called before the first frame update
    void Start()
    {
        planeDelete.SetActive(false);
        textRecovery.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        sec.text = timerStart.ToString();
        timerStart -= Time.deltaTime;
        sec.text = Mathf.Round(timerStart).ToString();

        if (timerStart <= 0.0)
        {
            textRecovery.SetActive(false);
        }

    }

    public void activePlaneDelete(int index)
    {
        planeDelete.SetActive(true); //6. При нажатии на кнопку удалить появляется всплывающее окно с вопрос "подтвердите удаление" и кнопками Ок/Cancel
        indexToDo = index;

    }

    public void canselDelete()
    {
        planeDelete.SetActive(false); //7. Cancel только закрывает окно
    }

    public void DeleteOk()
    {
        Check.IndexToDo(indexToDo, false);
        textRecovery.SetActive(true); //8. После удаления Todo в интерфейсе появляется сообщение об восстановлении последнего удаленного Todo с кнопкой - "Хотите отменить удаление кликните - Undo
        timerStart = 10; //8. сообщение видно 10 секунд, таймер показывается вместо текста $countdown
        planeDelete.SetActive(false); //9. Через 10 секунд сообщение об отмене пропадает
        indexUndo = indexToDo;
        Debug.Log("Удаление ToDo");
        Done.ActiveCheckbox(indexToDo,false); //7. Ок - удаляет Todo, Cancel только закрывает окно

    }
    public void Undo()
    {
        Check.IndexToDo(indexUndo, true);
        textRecovery.SetActive(false);
    }
}
