namespace LoginForm
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.pwTextBox = new System.Windows.Forms.TextBox();
			this.idLabel = new System.Windows.Forms.Label();
			this.pwLabel = new System.Windows.Forms.Label();
			this.loginBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// idTextBox
			// 
			this.idTextBox.Location = new System.Drawing.Point(305, 138);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(123, 21);
			this.idTextBox.TabIndex = 0;
			// 
			// pwTextBox
			// 
			this.pwTextBox.Location = new System.Drawing.Point(305, 176);
			this.pwTextBox.Name = "pwTextBox";
			this.pwTextBox.PasswordChar = 'O';
			this.pwTextBox.Size = new System.Drawing.Size(123, 21);
			this.pwTextBox.TabIndex = 1;
			// 
			// idLabel
			// 
			this.idLabel.AutoSize = true;
			this.idLabel.Location = new System.Drawing.Point(256, 143);
			this.idLabel.Name = "idLabel";
			this.idLabel.Size = new System.Drawing.Size(16, 12);
			this.idLabel.TabIndex = 2;
			this.idLabel.Text = "ID";
			// 
			// pwLabel
			// 
			this.pwLabel.AutoSize = true;
			this.pwLabel.Location = new System.Drawing.Point(256, 179);
			this.pwLabel.Name = "pwLabel";
			this.pwLabel.Size = new System.Drawing.Size(23, 12);
			this.pwLabel.TabIndex = 3;
			this.pwLabel.Text = "PW";
			// 
			// loginBtn
			// 
			this.loginBtn.Location = new System.Drawing.Point(447, 136);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(75, 61);
			this.loginBtn.TabIndex = 4;
			this.loginBtn.Text = "Log In";
			this.loginBtn.UseVisualStyleBackColor = true;
			this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("굴림", 20F);
			this.label1.Location = new System.Drawing.Point(264, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 27);
			this.label1.TabIndex = 5;
			this.label1.Text = "This is Login Form";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 299);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.loginBtn);
			this.Controls.Add(this.pwLabel);
			this.Controls.Add(this.idLabel);
			this.Controls.Add(this.pwTextBox);
			this.Controls.Add(this.idTextBox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.TextBox pwTextBox;
		private System.Windows.Forms.Label idLabel;
		private System.Windows.Forms.Label pwLabel;
		private System.Windows.Forms.Button loginBtn;
		private System.Windows.Forms.Label label1;
	}
}

