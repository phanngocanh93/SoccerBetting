﻿using SoccerBetting.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerBetting.ViewModels
{
    public class TournamentViewModel : BaseViewModel
    {
        public IList<New> News { get; set; }
        public TournamentResponse response { get; set; } = new TournamentResponse();

        public TournamentViewModel()
        {
            getNews();
            getTableResult();
        }

        private void getTableResult()
        {
            var listOfTableResultList = new List<TableResultList>();
            var team = new Team { Id = 1, Name = "VietNam", Image = "vn.png" };

            var tblResultLists = new TableResultList()
            {
                new TableResult { Position = 1, Team = team, MatchKicked = 3, Point = 9, WLIndex = "6-6" },
                new TableResult { Position = 2, Team = team, MatchKicked = 3, Point = 6, WLIndex = "5-6" },
                new TableResult { Position = 3, Team = team, MatchKicked = 3, Point = 3, WLIndex = "4-1" },
                new TableResult { Position = 4, Team = team, MatchKicked = 3, Point = 1, WLIndex = "1-10" }
            };
            tblResultLists.TableName = "A";
            listOfTableResultList.Add(tblResultLists);

            var tblResultLists2 = new TableResultList()
            {
                new TableResult { Position = 1, Team = team, MatchKicked = 3, Point = 9, WLIndex = "6-6" },
                new TableResult { Position = 2, Team = team, MatchKicked = 3, Point = 6, WLIndex = "5-6" },
                new TableResult { Position = 3, Team = team, MatchKicked = 3, Point = 3, WLIndex = "4-1" },
                new TableResult { Position = 4, Team = team, MatchKicked = 3, Point = 1, WLIndex = "1-10" }
            };
            tblResultLists2.TableName = "B";
            listOfTableResultList.Add(tblResultLists2);

            var tblResultLists3 = new TableResultList()
            {
                new TableResult { Position = 1, Team = team, MatchKicked = 3, Point = 9, WLIndex = "6-6" },
                new TableResult { Position = 2, Team = team, MatchKicked = 3, Point = 6, WLIndex = "5-6" },
                new TableResult { Position = 3, Team = team, MatchKicked = 3, Point = 3, WLIndex = "4-1" },
                new TableResult { Position = 4, Team = team, MatchKicked = 3, Point = 1, WLIndex = "1-10" }
            };
            tblResultLists3.TableName = "C";
            listOfTableResultList.Add(tblResultLists3);

            var tblResultLists4 = new TableResultList()
            {
                new TableResult { Position = 1, Team = team, MatchKicked = 3, Point = 9, WLIndex = "6-6" },
                new TableResult { Position = 2, Team = team, MatchKicked = 3, Point = 6, WLIndex = "5-6" },
                new TableResult { Position = 3, Team = team, MatchKicked = 3, Point = 3, WLIndex = "4-1" },
                new TableResult { Position = 4, Team = team, MatchKicked = 3, Point = 1, WLIndex = "1-10" }
            };
            tblResultLists4.TableName = "D";
            listOfTableResultList.Add(tblResultLists4);

            response.TblResult = listOfTableResultList[0];
            response.ListOfTblResult = listOfTableResultList;
        }

        private void getNews()
        {
            News = new List<New>();

            News.Add(new New
            {
                Id = 1,
                Title = "American Black Bear",
                Description = "The American black bear is a medium-sized bear native to North America. It is the continent's smallest and most widely distributed bear species. American black bears are omnivores, with their diets varying greatly depending on season and location. They typically live in largely forested areas, but do leave forests in search of food. Sometimes they become attracted to human communities because of the immediate availability of food. The American black bear is the world's most common bear species.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg"
            });

            News.Add(new New
            {
                Id = 2,
                Title = "Asian Black Bear",
                Description = "The Asian black bear, also known as the moon bear and the white-chested bear, is a medium-sized bear species native to Asia and largely adapted to arboreal life. It lives in the Himalayas, in the northern parts of the Indian subcontinent, Korea, northeastern China, the Russian Far East, the Honshū and Shikoku islands of Japan, and Taiwan. It is classified as vulnerable by the International Union for Conservation of Nature (IUCN), mostly because of deforestation and hunting for its body parts.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG"
            });

            News.Add(new New
            {
                Id = 3,
                Title = "Brown Bear",
                Description = "The brown bear is a bear that is found across much of northern Eurasia and North America. In North America the population of brown bears are often called grizzly bears. It is one of the largest living terrestrial members of the order Carnivora, rivaled in size only by its closest relative, the polar bear, which is much less variable in size and slightly larger on average. The brown bear's principal range includes parts of Russia, Central Asia, China, Canada, the United States, Scandinavia and the Carpathian region, especially Romania, Anatolia and the Caucasus. The brown bear is recognized as a national and state animal in several European countries.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5d/Kamchatka_Brown_Bear_near_Dvuhyurtochnoe_on_2015-07-23.jpg/320px-Kamchatka_Brown_Bear_near_Dvuhyurtochnoe_on_2015-07-23.jpg"
            });

            News.Add(new New
            {
                Id = 4,
                Title = "Giant Panda",
                Description = "The giant panda, also known as panda bear or simply panda, is a bear native to south central China. It is easily recognized by the large, distinctive black patches around its eyes, over the ears, and across its round body. The name giant panda is sometimes used to distinguish it from the unrelated red panda. Though it belongs to the order Carnivora, the giant panda's diet is over 99% bamboo. Giant pandas in the wild will occasionally eat other grasses, wild tubers, or even meat in the form of birds, rodents, or carrion. In captivity, they may receive honey, eggs, fish, yams, shrub leaves, oranges, or bananas along with specially prepared food.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Grosser_Panda.JPG/320px-Grosser_Panda.JPG"
            });

            News.Add(new New
            {
                Id = 5,
                Title = "Grizzly-Polar Bear Hybrid",
                Description = "A grizzly–polar bear hybrid is a rare ursid hybrid that has occurred both in captivity and in the wild. In 2006, the occurrence of this hybrid in nature was confirmed by testing the DNA of a unique-looking bear that had been shot near Sachs Harbour, Northwest Territories on Banks Island in the Canadian Arctic. The number of confirmed hybrids has since risen to eight, all of them descending from the same female polar bear.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7e/Grolar.JPG/276px-Grolar.JPG"
            });

            News.Add(new New
            {
                Id = 6,
                Title = "Sloth Bear",
                Description = "The sloth bear is an insectivorous bear species native to the Indian subcontinent. It is listed as Vulnerable on the IUCN Red List, mainly because of habitat loss and degradation. It has also been called labiated bear because of its long lower lip and palate used for sucking insects. Compared to brown and black bears, the sloth bear is lankier, has a long, shaggy fur and a mane around the face, and long, sickle-shaped claws. It evolved from the ancestral brown bear during the Pleistocene and through convergent evolution shares features found in insect-eating mammals.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/Sloth_Bear_Washington_DC.JPG/320px-Sloth_Bear_Washington_DC.JPG"
            });

            News.Add(new New
            {
                Id = 7,
                Title = "Sun Bear",
                Description = "The sun bear is a bear species occurring in tropical forest habitats of Southeast Asia. It is listed as Vulnerable on the IUCN Red List. The global population is thought to have declined by more than 30% over the past three bear generations. Suitable habitat has been dramatically reduced due to the large-scale deforestation that has occurred throughout Southeast Asia over the past three decades. The sun bear is also known as the honey bear, which refers to its voracious appetite for honeycombs and honey.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Sitting_sun_bear.jpg/319px-Sitting_sun_bear.jpg"
            });

            News.Add(new New
            {
                Id = 8,
                Title = "Polar Bear",
                Description = "The polar bear is a hypercarnivorous bear whose native range lies largely within the Arctic Circle, encompassing the Arctic Ocean, its surrounding seas and surrounding land masses. It is a large bear, approximately the same size as the omnivorous Kodiak bear. A boar (adult male) weighs around 350–700 kg (772–1,543 lb), while a sow (adult female) is about half that size. Although it is the sister species of the brown bear, it has evolved to occupy a narrower ecological niche, with many body characteristics adapted for cold temperatures, for moving across snow, ice and open water, and for hunting seals, which make up most of its diet. Although most polar bears are born on land, they spend most of their time on the sea ice. Their scientific name means maritime bear and derives from this fact. Polar bears hunt their preferred food of seals from the edge of sea ice, often living off fat reserves when no sea ice is present. Because of their dependence on the sea ice, polar bears are classified as marine mammals.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/6/66/Polar_Bear_-_Alaska_%28cropped%29.jpg"
            });

            News.Add(new New
            {
                Id = 9,
                Title = "Spectacled Bear",
                Description = "The spectacled bear, also known as the Andean bear or Andean short-faced bear and locally as jukumari (Aymara), ukumari (Quechua) or ukuku, is the last remaining short-faced bear. Its closest relatives are the extinct Florida spectacled bear, and the giant short-faced bears of the Middle to Late Pleistocene age. Spectacled bears are the only surviving species of bear native to South America, and the only surviving member of the subfamily Tremarctinae. The species is classified as Vulnerable by the IUCN because of habitat loss.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Spectacled_Bear_-_Houston_Zoo.jpg/264px-Spectacled_Bear_-_Houston_Zoo.jpg"
            });

            News.Add(new New
            {
                Id = 10,
                Title = "Cave Bear",
                Description = "The cave bear was a species of bear that lived in Europe and Asia during the Pleistocene and became extinct about 24,000 years ago during the Last Glacial Maximum. Both the word cave and the scientific name spelaeus are used because fossils of this species were mostly found in caves. This reflects the views of experts that cave bears may have spent more time in caves than the brown bear, which uses caves only for hibernation.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6a/Teufelshöhle-Höhlenbär-Dreiviertelprofil.jpg/320px-Teufelshöhle-Höhlenbär-Dreiviertelprofil.jpg"
            });

            News.Add(new New
            {
                Id = 11,
                Title = "Short-faced Bear",
                Description = "The short-faced bears is an extinct bear genus that inhabited North America during the Pleistocene epoch from about 1.8 Mya until 11,000 years ago. It was the most common early North American bear and was most abundant in California. There are two recognized species: Arctodus pristinus and Arctodus simus, with the latter considered to be one of the largest known terrestrial mammalian carnivores that has ever existed. It has been hypothesized that their extinction coincides with the Younger Dryas period of global cooling commencing around 10,900 BC.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/ArctodusSimusSkeleton.jpg/320px-ArctodusSimusSkeleton.jpg"
            });

            News.Add(new New
            {
                Id = 12,
                Title = "California Grizzly Bear",
                Description = "The California grizzly bear is an extinct subspecies of the grizzly bear, the very large North American brown bear. Grizzly could have meant grizzled (that is, with golden and grey tips of the hair) or fear-inspiring. Nonetheless, after careful study, naturalist George Ord formally classified it in 1815 – not for its hair, but for its character – as Ursus horribilis (terrifying bear). Genetically, North American grizzlies are closely related; in size and coloring, the California grizzly bear was much like the grizzly bear of the southern coast of Alaska. In California, it was particularly admired for its beauty, size and strength. The grizzly became a symbol of the Bear Flag Republic, a moniker that was attached to the short-lived attempt by a group of American settlers to break away from Mexico in 1846. Later, this rebel flag became the basis for the state flag of California, and then California was known as the Bear State.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/d/de/Monarch_the_bear.jpg"
            });
        }
    }
}