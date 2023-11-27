﻿using NewsWebsite.ViewModels.News;
using NewsWebsite.ViewModels.Video;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsWebsite.ViewModels.Home
{
   public class HomePageViewModel
    {
        public List<NewsViewModel> News { get; set; }
        public List<NewsViewModel> MostViewedNews { get; set; }
        public List<NewsViewModel> MostTalkNews { get; set; }
        public List<NewsViewModel> MostPopularNews { get; set; }

        public List<NewsViewModel> InternalNews { get; set; }
        public List<NewsViewModel> ForeignNews { get; set; }
        public List<VideoViewModel> Videos { get; set; }
        public int CountNewsPublished { get; set; }
        public HomePageViewModel(List<NewsViewModel> news, List<NewsViewModel> mostViewedNews, List<NewsViewModel> mostTalkNews, List<NewsViewModel> mostPopularNews, List<NewsViewModel> internalNews, List<NewsViewModel> foreignNews, List<VideoViewModel> videos, int countNewsPublished)

        {
            MostViewedNews = mostViewedNews;
            News = news;
            MostTalkNews = mostTalkNews;
            MostPopularNews = mostPopularNews;
            InternalNews = internalNews;
            ForeignNews = foreignNews;
            Videos = videos;
            CountNewsPublished = countNewsPublished;
        }

        
    }
}
