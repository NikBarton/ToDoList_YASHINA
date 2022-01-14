using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkbox : MonoBehaviour
{
    public ToDoActive Check;

    public Text textToDo1;
    public Toggle checkbox1;
    public GameObject buttonedit1;
    public GameObject datatime1;
    public Text datatime11;

    public Text textToDo2;
    public Toggle checkbox2;
    public GameObject buttonedit2;
    public GameObject datatime2;
    public Text datatime22;

    public Text textToDo3;
    public Toggle checkbox3;
    public GameObject buttonedit3;
    public GameObject datatime3;
    public Text datatime33;

    public Text textToDo4;
    public Toggle checkbox4;
    public GameObject buttonedit4;
    public GameObject datatime4;
    public Text datatime44;

    public Text textToDo5;
    public Toggle checkbox5;
    public GameObject buttonedit5;
    public Text datatime55;
    public GameObject datatime5;


    public string data;
        public string time;

    private void Start()
    {
        datatime1.SetActive(false);
        datatime2.SetActive(false);
        datatime3.SetActive(false);
        datatime4.SetActive(false);
        datatime5.SetActive(false);
    }

    private void Update()
    {
        data = System.DateTime.Now.ToShortDateString();
        time = System.DateTime.Now.ToShortTimeString();

    }

    
        public void ActiveCheckbox(int indexCheckbox, bool done) //13. После пометки (клика на checkbox)
    {
        done = true;
        if( done == true) { 
            if (indexCheckbox == 1)
            {
                if (checkbox1.isOn)
                {
                    datatime11.text = data + " " + time;
                    textToDo1.GetComponent<Text>().color = new Color(164 / 255.0f, 152 / 255.0f, 135 / 255.0f); //13.  текст Todo становится серым
                    buttonedit1.SetActive(false); //13.  кнопка редактирования пропадает
                    datatime1.SetActive(true); //13. вместо нее появляется дата и время закрытия (22.11.2022 15:15)

                }
                else //13.  повторный клик на checkbox делает Todo снова активным
                {
                    textToDo1.GetComponent<Text>().color = new Color(46 / 255.0f, 29 / 255.0f, 5 / 255.0f);
                    buttonedit1.SetActive(true); //13. кнопка редактирования появляется на месте даты выполненяи
                    datatime1.SetActive(false);
                }
            }
            if (indexCheckbox == 2)
            {
                if (checkbox2.isOn)
                {
                    datatime22.text = data + " " + time;
                    textToDo2.GetComponent<Text>().color = new Color(164 / 255.0f, 152 / 255.0f, 135 / 255.0f);
                    buttonedit2.SetActive(false);
                    datatime2.SetActive(true);
                }
                else
                {
                    textToDo2.GetComponent<Text>().color = new Color(46 / 255.0f, 29 / 255.0f, 5 / 255.0f);
                    buttonedit2.SetActive(true);
                    datatime2.SetActive(false);
                }
            }
            if (indexCheckbox == 3)
            {
                if (checkbox3.isOn)
                {
                    datatime33.text = data + " " + time;
                    textToDo3.GetComponent<Text>().color = new Color(164 / 255.0f, 152 / 255.0f, 135 / 255.0f);
                    buttonedit3.SetActive(false);
                    datatime3.SetActive(true);
                }
                else
                {
                    textToDo3.GetComponent<Text>().color = new Color(46 / 255.0f, 29 / 255.0f, 5 / 255.0f);
                    buttonedit3.SetActive(true);
                    datatime3.SetActive(false);
                }
            }
            if (indexCheckbox == 4)
            {
                if (checkbox4.isOn)
                {
                    datatime44.text = data + " " + time;
                    textToDo4.GetComponent<Text>().color = new Color(164 / 255.0f, 152 / 255.0f, 135 / 255.0f);
                    buttonedit4.SetActive(false);
                    datatime4.SetActive(true);
                }
                else
                {
                    textToDo4.GetComponent<Text>().color = new Color(46 / 255.0f, 29 / 255.0f, 5 / 255.0f);
                    buttonedit4.SetActive(true);
                    datatime4.SetActive(false);
                }
            }
            if (indexCheckbox == 5)
            {
                if (checkbox5.isOn)
                {
                    datatime55.text = data + " " + time;
                    textToDo5.GetComponent<Text>().color = new Color(164 / 255.0f, 152 / 255.0f, 135 / 255.0f);
                    buttonedit5.SetActive(false);
                    datatime5.SetActive(true);
                }
                else
                {
                    textToDo5.GetComponent<Text>().color = new Color(46 / 255.0f, 29 / 255.0f, 5 / 255.0f);
                    buttonedit5.SetActive(true);
                    datatime5.SetActive(false);
                }
            }
        }
    }
 }

