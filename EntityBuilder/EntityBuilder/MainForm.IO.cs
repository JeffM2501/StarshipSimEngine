using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

using SimCore.Entities;

namespace EntityBuilder
{
    partial class MainForm
    {
        protected void SetUpMRU()
        {
            Prefs prefs = Prefs.GetPrefs();
            recentToolStripMenuItem.DropDownItems.Clear();
            foreach (string file in prefs.RecentFiles)
            {
                ToolStripMenuItem menu = new ToolStripMenuItem(Path.GetFileNameWithoutExtension(file));
                menu.Tag = file;
                menu.Click += new EventHandler(MRUmenu_Click);
                recentToolStripMenuItem.DropDownItems.Add(menu);
            }
        }

        protected void AddMRUItem(string filename)
        {
            Prefs prefs = Prefs.GetPrefs();

            if (prefs.RecentFiles.Contains(filename))
                prefs.RecentFiles.Remove(filename);

            prefs.RecentFiles.Insert(0, filename);
            if (prefs.RecentFiles.Count > prefs.MaxRecentlyUsedFiles)
                prefs.RecentFiles.RemoveRange(prefs.MaxRecentlyUsedFiles - 1, prefs.RecentFiles.Count - prefs.MaxRecentlyUsedFiles);

            Prefs.Save();
            SetUpMRU();
        }

        protected void RemoveMRUItem(string filename)
        {
            Prefs prefs = Prefs.GetPrefs();

            if (prefs.RecentFiles.Contains(filename))
                prefs.RecentFiles.Remove(filename);

            Prefs.Save();
            SetUpMRU();
        }

        void MRUmenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            if (menu == null || menu.Tag == null)
                return;

            string file = menu.Tag as string;
            if (!File.Exists(file))
                RemoveMRUItem(file);
            else
                OpenFile(file);
        }

        protected Type GetDeserializationType(string filename)
        {
            Type serialType = typeof(Entity);

            XmlReader reader = XmlReader.Create(filename);

            bool isCelestial = false;
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "EntityType")
                        {
                            reader.Read();
                            if (reader.NodeType != XmlNodeType.Text)
                                continue;

                            if (reader.Value == "Ship")
                                return typeof(StarShip);
                            else if (reader.Value == "Celestial")
                                isCelestial = true;
                            else
                                return typeof(Entity);
                        }
                        else if (reader.Name == "Category" && isCelestial)
                        {
                            reader.Read();
                            if (reader.NodeType != XmlNodeType.Text)
                                continue;

                            if (reader.Value == "Planet")
                                return typeof(Planet);
                            else
                                return typeof(CelestialObject);
                        }
                        break;
                }
            }

            return serialType;
        }

        protected Type GetSerializationType()
        {
            Type serialType = typeof(Entity);

            if (TheEntity.EntityType == Entity.EntityTypes.Celestial)
            {
                serialType = typeof(CelestialObject);
                CelestialObject celestial = GetCelestial();
                if (celestial.Category == CelestialObject.Categories.Planet)
                    serialType = typeof(Planet);
            }
            else if (TheEntity.EntityType == Entity.EntityTypes.Ship)
                serialType = typeof(StarShip);

            return serialType;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DocDirty)
                saveToolStripMenuItem_Click(this, EventArgs.Empty);

            DocDirty = false;

            EntityTypeSelector selector = new EntityTypeSelector();
            if (selector.ShowDialog(this) == DialogResult.OK)
            {
                DocumentFile = null;
                if (selector.IsShip)
                {
                    TheEntity = new StarShip();
                }
                else
                {
                    if (selector.CelestialCategory == CelestialObject.Categories.Planet)
                        TheEntity = new Planet();
                    else
                    {
                        TheEntity = new CelestialObject();
                        (TheEntity as CelestialObject).Category = selector.CelestialCategory;
                    }
                }

                TheEntity.Name = selector.EntityName;
                EntityChanged();
            }
        }

        protected void OpenFile(string fileName)
        {
            if (DocDirty)
                saveToolStripMenuItem_Click(this, EventArgs.Empty);

            DocDirty = false;

            FileInfo file = new FileInfo(fileName);
            if (!file.Exists)
                return;

            XmlSerializer xml = new XmlSerializer(GetDeserializationType(fileName));
            Stream fs = file.OpenRead();
            TheEntity = xml.Deserialize(fs) as Entity;
            fs.Close();

            DocumentFile = file;
            AddMRUItem(DocumentFile.FullName);
            EntityChanged();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Extensible Markup Language files (*.XML)|*.xml|All files (*.*)|*.*";
            ofd.FilterIndex = 0;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog(this) == DialogResult.OK)
                OpenFile(ofd.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheEntity == null)
                return;

            if (DocumentFile == null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Extensible Markup Language files (*.XML)|*.xml|All files (*.*)|*.*";
                sfd.FilterIndex = 0;
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog(this) != DialogResult.OK)
                    return;

                DocumentFile = new FileInfo(sfd.FileName);
                AddMRUItem(DocumentFile.FullName);
            }

            DocumentFile.Delete();

            try
            {
                FileStream fs = DocumentFile.OpenWrite();
                XmlSerializer xml = new XmlSerializer(GetSerializationType());
                xml.Serialize(fs, TheEntity);
                fs.Close();

                DocDirty = false;
                this.Text = TheEntity.Name;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error writing file");
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentFile = null;
            saveToolStripMenuItem_Click(sender, e);
        }    
    }
}
