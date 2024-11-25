

namespace ABCs
{
    public partial class ABCWindow : Form
    {
        private NotePlayer _playerC = new NotePlayer(Notes.Note.C4);
        private NotePlayer _playerD = new NotePlayer(Notes.Note.D4);
        private NotePlayer _playerE = new NotePlayer(Notes.Note.E4);
        private NotePlayer _playerF = new NotePlayer(Notes.Note.F4);
        private NotePlayer _playerG = new NotePlayer(Notes.Note.G4);
        private NotePlayer _playerA = new NotePlayer(Notes.Note.A4);
        private NotePlayer _playerB = new NotePlayer(Notes.Note.B4);

        private ColorDialog _colorDialog = new ColorDialog();

        public ABCWindow()
        {
            InitializeComponent();

            // Let the user select a custom color.
            _colorDialog.AllowFullOpen = true;
            // Sets the initial color select to the current button color.
            _colorDialog.Color = button1.BackColor;

            KeyPreview = true;
            KeyDown += OnKeyDown;
            KeyUp += OnKeyUp;
            KeyPress += OnKeyPress;
        }

        private void DisposePlayers()
        {
            _playerC.Dispose();
            _playerD.Dispose();
            _playerE.Dispose();
            _playerF.Dispose();
            _playerG.Dispose();
            _playerA.Dispose();
            _playerB.Dispose();
        }
        private void ABCWindow_Load(object sender, EventArgs e)
        {
        }

        private void buttonC_MouseDown(object sender, MouseEventArgs e)
        {
            _playerC.StartPlaying();
        }

        private void buttonC_MouseUp(object sender, MouseEventArgs e)
        {
            _playerC.StopPlaying();
        }

        private void buttonD_MouseDown(object sender, MouseEventArgs e)
        {
            _playerD.StartPlaying();
        }

        private void buttonD_MouseUp(object sender, MouseEventArgs e)
        {
            _playerD.StopPlaying();
        }

        private void buttonE_MouseDown(object sender, MouseEventArgs e)
        {
            _playerE.StartPlaying();
        }

        private void buttonE_MouseUp(object sender, MouseEventArgs e)
        {
            _playerE.StopPlaying();
        }

        private void buttonF_MouseDown(object sender, MouseEventArgs e)
        {
            _playerF.StartPlaying();
        }

        private void buttonF_MouseUp(object sender, MouseEventArgs e)
        {
            _playerF.StopPlaying();
        }

        private void buttonG_MouseDown(object sender, MouseEventArgs e)
        {
            _playerG.StartPlaying();
        }

        private void buttonG_MouseUp(object sender, MouseEventArgs e)
        {
            _playerG.StopPlaying();
        }

        private void buttonA_MouseDown(object sender, MouseEventArgs e)
        {
            _playerA.StartPlaying();
        }

        private void buttonA_MouseUp(object sender, MouseEventArgs e)
        {
            _playerA.StopPlaying();
        }

        private void buttonB_MouseDown(object sender, MouseEventArgs e)
        {
            _playerB.StartPlaying();
        }
        private void buttonB_MouseUp(object sender, MouseEventArgs e)
        {
            _playerB.StopPlaying();
        }

        private void OnKeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode < Keys.A || e.KeyCode > Keys.Z)
                return;

