**[View document in Syncfusion .NET MAUI Knowledge Base](https://www.syncfusion.com/kb/13158/how-to-improve-performance-when-doing-bulk-changes-in-net-maui-listview-sflistview)**

## Sample

```xaml
<StackLayout>
    <Button x:Name="addButton" Text="Populate ListView items" HeightRequest="50"/>
    <ListView:SfListView x:Name="listView" 
                        ItemSize="60" 
                        ItemsSource="{Binding ContactsInfo}"
                        HorizontalOptions="FillAndExpand"
                        VerticalOptions="FillAndExpand">

        <ListView:SfListView.ItemTemplate>
            <DataTemplate>
                <code>
                . . .
                . . .
                <code>
            </DataTemplate>
        </ListView:SfListView.ItemTemplate>
    </ListView:SfListView>
</StackLayout>

C#:

AddButton.Clicked += AddButton_Clicked;

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
```