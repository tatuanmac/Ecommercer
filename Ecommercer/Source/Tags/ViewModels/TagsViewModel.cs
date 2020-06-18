using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Ecommercer.Source.Common.Bases;
using Ecommercer.Source.Tags.Model;
using Prism.Navigation;

namespace Ecommercer.Source.Tags.ViewModels
{
    public class TagsViewModel : TabbedViewModelBase
    {
        readonly Random Random = new Random();

        public ObservableCollection<TagsModel> Tags { get; set; } = new ObservableCollection<TagsModel>
        {
            new TagsModel
            {
                 Tag_title =  "mlem 1"
            },
            new TagsModel
            {
                 Tag_title =  "mlem 2"
            },
            new TagsModel
            {
                 Tag_title =  "mlem 3"
            },
            new TagsModel
            {
                 Tag_title =  "mlem 4"
            },
            new TagsModel
            {
                 Tag_title =  "mlem 5"
            },
            new TagsModel
            {
                 Tag_title =  "mlem 6"
            },
            new TagsModel
            {
                 Tag_title =  "mlem 7"
            },
            new TagsModel
            {
                 Tag_title =  "mlem 8"
            },
            new TagsModel
            {
                 Tag_title =  "mlem 9"
            },
            new TagsModel
            {
                 Tag_title =  "mlem 10"
            },
            new TagsModel
            {
                 Tag_title =  "mlem 11"
            },
            new TagsModel
            {
                 Tag_title =  "mlem 5"
            },
            new TagsModel
            {
                 Tag_title =  "mlem 6"
            },
            new TagsModel
            {
                 Tag_title =  "mlem 7"
            },
            new TagsModel
            {
                 Tag_title =  "mlem 8"
            },
            new TagsModel
            {
                 Tag_title =  "mlem 9"
            }
        };


        public TagsViewModel(INavigationService navigationService) : base(navigationService)
        {
            foreach (var tag in Tags)
            {
                tag.TagSize = Random.Next(80, 130);
                tag.SizeRadius = tag.TagSize / 2;
            }
        }
    }
}