            switch (e.KeyCode)
            {
                case Keys.A:
                case Keys.B:
                case Keys.P:
                    _playerC.StartPlaying();
                    break;
                case Keys.L:
                case Keys.M:
                case Keys.N:
                case Keys.O:
                case Keys.V:
                case Keys.Z:
                    _playerD.StartPlaying();
                    break;
                case Keys.J:
                case Keys.K:
                case Keys.T:
                case Keys.U:
                case Keys.Y:
                    _playerE.StartPlaying();
                    break;
                case Keys.H:
                case Keys.I:
                case Keys.S:
                case Keys.X:
                    _playerF.StartPlaying();
                    break;
                case Keys.C:
                case Keys.D:
                case Keys.G:
                case Keys.Q:
                case Keys.R:
                case Keys.W:
                    _playerG.StartPlaying();
                    break;
                case Keys.E:
                case Keys.F:
                    _playerA.StartPlaying();
                    break;
                default:
                    break;
            }
        }

        private void OnKeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode < Keys.A || e.KeyCode > Keys.Z)
                return;

            switch (e.KeyCode)
            {
                case Keys.A:
                case Keys.B:
                case Keys.P:
                    _playerC.StopPlaying();
                    break;
                case Keys.L:
                case Keys.M:
                case Keys.N:
                case Keys.O:
                case Keys.V:
                case Keys.Z:
                    _playerD.StopPlaying();
                    break;
                case Keys.J:
                case Keys.K:
                case Keys.T:
                case Keys.U:
                case Keys.Y:
                    _playerE.StopPlaying();
                    break;
                case Keys.H:
                case Keys.I:
                case Keys.S:
                case Keys.X:
                    _playerF.StopPlaying();
                    break;
                case Keys.C:
                case Keys.D:
                case Keys.G:
                case Keys.Q:
                case Keys.R:
                case Keys.W:
                    _playerG.StopPlaying();
                    break;
                case Keys.E:
                case Keys.F:
                    _playerA.StopPlaying();
                    break;
                default:
                    break;
            }
        }

        private void OnKeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '/')
                return;

            // Rotate through the tone types in response to a slash key.
            NotePlayer.NoteType noteType = _playerA.GetToneType();
            switch (noteType)
            {
                case NotePlayer.NoteType.Sin:
                    UseTriangle();
                    break;
                case NotePlayer.NoteType.Triangle:
                    UseSquare();
                    break;
                case NotePlayer.NoteType.Square:
                    UseSawTooth();
                    break;
                case NotePlayer.NoteType.SawTooth:
                    UseSin();
                    break;
                default:
                    break;
            }
        }

        private void OnColorButtonClicked(object sender, EventArgs e)
        {
            // Update the color of the buttons if the user clicks OK 
            if (_colorDialog.ShowDialog() == DialogResult.OK)
                SetButtonColor(_colorDialog.Color);
        }

        private void OnOctaveSelected(object sender, EventArgs e)
        {
            string? octave = octaveList.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(octave))
                return;

            if (octave == "3")
                UseOctave3();
            else if (octave == "4")
                UseOctave4();
            else if (octave == "5")
                UseOctave5();
            else if (octave == "6")
                UseOctave6();
            else if (octave == "7")
                UseOctave7();
            else if (octave == "8")
                UseOctave8();
        }

        private void UseOctave3()
        {
            _playerC.SetNote(Notes.Note.C3);
            _playerD.SetNote(Notes.Note.D3);
            _playerE.SetNote(Notes.Note.E3);
            _playerF.SetNote(Notes.Note.F3);
            _playerG.SetNote(Notes.Note.G3);
            _playerA.SetNote(Notes.Note.A3);
            _playerB.SetNote(Notes.Note.B3);
        }

        private void UseOctave4()
        {
            _playerC.SetNote(Notes.Note.C4);
            _playerD.SetNote(Notes.Note.D4);
            _playerE.SetNote(Notes.Note.E4);
            _playerF.SetNote(Notes.Note.F4);
            _playerG.SetNote(Notes.Note.G4);
            _playerA.SetNote(Notes.Note.A4);
            _playerB.SetNote(Notes.Note.B4);
        }

        private void UseOctave5()
        {
            _playerC.SetNote(Notes.Note.C5);
            _playerD.SetNote(Notes.Note.D5);
            _playerE.SetNote(Notes.Note.E5);
            _playerF.SetNote(Notes.Note.F5);
            _playerG.SetNote(Notes.Note.G5);
            _playerA.SetNote(Notes.Note.A5);
            _playerB.SetNote(Notes.Note.B5);
        }

        private void UseOctave6()
        {
            _playerC.SetNote(Notes.Note.C6);
            _playerD.SetNote(Notes.Note.D6);
            _playerE.SetNote(Notes.Note.E6);
            _playerF.SetNote(Notes.Note.F6);
            _playerG.SetNote(Notes.Note.G6);
            _playerA.SetNote(Notes.Note.A6);
            _playerB.SetNote(Notes.Note.B6);
        }

        private void UseOctave7()
        {
            _playerC.SetNote(Notes.Note.C7);
            _playerD.SetNote(Notes.Note.D7);
            _playerE.SetNote(Notes.Note.E7);
            _playerF.SetNote(Notes.Note.F7);
            _playerG.SetNote(Notes.Note.G7);
            _playerA.SetNote(Notes.Note.A7);
            _playerB.SetNote(Notes.Note.B7);
        }

        private void UseOctave8()
        {
            _playerC.SetNote(Notes.Note.C8);
            _playerD.SetNote(Notes.Note.D8);
            _playerE.SetNote(Notes.Note.E8);
            _playerF.SetNote(Notes.Note.F8);
            _playerG.SetNote(Notes.Note.G8);
            _playerA.SetNote(Notes.Note.A8);
            _playerB.SetNote(Notes.Note.B8);
        }

        private void UseSin()
        {
            _playerC.SetToneType(NotePlayer.NoteType.Sin);
            _playerD.SetToneType(NotePlayer.NoteType.Sin);
            _playerE.SetToneType(NotePlayer.NoteType.Sin);
            _playerF.SetToneType(NotePlayer.NoteType.Sin);
            _playerG.SetToneType(NotePlayer.NoteType.Sin);
            _playerA.SetToneType(NotePlayer.NoteType.Sin);
        }

        private void UseTriangle()
        {
            _playerC.SetToneType(NotePlayer.NoteType.Triangle);
            _playerD.SetToneType(NotePlayer.NoteType.Triangle);
            _playerE.SetToneType(NotePlayer.NoteType.Triangle);
            _playerF.SetToneType(NotePlayer.NoteType.Triangle);
            _playerG.SetToneType(NotePlayer.NoteType.Triangle);
            _playerA.SetToneType(NotePlayer.NoteType.Triangle);
        }

        private void UseSquare()
        {
            _playerC.SetToneType(NotePlayer.NoteType.Square);
            _playerD.SetToneType(NotePlayer.NoteType.Square);
            _playerE.SetToneType(NotePlayer.NoteType.Square);
            _playerF.SetToneType(NotePlayer.NoteType.Square);
            _playerG.SetToneType(NotePlayer.NoteType.Square);
            _playerA.SetToneType(NotePlayer.NoteType.Square);
        }

        private void UseSawTooth()
        {
            _playerC.SetToneType(NotePlayer.NoteType.SawTooth);
            _playerD.SetToneType(NotePlayer.NoteType.SawTooth);
            _playerE.SetToneType(NotePlayer.NoteType.SawTooth);
            _playerF.SetToneType(NotePlayer.NoteType.SawTooth);
            _playerG.SetToneType(NotePlayer.NoteType.SawTooth);
            _playerA.SetToneType(NotePlayer.NoteType.SawTooth);
        }

        private void SetButtonColor(Color color)
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(ABCButton) || c.GetType() == typeof(Button))
                {
                    c.BackColor = color;
                }
            }
        }
    }
}
