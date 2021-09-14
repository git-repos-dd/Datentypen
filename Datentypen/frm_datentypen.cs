﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datentypen
{
    public partial class frm_datentypen : Form
    {
        public frm_datentypen()
        {
            InitializeComponent();
        }

        private void btn_datentypen_anzeigen_Click(object sender, EventArgs e)
        {
            /* Ganze Zahlen */
            byte By;
            short Sh;
            int It, Hex;
            long Lg;
            /* Zahlen mit Nachkommastellen */
            float Fl;
            double Db1, Db2, Exp1, Exp2;
            decimal De;
            /* Boolesche Variable, Zeichen, Zeichenkette */
            bool Bo;
            char Ch;
            string St;
            /* Ganze Zahlen */
            By = 200;
            Sh = 30000;
            It = 2000000000;
            Lg = 3000000000;
            Hex = 0x3a;
            /* Zahlen mit Nachkommastellen */
            Fl = 1.0f / 7;
            Db1 = 1 / 7;
            Db2 = 1.0 / 7;
            De = 1.0m / 7;
            Exp1 = 1.5e3;
            Exp2 = 1.5e-3;
            /* Boolesche Variable, Zeichen, Zeichenkette */
            Bo = true;
            Ch = 'a';
            St = "Zeichenkette";
            lbl_datentypen.Text =
                "byte: " +By + "\n" + "short: " +Sh + "\n" +
                "int: " +It + "\n" + "long: " +Lg + "\n" +
                "(hexadezimale Zahl): " +Hex + "\n\n" +
                "float: " +Fl + "\n" + "double 1: " +Db1 + "\n" +
                "double 2: " +Db2 + "\n" + "decimal: " +De + "\n" +
                "(Exponent positiv): " +Exp1 + "\n" +
                "(Exponent negativ): " +Exp2 + "\n\n" +
                "bool: " +Bo + "\n" + "char: " +Ch + "\n" + "string: " +St;
        }
    }
}
