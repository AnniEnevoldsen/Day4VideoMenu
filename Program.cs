using System;
using System.Collections.Generic;

namespace Day4VideoMenu
{
    class Program
    {
        static int id = 1;
        static List<Video> videos = new List<Video>();


        static void Main(string[] args)
        {
            var cust1 = new Video()
            {
                Id = id++,
                Title = "A",
                Genre = "B"
            };

            videos.Add(cust1);

            Console.WriteLine("Hello yeppeo!");
           // MenuSelection();
            

            string[] menuItems = {
                "List All Videos",
                "Add Video",
                "Delete Video",
                "Edit Video",
                "Exit"
                };

            var selection = PrintMenu(menuItems);

            while (selection != 4)
            {
            switch (selection)
            {
                case 1:
                    VideoList();
                    break;
                case 2:
                    AddVideo();
                    break;
                case 3:
                    DeleteVideo();
                    break;
                case 4:
                    UpdateVideo();
                    break;
                    case 5:
                        Console.WriteLine("Exit");
                        break;
                default:
                    Console.WriteLine("nop, twy agwain");
                    break;
            }
               selection = PrintMenu(menuItems);
            }
            
           

            Console.ReadLine();
        }

        private static int PrintMenu(string[] items)
        {
            Console.WriteLine("");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{(i+1)}: {items[i]}");
            }
            Console.WriteLine();
            Console.Write("What would you like to do: ");



            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                || selection < 1
                || selection > 5)
            {
                Console.WriteLine("Please select a number between 1-5");
            }

            return selection;
        }

        private static void MenuSelection()
        {
            Console.WriteLine("Select an option");
            var s = int.Parse(Console.ReadLine());
            //show menu
            
            Console.ReadLine();
        }

        private static void VideoList()
        {
            Console.WriteLine("List all videos");
        }

        private static void UpdateVideo()
        {
            Console.WriteLine("Update video");
        }

        private static void DeleteVideo()
        {
            Console.WriteLine("Delete video");
        }

        private static void AddVideo()
        {

            Console.WriteLine("Add video");

            //Console.Write("Type in the title of the video");
            //var title = Console.ReadLine();

            //Console.WriteLine("Input the video's genre");
            //var genre = Console.ReadLine();

            //var video = new Video();
            //video.Id = id++;
            //video.Title = title;
            //video.Genre = genre;

        }
    }
}
