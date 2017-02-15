using System;
using Xamarin.Forms;

namespace MyContacts
{
    public partial class ContactDetails : ContentPage
    {
        readonly Person person;

		public ContactDetails(Person person)
        {
			BindingContext = person;
            this.person = person;
            InitializeComponent();
        }

		void OnShow(object sender, EventArgs e)
		{
			person.Dob = person.Dob.AddYears(1);
		    this.DisplayAlert("Selected Contact", person.ToString(), "OK");
		}
    }
}
