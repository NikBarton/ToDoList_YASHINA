using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkbox : MonoBehaviour
{
    public Toggle checkbox;
    public Text textToDo1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void activeToggle(int indexCheckbox) {
        if (indexCheckbox == 1)
        {
            if (checkbox.isOn)
            {
                textToDo1.GetComponent<Text>().color = new Color(164 / 255.0f, 164 / 255.0f, 164 / 255.0f);
                Debug.Log("Светло серый");
            }
            else
            {
                textToDo1.GetComponent<Text>().color =new Color(50 / 255.0f, 50 / 255.0f, 50 / 255.0f);
                Debug.Log("Темно серый");
            }
        }

    }
}
