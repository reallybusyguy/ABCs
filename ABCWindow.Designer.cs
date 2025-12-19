



namespace ABCs
{
    partial class ABCWindow
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

            DisposePlayers();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();

            // Aspects of a button
            Color color = Color.FromArgb(255, 192, 192);
            Font font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            int width = 120;
            int height = 90;
            int margin = 2;
            Size size = new Size(width, height);

            Point rootLocation = new Point(80, 40);
            Size horizDistance = new Size(width + margin, 0);
            Size vertDistance = new Size(0, height + margin);

            // Row 1 of buttons
            button1 = new ABCButton("A", color, font, size, rootLocation, buttonC_MouseDown, buttonC_MouseUp);
            button2 = new ABCButton("B", color, font, size, button1.Location + horizDistance, buttonC_MouseDown, buttonC_MouseUp);
            button3 = new ABCButton("C", color, font, size, button2.Location + horizDistance, buttonG_MouseDown, buttonG_MouseUp);
            button4 = new ABCButton("D", color, font, size, button3.Location + horizDistance, buttonG_MouseDown, buttonG_MouseUp);
            button5 = new ABCButton("E", color, font, size, button4.Location + horizDistance, buttonA_MouseDown, buttonA_MouseUp);
            button6 = new ABCButton("F", color, font, size, button5.Location + horizDistance, buttonA_MouseDown, buttonA_MouseUp);
            button7 = new ABCButton("G", color, font, size, button6.Location + horizDistance, buttonG_MouseDown, buttonG_MouseUp);

            // Row 2 of buttons
            button8 = new ABCButton("H", color, font, size, button1.Location + vertDistance, buttonF_MouseDown, buttonF_MouseUp);
            button9 = new ABCButton("I", color, font, size, button8.Location + horizDistance, buttonF_MouseDown, buttonF_MouseUp);
            button10 = new ABCButton("J", color, font, size, button9.Location + horizDistance, buttonE_MouseDown, buttonE_MouseUp);
            button11 = new ABCButton("K", color, font, size, button10.Location + horizDistance, buttonE_MouseDown, buttonE_MouseUp);

            // Row 3 of buttons
            button12 = new ABCButton("L", color, font, size, button8.Location + vertDistance, buttonD_MouseDown, buttonD_MouseUp);
            button13 = new ABCButton("M", color, font, size, button12.Location + horizDistance, buttonD_MouseDown, buttonD_MouseUp);
            button14 = new ABCButton("N", color, font, size, button13.Location + horizDistance, buttonD_MouseDown, buttonD_MouseUp);
            button15 = new ABCButton("O", color, font, size, button14.Location + horizDistance, buttonD_MouseDown, buttonD_MouseUp);
            button16 = new ABCButton("P", color, font, size, button15.Location + horizDistance, buttonC_MouseDown, buttonC_MouseUp);

            // Row 4 of buttons
            button17 = new ABCButton("Q", color, font, size, button12.Location + vertDistance, buttonG_MouseDown, buttonG_MouseUp);
            button18 = new ABCButton("R", color, font, size, button17.Location + horizDistance, buttonG_MouseDown, buttonG_MouseUp);
            button19 = new ABCButton("S", color, font, size, button18.Location + horizDistance, buttonF_MouseDown, buttonF_MouseUp);
            button20 = new ABCButton("T", color, font, size, button19.Location + horizDistance, buttonE_MouseDown, buttonE_MouseUp);
            button21 = new ABCButton("U", color, font, size, button20.Location + horizDistance, buttonE_MouseDown, buttonE_MouseUp);
            button22 = new ABCButton("V", color, font, size, button21.Location + horizDistance, buttonD_MouseDown, buttonD_MouseUp);

            // Row 5 of buttons
            button23 = new ABCButton("W", color, font, size, button17.Location + vertDistance, buttonG_MouseDown, buttonG_MouseUp);
            button24 = new ABCButton("X", color, font, size, button23.Location + horizDistance, buttonF_MouseDown, buttonF_MouseUp);
            button25 = new ABCButton("Y", color, font, size, button24.Location + horizDistance, buttonE_MouseDown, buttonE_MouseUp);
            button26 = new ABCButton("and", color, font, size, button25.Location + horizDistance, buttonE_MouseDown, buttonE_MouseUp);
            button27 = new ABCButton("Z", color, font, size, button26.Location + horizDistance, buttonD_MouseDown, buttonD_MouseUp);

