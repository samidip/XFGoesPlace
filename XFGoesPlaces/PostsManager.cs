using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;

namespace XFGoesPlaces
{
    public class PostsManager
    {
        public ObservableCollection<Posts> MyPosts = new ObservableCollection<Posts>();
        HttpClient myClient = new HttpClient();

        public async Task<ObservableCollection<Posts>> GetPosts()
        {   
            var response = await myClient.GetAsync(Constants.POSTRestfulAPIEndpoint);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                MyPosts = JsonConvert.DeserializeObject<ObservableCollection<Posts>>(content);
            }

            return MyPosts;
        }

        public ObservableCollection<Posts> FilterPosts(string filterText)
        {
            var FilteredCollection = new ObservableCollection<Posts>(MyPosts.Where(x => x.Title.Contains(filterText.ToLower())));
            return FilteredCollection;
        }

        public PostsManager() { }
    }
}
