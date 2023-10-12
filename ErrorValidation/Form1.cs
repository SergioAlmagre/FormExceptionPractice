using System.CodeDom;
using System.Text.RegularExpressions;

namespace ErrorValidation
{
    public partial class PersonalData : Form
    {
        public PersonalData()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            int ok = 1;
            try
            {
                if (!txtAccountNumber.MaskFull)
                {
                    throw new AccountNumberException("The account number must be 20 digits");
                }
            }
            catch (AccountNumberException ex)
            {
                MessageBox.Show(ex.Message, "Account Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = 0;
            }

            try
            {
                if (!txtMovil.MaskFull)
                {
                    throw new MovilNumberException("The movil number must be 9 digits");
                }
            }
            catch (MovilNumberException ex)
            {
                MessageBox.Show(ex.Message, "Movil Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = 0;
            }

            try
            {
                if (!txtNif.MaskFull)
                {
                    throw new NifException("The nif number must be 9 digits");
                }
            }
            catch (NifException ex)
            {
                MessageBox.Show(ex.Message, "Nif Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = 0;
            }

            try
            {
                string nif = txtNif.Text;
                string nifNumber = nif.Substring(0, 8);
                string nifLetter = nif.Substring(9, 1);
                int nifNumberInt = int.Parse(nifNumber);
                int resto = nifNumberInt % 23;
                string[] letters = new string[] { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B",
                                                    "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
                string letter = letters[resto];
                if (letter != nifLetter)
                {
                    throw new NifException("The letter of nif is not correct");
                }
            }
            catch (NifException ex)
            {
                MessageBox.Show(ex.Message, "Nif Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = 0;
            }

            String regularExpression = "\\A[A-Za-z]+@[A-Za-z]+[.][A-Za-z]+\\Z";
            String checkStr = txtEmail.Text;
            Regex regex = new Regex(regularExpression);
            try
            {
                if (!regex.IsMatch(checkStr))
                {
                    throw new EmailException("The format of email is not correct");
                }
            }
            catch (EmailException ex)
            {
                MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = 0;
            }

            try
            {
                regularExpression = "\\A\\d{4}\\s?[B-DF-HJ-NPR-TV-Z]{3}\\Z";
                checkStr = txtCarPlate.Text;
                regex = new Regex(regularExpression);
                if (!regex.IsMatch(checkStr))
                {
                    throw new CarPanelException("The format of car panel is not correct\n Must be like that 1234LJL");
                }
            }
            catch (CarPanelException ex)
            {
                MessageBox.Show(ex.Message, "Car Panel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = 0;
            }

            try
            {
                if (string.IsNullOrEmpty(txtFirsName.Text) || string.IsNullOrEmpty(txtSecondName.Text) || string.IsNullOrEmpty(txtAccountNumber.Text) || string.IsNullOrEmpty(txtMovil.Text) || string.IsNullOrEmpty(txtNif.Text))
                {
                    throw new EverythingException("All fields must be filled");
                }
            }
            catch (EverythingException ex)
            {
                MessageBox.Show(ex.Message, "General information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = 0;
            }
            if (ok == 1)
            {
                MessageBox.Show(
                    txtFirsName.Text.Trim() + "\n"
                    + txtSecondName.Text.Trim() + "\n"
                    + txtEmail.Text.Trim() + "\n"
                    + txtCarPlate.Text.Trim() + "\n"
                    + txtMovil.Text.Trim() + "\n"
                    + txtNif.Text.Trim() + "\n"
                    + txtAccountNumber.Text.Trim(), "These are your data");
            }

        }

    }
}