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
            {
                PrefsCache = new Prefs();
                PrefsCache.SetDefaults();
            }
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
        public List<byte> BackgroundColor = new List<Byte>();

        public float MajorGridSpacing = 5;
        public float MinorGridSpacing = 1;

        public float OriginSize = 5;

        public List<byte> MajorGridColor = new List<Byte>();
        public List<byte> MinorGridColor = new List<Byte>();

        public float LineWidth = 1;

        protected void SetDefaults()
        {
            MajorGridColor = new List<Byte>(new Byte[] { 125, 125, 125 });
            MinorGridColor = new List<Byte>(new Byte[] { 75, 75, 75 });
            BackgroundColor = new List<Byte>(new Byte[] { 0, 0, 0 });
        }
    }
}
