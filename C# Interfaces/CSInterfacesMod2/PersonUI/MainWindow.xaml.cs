using MahApps.Metro.Controls;
using Person;
using System.Collections;
using System.Collections.Generic;
using System.Windows;

namespace PersonUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        PersonRepository peoplerep = new PersonRepository();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConcrete_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            List<Person.Person> people;
            people = peoplerep.GetPeople();
            foreach (var person in people)
                ltbPerson.Items.Add(person);
        }

        private void btnInterface_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            IEnumerable people;
            people = peoplerep.GetPeople();
            foreach (var person in people)
                ltbPerson.Items.Add(person);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            ltbPerson.Items.Clear();
        }
    }
}
