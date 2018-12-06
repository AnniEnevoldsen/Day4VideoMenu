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
            var vid1 = new Video()
            {
                Id = id++,
                Title = "Big d",
                Genre = "Horror, action"
            };

            var vid2 = new Video()
            {
                Id = id++,
                Title = "lil D",
                Genre = "Comedy"
            };

            videos.Add(vid1);
            videos.Add(vid2);

            Console.WriteLine("Hello yeppeo!");

            string[] menuItems = {
                "List All Videos",
                "Add Video",
                "Delete Video",
                "Edit Video",
                "Exit"
                };

            var selection = PrintMenu(menuItems);

            while (selection != 5)
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
                    default:
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
                Console.WriteLine($"{(i + 1)}: {items[i]}");
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

        private static void VideoList()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("List all videos");

            foreach (var video in videos)
            {
                Console.WriteLine($"Id: {video.Id}, Title: {video.Title}, Genre: {video.Genre}");
            }
            Console.WriteLine("---------------------------------------------------------------");
        }

        private static void UpdateVideo()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Update video");

            var ChosenVideo = FindVideoById();

            Console.Write("Update title: ");
            ChosenVideo.Title = Console.ReadLine();

            Console.Write("Update genre: ");
            ChosenVideo.Genre = Console.ReadLine();

            Console.WriteLine("---------------------------------------------------------------");
        }

        private static void DeleteVideo()
        {
            Console.WriteLine("---------------------------------------------------------------");

            var ChosenVideo = FindVideoById();
            videos.Remove(ChosenVideo);

            Console.WriteLine("---------------------------------------------------------------");
        }

        private static void AddVideo()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Add video");

            Console.Write("Type in the title of the video: ");
            var title = Console.ReadLine();

            Console.Write("Input the video's genre: ");
            var genre = Console.ReadLine();

            var video = new Video();
            video.Id = id++;
            video.Title = title;
            video.Genre = genre;
            videos.Add(video);

            Console.WriteLine("---------------------------------------------------------------");
        }

        private static Video FindVideoById()
        {
            Console.WriteLine("Type in the videos ID");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Try a number instead");
            }
            foreach (var video in videos)
            {
                if (video.Id == id)
                {
                    return video;
                }
            }
            return null;
        }
    }
}
