using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace EntityBuilder
{
    public class Prefs
    {
        protected static Prefs PrefsCache = null;

        protected static string GetPrefsFileName()
        {
            return Path.Combine(Application.LocalUserAppDataPath, "Prefs.xml");
        }

        public static Prefs GetPrefs()
        {
            if (PrefsCache != null)
                return PrefsCache;

            FileInfo prefsFile = new FileInfo(GetPrefsFileName());
            if (!prefsFile.Exists)
                PrefsCache = new Prefs();
            else
            {
                XmlSerializer xml = new XmlSerializer(typeof(Prefs));
                FileStream fs = prefsFile.OpenRead();
                PrefsCache = (Prefs)xml.Deserialize(fs);
                fs.Close();
            }  
            return PrefsCache;
        }

        public static void Save()
        {
            GetPrefs().SaveFile();
        }

        public void SaveFile()
        {
            FileInfo prefsFile = new FileInfo(GetPrefsFileName());
            if (prefsFile.Exists)
                prefsFile.Delete();

            XmlSerializer xml = new XmlSerializer(typeof(Prefs));
            FileStream fs = prefsFile.OpenWrite();
            xml.Serialize(fs,this);
            fs.Close();
        }

        public List<string> RecentFiles = new List<string>();
        public int MaxRecentlyUsedFiles = 10;

        public bool OrthographicView = false;
        public Byte[] BackgroundColor = new Byte[] { 0, 0, 0 };

        public float MajorGridSpacing = 5;
        public float MinorGridSpacing = 1;

        public float OriginSize = 5;

        public Byte[] MajorGridColor = new Byte[] { 125, 125, 125 };
        public Byte[] MinorGridColor = new Byte[] { 75, 75, 75 };

        public float LineWidth = 1;
    }
}
