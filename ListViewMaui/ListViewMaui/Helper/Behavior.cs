using Syncfusion.Maui.ListView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    #region Behavior
    public class Behavior : Behavior<ContentPage>
    {
        #region Fields

        SfListView ListView;
        Button AddButton;
        ContactsViewModel ViewModel;

        #endregion

        #region Overrides
        protected override void OnAttachedTo(ContentPage bindable)
        {
            ListView = bindable.FindByName<SfListView>("listView");
            AddButton = bindable.FindByName<Button>("addButton");

            ViewModel = bindable.BindingContext as ContactsViewModel;
            AddButton.Clicked += AddButton_Clicked;

            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            AddButton.Clicked += AddButton_Clicked;
            ListView = null;
            AddButton = null;
            ViewModel = null;
            base.OnDetachingFrom(bindable);
        }
        #endregion

        #region Private methods

        private void AddButton_Clicked(object sender, EventArgs e)
        {
            this.GenerateInfo();
        }

        private void GenerateInfo()
        {
            Random r = new Random();
            var contactsInfo = new List<Contacts>();
            for (int i = 0; i < 15; i++)
            {
                var contact = new Contacts(ViewModel.CustomerNames[i], r.Next(720, 799).ToString() + " - " + r.Next(3010, 3999).ToString());
                contact.ContactImage = "people_circle" + (i % 19) + ".png";
                contactsInfo.Add(contact);
            }

            ListView.DataSource.BeginInit();
            ViewModel.ContactsInfo.AddRange(contactsInfo);
            ListView.DataSource.EndInit();
        }

        #endregion
    }
    #endregion
}
