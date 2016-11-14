namespace Phuket.Migrations
{
    using Phuket.Models;
    using Phuket.DAL;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Phuket.DAL.PageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Phuket.DAL.PageContext context)
        {
            var settings = new List<PageSetting>
            {
                new PageSetting{SettingSharedLayout="TestSharedLayout1",SettingPageType="TestPageType1"},
                new PageSetting{SettingSharedLayout="TestSharedLayout2",SettingPageType="TestPageType2"},
                new PageSetting{SettingSharedLayout="TestSharedLayout3",SettingPageType="TestPageType3"},
            };
            settings.ForEach(s => context.Settings.Add(s));
            context.SaveChanges();

            var pages = new List<Page>
            {
                new Page{PageActive=true,PageAuthor="testAuthor1",PageFileName="FileName1",PageLastModified=DateTime.Now,PageTitle="PageTitle1", SettingID=1},
                new Page{PageActive=true,PageAuthor="testAuthor2",PageFileName="FileName2",PageLastModified=DateTime.Now,PageTitle="PageTitle2", SettingID=1/*,ParentPageID=1*/},
                new Page{PageActive=true,PageAuthor="testAuthor3",PageFileName="FileName3",PageLastModified=DateTime.Now,PageTitle="PageTitle3", SettingID=2/*,ParentPageID=1*/},
                new Page{PageActive=true,PageAuthor="testAuthor4",PageFileName="FileName4",PageLastModified=DateTime.Now,PageTitle="PageTitle4", SettingID=3/*,ParentPageID=2*/},
            };
            pages.ForEach(s => context.Pages.Add(s));
            context.SaveChanges();

            var contentCategories = new List<ContentCategory>
            {
                new ContentCategory{ContentCategoryType="Image"},
                new ContentCategory{ContentCategoryType="Doc"},
                new ContentCategory{ContentCategoryType="Text"},
            };
            contentCategories.ForEach(s => context.ContentCategories.Add(s));
            context.SaveChanges();

            var contentBlocks = new List<ContentBlock>
            {
                new ContentBlock{ContentBlockHeaderTitle="ContentTitle1",ContentBlockSummary="ContentSummary1",ContentBlockParentContentBlock=false},
                new ContentBlock{ContentBlockHeaderTitle="ContentTitle2",ContentBlockSummary="ContentSummary2",ContentBlockParentContentBlock=true,ParentContentBlockID=1},
                new ContentBlock{ContentBlockHeaderTitle="ContentTitle3",ContentBlockSummary="ContentSummary3",ContentBlockParentContentBlock=true,ParentContentBlockID=1},
                new ContentBlock{ContentBlockHeaderTitle="ContentTitle4",ContentBlockSummary="ContentSummary4",ContentBlockParentContentBlock=true,ParentContentBlockID=2},
                new ContentBlock{ContentBlockHeaderTitle="ContentTitle5",ContentBlockSummary="ContentSummary5",ContentBlockParentContentBlock=true,ParentContentBlockID=3},
            };
            contentBlocks.ForEach(s => context.ContentBlocks.Add(s));
            context.SaveChanges();

            var mediaCategories = new List<MediaCategory>
            {
                new MediaCategory{MediaCategoryType="Image"},
                new MediaCategory{MediaCategoryType="Doc"},
                new MediaCategory{MediaCategoryType="Text"},
            };
            mediaCategories.ForEach(s => context.MediaCategories.Add(s));
            context.SaveChanges();

            var mediaItems = new List<Media>
            {
                new Media{MediaItemActive=true,MediaItemHeight=200,MediaItemWidth=200,MediaItemLongDescription="LongDesc1",MediaItemShortDescription="ShortDesc1",MediaItemURL="url1", MediaCategoryID=1},
                new Media{MediaItemActive=true,MediaItemHeight=200,MediaItemWidth=200,MediaItemLongDescription="LongDesc2",MediaItemShortDescription="ShortDesc1",MediaItemURL="url2", MediaCategoryID=2},
                new Media{MediaItemActive=true,MediaItemHeight=200,MediaItemWidth=200,MediaItemLongDescription="LongDesc3",MediaItemShortDescription="ShortDesc1",MediaItemURL="url3", MediaCategoryID=3},
            };
            mediaItems.ForEach(s => context.MediaItems.Add(s));
            context.SaveChanges();

            var tags = new List<Tag>
            {
                new Tag{TagKeyword="Keyword1"},
                new Tag{TagKeyword="Keyword2"},
                new Tag{TagKeyword="Keyword3"},
            };
            tags.ForEach(s => context.Tags.Add(s));
            context.SaveChanges();
        }
    }
}
