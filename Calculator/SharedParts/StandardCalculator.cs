using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GEM.Calculator
{
    internal class StandardCalculator : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public MathNodes.IMathNode CurrentFunction;
        public MathNodes.ConstantNode CurrentInput;

        public double CurrentValue => CurrentInput.Value;

        private string _entry = "0";
        private bool _hasDecimal = false;

        private double _memory = 0;

        public string Entry
        {
            get => _entry;
            set
            {
                _entry = value;
                CurrentInput.Value = Convert.ToDouble(_entry);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Entry)));
            }
        }

        public StandardCalculator()
        {
            PressClear();
        }

        public void PressSolve()
        {
            double r = CurrentFunction.Solve();
            PressClear();
            Entry = r.ToString();
        }

        public void ClearMemory()
        {
            _memory = 0;
        }
        public void RecallMemory()
        {
            Entry = _memory.ToString();
        }
        public void AddMemory()
        {
            _memory += Convert.ToDouble(Entry);
        }
        public void SubtractMemory()
        {
            _memory -= Convert.ToDouble(Entry);
        }
        public void SaveMemory()
        {
            _memory = Convert.ToDouble(Entry);
        }

        public void PressRoot()
        {
            MathNodes.SqRootNode node = new MathNodes.SqRootNode(CurrentFunction);
            CurrentFunction = node;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentFunction)));
        }
        public void PressSquare()
        {
            MathNodes.SquareNode node = new MathNodes.SquareNode(
                CurrentFunction);
            CurrentFunction = node;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentFunction)));
        }
        public void PressInvert()
        {
            MathNodes.InvertNode node = new MathNodes.InvertNode(
                CurrentFunction);
            CurrentFunction = node;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentFunction)));
        }

        public void PressDivide()
        {
            MathNodes.DivisionNode aNode = new MathNodes.DivisionNode(
                CurrentFunction, new MathNodes.ConstantNode(0));
            CurrentFunction = aNode;
            CurrentInput = aNode.NodeB as MathNodes.ConstantNode;
            PressClearEntry();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentFunction)));
        }
        public void PressMultiply()
        {
            MathNodes.Product_Node aNode = new MathNodes.Product_Node(
                CurrentFunction, new MathNodes.ConstantNode(0));
            CurrentFunction = aNode;
            CurrentInput = aNode.NodeB as MathNodes.ConstantNode;
            PressClearEntry();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentFunction)));
        }
        public void PressSubtract()
        {
            MathNodes.SubtractNode aNode = new MathNodes.SubtractNode(
                CurrentFunction, new MathNodes.ConstantNode(0));
            CurrentFunction = aNode;
            CurrentInput = aNode.NodeB as MathNodes.ConstantNode;
            PressClearEntry();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentFunction)));
        }
        public void PressAdd()
        {
            MathNodes.AdditionNode aNode = new MathNodes.AdditionNode(
                CurrentFunction, new MathNodes.ConstantNode(0));
            CurrentFunction = aNode;
            CurrentInput = aNode.NodeB as MathNodes.ConstantNode;
            PressClearEntry();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentFunction)));
        }

        private void CheckSetAddDigit(char digit)
        {
            if (Entry == "0")
            {
                Entry = $"{digit}";
            }
            else
            {
                Entry += digit;
            }
        }

        public void PressNegate()
        {
            double i = Convert.ToDouble(Entry);
            i *= -1;
            Entry = i.ToString();
        }
        public void Press9() => CheckSetAddDigit('9');
        public void Press8() => CheckSetAddDigit('8');
        public void Press7() => CheckSetAddDigit('7');
        public void Press6() => CheckSetAddDigit('6');
        public void Press5() => CheckSetAddDigit('5');
        public void Press4() => CheckSetAddDigit('4');
        public void Press3() => CheckSetAddDigit('3');
        public void Press2() => CheckSetAddDigit('2');
        public void Press1() => CheckSetAddDigit('1');
        public void Press0()
        {
            if (Entry != "0")
            {
                Entry += "0";
            }
        }
        public void PressDecimal()
        {
            if (!_hasDecimal)
            {
                Entry += ".";
                _hasDecimal = true;
            }
        }

        public void PressBackspace()
        {
            Entry = Entry.Substring(0, Entry.Length - 1);
        }
        public void PressClearEntry()
        {
            _entry = "0";
            _hasDecimal = false;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Entry)));
        }
        public void PressClear()
        {
            CurrentFunction = new MathNodes.ConstantNode(0);
            CurrentInput = CurrentFunction as MathNodes.ConstantNode;
            PressClearEntry();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentFunction)));
        }
        public void PressPercent()
        {
            double i = Convert.ToDouble(Entry);
            i *= 0.01;
            Entry = i.ToString();
        }
    }
}