            // Row 6 of buttons
            button28 = new ABCButton("Now", color, font, size, button23.Location + vertDistance, buttonC_MouseDown, buttonC_MouseUp);
            button29 = new ABCButton("I", color, font, size, button28.Location + horizDistance, buttonC_MouseDown, buttonC_MouseUp);
            button30 = new ABCButton("know", color, font, size, button29.Location + horizDistance, buttonG_MouseDown, buttonG_MouseUp);
            button31 = new ABCButton("my", color, font, size, button30.Location + horizDistance, buttonG_MouseDown, buttonG_MouseUp);
            button32 = new ABCButton("A", color, font, size, button31.Location + horizDistance, buttonA_MouseDown, buttonA_MouseUp);
            button33 = new ABCButton("B", color, font, size, button32.Location + horizDistance, buttonA_MouseDown, buttonA_MouseUp);
            button34 = new ABCButton("Cs", color, font, size, button33.Location + horizDistance, buttonG_MouseDown, buttonG_MouseUp);

            // Row 7 of buttons
            button35 = new ABCButton("Next", color, font, size, button28.Location + vertDistance, buttonF_MouseDown, buttonF_MouseUp);
            button36 = new ABCButton("time", color, font, size, button35.Location + horizDistance, buttonF_MouseDown, buttonF_MouseUp);
            button37 = new ABCButton("won't", color, font, size, button36.Location + horizDistance, buttonE_MouseDown, buttonE_MouseUp);
            button38 = new ABCButton("you", color, font, size, button37.Location + horizDistance, buttonE_MouseDown, buttonE_MouseUp);
            button39 = new ABCButton("sing", color, font, size, button38.Location + horizDistance, buttonD_MouseDown, buttonD_MouseUp);
            button40 = new ABCButton("with", color, font, size, button39.Location + horizDistance, buttonD_MouseDown, buttonD_MouseUp);
            button41 = new ABCButton("me?", color, font, size, button40.Location + horizDistance, buttonC_MouseDown, buttonC_MouseUp);

            // Color chooser button
            colorButton = new Button()
            {
                Text = "Choose color...",
                Size = new Size(250, 80),
                Location = button35.Location + vertDistance*2,
                Font = font,
                BackColor = color
            };
            colorButton.Click += OnColorButtonClicked;
            Controls.Add(colorButton);

            // Label for octave chooser
            Label label = new Label()
            {
                Text = "Octave:",
                Size = new Size(120, 40),
                Location = colorButton.Location + vertDistance,
                Font = font
            };
            Controls.Add(label);

            // Octave chooser
            octaveList = new ComboBox()
            {
                Size = new Size(100, 40),
                Location = label.Location + horizDistance*2,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            string[] octaves = new string[] { "3", "4", "5", "6", "7", "8" };
            octaveList.Items.AddRange(octaves);
            octaveList.SelectedIndex = 1;
            octaveList.SelectedIndexChanged += OnOctaveSelected;
            Controls.Add(octaveList);

            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 1200);

            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button21);
            Controls.Add(button22);
            Controls.Add(button23);
            Controls.Add(button24);
            Controls.Add(button25);
            Controls.Add(button26);
            Controls.Add(button27);
            Controls.Add(button28);
            Controls.Add(button29);
            Controls.Add(button30);
            Controls.Add(button31);
            Controls.Add(button32);
            Controls.Add(button33);
            Controls.Add(button34);
            Controls.Add(button35);
            Controls.Add(button36);
            Controls.Add(button37);
            Controls.Add(button38);
            Controls.Add(button39);
            Controls.Add(button40);
            Controls.Add(button41);

            Name = "ABC_Window";
            Text = "ABC Song QWERTY Game For Kids";
            Load += ABCWindow_Load;
            ResumeLayout(false);
        }

        #endregion

        private ABCButton button1;
        private ABCButton button2;
        private ABCButton button3;
        private ABCButton button4;
        private ABCButton button5;
        private ABCButton button6;
        private ABCButton button7;
        private ABCButton button8;
        private ABCButton button9;
        private ABCButton button10;
        private ABCButton button11;
        private ABCButton button12;
        private ABCButton button13;
        private ABCButton button14;
        private ABCButton button15;
        private ABCButton button16;
        private ABCButton button17;
        private ABCButton button18;
        private ABCButton button19;
        private ABCButton button20;
        private ABCButton button21;
        private ABCButton button22;
        private ABCButton button23;
        private ABCButton button24;
        private ABCButton button25;
        private ABCButton button26;
        private ABCButton button27;
        private ABCButton button28;
        private ABCButton button29;
        private ABCButton button30;
        private ABCButton button31;
        private ABCButton button32;
        private ABCButton button33;
        private ABCButton button34;
        private ABCButton button35;
        private ABCButton button36;
        private ABCButton button37;
        private ABCButton button38;
        private ABCButton button39;
        private ABCButton button40;
        private ABCButton button41;

        private Button colorButton;

        private ComboBox octaveList;
    }
}
