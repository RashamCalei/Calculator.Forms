using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Forms
{
    static class Start
    {
        static void Main()
        {
            // wiadomość powitalna
            MessageBox.Show("Calculator made by Roger A.\n Welcome!");       
            // uruchomienie okienka kalkulatora
            Application.Run(new MainForm());
            
        }
    }
}
