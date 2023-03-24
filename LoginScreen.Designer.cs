namespace W7FormAppTest
{
    partial class LoginScreen
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
            UserInputField = new TextBox();
            UserLabel = new Label();
            PasswordLabel = new Label();
            PasswordInputField = new TextBox();
            SubmitButton = new Button();
            SuspendLayout();
            // 
            // UserInputField
            // 
            UserInputField.Location = new Point(98, 43);
            UserInputField.Name = "UserInputField";
            UserInputField.Size = new Size(181, 23);
            UserInputField.TabIndex = 0;
            UserInputField.TextChanged += UserInputField_TextChanged;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(45, 46);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(47, 15);
            UserLabel.TabIndex = 1;
            UserLabel.Text = "Usuario";
            UserLabel.Click += label1_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(25, 75);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(67, 15);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Contraseña";
            PasswordLabel.Click += label1_Click_1;
            // 
            // PasswordInputField
            // 
            PasswordInputField.Location = new Point(98, 72);
            PasswordInputField.Name = "PasswordInputField";
            PasswordInputField.Size = new Size(181, 23);
            PasswordInputField.TabIndex = 2;
            PasswordInputField.UseSystemPasswordChar = true;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(45, 115);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(198, 27);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "Iniciar Sesión";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 154);
            Controls.Add(SubmitButton);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordInputField);
            Controls.Add(UserLabel);
            Controls.Add(UserInputField);
            Name = "LoginScreen";
            Text = "Iniciar Sesión";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserInputField;
        private Label UserLabel;
        private Label PasswordLabel;
        private TextBox PasswordInputField;
        private Button SubmitButton;
    }
}