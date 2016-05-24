using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg240PartyPlaner2 {
    public partial class Form1 : Form {
        BirthdayParty birthdayParty;
        DinnerParty dinnerParty;

        public Form1() {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)guestsUpDown.Value, alcoholBox.Checked, fancyDinner.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);
            DisplayBirthdayPartyCost();
        }

        private void DisplayDinnerPartyCost() {
            costLabel.Text = dinnerParty.Cost.ToString("c");
        }

        private void DisplayBirthdayPartyCost() {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            birthdayCost.Text = birthdayParty.Cost.ToString("c");
        }

        private void guestsUpDown_ValueChanged(object sender, EventArgs e) {
            dinnerParty.NumberOfGuests = (int)guestsUpDown.Value;
            DisplayDinnerPartyCost();
        }

        private void fancyCheckBox_CheckedChanged(object sender, EventArgs e) {
            dinnerParty.FancyDecorations = fancyDinner.Checked;
            DisplayDinnerPartyCost();
        }

        private void alcoholCheckBox_CheckedChanged(object sender, EventArgs e) {
            dinnerParty.Alcohol = alcoholBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e) {
            birthdayParty.NumberOfGuests = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e) {
            birthdayParty.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e) {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}