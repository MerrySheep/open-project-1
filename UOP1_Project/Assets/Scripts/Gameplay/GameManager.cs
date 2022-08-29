using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{

	//Adding extra ; 

	public enum InteractionType { None = 0, PickUp, Cook, Talk };

	public enum SelectionType
	{
	Questline,
	Quest,
	Step,
	Dialogue,



	}

	//End of tesrt

	[SerializeField] private QuestManagerSO _questManager = default;
	[SerializeField] private GameStateSO _gameState = default;

@@ -17,7 +36,37 @@ public class GameManager : MonoBehaviour
	[SerializeField] private VoidEventChannelSO _addRockCandyRecipeEvent = default;
	[SerializeField] private VoidEventChannelSO _cerisesMemoryEvent = default;
	[SerializeField] private VoidEventChannelSO _decideOnDishesEvent = default;


	//SA1203: ConstantsMustAppearBeforeFields
	//SA1401FieldsMustBePrivate

	public var number = 10;
	public const day = "Monday";

	//SA1313ParameterNamesMustBeginWithLowerCaseLetter

	private int TestInt(int Number) {

	return Number;

	}


	///SA1503BracesMustNotBeOmitted
	private int Test2() {
	var value;
	if (true) 
    	value = 2;       




    	return value;
	}



	private void Start()
	{
		StartGame();
@@ -59,5 +108,11 @@ void StartGame()
	{
		_gameState.UpdateGameState(GameState.Gameplay);
		_questManager.StartGame();



	}

	//Adding a few blank lines to trigger CodeFactor

}
