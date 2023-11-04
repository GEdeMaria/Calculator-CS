using GEM.Calculator;

namespace Calculator
{
    public partial class FCalculator : Form
    {

        StandardCalculator Back;

        public FCalculator()
        {
            InitializeComponent();
            Back = new StandardCalculator();
            Back.PropertyChanged += Back_PropertyChanged;
        }

        private void Back_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(Back.CurrentFunction):
                    UpdateEquation();
                    break;
                case nameof(Back.Entry):
                    UpdateEquation();
                    UpdateValue();
                    break;
            }
        }

        public void UpdateEquation() => lblEquation.Text = Back.CurrentFunction.GetString();
        public void UpdateValue() => lblIO.Text = Back.Entry;

        private void FCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnMemoryClear_Click(object sender, EventArgs e) => Back.ClearMemory();
        private void btnMemoryReturn_Click(object sender, EventArgs e) => Back.RecallMemory();
        private void btnMemoryAdd_Click(object sender, EventArgs e) => Back.AddMemory();
        private void btnMemorySubtract_Click(object sender, EventArgs e) => Back.SubtractMemory();
        private void btnMemorySave_Click(object sender, EventArgs e) => Back.SaveMemory();

        private void btnPercent_Click(object sender, EventArgs e) => Back.PressPercent();
        private void btnClearEntry_Click(object sender, EventArgs e) => Back.PressClearEntry();
        private void btnClear_Click(object sender, EventArgs e) => Back.PressClear();
        private void btnBackspace_Click(object sender, EventArgs e) => Back.PressBackspace();

        private void btnInverse_Click(object sender, EventArgs e) => Back.PressInvert();
        private void btnSquare_Click(object sender, EventArgs e) => Back.PressSquare();
        private void btnRoot_Click(object sender, EventArgs e) => Back.PressRoot();
        private void btnNegate_Click(object sender, EventArgs e) => Back.PressNegate();
        private void btnDecimal_Click(object sender, EventArgs e) => Back.PressDecimal();

        private void btnDivide_Click(object sender, EventArgs e) => Back.PressDivide();
        private void btnMultiply_Click(object sender, EventArgs e) => Back.PressMultiply();
        private void btnSubtract_Click(object sender, EventArgs e) => Back.PressSubtract();
        private void btnAdd_Click(object sender, EventArgs e) => Back.PressAdd();

        private void btnSolve_Click(object sender, EventArgs e) => Back.PressSolve();

        private void btn0_Click(object sender, EventArgs e) => Back.Press0();
        private void btn1_Click(object sender, EventArgs e) => Back.Press1();
        private void btn2_Click(object sender, EventArgs e) => Back.Press2();
        private void btn3_Click(object sender, EventArgs e) => Back.Press3();
        private void btn4_Click(object sender, EventArgs e) => Back.Press4();
        private void btn5_Click(object sender, EventArgs e) => Back.Press5();
        private void btn6_Click(object sender, EventArgs e) => Back.Press6();
        private void btn7_Click(object sender, EventArgs e) => Back.Press7();
        private void btn8_Click(object sender, EventArgs e) => Back.Press8();
        private void btn9_Click(object sender, EventArgs e) => Back.Press9();
    }
}