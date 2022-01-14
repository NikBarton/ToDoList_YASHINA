using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteToDo : MonoBehaviour {

	public GameObject planeDelete;
	public GameObject textRecovery;
	public ToDoActive Check;
	public GameObject toDo;
    public int indexToDo;
    

	public float timerStart = 10;
	public Text sec;
	public int indexUndo;


	// Use this for initialization
	void Start () {
		planeDelete.SetActive(false);
		textRecovery.SetActive(false);
		

	}

	// Update is called once per frame
	void Update () {
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
		planeDelete.SetActive(true);
		indexToDo = index;

	}

	public void canselDelete()
	{
		planeDelete.SetActive(false);
	}

	public void DeleteOk()
	{
		Check.IndexToDo(indexToDo, false);
		textRecovery.SetActive(true);
		timerStart = 10;
		planeDelete.SetActive(false);
		indexUndo = indexToDo;
		Debug.Log("Удаление ToDo");
		
	}

	public void Undo()
	{
		Check.IndexToDo(indexUndo, true);
		textRecovery.SetActive(false);
	}
		
	
}
