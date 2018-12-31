using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public enum GamePhases { init, startGame, selectWord, guessWord, endGame }
	GamePhases _currentPhase = GamePhases.init;

	public WordHintController myWordHintController;
	public WordListController myWordListController;

	void Awake()
	{
		TriggerPhaseTransition(GamePhases.init);
	}
	void Start()
	{
		TriggerPhaseTransition(GamePhases.startGame);
	}
	void Update()
	{
		UpdateCurrentPhase();
	}

	public void TriggerPhaseTransition( GamePhases nextPhase )
	{
		EndCurrentPhase();
		_currentPhase = nextPhase;
		StartCurrentPhase();
	}


	void StartCurrentPhase()
	{
		if(_currentPhase == GamePhases.init)
		{
			myWordListController.GenerateWordList();
		}
		else if(_currentPhase == GamePhases.startGame){}
		else if(_currentPhase == GamePhases.selectWord){}
		else if(_currentPhase == GamePhases.guessWord)
		{
			myWordHintController.TriggerNewWord( myWordListController.GetCurrentWord() );
		}
		else if(_currentPhase == GamePhases.endGame){}
	}
	void UpdateCurrentPhase()
	{
		if(_currentPhase == GamePhases.init){}
		else if(_currentPhase == GamePhases.startGame){}
		else if(_currentPhase == GamePhases.selectWord){}
		else if(_currentPhase == GamePhases.guessWord)
		{
			myWordHintController.TriggerUpdateHintController();
			//update the ui here for showing the current word status
			//let the main player draw a pixel art if we get to that point
		}
		else if(_currentPhase == GamePhases.endGame){}
	}
	void EndCurrentPhase()
	{
		if(_currentPhase == GamePhases.init){}
		else if(_currentPhase == GamePhases.startGame){}
		else if(_currentPhase == GamePhases.selectWord){}
		else if(_currentPhase == GamePhases.guessWord){}
		else if(_currentPhase == GamePhases.endGame){}
	}
}
