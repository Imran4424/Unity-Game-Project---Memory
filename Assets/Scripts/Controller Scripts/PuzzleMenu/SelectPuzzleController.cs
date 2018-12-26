using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPuzzleController : MonoBehaviour 
{
	[SerializeField]
	private GameObject selectPuzzleMenuPanel, selectPuzzleLevel;

	[SerializeField]
	private Animator selectPuzzleMenuAnim, selectPuzzleLevelAnim;

	private string selectedPuzzle;

	public void SelectedPuzzle()
	{
		selectedPuzzle = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

		Debug.Log(selectedPuzzle);
	}	
}
