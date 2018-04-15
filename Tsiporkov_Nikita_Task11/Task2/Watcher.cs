using System;
using System.Collections.Generic;
using System.IO;

namespace Task2
{
    class Watcher
    {
        public int counter = 0;
        private FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
        public Dictionary<int, DateTime> three = new Dictionary<int, DateTime>();
        public DirectoryInfo dir;
        private bool on = false;
        public string way;
        private string repository = @"D:\Epam\-.Net-2018-1-\Tsiporkov_Nikita_Task11\New";
        public bool On
        {
            get
            { return On; }
            set
            {
                if (value == true)
                { Subscribe(); }
                on = value;
            }
        }
        public Watcher(string way)
        {
            this.way = way;
            fileSystemWatcher.Path = way;
            fileSystemWatcher.NotifyFilter =
                NotifyFilters.LastAccess |
                NotifyFilters.LastWrite |
                NotifyFilters.FileName |
                NotifyFilters.DirectoryName;
            fileSystemWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.Size | NotifyFilters.DirectoryName;
            //fileSystemWatcher.Filter = "*.txt";
            fileSystemWatcher.IncludeSubdirectories = true;
            fileSystemWatcher.EnableRaisingEvents = true;
            if (Directory.Exists(repository))
            {
                Directory.Delete(repository, true);
            }
            dir = new DirectoryInfo(repository);
            dir.Create();
        }
        private void OnChanged(object sourse, FileSystemEventArgs eventArgs)
        {
            Console.WriteLine("File :" + eventArgs.Name + "." + eventArgs.ChangeType);
            Console.WriteLine(eventArgs.FullPath);
            ToCopyDir(way, repository);
            three.Add(counter, DateTime.Now);
            counter++;
        }
        private static void OnRenamed(object sourse, RenamedEventArgs eventArgs)
        {
            Console.WriteLine("File : {0} renamed to {1}", eventArgs.OldName, eventArgs.Name);
        }
        private void ToCopyDir(string fromDir, string toDir, bool _counter = true)
        {
            if (_counter)
            {
                toDir += "\\" + counter;
                Directory.CreateDirectory(toDir);
            }
            foreach (var i in Directory.GetFiles(fromDir))
            {
                string str = toDir + "\\" + Path.GetFileName(i);
                File.Copy(i, str);
            }
            foreach (var i in Directory.GetDirectories(fromDir))
            {
                string temp = toDir + "\\" + Path.GetFileName(i);
                Directory.CreateDirectory(temp);
                ToCopyDir(i, temp, false);
            }
        }
        public void RollBack(int version)
        {
            fileSystemWatcher.Created -= new FileSystemEventHandler(OnChanged);
            fileSystemWatcher.Changed -= new FileSystemEventHandler(OnChanged);
            fileSystemWatcher.Deleted -= new FileSystemEventHandler(OnChanged);
            fileSystemWatcher.Renamed -= new RenamedEventHandler(OnRenamed);
            ClearDir(way);
            ToCopyDir(repository + "\\" + version, way, false);
            ClearRepository(repository, version);
            fileSystemWatcher.Created += new FileSystemEventHandler(OnChanged);
            fileSystemWatcher.Changed += new FileSystemEventHandler(OnChanged);
            fileSystemWatcher.Deleted += new FileSystemEventHandler(OnChanged);
            fileSystemWatcher.Renamed += new RenamedEventHandler(OnRenamed);
        }
        public void ClearDir(string way)
        {
            dir = new DirectoryInfo(way);
            foreach (var file in dir.GetFiles())
            {
                file.Delete();
            }
            foreach (var directory in dir.GetDirectories())
            {
                Directory.Delete(way + "\\" + directory, true);
            }
        }
        public void ClearRepository(string way, int currentVersion)
        {
            int temp = three.Count;
            for (int i = currentVersion + 1; i < temp; i++)
            {
                Directory.Delete(way + "\\" + i, true);
                three.Remove(i);
                counter--;
            }
        }
        public void Subscribe()
        {
            fileSystemWatcher.Created += new FileSystemEventHandler(OnChanged);
            fileSystemWatcher.Changed += new FileSystemEventHandler(OnChanged);
            fileSystemWatcher.Deleted += new FileSystemEventHandler(OnChanged);
            fileSystemWatcher.Renamed += new RenamedEventHandler(OnRenamed);
            ToCopyDir(way, repository);
            three.Add(counter, DateTime.Now);
            counter++;
        }
    }
}
