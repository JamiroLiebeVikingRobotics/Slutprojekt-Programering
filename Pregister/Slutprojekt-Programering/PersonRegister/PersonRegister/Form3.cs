using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PersonRegister
{
    public partial class listForm : Form
    {

        //registrer[] skapas
        private Person[] register = new Person[1];

        //Denna måste vara public då den kommunicerar med Form1.cs
        public listForm()
        {
            InitializeComponent();

            // Genererar contents i AgeList
            for(int x = 0; x < 120; x++) 
            {
                ageListBox.Items.Add(x);
            }
        }

        //skriver arrayen till en txt fil
        private void Write(Person p)
        {
            //Skriver in den "nya personen" när Write() anropas. SteamWriter skriver in i "register.txt" och skriver in namn, ålder rad för rad.
            StreamWriter sw = new StreamWriter("register.txt");
            sw.WriteLine(register.Length + 1 );
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
        //Läser in de existerande kontakterna och lägger till dessa i register.txt
        private void Read() 
        {
            
           //Väljer vilket dokument som ska läsas
            StreamReader sr = new StreamReader("register.txt");
            //Anropar Person konstruktorn
            register = new Person[Convert.ToInt32(sr.ReadLine())];
            
            for (int i = 0; i < register.Length; i++)
            {
                
                register[i] = new Person();
                register[i].FirstName = sr.ReadLine();
                register[i].LastName = sr.ReadLine();
                register[i].Age = int.Parse(sr.ReadLine().ToString());
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
        //När formen laddas in anropas Read() och Display()
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
            //Anropar ToString() för att få rätt format till listan
            listPerson.Items.Add(p.ToString());

            //Writar till txt filen läser in alla personer diplayar dem och clearar sedan input rutorna
            Write(p);
            Read();
            Display();
            clearInfo();
         
        }

        // Saveknappen aktivieras först om ett namn har angets
        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(firstNameTextBox.Text != "" )
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void searchKey_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            //Skapar en ny lista för att spara positionen av den hittade personen samt rensar resultatboxen och listan
            List<int>searchCache = new List<int>();
            searchResultBox.Items.Clear();
            searchCache.Clear();

            //När sökknappen trycks tas inputen från searchKey och linjär sökning mot register[] genomförs, det som matchar Key såaras i searchcachen
            string Key = searchKey.Text;
            for (int i = 0; i < register.Length; i++)
            {
                if (register[i].Age.ToString().Contains(Key))
                    searchCache.Add(i);

                else if (register[i].FirstName.Contains(Key))
                    searchCache.Add(i);

                else if (register[i].LastName.Contains(Key))
                      searchCache.Add(i); 
                

            }
      

            //displayar träffarna eller om inget hittas 
            foreach (int i in searchCache)
	        {
                searchResultBox.Items.Add(register[i]);
	        }

            if (searchCache.Count == 0) 
            {
                searchResultBox.Items.Add("Sökningen matchade inga resultat");
            }
        }

        private void searchResultBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listPerson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
