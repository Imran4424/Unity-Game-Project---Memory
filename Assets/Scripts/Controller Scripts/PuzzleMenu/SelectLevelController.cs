using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLevelController : MonoBehaviour
{
	[SerializeField]
	private GameObject selectPuzzleMenuPanel, selectPuzzleLevelPanel;

	[SerializeField]
	private Animator selectPuzzleMenuAnim, selectPuzzleLevelAnim;

	private string selectedLevel;

}