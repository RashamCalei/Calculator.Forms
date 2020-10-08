using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Forms
{
    class MainForm: Form
    {
        Label appTitle;
        Button calculateButton; 
        TextBox firstValueTextBox, secondValueTextBox, resultTextBox;
        RadioButton addOperation, substractOperation, multiplyOperation, divideOperation;
        public MainForm()
        {
            // długość szerokość tytuł okna kalkulatora
            this.Width = 350;
            this.Height = 400;
            this.Text = "Calculator";
            // utworzenie obiektu appTitle i konfiguracja czcionki, położenia tytułu aplikacji "Calculator" 
            appTitle = new Label();
            appTitle.Font = new Font("Courier", 15, FontStyle.Bold);
            appTitle.Text = "Calculator";
            appTitle.AutoSize = true;
            appTitle.Left = ((this.ClientSize.Width - appTitle.Width) / 2) - 10;
            appTitle.Top = 20;

            // utworzenie obiektu calculateButton, konfiguracja jego tekstu, położenia
            calculateButton = new Button();
            calculateButton.AutoSize = true;
            calculateButton.Text = "Calculate";
            calculateButton.Left = (this.ClientSize.Width - calculateButton.Width) / 2;
            calculateButton.Top = (this.ClientSize.Height / 2) + calculateButton.Height;

            // utworzenie obiektu firstValueTextBox i konfiguracja okienka tekstowego dla pierwszej liczby
            firstValueTextBox = new TextBox();
            firstValueTextBox.Text = "test1";
            firstValueTextBox.Left = (this.ClientSize.Width - firstValueTextBox.Width) / 8;
            firstValueTextBox.Top = firstValueTextBox.Height * 5;
            // utworzenie obiektu secondValueTextBox i konfiguracja okienka tekstowego dla drugiej liczby
            secondValueTextBox = new TextBox();
            secondValueTextBox.Text = "test2";
            secondValueTextBox.Left = (this.ClientSize.Width - secondValueTextBox.Width) / 8;
            secondValueTextBox.Top = secondValueTextBox.Height * 8;
            // utworzenie obiektu resultTextBox, konfiguracja położenia, ReadOnly
            resultTextBox = new TextBox();
            resultTextBox.Font = new Font("Arial", 14, FontStyle.Regular);
            resultTextBox.ReadOnly = true;
            resultTextBox.Text = "TestText";    // DO USUNIĘCIA
            resultTextBox.Left = (this.ClientSize.Width - resultTextBox.Width) / 2;
            resultTextBox.Top = 275;
            
            // utworzenie obiektu addOperation, konfiguracja położenia
            addOperation = new RadioButton();
            addOperation.Text = "Add (+)";
            addOperation.Left = 180;
            addOperation.Top = secondValueTextBox.Height * 5;
            // utworzenie obiektu substractOperation, konfiguracja położenia
            substractOperation = new RadioButton();
            substractOperation.Text = "Substract (-)";
            substractOperation.Left = 180;
            substractOperation.Top = secondValueTextBox.Height * 6;
            // utworzenie obiektu multiplyOperation, konfiguracja położenia
            multiplyOperation = new RadioButton();
            multiplyOperation.Text = "Multiply (*)";
            multiplyOperation.Left = 180;
            multiplyOperation.Top = secondValueTextBox.Height * 7;
            // utworzenie obiektu divideOperatiion, konfiguracja położenia
            divideOperation = new RadioButton();
            divideOperation.Text = "Divide (/)";
            divideOperation.Left = 180;
            divideOperation.Top = secondValueTextBox.Height * 8;

            // dodanie obiektów do okienka aplikacji
            this.Controls.Add(appTitle);
            this.Controls.Add(calculateButton);
            this.Controls.Add(firstValueTextBox);
            this.Controls.Add(secondValueTextBox);
            this.Controls.Add(resultTextBox);
            this.Controls.Add(addOperation);
            this.Controls.Add(substractOperation);
            this.Controls.Add(multiplyOperation);
            this.Controls.Add(divideOperation);
        }
    }
}
