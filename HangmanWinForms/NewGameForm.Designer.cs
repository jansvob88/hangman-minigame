namespace HangmanWinForms
{
	partial class NewGameForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBoxWord = new TextBox();
			labelGuessWord = new Label();
			btnCreate = new Button();
			btnRandom = new Button();
			labelMessage = new Label();
			SuspendLayout();
			// 
			// textBoxWord
			// 
			textBoxWord.Font = new Font("Segoe UI", 16F);
			textBoxWord.Location = new Point(159, 26);
			textBoxWord.Name = "textBoxWord";
			textBoxWord.Size = new Size(486, 36);
			textBoxWord.TabIndex = 0;
			textBoxWord.Enter += textBoxGuessedWord_Enter;
			// 
			// labelGuessWord
			// 
			labelGuessWord.AutoSize = true;
			labelGuessWord.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
			labelGuessWord.Location = new Point(12, 33);
			labelGuessWord.Name = "labelGuessWord";
			labelGuessWord.Size = new Size(141, 26);
			labelGuessWord.TabIndex = 1;
			labelGuessWord.Text = "Zadej slovo:";
			// 
			// btnCreate
			// 
			btnCreate.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
			btnCreate.Location = new Point(12, 132);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(200, 40);
			btnCreate.TabIndex = 2;
			btnCreate.Text = "ZAHÁJIT HRU";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// btnRandom
			// 
			btnRandom.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
			btnRandom.Location = new Point(276, 132);
			btnRandom.Name = "btnRandom";
			btnRandom.Size = new Size(369, 40);
			btnRandom.TabIndex = 3;
			btnRandom.Text = "VYBRAT NÁHODNÉ SLOVO";
			btnRandom.UseVisualStyleBackColor = true;
			btnRandom.Click += btnRandom_Click;
			// 
			// labelMessage
			// 
			labelMessage.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 238);
			labelMessage.ForeColor = Color.Red;
			labelMessage.Location = new Point(12, 78);
			labelMessage.Name = "labelMessage";
			labelMessage.Size = new Size(633, 41);
			labelMessage.TabIndex = 4;
			labelMessage.Text = "Pole zadej slovo nesmí být prázdné.";
			labelMessage.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// NewGameForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(657, 184);
			Controls.Add(labelMessage);
			Controls.Add(btnRandom);
			Controls.Add(btnCreate);
			Controls.Add(labelGuessWord);
			Controls.Add(textBoxWord);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "NewGameForm";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Nová hra";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBoxWord;
		private Label labelGuessWord;
		private Button btnCreate;
		private Button btnRandom;
		private Label labelMessage;
	}
}