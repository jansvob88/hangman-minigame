using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanWinForms
{
	public partial class NewGameForm : Form
	{
		private Game _game;
		private List<string> _wordDatabase;
		private List<string> _newWords;
		private Random _random;
		public NewGameForm(Game game, List<string> wordDatabase, List<string> newWords, Random random)
		{
			InitializeComponent();
			_game = game;
			textBoxWord.Text = "";
			_wordDatabase = wordDatabase;
			_newWords = newWords;
			_random = random;
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			string word = textBoxWord.Text.ToLower();

			if (word.Length == 0)
			{
				labelMessage.Text = "Pole \"Zadej slovo\" nesmí být prázdné.";
			}
			else if (word.Length > 20)
			{
				labelMessage.Text = "Slovo nesmí být delší než 20 znaků.";
			}
			else if (!IsLetterOnly(word))
			{
				labelMessage.Text = "Slovo smí obsahovat pouze písmena.";
			}
			else
			{
				if (!_wordDatabase.Contains(word))
				{
					_wordDatabase.Add(word);
					_newWords.Add(word);
				}
				_game.NewGame(word);
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void btnRandom_Click(object sender, EventArgs e)
		{
			if (_wordDatabase.Count > 0)
			{
				_game.NewGame(_wordDatabase[_random.Next(_wordDatabase.Count)]);
				DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("Databáze neobsahuje žádná slova.");
			}
			Close();
		}

		private void textBoxGuessedWord_Enter(object sender, EventArgs e)
		{
			labelMessage.Text = "";
		}

		private bool IsLetterOnly(string word)
		{
			foreach (char c in word)
			{
				if (!char.IsLetter(c))
					return false;
			}
			return true;
		}
	}
}
