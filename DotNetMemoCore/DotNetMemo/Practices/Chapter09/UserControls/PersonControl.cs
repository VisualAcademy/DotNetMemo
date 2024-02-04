using System;
using System.Windows.Forms;

namespace UserControls
{
    public partial class PersonControl : UserControl
    {
        public PersonControl()
        {
            InitializeComponent();
        }

        private Person _person;

        public Person Person
        {
            get
            {
                _person.FirstName = FirstTextBox.Text;
                _person.LastName = LastNameTextBox.Text;
                _person.Age = Convert.ToInt32(AgeTextBox.Text);
                return _person;
            }
            set
            {
                FirstTextBox.Text = value.FirstName;
                LastNameTextBox.Text = value.LastName;
                AgeTextBox.Text = value.Age.ToString();
                _person = value;
            }
        }
    }
}
