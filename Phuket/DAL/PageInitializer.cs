using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Phuket.Models;

namespace Phuket.DAL 
{
    public class PageInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PageContext>
    {
        protected override void Seed(PageContext context)
        {
            //var settings = new List<Setting>
            //{
            //    new Setting{SettingSharedLayout="TestSharedLayout1",SettingPageType="TestPageType1"},
            //    new Setting{SettingSharedLayout="TestSharedLayout2",SettingPageType="TestPageType2"},
            //    new Setting{SettingSharedLayout="TestSharedLayout3",SettingPageType="TestPageType3"},
            //};
            //settings.ForEach(s => context.Settings.Add(s));
            //context.SaveChanges();

            //var pages = new List<Page>
            //{
            //    new Page{PageActive=true,PageAuthor="testAuthor1",PageFileName="FileName1",PageLastModified=DateTime.Now,PageTitle="PageTitle1"},
            //    new Page{PageActive=true,PageAuthor="testAuthor2",PageFileName="FileName2",PageLastModified=DateTime.Now,PageTitle="PageTitle2"/*,ParentPageID=1*/},
            //    new Page{PageActive=true,PageAuthor="testAuthor3",PageFileName="FileName3",PageLastModified=DateTime.Now,PageTitle="PageTitle3"/*,ParentPageID=1*/},
            //    new Page{PageActive=true,PageAuthor="testAuthor4",PageFileName="FileName4",PageLastModified=DateTime.Now,PageTitle="PageTitle4"/*,ParentPageID=2*/},
            //};
            //pages.ForEach(s => context.Pages.Add(s));
            //context.SaveChanges();

            //var contentBlocks = new List<ContentBlock>
            //{
            //    new ContentBlock{ContentBlockHeaderTitle="ContentTitle1",ContentBlockSummary="ContentSummary1",ContentBlockParentContentBlock=false},
            //    new ContentBlock{ContentBlockHeaderTitle="ContentTitle2",ContentBlockSummary="ContentSummary2",ContentBlockParentContentBlock=true,ParentContentBlockID=1},
            //    new ContentBlock{ContentBlockHeaderTitle="ContentTitle3",ContentBlockSummary="ContentSummary3",ContentBlockParentContentBlock=true,ParentContentBlockID=1},
            //    new ContentBlock{ContentBlockHeaderTitle="ContentTitle4",ContentBlockSummary="ContentSummary4",ContentBlockParentContentBlock=true,ParentContentBlockID=2},
            //    new ContentBlock{ContentBlockHeaderTitle="ContentTitle5",ContentBlockSummary="ContentSummary5",ContentBlockParentContentBlock=true,ParentContentBlockID=3},
            //};
            //contentBlocks.ForEach(s => context.ContentBlocks.Add(s));
            //context.SaveChanges();

            //var mediaCategories = new List<MediaCategory>
            //{
            //    new MediaCategory{MediaCategoryType="Image"},
            //    new MediaCategory{MediaCategoryType="Doc"},
            //    new MediaCategory{MediaCategoryType="Text"},
            //};
            //mediaCategories.ForEach(s => context.MediaCategories.Add(s));
            //context.SaveChanges();

            //var mediaItems = new List<MediaItem>
            //{
            //    new MediaItem{MediaItemActive=true,MediaItemHeight=200,MediaItemWidth=200,MediaItemLongDescription="LongDesc1",MediaItemShortDescription="ShortDesc1",MediaItemURL="url1"},
            //    new MediaItem{MediaItemActive=true,MediaItemHeight=200,MediaItemWidth=200,MediaItemLongDescription="LongDesc2",MediaItemShortDescription="ShortDesc1",MediaItemURL="url2"},
            //    new MediaItem{MediaItemActive=true,MediaItemHeight=200,MediaItemWidth=200,MediaItemLongDescription="LongDesc3",MediaItemShortDescription="ShortDesc1",MediaItemURL="url3"},
            //};
            //mediaItems.ForEach(s => context.MediaItems.Add(s));
            //context.SaveChanges();

            //var tags = new List<Tag>
            //{
            //    new Tag{TagKeyword="Keyword1"},
            //    new Tag{TagKeyword="Keyword2"},
            //    new Tag{TagKeyword="Keyword3"},
            //};
            //tags.ForEach(s => context.Tags.Add(s));
            //context.SaveChanges();
        }
    }
}