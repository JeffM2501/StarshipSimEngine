using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

using SimCore;
using SimCore.Universe;

namespace XMLExport
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy galaxy = new Galaxy();

            Assembly thisAssembly = Assembly.GetExecutingAssembly();
            
            AssemblyName simName = null;
            foreach(AssemblyName name in thisAssembly.GetReferencedAssemblies())
            {
                if (name.Name == "SimCore")
                    simName = name;
            }
            if (simName == null)
                return;

            Assembly simAssembly = Assembly.Load(simName);

            DirectoryInfo dir = new DirectoryInfo("XML");
            dir.Create();

            foreach(Type type in simAssembly.GetTypes())
            {
                if (type.IsClass)
                {
                    try
                    {
                        FileInfo file = new FileInfo(Path.Combine(dir.Name,type.Name + ".xml"));
                        file.Delete();
                        FileStream fs = file.OpenWrite();

                        XmlSerializer xml = new XmlSerializer(type);

                        xml.Serialize(fs, Activator.CreateInstance(type));

                        fs.Close();

                        Console.WriteLine("Exported " + type.Name); 
                        
                    }
                    catch (System.Exception ex)
                    {
                        Console.WriteLine("Unable to export " + type.Name + " : " + ex.ToString());
                    }

                }
            }
        }
    }
}
