using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanWinForms
{
	public enum GuessResult { Guessed, Correct, Incorrect}

	public class Game
	{
		public Dictionary<GuessResult, string> ResultMessages = new Dictionary<GuessResult, string>
		{
			[GuessResult.Guessed] = "Toto písmeno jsi již hádal.",
			[GuessResult.Correct] = "Výborně! Správný tip.",
			[GuessResult.Incorrect] = "Špatný tip!"
		};
		public BindingList<string> GuessHistory { get; }
		private Random _random;

		public string Word { get; private set; }
		public string GuessingWord { get; private set; }
		public byte TriesLeft { get; private set; }
		public bool IsWon { get { return GuessingWord == Word; } }

		public Game()
		{
			_random = new Random();
			GuessHistory = new BindingList<string>();
			TriesLeft = 10;
			Word = "";
			GuessingWord = "";
		}

		public void NewGame(string word)
		{
			GuessHistory.Clear();
			TriesLeft = 10;
			Word = word.ToLower();
			GuessingWord = "";
			for (int i = 0; i < Word.Length; i++)
				GuessingWord += "_";
		}

		public GuessResult GuessLetter(string letter)
		{
			letter = letter.ToUpper();

			if (GuessHistory.Contains(letter))
				return GuessResult.Guessed;
			GuessHistory.Add(letter);

			letter = letter.ToLower();

			if (Word.Contains(letter))
			{
				for (int i = 0; i < Word.Length; i++)
				{
					if (Word[i].ToString() == letter)
						GuessingWord = GuessingWord.Remove(i, 1).Insert(i, letter);
				}
				return GuessResult.Correct;
			}

			TriesLeft--;
			return GuessResult.Incorrect;
		}
	}
}
