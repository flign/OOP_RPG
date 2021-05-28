using System;
using System.IO;

namespace OOP_RPG
{
    public class FileDatabase
    {
        private string filePath1 = "Hero.txt", filePath2 = "Achievements.csv", filePath3 = "Weapon.txt", filePath4 = "Armor.txt";
        public FileDatabase()
        {
            filePath1 = Environment.CurrentDirectory + @"\" + filePath1;
            filePath2 = Environment.CurrentDirectory + @"\" + filePath2;
            filePath2 = Environment.CurrentDirectory + @"\" + filePath3;
            filePath2 = Environment.CurrentDirectory + @"\" + filePath4;
        }
        public string[] ReadHero()
        {
            if (File.Exists(filePath1))
                return File.ReadAllLines(filePath1);
            else
                return null;
        }
        public string[] ReadAchievements()
        {
            if (File.Exists(filePath2))
                return File.ReadAllLines(filePath2);
            else
                return null;
        }
        /*public string[] ReadSword()
        {
            if (File.Exists(filePath3))
                return File.ReadAllLines(filePath3);
            else
                return null;
        }*/
        public void UpdateFile1(string data)
        {
            File.WriteAllText(filePath1, data);
        }
        public void UpdateFile2(string data)
        {
            File.WriteAllText(filePath2, data);
        }
        public void UpdateFile3(string data)
        {
            File.WriteAllText(filePath3, data);
        }
    }
}
