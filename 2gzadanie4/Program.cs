using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _2gzadanie4
{
    internal class Program
    {
        static void Main()
        {
            int number;
            number = Int32.Parse(
                Interaction.InputBox(
                    "Введите целое число от 5 до 10")
                );
            MessageBox.Show((number >= 5 && number <= 10) ? "Число ввели правильно"
                : "Число ввели не правильно");
        }
    }
}
