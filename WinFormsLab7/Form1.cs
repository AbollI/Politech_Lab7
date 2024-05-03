using System;
using System.Windows.Forms;

namespace WinFormsLab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Program.Globallister.AddNewEntry(0, "id1");
            Program.Globallister.AddNewEntry(1, "id2");
            Program.Globallister.AddNewEntry(2, "id3");
            Program.Globallister.AddNewEntry(3, "id4");
            Program.Globallister.AddNewEntry(4, "id5");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Ratings lister = new Ratings();

            lister.AddNewEntry(0, "1");
            lister.AddNewEntry(1, "2");
            lister.AddNewEntry(3, "3");
            lister.AddNewEntry(4, "4");
            lister.AddNewEntry(5, "5");

            lister.ShiftEmptySlots();
            int g = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //удаляет одну запись в списке и сдвигает оставшиеся записи
            Ratings lister = new Ratings();

            lister.AddNewEntry(0, "1");
            lister.AddNewEntry(1, "2");
            lister.AddNewEntry(2, "3");
            lister.AddNewEntry(3, "4");
            lister.AddNewEntry(4, "5");

            lister.RemoveEntry(1);

            lister.ShiftEmptySlots();
            int g = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ratings lister = new Ratings();

            lister.AddNewEntry(0, "id1");
            lister.AddNewEntry(1, "id2");
            lister.AddNewEntry(2, "id3");
            lister.AddNewEntry(3, "id4");
            lister.AddNewEntry(4, "id5");

            var entrysearch = lister.SearchEntry(1);//должно отдать entrysearch = "id2" 
            var placesearch = lister.SearchPlace("id3");//должно отдать placesearch = "2"
            var errorplacesearch = lister.SearchPlace("id-err");//должно отдать значение "-1" которое является ошибкой
            int g = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Program.Globallister.GetRating();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //get id from textbox2 and delete entry in globallister
            Program.Globallister.RemoveEntry(Program.Globallister.SearchPlace(textBox2.Text));
            Program.Globallister.ShiftEmptySlots();
        }
    }
}
