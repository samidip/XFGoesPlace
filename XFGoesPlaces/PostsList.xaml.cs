using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFGoesPlaces
{
    public partial class PostsList : ContentPage
    {
        PostsManager PostsHandler = new PostsManager();

        public PostsList()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DrawUI();
        }

        public async void DrawUI()
        {
            this.MyPostsList.ItemsSource = await PostsHandler.GetPosts();
        }

        void SearchButtonPressed(System.Object sender, System.EventArgs e)
        {
            var searchText = this.SearchBar.Text;
            this.MyPostsList.ItemsSource = PostsHandler.FilterPosts(searchText);
        }
    }
}
