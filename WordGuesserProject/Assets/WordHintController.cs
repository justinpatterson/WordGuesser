using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordHintController : MonoBehaviour {

	char[] _currentWordCharacters_REAL;
	char[] _currentWordCharacters_HINT;

	public enum HintPhases {blank, showCount, showLetters }
	HintPhases _currentHintPhase = HintPhases.blank;

	float countdownToNextHint = 10f;

	public void TriggerNewWord(string word)
	{
		_currentWordCharacters_REAL = word.ToCharArray();
		_currentWordCharacters_HINT = new char[ _currentWordCharacters_REAL.Length ];
		_currentHintPhase = HintPhases.blank;
	}

	public void TriggerUpdateHintController()
	{
		//reduce countdown to next hint
		//if countdown is to 0, trigger next hint ( TriggerHint() )
	}
	void TriggerHint()
	{
		if(_currentHintPhase == HintPhases.blank)
		{
			_currentHintPhase = HintPhases.showCount;
		}
		else if(_currentHintPhase == HintPhases.showCount)
		{
			for(int charIndex = 0; charIndex < _currentWordCharacters_HINT.Length; charIndex++)
			{
				_currentWordCharacters_HINT[charIndex] = '_';
			}
			_currentHintPhase = HintPhases.showLetters;
		}
		else if(_currentHintPhase == HintPhases.showLetters)
		{
			
		}

		countdownToNextHint = 10f;
	}

	string GetCurrentHintCharacters()
	{
		return _currentWordCharacters_REAL.ToString();
	}

}
