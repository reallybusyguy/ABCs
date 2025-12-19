using System;

using NAudio.Wave;
using NAudio.Wave.SampleProviders;

// This documentation is a helpful reference: https://github.com/naudio/NAudio/tree/master/Docs

namespace ABCs
{
    internal class NotePlayer : IDisposable
    {

        public enum NoteType
        {
            Sin,
            Triangle,
            Square,
            SawTooth
        }

        private double _gain = 0.30;

        // Possible signal types: Sin, Triangle, Square, SawTooth
        private NoteType _noteType = NoteType.Triangle;

        private SignalGenerator _generator;

        private WaveOutEvent _waveOut = new WaveOutEvent();

        private int _latency = 10; // msec

        private Notes.Note _note;

        public NotePlayer(Notes.Note note)
        {
            _note = note;

            _generator = new SignalGenerator()
            {
                Gain = _gain,
                Frequency = Notes.GetFrequency(_note)
            };
            SetToneType(_noteType);

            _waveOut.Init(_generator);
            _waveOut.DesiredLatency = _latency;
        }

        public NoteType GetToneType()
        {
            return _noteType;
        }

        public void SetToneType(NoteType type)
        {
            _noteType = type;
            switch(type)
            {
                case NoteType.Sin:
                    SetToneType(SignalGeneratorType.Sin);
                    break;
                case NoteType.Triangle:
                    SetToneType(SignalGeneratorType.Triangle);
                    break;
                case NoteType.Square:
                    SetToneType(SignalGeneratorType.Square);
                    break;
                case NoteType.SawTooth:
                    SetToneType(SignalGeneratorType.SawTooth);
                    break;
                default:
                    break;
            }
        }

        private void SetToneType(SignalGeneratorType type)
        {
            _generator.Type = type;
        }

        public void StartPlaying()
        {
            _waveOut.Play();
        }

        public void StopPlaying()
        {
            _waveOut.Stop();
        }

        public void SetNote(Notes.Note note)
        {
            _note = note;
            _generator.Frequency = Notes.GetFrequency(_note);
        }

        public void Dispose()
        {
            _waveOut.Dispose();
        }
    }
}
