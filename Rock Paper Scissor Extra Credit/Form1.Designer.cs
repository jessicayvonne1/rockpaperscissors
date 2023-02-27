
namespace Rock_Paper_Scissor_Extra_Credit
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outcomeOutputLabel = new System.Windows.Forms.Label();
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorButton = new System.Windows.Forms.Button();
            this.computerChoiceOutput = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.myImageList = new System.Windows.Forms.ImageList(this.components);
            this.rockPictureBox = new System.Windows.Forms.PictureBox();
            this.paperPictureBox = new System.Windows.Forms.PictureBox();
            this.scissorPictureBox = new System.Windows.Forms.PictureBox();
            this.computerChoicePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerChoicePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(65, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Choice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(640, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Computer Choice:";
            // 
            // outcomeOutputLabel
            // 
            this.outcomeOutputLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.outcomeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outcomeOutputLabel.Location = new System.Drawing.Point(490, 309);
            this.outcomeOutputLabel.Name = "outcomeOutputLabel";
            this.outcomeOutputLabel.Size = new System.Drawing.Size(469, 90);
            this.outcomeOutputLabel.TabIndex = 2;
            this.outcomeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rockButton
            // 
            this.rockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rockButton.Location = new System.Drawing.Point(69, 96);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(103, 46);
            this.rockButton.TabIndex = 3;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = false;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.paperButton.Location = new System.Drawing.Point(69, 224);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(103, 45);
            this.paperButton.TabIndex = 4;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = false;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // scissorButton
            // 
            this.scissorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.scissorButton.Location = new System.Drawing.Point(69, 356);
            this.scissorButton.Name = "scissorButton";
            this.scissorButton.Size = new System.Drawing.Size(103, 43);
            this.scissorButton.TabIndex = 5;
            this.scissorButton.Text = "Scissors";
            this.scissorButton.UseVisualStyleBackColor = false;
            this.scissorButton.Click += new System.EventHandler(this.scissorButton_Click);
            // 
            // computerChoiceOutput
            // 
            this.computerChoiceOutput.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.computerChoiceOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.computerChoiceOutput.Location = new System.Drawing.Point(704, 59);
            this.computerChoiceOutput.Name = "computerChoiceOutput";
            this.computerChoiceOutput.Size = new System.Drawing.Size(110, 40);
            this.computerChoiceOutput.TabIndex = 6;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitButton.Location = new System.Drawing.Point(512, 463);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(142, 49);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.restartButton.Location = new System.Drawing.Point(259, 463);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(142, 49);
            this.restartButton.TabIndex = 8;
            this.restartButton.Text = "New Game";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // myImageList
            // 
            this.myImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myImageList.ImageStream")));
            this.myImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.myImageList.Images.SetKeyName(0, "paper.jpg");
            this.myImageList.Images.SetKeyName(1, "rock.jpg");
            this.myImageList.Images.SetKeyName(2, "scissors.jpg");
            // 
            // rockPictureBox
            // 
            this.rockPictureBox.Location = new System.Drawing.Point(206, 59);
            this.rockPictureBox.Name = "rockPictureBox";
            this.rockPictureBox.Size = new System.Drawing.Size(155, 122);
            this.rockPictureBox.TabIndex = 9;
            this.rockPictureBox.TabStop = false;
            // 
            // paperPictureBox
            // 
            this.paperPictureBox.Location = new System.Drawing.Point(206, 187);
            this.paperPictureBox.Name = "paperPictureBox";
            this.paperPictureBox.Size = new System.Drawing.Size(155, 122);
            this.paperPictureBox.TabIndex = 10;
            this.paperPictureBox.TabStop = false;
            // 
            // scissorPictureBox
            // 
            this.scissorPictureBox.Location = new System.Drawing.Point(206, 315);
            this.scissorPictureBox.Name = "scissorPictureBox";
            this.scissorPictureBox.Size = new System.Drawing.Size(155, 122);
            this.scissorPictureBox.TabIndex = 11;
            this.scissorPictureBox.TabStop = false;
            // 
            // computerChoicePictureBox
            // 
            this.computerChoicePictureBox.Location = new System.Drawing.Point(681, 116);
            this.computerChoicePictureBox.Name = "computerChoicePictureBox";
            this.computerChoicePictureBox.Size = new System.Drawing.Size(155, 122);
            this.computerChoicePictureBox.TabIndex = 12;
            this.computerChoicePictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.computerChoicePictureBox);
            this.Controls.Add(this.scissorPictureBox);
            this.Controls.Add(this.paperPictureBox);
            this.Controls.Add(this.rockPictureBox);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.computerChoiceOutput);
            this.Controls.Add(this.scissorButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.outcomeOutputLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissor Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerChoicePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label outcomeOutputLabel;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Label computerChoiceOutput;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.ImageList myImageList;
        private System.Windows.Forms.PictureBox rockPictureBox;
        private System.Windows.Forms.PictureBox paperPictureBox;
        private System.Windows.Forms.PictureBox scissorPictureBox;
        private System.Windows.Forms.PictureBox computerChoicePictureBox;
    }
}

