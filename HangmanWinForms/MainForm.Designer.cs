namespace HangmanWinForms
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnGuess = new Button();
			btnNewGame = new Button();
			listBoxGuessHistory = new ListBox();
			textBoxGuess = new TextBox();
			labelWord = new Label();
			labelGuessHistory = new Label();
			labelGuess = new Label();
			groupBoxHangmanPicture = new GroupBox();
			picBoxDiagonal = new PictureBox();
			picBoxLegRight = new PictureBox();
			picBoxLegLeft = new PictureBox();
			picBoxHandRight = new PictureBox();
			picBoxHandLeft = new PictureBox();
			picBoxBody = new PictureBox();
			picBoxHead = new PictureBox();
			picBoxRope = new PictureBox();
			picBoxHorizontal = new PictureBox();
			picBoxVertical = new PictureBox();
			picBoxGround = new PictureBox();
			labelMessage = new Label();
			labelTriesLeft = new Label();
			labelTriesLeftNumber = new Label();
			groupBoxHangmanPicture.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picBoxDiagonal).BeginInit();
			((System.ComponentModel.ISupportInitialize)picBoxLegRight).BeginInit();
			((System.ComponentModel.ISupportInitialize)picBoxLegLeft).BeginInit();
			((System.ComponentModel.ISupportInitialize)picBoxHandRight).BeginInit();
			((System.ComponentModel.ISupportInitialize)picBoxHandLeft).BeginInit();
			((System.ComponentModel.ISupportInitialize)picBoxBody).BeginInit();
			((System.ComponentModel.ISupportInitialize)picBoxHead).BeginInit();
			((System.ComponentModel.ISupportInitialize)picBoxRope).BeginInit();
			((System.ComponentModel.ISupportInitialize)picBoxHorizontal).BeginInit();
			((System.ComponentModel.ISupportInitialize)picBoxVertical).BeginInit();
			((System.ComponentModel.ISupportInitialize)picBoxGround).BeginInit();
			SuspendLayout();
			// 
			// btnGuess
			// 
			btnGuess.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
			btnGuess.Location = new Point(200, 573);
			btnGuess.Name = "btnGuess";
			btnGuess.Size = new Size(100, 40);
			btnGuess.TabIndex = 0;
			btnGuess.Text = "Hádat";
			btnGuess.UseVisualStyleBackColor = true;
			btnGuess.Click += btnGuess_Click;
			// 
			// btnNewGame
			// 
			btnNewGame.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
			btnNewGame.Location = new Point(179, 680);
			btnNewGame.Name = "btnNewGame";
			btnNewGame.Size = new Size(180, 40);
			btnNewGame.TabIndex = 1;
			btnNewGame.Text = "NOVÁ HRA";
			btnNewGame.UseVisualStyleBackColor = true;
			btnNewGame.Click += btnNewGame_Click;
			// 
			// listBoxGuessHistory
			// 
			listBoxGuessHistory.ColumnWidth = 35;
			listBoxGuessHistory.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
			listBoxGuessHistory.FormattingEnabled = true;
			listBoxGuessHistory.ItemHeight = 25;
			listBoxGuessHistory.Location = new Point(431, 74);
			listBoxGuessHistory.MultiColumn = true;
			listBoxGuessHistory.Name = "listBoxGuessHistory";
			listBoxGuessHistory.RightToLeft = RightToLeft.No;
			listBoxGuessHistory.SelectionMode = SelectionMode.None;
			listBoxGuessHistory.Size = new Size(81, 429);
			listBoxGuessHistory.TabIndex = 3;
			// 
			// textBoxGuess
			// 
			textBoxGuess.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
			textBoxGuess.Location = new Point(147, 575);
			textBoxGuess.Name = "textBoxGuess";
			textBoxGuess.Size = new Size(38, 38);
			textBoxGuess.TabIndex = 4;
			// 
			// labelWord
			// 
			labelWord.BorderStyle = BorderStyle.FixedSingle;
			labelWord.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
			labelWord.Location = new Point(12, 516);
			labelWord.Name = "labelWord";
			labelWord.Size = new Size(500, 40);
			labelWord.TabIndex = 5;
			labelWord.Text = "labelWord";
			labelWord.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// labelGuessHistory
			// 
			labelGuessHistory.AutoSize = true;
			labelGuessHistory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
			labelGuessHistory.Location = new Point(431, 22);
			labelGuessHistory.Name = "labelGuessHistory";
			labelGuessHistory.Size = new Size(81, 40);
			labelGuessHistory.TabIndex = 6;
			labelGuessHistory.Text = "Hádané\r\npísmena:";
			labelGuessHistory.TextAlign = ContentAlignment.TopCenter;
			// 
			// labelGuess
			// 
			labelGuess.AutoSize = true;
			labelGuess.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
			labelGuess.Location = new Point(29, 579);
			labelGuess.Name = "labelGuess";
			labelGuess.Size = new Size(112, 26);
			labelGuess.TabIndex = 7;
			labelGuess.Text = "Písmeno:";
			// 
			// groupBoxHangmanPicture
			// 
			groupBoxHangmanPicture.Controls.Add(picBoxDiagonal);
			groupBoxHangmanPicture.Controls.Add(picBoxLegRight);
			groupBoxHangmanPicture.Controls.Add(picBoxLegLeft);
			groupBoxHangmanPicture.Controls.Add(picBoxHandRight);
			groupBoxHangmanPicture.Controls.Add(picBoxHandLeft);
			groupBoxHangmanPicture.Controls.Add(picBoxBody);
			groupBoxHangmanPicture.Controls.Add(picBoxHead);
			groupBoxHangmanPicture.Controls.Add(picBoxRope);
			groupBoxHangmanPicture.Controls.Add(picBoxHorizontal);
			groupBoxHangmanPicture.Controls.Add(picBoxVertical);
			groupBoxHangmanPicture.Controls.Add(picBoxGround);
			groupBoxHangmanPicture.Location = new Point(12, 12);
			groupBoxHangmanPicture.Name = "groupBoxHangmanPicture";
			groupBoxHangmanPicture.Size = new Size(400, 491);
			groupBoxHangmanPicture.TabIndex = 8;
			groupBoxHangmanPicture.TabStop = false;
			// 
			// picBoxDiagonal
			// 
			picBoxDiagonal.Image = Properties.Resources.diagonal;
			picBoxDiagonal.Location = new Point(136, 104);
			picBoxDiagonal.Name = "picBoxDiagonal";
			picBoxDiagonal.Size = new Size(60, 60);
			picBoxDiagonal.SizeMode = PictureBoxSizeMode.AutoSize;
			picBoxDiagonal.TabIndex = 11;
			picBoxDiagonal.TabStop = false;
			// 
			// picBoxLegRight
			// 
			picBoxLegRight.Image = Properties.Resources.leg_right;
			picBoxLegRight.Location = new Point(268, 285);
			picBoxLegRight.Name = "picBoxLegRight";
			picBoxLegRight.Size = new Size(40, 80);
			picBoxLegRight.SizeMode = PictureBoxSizeMode.AutoSize;
			picBoxLegRight.TabIndex = 10;
			picBoxLegRight.TabStop = false;
			// 
			// picBoxLegLeft
			// 
			picBoxLegLeft.Image = Properties.Resources.leg_left;
			picBoxLegLeft.Location = new Point(225, 285);
			picBoxLegLeft.Name = "picBoxLegLeft";
			picBoxLegLeft.Size = new Size(40, 80);
			picBoxLegLeft.SizeMode = PictureBoxSizeMode.AutoSize;
			picBoxLegLeft.TabIndex = 9;
			picBoxLegLeft.TabStop = false;
			// 
			// picBoxHandRight
			// 
			picBoxHandRight.Image = Properties.Resources.hand_right;
			picBoxHandRight.Location = new Point(270, 215);
			picBoxHandRight.Name = "picBoxHandRight";
			picBoxHandRight.Size = new Size(30, 60);
			picBoxHandRight.SizeMode = PictureBoxSizeMode.AutoSize;
			picBoxHandRight.TabIndex = 8;
			picBoxHandRight.TabStop = false;
			// 
			// picBoxHandLeft
			// 
			picBoxHandLeft.Image = Properties.Resources.hand_left;
			picBoxHandLeft.Location = new Point(235, 215);
			picBoxHandLeft.Name = "picBoxHandLeft";
			picBoxHandLeft.Size = new Size(30, 60);
			picBoxHandLeft.SizeMode = PictureBoxSizeMode.AutoSize;
			picBoxHandLeft.TabIndex = 7;
			picBoxHandLeft.TabStop = false;
			// 
			// picBoxBody
			// 
			picBoxBody.Image = Properties.Resources.body;
			picBoxBody.Location = new Point(265, 193);
			picBoxBody.Name = "picBoxBody";
			picBoxBody.Size = new Size(5, 100);
			picBoxBody.SizeMode = PictureBoxSizeMode.AutoSize;
			picBoxBody.TabIndex = 6;
			picBoxBody.TabStop = false;
			// 
			// picBoxHead
			// 
			picBoxHead.Image = Properties.Resources.head;
			picBoxHead.Location = new Point(248, 158);
			picBoxHead.Name = "picBoxHead";
			picBoxHead.Size = new Size(40, 40);
			picBoxHead.SizeMode = PictureBoxSizeMode.AutoSize;
			picBoxHead.TabIndex = 5;
			picBoxHead.TabStop = false;
			// 
			// picBoxRope
			// 
			picBoxRope.Image = Properties.Resources.rope;
			picBoxRope.Location = new Point(263, 104);
			picBoxRope.Name = "picBoxRope";
			picBoxRope.Size = new Size(10, 60);
			picBoxRope.SizeMode = PictureBoxSizeMode.AutoSize;
			picBoxRope.TabIndex = 4;
			picBoxRope.TabStop = false;
			// 
			// picBoxHorizontal
			// 
			picBoxHorizontal.Image = Properties.Resources.horizontal;
			picBoxHorizontal.Location = new Point(97, 84);
			picBoxHorizontal.Name = "picBoxHorizontal";
			picBoxHorizontal.Size = new Size(200, 20);
			picBoxHorizontal.SizeMode = PictureBoxSizeMode.AutoSize;
			picBoxHorizontal.TabIndex = 2;
			picBoxHorizontal.TabStop = false;
			// 
			// picBoxVertical
			// 
			picBoxVertical.Image = Properties.Resources.vertical;
			picBoxVertical.Location = new Point(116, 63);
			picBoxVertical.Name = "picBoxVertical";
			picBoxVertical.Size = new Size(20, 350);
			picBoxVertical.SizeMode = PictureBoxSizeMode.AutoSize;
			picBoxVertical.TabIndex = 1;
			picBoxVertical.TabStop = false;
			// 
			// picBoxGround
			// 
			picBoxGround.Image = Properties.Resources.ground;
			picBoxGround.Location = new Point(107, 410);
			picBoxGround.Name = "picBoxGround";
			picBoxGround.Size = new Size(200, 20);
			picBoxGround.SizeMode = PictureBoxSizeMode.AutoSize;
			picBoxGround.TabIndex = 0;
			picBoxGround.TabStop = false;
			// 
			// labelMessage
			// 
			labelMessage.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 238);
			labelMessage.Location = new Point(12, 628);
			labelMessage.Name = "labelMessage";
			labelMessage.Size = new Size(500, 40);
			labelMessage.TabIndex = 9;
			labelMessage.Text = "labelMessage";
			labelMessage.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// labelTriesLeft
			// 
			labelTriesLeft.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
			labelTriesLeft.Location = new Point(380, 573);
			labelTriesLeft.Name = "labelTriesLeft";
			labelTriesLeft.Size = new Size(65, 40);
			labelTriesLeft.TabIndex = 10;
			labelTriesLeft.Text = "Zbývá pokusů:";
			// 
			// labelTriesLeftNumber
			// 
			labelTriesLeftNumber.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
			labelTriesLeftNumber.ForeColor = Color.FromArgb(192, 0, 0);
			labelTriesLeftNumber.Location = new Point(451, 573);
			labelTriesLeftNumber.Name = "labelTriesLeftNumber";
			labelTriesLeftNumber.Size = new Size(45, 40);
			labelTriesLeftNumber.TabIndex = 11;
			labelTriesLeftNumber.Text = "10";
			labelTriesLeftNumber.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(521, 732);
			Controls.Add(labelTriesLeftNumber);
			Controls.Add(labelTriesLeft);
			Controls.Add(labelMessage);
			Controls.Add(groupBoxHangmanPicture);
			Controls.Add(labelGuess);
			Controls.Add(labelGuessHistory);
			Controls.Add(labelWord);
			Controls.Add(textBoxGuess);
			Controls.Add(listBoxGuessHistory);
			Controls.Add(btnNewGame);
			Controls.Add(btnGuess);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			MaximizeBox = false;
			Name = "MainForm";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Oběšenec";
			FormClosing += MainForm_FormClosing;
			groupBoxHangmanPicture.ResumeLayout(false);
			groupBoxHangmanPicture.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picBoxDiagonal).EndInit();
			((System.ComponentModel.ISupportInitialize)picBoxLegRight).EndInit();
			((System.ComponentModel.ISupportInitialize)picBoxLegLeft).EndInit();
			((System.ComponentModel.ISupportInitialize)picBoxHandRight).EndInit();
			((System.ComponentModel.ISupportInitialize)picBoxHandLeft).EndInit();
			((System.ComponentModel.ISupportInitialize)picBoxBody).EndInit();
			((System.ComponentModel.ISupportInitialize)picBoxHead).EndInit();
			((System.ComponentModel.ISupportInitialize)picBoxRope).EndInit();
			((System.ComponentModel.ISupportInitialize)picBoxHorizontal).EndInit();
			((System.ComponentModel.ISupportInitialize)picBoxVertical).EndInit();
			((System.ComponentModel.ISupportInitialize)picBoxGround).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnGuess;
		private Button btnNewGame;
		private ListBox listBoxGuessHistory;
		private TextBox textBoxGuess;
		private Label labelWord;
		private Label labelGuessHistory;
		private Label labelGuess;
		private GroupBox groupBoxHangmanPicture;
		private PictureBox picBoxGround;
		private PictureBox picBoxVertical;
		private PictureBox picBoxHorizontal;
		private PictureBox picBoxRope;
		private PictureBox picBoxHead;
		private PictureBox picBoxBody;
		private PictureBox picBoxHandLeft;
		private PictureBox picBoxHandRight;
		private PictureBox picBoxLegLeft;
		private PictureBox picBoxLegRight;
		private PictureBox picBoxDiagonal;
		private Label labelMessage;
		private Label labelTriesLeft;
		private Label labelTriesLeftNumber;
	}
}
