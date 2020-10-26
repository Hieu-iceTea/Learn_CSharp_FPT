using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_UWP.Pages.Lab.Lab_44_Adeptly_Adaptive_Challenge.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }
    }

    public class NewsManager
    {
        private static List<NewsItem> GetNewsItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Financial Headline", Subhead = "Subhead", DateLine = "DateLine", Image = "/Assets/Logo.png" });
            items.Add(new NewsItem() { Id = 2, Category = "Financial", Headline = "Headline", Subhead = "Subhead", DateLine = "DateLine", Image = "/Assets/Logo.png" });
            items.Add(new NewsItem() { Id = 3, Category = "Financial", Headline = "Headline", Subhead = "Subhead", DateLine = "DateLine", Image = "/Assets/Logo.png" });
            items.Add(new NewsItem() { Id = 4, Category = "Financial", Headline = "Headline", Subhead = "Subhead", DateLine = "DateLine", Image = "/Assets/Logo.png" });
            items.Add(new NewsItem() { Id = 5, Category = "Financial", Headline = "Headline", Subhead = "Subhead", DateLine = "DateLine", Image = "/Assets/Logo.png" });

            items.Add(new NewsItem() { Id = 6, Category = "Food", Headline = "Food Headline", Subhead = "Subhead", DateLine = "DateLine", Image = "/Assets/Logo.png" });
            items.Add(new NewsItem() { Id = 7, Category = "Food", Headline = "Headline", Subhead = "Subhead", DateLine = "DateLine", Image = "/Assets/Logo.png" });
            items.Add(new NewsItem() { Id = 8, Category = "Food", Headline = "Headline", Subhead = "Subhead", DateLine = "DateLine", Image = "/Assets/Logo.png" });
            items.Add(new NewsItem() { Id = 9, Category = "Food", Headline = "Headline", Subhead = "Subhead", DateLine = "DateLine", Image = "/Assets/Logo.png" });
            items.Add(new NewsItem() { Id = 10, Category = "Food", Headline = "Headline", Subhead = "Subhead", DateLine = "DateLine", Image = "/Assets/Logo.png" });

            return items;
        }

        public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = GetNewsItems();

            var filteredNewsItems = allItems
                .Where(p => p.Category == category)
                .ToList();

            newsItems.Clear();

            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }
    }
}
