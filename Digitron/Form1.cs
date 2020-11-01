using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Digitron
{
    public partial class Form1 : Form
    {
        // karakteri koji se ne mogu uzastopno ponoviti (na primer: ++)
        private static readonly List<char> Unrepeatable = new List<char> {'+', '-', '*', '/', '.'};

        // karakteri sa kojim matematicki izraz ne moze da zapocne
        private static readonly List<char> CantStartWith = new List<char> {'*', '/'};

        // matermaticki izraz u formatu StringBuildera
        private readonly StringBuilder _expression = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var title = "Digitron";
            var text = "Napravio Ivan Cerovina";

            MessageBox.Show(text, title, MessageBoxButtons.OK);
        }

        private void ClickZero(object sender, EventArgs e)
        {
            AppendToExpression('0');
        }

        private void ClickOne(object sender, EventArgs e)
        {
            AppendToExpression('1');
        }

        private void ClickTwo(object sender, EventArgs e)
        {
            AppendToExpression('2');
        }

        private void ClickThree(object sender, EventArgs e)
        {
            AppendToExpression('3');
        }

        private void ClickFour(object sender, EventArgs e)
        {
            AppendToExpression('4');
        }

        private void ClickFive(object sender, EventArgs e)
        {
            AppendToExpression('5');
        }

        private void ClickSix(object sender, EventArgs e)
        {
            AppendToExpression('6');
        }

        private void ClickSeven(object sender, EventArgs e)
        {
            AppendToExpression('7');
        }

        private void ClickEight(object sender, EventArgs e)
        {
            AppendToExpression('8');
        }

        private void ClickNine(object sender, EventArgs e)
        {
            AppendToExpression('9');
        }

        private void ClickPlus(object sender, EventArgs e)
        {
            AppendToExpression('+');
        }

        private void ClickMinus(object sender, EventArgs e)
        {
            AppendToExpression('-');
        }

        private void ClickDivide(object sender, EventArgs e)
        {
            AppendToExpression('/');
        }

        private void ClickMultiply(object sender, EventArgs e)
        {
            AppendToExpression('*');
        }

        private void ClickDecimalPoint(object sender, EventArgs e)
        {
            AppendToExpression('.');
        }

        private void ClickOpeningBracket(object sender, EventArgs e)
        {
            AppendToExpression('(');
        }

        private void ClickClosingBracket(object sender, EventArgs e)
        {
            AppendToExpression(')');
        }

        private void ClickBack(object sender, EventArgs e)
        {
            RemoveLastCharacterFromExpression();
        }

        private void ClickClear(object sender, EventArgs e)
        {
            ClearExpression();
        }

        private void ClickEquals(object sender, EventArgs e)
        {
            // ako je izraz prazan, ne nastavljamo
            if (_expression.Length == 0) return;

            // Koristimo try/catch blok da bismo mogli reci korisniku kada je napravio sintaksnu gresku
            try
            {
                // racunamo izraz
                var expressionResult = Convert.ToDouble(new DataTable().Compute(_expression.ToString(), null));

                // pretvaramo izraz u string
                var resultString = expressionResult.ToString(CultureInfo.InvariantCulture);

                // postavljamo tekst na rezultat
                UpdateText(resultString);

                // Ovo sluzi da bi, posle racunanja, mogli nastaviti izraz sa rezultatom
                _expression.Clear().Append(resultString);
            }
            catch (SyntaxErrorException exception)
            {
                ClearExpression();
                UpdateText("Syntax error:\n" + exception.Message);
            }
            catch (Exception)
            {
                ClearExpression();
                UpdateText("Syntax error");
            }
        }

        /**
         * Ova funkcija dodaje unet karakter na matematicki izraz
         */
        private void AppendToExpression(char character)
        {
            // proveravamo da li je unet prvi karater, i da li je taj karakter
            // u listi karaktera koji ne mogu biti prvi
            if (_expression.Length == 0 && CantStartWith.Contains(character)) return;


            // proveravamo da li se ponavaljaju isti karakteri koji su u listi karaktera
            // koji se ne mogu ponavljati
            if (Unrepeatable.Contains(character) && _expression.Length != 0 &&
                Unrepeatable.Contains(_expression.ToString()[_expression.Length - 1]))
                _expression.Remove(_expression.Length - 1, 1);

            // ako smo prosli sve provere
            // dodajemo karakter u izraz
            _expression.Append(character);

            // STARI KOD
            //if (CantStartWith.Contains(_expression[0])) CantStartWith.RemoveAt(0);

            // menjamo tekst prikazan korisniku
            UpdateText(_expression.ToString());
        }

        /**
         * Brise poslednji karakter iz izraza
         */
        private void RemoveLastCharacterFromExpression()
        {
            // ako je izraz prazan, necemo nista da menjamo
            if (_expression.Length == 0) return;

            // brisemo poslednji karakter iz izraza
            _expression.Remove(_expression.Length - 1, 1);
            result.Text = _expression.ToString();
        }

        /**
         * Brise ceo izraz
         */
        private void ClearExpression()
        {
            _expression.Clear();
            UpdateText(_expression.ToString());
        }

        /**
         * Menja tekst prikazan korisniku
         */
        private void UpdateText(string text)
        {
            // da bi povecali kolicinu teksta koji moze stati u jedan red, smanjujemo
            // tekst srazmerno na duzinu teksta, podeljeno sa dva
            var size = 24 - text.Length / 2;
            var font = new Font("Arial", size > 10 ? size : 11);

            result.Font = font;
            result.Text = text;
        }
    }
}