using System;
using System.Windows;
using System.Windows.Input;
using System.Globalization;

namespace Intel8086Sim
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //HEX VALUE RULE
        private void OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int hexNumber;
            e.Handled = !int.TryParse(e.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out hexNumber);
        }
        //HEX VALUES GENERATOR
        private void RandomHex()
        {
            Random random = new Random();
            AX.Text = random.Next(0, 65535).ToString("X");
            BX.Text = random.Next(0, 65535).ToString("X");
            CX.Text = random.Next(0, 65535).ToString("X");
            DX.Text = random.Next(0, 65535).ToString("X");
        }
        //RESET REGISTERS
        private void Clear()
        {
            AX.Text = "";
            BX.Text = "";
            CX.Text = "";
            DX.Text = "";
            FromAXButton.IsChecked = true;
            ToAXButton.IsChecked = true;
        }
        //MOVE REGISTERS
        private void MoveRegisters()
        {
            if (FromAXButton.IsChecked == true && ToBXButton.IsChecked == true)
            {
                BX.Text = AX.Text;
            }
            else if (FromAXButton.IsChecked == true && ToCXButton.IsChecked == true)
            {
                CX.Text = AX.Text;
            }
            else if (FromAXButton.IsChecked == true && ToDXButton.IsChecked == true)
            {
                DX.Text = AX.Text;
            }

            if (FromBXButton.IsChecked == true && ToAXButton.IsChecked == true)
            {
                AX.Text = BX.Text;
            }
            else if (FromBXButton.IsChecked == true && ToCXButton.IsChecked == true)
            {
                CX.Text = BX.Text;
            }
            else if (FromBXButton.IsChecked == true && ToDXButton.IsChecked == true)
            {
                DX.Text = BX.Text;
            }

            if (FromCXButton.IsChecked == true && ToAXButton.IsChecked == true)
            {
                AX.Text = CX.Text;
            }
            else if (FromCXButton.IsChecked == true && ToBXButton.IsChecked == true)
            {
                BX.Text = CX.Text;
            }
            else if (FromCXButton.IsChecked == true && ToDXButton.IsChecked == true)
            {
                DX.Text = CX.Text;
            }

            if (FromDXButton.IsChecked == true && ToAXButton.IsChecked == true)
            {
                AX.Text = DX.Text;
            }
            else if (FromDXButton.IsChecked == true && ToBXButton.IsChecked == true)
            {
                BX.Text = DX.Text;
            }
            else if (FromDXButton.IsChecked == true && ToCXButton.IsChecked == true)
            {
                CX.Text = DX.Text;
            }
        }
        //XCHG REGISTERS
        private void XCHGRegisters()
        {
            if (FromAXButton.IsChecked == true && ToBXButton.IsChecked == true)
            {
                string x1 = AX.Text;
                string x2 = BX.Text;
                AX.Text = x2;
                BX.Text = x1;
            }
            else if (FromAXButton.IsChecked == true && ToCXButton.IsChecked == true)
            {
                string x1 = AX.Text;
                string x2 = CX.Text;
                AX.Text = x2;
                CX.Text = x1;
            }
            else if (FromAXButton.IsChecked == true && ToDXButton.IsChecked == true)
            {
                string x1 = AX.Text;
                string x2 = DX.Text;
                AX.Text = x2;
                DX.Text = x1;
            }

            if (FromBXButton.IsChecked == true && ToAXButton.IsChecked == true)
            {
                string x1 = BX.Text;
                string x2 = AX.Text;
                BX.Text = x2;
                AX.Text = x1;
            }
            else if (FromBXButton.IsChecked == true && ToCXButton.IsChecked == true)
            {
                string x1 = BX.Text;
                string x2 = CX.Text;
                BX.Text = x2;
                CX.Text = x1;
            }
            else if (FromBXButton.IsChecked == true && ToDXButton.IsChecked == true)
            {
                string x1 = BX.Text;
                string x2 = DX.Text;
                BX.Text = x2;
                DX.Text = x1;
            }

            if (FromCXButton.IsChecked == true && ToAXButton.IsChecked == true)
            {
                string x1 = CX.Text;
                string x2 = AX.Text;
                CX.Text = x2;
                AX.Text = x1;
            }
            else if (FromCXButton.IsChecked == true && ToBXButton.IsChecked == true)
            {
                string x1 = CX.Text;
                string x2 = BX.Text;
                CX.Text = x2;
                BX.Text = x1;
            }
            else if (FromCXButton.IsChecked == true && ToDXButton.IsChecked == true)
            {
                string x1 = CX.Text;
                string x2 = DX.Text;
                CX.Text = x2;
                DX.Text = x1;
            }

            if (FromDXButton.IsChecked == true && ToAXButton.IsChecked == true)
            {
                string x1 = DX.Text;
                string x2 = AX.Text;
                DX.Text = x2;
                AX.Text = x1;
            }
            else if (FromDXButton.IsChecked == true && ToBXButton.IsChecked == true)
            {
                string x1 = DX.Text;
                string x2 = BX.Text;
                DX.Text = x2;
                BX.Text = x1;
            }
            else if (FromDXButton.IsChecked == true && ToCXButton.IsChecked == true)
            {
                string x1 = DX.Text;
                string x2 = CX.Text;
                DX.Text = x2;
                CX.Text = x1;
            }
        }
        //Random BUTTON REF
        private void RandomHexButton(object sender, EventArgs e)
        {
            RandomHex();
        }
        //Clear BUTTON REF
        private void ClearRegistersButton(object sender, EventArgs e)
        {
            Clear();
        }
        //MOVE BUTTON REF
        private void MoveRegistersButton(object sender, EventArgs e)
        {
            MoveRegisters();
        }
        //XCHG BUTTON REF
        private void XCHGRegistersButton(object sender, EventArgs e)
        {
            XCHGRegisters();
        }
    }
}