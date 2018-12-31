using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordListController : MonoBehaviour {
	public List<string> allWords = new List<string>();
	List<string> _availableWords = new List<string>();
	List<string> _usedWords = new List<string>();
	string _currentWord;

	void Awake()
	{	
		_availableWords = allWords;
	}

	public void GenerateWordList()
	{
		//read a list of words from a text file
		//set allWords to that list
	}

	List<string> GetWordOptions(int optionCount)
	{
		//gather words based on option count
		return new List<string>();
	}

	void SelectWord(string inputWord)
	{
		//remove it from available words
		//add it to used words
		//set _currentWord
	}

	 public string GetCurrentWord()
	{
		return _currentWord;	
	}

}
