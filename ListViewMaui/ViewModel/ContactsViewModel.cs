﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    public class ContactsViewModel : INotifyPropertyChanged
    {
        #region Properties

        public ObservableCollection<Contacts> contactsinfo { get; set; }
        public double HeightRequest { get; set; }
        #endregion

        #region Constructor

        public ContactsViewModel()
        {
            contactsinfo = new ObservableCollection<Contacts>();
            GenerateInfo();
        }

        public void GenerateInfo()
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                var contact = new Contacts(CustomerNames[i], r.Next(720, 799).ToString() + " - " + r.Next(3010, 3999).ToString());
                contact.ContactImage = ImageSource.FromResource("ListViewMaui.Images.Image" + r.Next(0, 28) + ".png");
                contact.Availability = this.availability[i];
                contactsinfo.Add(contact);
            }
        }
        #endregion

        #region Fields

        bool?[] availability = new bool?[]
        {
            true,
            false,
            false,
            true,
            null,
            false,
            null,
            true,
            true,
            null,
        };

        string[] CustomerNames = new string[] {
            "Kyle",
            "Gina",
            "Irene",
            "Katie",
            "Michael",
            "Oscar",
            "Ralph",
            "Torrey",
            "William",
            "Bill",
            "Daniel",
            "Frank",
            "Brenda",
            "Danielle",
            "Fiona",
            "Howard",
            "Jack",
            "Larry",
            "Holly",
            "Jennifer",
            "Liz",
            "Pete",
            "Steve",
            "Vince",
            "Zeke",
            "Aiden",
            "Jackson",
            "Mason",
            "Liam",
            "Jacob",
            "Jayden",
            "Ethan",
            "Noah",
            "Lucas",
            "Logan",
            "Caleb",
            "Caden",
            "Jack",
            "Ryan",
            "Connor",
            "Michael",
            "Elijah",
            "Brayden",
            "Benjamin",
            "Nicholas",
            "Alexander",
            "William",
            "Matthew",
            "James",
            "Landon",
            "Nathan",
            "Dylan",
            "Evan",
            "Luke",
            "Andrew",
            "Gabriel",
            "Gavin",
            "Joshua",
            "Owen",
            "Daniel",
            "Carter",
            "Tyler",
            "Cameron",
            "Christian",
            "Wyatt",
            "Henry",
            "Eli",
            "Joseph",
            "Max",
            "Isaac",
            "Samuel",
            "Anthony",
            "Grayson",
            "Zachary",
            "David",
            "Christopher",
            "John",
            "Isaiah",
            "Levi",
            "Jonathan",
            "Oliver",
            "Chase",
            "Cooper",
            "Tristan",
            "Colton",
            "Austin",
            "Colin",
            "Charlie",
            "Dominic",
            "Parker",
            "Hunter",
            "Thomas",
            "Alex",
            "Ian",
            "Jordan",
            "Cole",
            "Julian",
            "Aaron",
            "Carson",
            "Miles",
            "Blake",
            "Brody",
            "Adam",
            "Sebastian",
            "Adrian",
            "Nolan",
            "Sean",
            "Riley",
            "Bentley",
            "Xavier",
            "Hayden",
            "Jeremiah",
            "Jason",
            "Jake",
            "Asher",
            "Micah",
            "Jace",
            "Brandon",
            "Josiah",
            "Hudson",
            "Nathaniel",
            "Bryson",
            "Ryder",
            "Justin",
            "Bryce",
        };

        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
