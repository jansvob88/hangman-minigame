using System;
using System.ComponentModel;

namespace HangmanWinForms
{
	public partial class MainForm : Form
	{
		public const string _fileName = "wordDatabase.txt";
		private List<string> _wordDatabase;
		private List<string> _newWords;
		private Random _random;
		private Game _game;

		public MainForm()
		{
			InitializeComponent();
			labelWord.Text = "";
			labelMessage.Text = "";
			labelTriesLeftNumber.Text = "0";
			ToggleControls(false);

			_game = new Game();
			listBoxGuessHistory.DataSource = _game.GuessHistory;

			_random = new Random();
			_newWords = new List<string>();
			_wordDatabase = new List<string>();
			try
			{
				DataManager.LoadTxt(_fileName, _wordDatabase);
			}
			catch
			{
				MessageBox.Show($"Nepodaøilo se naèíst databázi slov. Ve složce chybí soubor \"{_fileName}\"", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnNewGame_Click(object sender, EventArgs e)
		{
			NewGameForm form = new NewGameForm(_game, _wordDatabase, _newWords, _random);
			if (form.ShowDialog() == DialogResult.OK)
			{
				ToggleControls(true);
				HideHangman();
				labelWord.ForeColor = Color.Black;
				labelWord.Text = WordDisplay(_game.GuessingWord);
				labelTriesLeftNumber.Text = _game.TriesLeft.ToString();
			}
		}

		private void HideHangman()
		{
			foreach (Control item in groupBoxHangmanPicture.Controls)
			{
				((PictureBox)item).Visible = false;
			}
			picBoxGround.Visible = true;
		}

		private void btnGuess_Click(object sender, EventArgs e)
		{
			labelMessage.ForeColor = Color.Red;
			string letter = textBoxGuess.Text;

			if (letter.Length < 1)
				labelMessage.Text = "Musíš zadat písmeno k hádání.";

			else if (letter.Length > 1)
				labelMessage.Text = "Nemùžeš hádat více písmen najednou.";

			else if (!char.IsLetter(letter.ToCharArray()[0]))
				labelMessage.Text = $"{textBoxGuess.Text} není písmeno.";

			else
			{
				GuessResult result = _game.GuessLetter(letter);
				if (result == GuessResult.Correct)
					labelMessage.ForeColor = Color.Green;

				labelMessage.Text = _game.ResultMessages[result];
				labelWord.Text = WordDisplay(_game.GuessingWord);

				if (result == GuessResult.Incorrect)
				{
					SelectPictureBox(_game.TriesLeft).Visible = true;
					labelTriesLeftNumber.Text = _game.TriesLeft.ToString();
				}
			}

			textBoxGuess.Text = "";
			textBoxGuess.Focus();

			if (_game.IsWon)
			{
				ToggleControls(false);
				labelWord.ForeColor = Color.Green;
				labelMessage.ForeColor = Color.Green;
				labelMessage.Text = "Vyhrál jsi!";
			}

			if (_game.TriesLeft == 0)
			{
				ToggleControls(false);
				labelMessage.Text = "Prohrál jsi!";
				labelWord.ForeColor = Color.Red;
				labelWord.Text = WordDisplay(_game.Word);
			}
		}

		private PictureBox SelectPictureBox(int triesLeft)
		{
			switch (triesLeft)
			{
				case 9:
					return picBoxVertical;
				case 8:
					return picBoxHorizontal;
				case 7:
					return picBoxDiagonal;
				case 6:
					return picBoxRope;
				case 5:
					return picBoxHead;
				case 4:
					return picBoxBody;
				case 3:
					return picBoxHandLeft;
				case 2:
					return picBoxHandRight;
				case 1:
					return picBoxLegLeft;
				case 0:
					return picBoxLegRight;
				default:
					return null;
			}
		}

		private void ToggleControls(bool boolean)
		{
			btnGuess.Enabled = boolean;
			textBoxGuess.Enabled = boolean;
		}

		private string WordDisplay(string word)
		{
			string str = "";
			for (int i = 0; i < word.Length; i++)
				str += word[i] + " ";
			if (word.Length > 0)
				str = str.Remove(str.Length - 1);
			return str.ToUpper();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_newWords.Count > 0)
				DataManager.AppendTxt(_fileName, _newWords);
		}
	}
}
