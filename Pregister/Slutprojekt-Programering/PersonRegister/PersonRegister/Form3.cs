using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonRegister
{
    public partial class listForm : Form
    {

        //global funktion
        private Person[] register = new Person[1];

        public listForm()
        {
            InitializeComponent();


            for(int x = 0; x < 120; x++) 
            {
                ageListBox.Items.Add(x);
            }
        }
        //skriver arrayen till en txt fil
        private void Write(Person p)
        {
            //Skriver in den "nya personen" när Write() anropas
            StreamWriter sw = new StreamWriter("register.txt");
            sw.WriteLine( register.Length + 1 );
            sw.WriteLine(p.FirstName);
            sw.WriteLine(p.LastName);
            sw.WriteLine(p.Age);

            //Skriver ut alla befintliga kontakter
            for (int i = 0; i < register.Length; i++)
            {
                sw.WriteLine(register[i].FirstName);
                sw.WriteLine(register[i].LastName);
                sw.WriteLine(register[i].Age);
            }
            sw.Close();
        }
        //Läser in de existerande kontakterna i txt dokumentet
        private void Read() 
        {
            
            //string[] files = Directory.GetFiles(@"C:\Users\Jamiro\source\repos\PersonRegister\PersonRegister\bin\Debug");
            StreamReader sr = new StreamReader("register.txt");
            register = new Person[Convert.ToInt32(sr.ReadLine())];
     
            for (int i = 0; i < register.Length; i++)
            {
                
                register[i] = new Person();
                register[i].FirstName = sr.ReadLine();
                register[i].LastName = sr.ReadLine();
                register[i].Age = int.Parse(sr.ReadLine());
            }
            sr.Close();

        }
        //Visar kontakterna i en lista
        private void Display() 
        {
            listPerson.Items.Clear();
            for (int i = 0; i < register.Length; i++)
            {
                listPerson.Items.Add(register[i].ToString());

            }
        }
        //Anropas för att rensa informationen som finns i textrutorna
        private void clearInfo() 
        {
            firstNameTextBox.Clear();
            secondNameTextBox.Clear();
            ageListBox.ClearSelected();
        }


        private void listViewPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void listForm_Load(object sender, EventArgs e)
        {
            Read();
            Display();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveBttn_Click(object sender, EventArgs e)
        {

            // Vid Save skapas en ny Person i arrayen och informationen sparas
            Person p = new Person();
            
            p.FirstName = firstNameTextBox.Text;
            p.LastName = secondNameTextBox.Text;
            p.Age = ageListBox.SelectedIndex;

            listPerson.Items.Add(p.ToString());
            Write(p);
            Read();
            Display();
            clearInfo();
         
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(firstNameTextBox.Text != "")
            {
                saveBttn.Enabled = true;
            }
            else
            {
                saveBttn.Enabled = false;
            }
        }

        private void secondNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
