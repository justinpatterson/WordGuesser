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
        foreach (string s in allWords) _availableWords.Add(s);

	}

	public void GenerateWordList()
	{
		//read a list of words from a text file
		//set allWords to that list
	}

	public List<string> GetWordOptions(int optionCount)
	{
        List<string> returnwords = new List<string>();
        //gather words based on option count
        for (int i = 0; i < optionCount; i++) {
            if (_availableWords.Count > 0) {
                int randomword = Random.Range(0, _availableWords.Count);
                returnwords.Add(_availableWords[randomword]);
                _usedWords.Add(_availableWords[randomword]);
                _availableWords.RemoveAt(randomword);
            }
        }
        return returnwords;
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
