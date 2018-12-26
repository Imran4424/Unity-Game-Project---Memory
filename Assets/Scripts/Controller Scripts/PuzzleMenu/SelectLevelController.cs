using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLevelController : MonoBehaviour
{
	[SerializeField]
	private GameObject selectPuzzleMenuPanel, selectPuzzleLevelPanel;

	[SerializeField]
	private Animator selectPuzzleMenuAnim, selectPuzzleLevelAnim;

	private string selectedPuzzle;

	public void BackButtonClicked ()
	{
		StartCoroutine (BackToPuzzleSelectMenu ());
	}

	IEnumerator BackToPuzzleSelectMenu ()
	{
		selectPuzzleMenuPanel.SetActive (true);

		selectPuzzleLevelAnim.Play ("SlideOut");
		yield return new WaitForSeconds (0.2f);
		selectPuzzleMenuAnim.Play ("SlideIn");

		yield return new WaitForSeconds (1f);

		selectPuzzleLevelPanel.SetActive (false);
	}
}