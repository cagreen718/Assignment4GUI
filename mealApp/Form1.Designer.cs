namespace mealApp
{
    partial class frmBurgers
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
            btnVeggie = new Button();
            btnSelectMeal = new Button();
            btnPrime = new Button();
            btnExit = new Button();
            lblHeading = new Label();
            picPrime = new PictureBox();
            picVeggie = new PictureBox();
            lblInstructions = new Label();
            lblConfirmation = new Label();
            ((System.ComponentModel.ISupportInitialize)picPrime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVeggie).BeginInit();
            SuspendLayout();
            // 
            // btnVeggie
            // 
            btnVeggie.Font = new Font("Segoe UI", 9F);
            btnVeggie.Location = new Point(596, 340);
            btnVeggie.Name = "btnVeggie";
            btnVeggie.Size = new Size(128, 35);
            btnVeggie.TabIndex = 0;
            btnVeggie.Text = "Veggie";
            btnVeggie.UseVisualStyleBackColor = true;
            btnVeggie.Click += button1_Click;
            // 
            // btnSelectMeal
            // 
            btnSelectMeal.Font = new Font("Segoe UI", 9F);
            btnSelectMeal.Location = new Point(337, 340);
            btnSelectMeal.Name = "btnSelectMeal";
            btnSelectMeal.Size = new Size(128, 35);
            btnSelectMeal.TabIndex = 1;
            btnSelectMeal.Text = "Select Meal";
            btnSelectMeal.UseVisualStyleBackColor = true;
            btnSelectMeal.Click += btnSelectMeal_Click;
            // 
            // btnPrime
            // 
            btnPrime.Font = new Font("Segoe UI", 9F);
            btnPrime.Location = new Point(59, 340);
            btnPrime.Name = "btnPrime";
            btnPrime.Size = new Size(128, 35);
            btnPrime.TabIndex = 2;
            btnPrime.Text = "Prime Beef";
            btnPrime.UseVisualStyleBackColor = true;
            btnPrime.Click += btnPrime_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10F);
            btnExit.Location = new Point(325, 487);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(128, 35);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit Window";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(276, 23);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(201, 22);
            lblHeading.TabIndex = 4;
            lblHeading.Text = "Farm Burger Specials";
            // 
            // picPrime
            // 
            picPrime.Location = new Point(56, 81);
            picPrime.Name = "picPrime";
            picPrime.Size = new Size(260, 250);
            picPrime.TabIndex = 5;
            picPrime.TabStop = false;
            // 
            // picVeggie
            // 
            picVeggie.Location = new Point(461, 73);
            picVeggie.Name = "picVeggie";
            picVeggie.Size = new Size(260, 250);
            picVeggie.TabIndex = 6;
            picVeggie.TabStop = false;
            picVeggie.Click += picVeggie_Click;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Tahoma", 9F);
            lblInstructions.Location = new Point(173, 394);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(439, 22);
            lblInstructions.TabIndex = 7;
            lblInstructions.Text = "Choose a Burger and then click the Select Meal button";
            // 
            // lblConfirmation
            // 
            lblConfirmation.AutoSize = true;
            lblConfirmation.Font = new Font("Tahoma", 9F);
            lblConfirmation.Location = new Point(261, 430);
            lblConfirmation.Name = "lblConfirmation";
            lblConfirmation.Size = new Size(216, 22);
            lblConfirmation.TabIndex = 8;
            lblConfirmation.Text = "Enjoy your burger special ";
            // 
            // frmBurgers
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 534);
            Controls.Add(lblConfirmation);
            Controls.Add(lblInstructions);
            Controls.Add(picVeggie);
            Controls.Add(picPrime);
            Controls.Add(lblHeading);
            Controls.Add(btnExit);
            Controls.Add(btnPrime);
            Controls.Add(btnSelectMeal);
            Controls.Add(btnVeggie);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "frmBurgers";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picPrime).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVeggie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVeggie;
        private Button btnSelectMeal;
        private Button btnPrime;
        private Button btnExit;
        private Label lblHeading;
        private PictureBox picPrime;
        private PictureBox picVeggie;
        private Label lblInstructions;
        private Label lblConfirmation;
    }
}
