using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;


namespace _17
{
    public partial class Form1 : Form
    {
        private readonly HttpClient httpClient;
        public Form1()
        {
            InitializeComponent();
            httpClient = new HttpClient();
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            string author = AuthorTextBox.Text;
            string title = TitleTextBox.Text;

            string url = $"https://openlibrary.org/search.json?author={author}&title={title}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(json);

                    BookListBox.Items.Clear();

                    foreach (JToken book in data["docs"])
                    {
                        string bookInfo = $"Назва: {book["title"]}\n Автор: {string.Join(", ", book["author_name"])}\n Рік видання: {book["first_publish_year"]}";
                        BookListBox.Items.Add(bookInfo);
                    }
                }
                else
                {
                    MessageBox.Show("Помилка виконання запиту до API");
                }
            }
        }
    }
}
