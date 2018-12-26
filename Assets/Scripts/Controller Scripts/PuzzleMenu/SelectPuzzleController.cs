using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPuzzleController : MonoBehaviour 
{
	[SerializeField]
	private GameObject selectPuzzleMenuPanel, selectPuzzleLevelPanel;

	[SerializeField]
	private Animator selectPuzzleMenuAnim, selectPuzzleLevelAnim;

	private string selectedPuzzle;

	public void SelectedPuzzle()
	{
		selectedPuzzle = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

		StartCoroutine(ShowPuzzleLevelSelectMenu());
	}

	IEnumerator ShowPuzzleLevelSelectMenu()
	{
		selectPuzzleLevelPanel.SetActive(true);
		selectPuzzleMenuAnim.Play("SlideOut");
		yield return new WaitForSeconds(0.2f);
		selectPuzzleLevelAnim.Play("SlideIn");

		yield return new WaitForSeconds(1f);
		selectPuzzleMenuPanel.SetActive(false);
	}	
}
