using System;
using System.IO;
using System.Collections.Generic;

namespace codegen
{
    public enum ItemTypes
    {
        Data,
        Struct,
        Container,
    }

    public class FieldDef
    {
        public ItemTypes ItemType = ItemTypes.Data;
        public string Name = string.Empty;
        public string FieldType = string.Empty;
        public string DefaultValue = string.Empty;
    }

    public class StructureDef
    {
        public string Name = string.Empty;
        public List<FieldDef> Fields = new List<FieldDef>();

        public int StructureCount = 0;
    }

    public class DefFile
    {
        public DirectoryInfo IncludeOutputDir = null;
        public DirectoryInfo SourceOutputDir = null;
        public FileInfo InputFile = null;

        public List<StructureDef> Structures = new List<StructureDef>();
        public List<string> StructNames = new List<string>();
        public List<string> Imports = new List<string>();

        public void ValidateStructures()
        {
            foreach (var structDef in Structures)
            {
                foreach (var fieldDef in structDef.Fields.ToArray())
                {
                    if (fieldDef.ItemType == ItemTypes.Container)
                        continue;

                    if (StructNames.Contains(fieldDef.FieldType))
                    {
                        fieldDef.ItemType = ItemTypes.Struct;
                        structDef.StructureCount++;
                    }
                    else
                    {
                        fieldDef.ItemType = ItemTypes.Data;
                    }
                }
            }
        }

        public void ProcessFile()
        {
            StructureDef structDef = null;

            var reader = InputFile.OpenText();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine().Trim();
                if (line.Length == 0)
                    continue;

                if (line.StartsWith("struct"))
                {
                    string[] parts = line.Split(" ".ToCharArray());
                    if (parts.Length < 2 || string.IsNullOrEmpty(parts[1]))
                    {
                        Console.WriteLine("Invalid struct line " + line);
                        continue;
                    }

                    if (structDef != null)
                    {
                        Console.WriteLine("Unterminated struct " + structDef.Name);
                    }

                    structDef = new StructureDef();
                    structDef.Name = parts[1];
                }
                else if (structDef != null)
                {
                    if (line.StartsWith("{"))
                        continue;

                    if (line.StartsWith("}"))
                    {
                        StructNames.Add(structDef.Name);
                        Structures.Add(structDef);
                        structDef = null;
                    }
                    else
                    {
                        string[] parts = line.Split(" ".ToCharArray(), 4);

                        if (parts.Length < 2)
                        {
                            Console.WriteLine("Invalid field line " + line);
                            continue;
                        }

                        FieldDef field = new FieldDef();
                        field.FieldType = parts[0];

                        if (field.FieldType.StartsWith("container<"))
                        {
                            field.ItemType = ItemTypes.Container;
                            field.FieldType = field.FieldType.Substring("container<".Length);
                            field.FieldType = field.FieldType.TrimEnd('>');
                        }

                        field.Name = parts[1];

                        if (parts.Length >= 4 && parts[2] == "=")
                        {
                            field.DefaultValue = parts[3];
                            if (field.DefaultValue.Contains(';'))
                            {
                                int index = field.DefaultValue.IndexOf(';');
                                field.DefaultValue = field.DefaultValue.Substring(0, index);
                            }
                        }
                        else if (field.Name.EndsWith(";"))
                        {
                            field.Name = field.Name.TrimEnd(';');
                        }

                        structDef.Fields.Add(field);
                    }
                }
                else if (line.StartsWith("import"))
                {
                    string[] parts = line.Split(" ".ToCharArray());
                    if (parts.Length > 1)
                        Imports.Add(parts[1]);
                }
            }

            reader.Close();
        }

        protected void OutputStructureHeader(StreamWriter writer, StructureDef structDef)
        {
            // define class
            writer.WriteLine();
            writer.WriteLine("\t// Autogen struct " + structDef.Name);

            writer.WriteLine("\tclass " + structDef.Name + " : public Data::StructWrapper");
            writer.WriteLine("\t{");
            writer.WriteLine("\tpublic:");

            // static methods
            writer.WriteLine("\t\tstatic constexpr const char Name[] = \"" + structDef.Name + "\";");
            writer.WriteLine("\t\tstatic bool Create(const std::string& stucture, Data::StructurePtr structureItem);");

            writer.WriteLine();
            // constructor
            writer.WriteLine("\t\t" + structDef.Name + "(Data::StructurePtr structPtr) : StructWrapper(structPtr) { Validate(\"" + structDef.Name + "\");}");

            //Field accessors
            foreach (var field in structDef.Fields)
            {
                writer.WriteLine();

                if (field.ItemType == ItemTypes.Struct)
                {
                    // getter
                    writer.Write("\t\tclass ");
                    writer.Write(field.FieldType);
                    writer.WriteLine(" Get" + field.Name + "() const;");
                }
                else if (field.ItemType == ItemTypes.Container)
                {
                    // getter
                    writer.Write("\t\tContainerWrapper<");
                    writer.Write(field.FieldType);
                    writer.WriteLine("> Get" + field.Name + "() const;");
                }
                else
                {
                    // getter
                    writer.Write("\t\tconst ");
                    writer.Write(field.FieldType + "&");
                    writer.WriteLine(" Get" + field.Name + "() const;");

                    // setter
                    writer.Write("\t\tvoid ");
                    writer.Write("Set" + field.Name + "(const ");
                    writer.WriteLine(field.FieldType + "& value);");
                }

            }
            writer.WriteLine("\t};");
        }

        public void OutputHeaderFile()
        {
            string outName = Path.Combine(IncludeOutputDir.FullName, Path.GetFileNameWithoutExtension(InputFile.Name));
            outName += ".h";

            FileInfo outFile = new FileInfo(outName);

            if (outFile.Exists)
                outFile.Delete();

            StreamWriter writer = new StreamWriter(outFile.OpenWrite());

            // common headers
            writer.WriteLine("#pragma once");
            writer.WriteLine("#include \"data/data.h\"");
            writer.WriteLine("#include \"data/wrappers.h\"");

            foreach (var import in Imports)
            {
                writer.WriteLine("#include \"data/" + import + "\"");
            }
            writer.WriteLine("#include <memory>");

            writer.WriteLine();
            writer.WriteLine("namespace Data");
            writer.WriteLine("{");
            foreach (var structDef in Structures)
            {
                OutputStructureHeader(writer, structDef);
            }
            writer.WriteLine();
            writer.WriteLine("\t// Registration function");

            string CodeName = Path.GetFileNameWithoutExtension(outName);
            CodeName = CodeName.Substring(0, 1).ToUpper() + CodeName.Substring(1);

            writer.WriteLine("\tvoid Register" + CodeName + "Structs();");

            writer.WriteLine();
            writer.WriteLine("}");
            writer.Close();
        }

        protected void OutputStructureSource(StreamWriter writer, StructureDef structDef)
        {
            // define class
            writer.WriteLine();
            writer.WriteLine("\t// Autogen struct" + structDef.Name);

            writer.WriteLine("\tbool " + structDef.Name + "::Create(const std::string& stucture, Data::StructurePtr structureItem)");
            writer.WriteLine("\t{");
            foreach (var field in structDef.Fields)
            {
                if (field.ItemType == ItemTypes.Struct)
                {
                    writer.Write("\t\tDB::CreateStructure(");
                    writer.Write(field.FieldType);
                    writer.Write("::Name, \"");
                    writer.Write(field.Name);
                    writer.WriteLine("\", structureItem);");
                }
                else if (field.ItemType == ItemTypes.Container)
                {
                    writer.Write("\t\tDB::CreateConatner(");
                    writer.Write(field.FieldType);
                    writer.Write("::Name, \"");
                    writer.Write(field.Name);
                    writer.WriteLine("\", structureItem);");
                }
                else
                {
                    writer.Write("\t\tstructureItem->AddField(Data::ValueItem<");
                    writer.Write(field.FieldType);
                    writer.Write(">::Create(\"");
                    writer.Write(field.Name);
                    writer.Write("\"");
                    if (!string.IsNullOrEmpty(field.DefaultValue))
                        writer.Write(", " + field.DefaultValue);

                    writer.Write(", \"" + field.FieldType + "\"");
                    writer.WriteLine("));");
                }
            }

            writer.WriteLine();
            writer.WriteLine("\t\treturn true;");
            writer.WriteLine("\t}");

            //Field accessors
            foreach (var field in structDef.Fields)
            {
                writer.WriteLine();

                if (field.ItemType == ItemTypes.Struct)
                {
                    // getter
                    writer.Write("\t" + field.FieldType + " ");
                    writer.Write(structDef.Name + "::Get" + field.Name + "() const { return std::move(ExtractStructFromField<");
                    writer.Write(field.FieldType + ">(\"");
                    writer.WriteLine(field.Name + "\")); }");
                }
                else if (field.ItemType == ItemTypes.Container)
                {
                    // getter
                    writer.Write("\tContainerWrapper<" + field.FieldType + "> ");
                    writer.Write(structDef.Name + "::Get" + field.Name + "() const { return std::move(ExtractContainerFromField<");
                    writer.Write(field.FieldType + ">(\"");
                    writer.WriteLine(field.Name + "\")); }");
                }
                else
                {
                    // getter
                    writer.Write("\tconst ");
                    writer.Write(field.FieldType + "& ");
                    writer.Write(structDef.Name + "::Get" + field.Name + "() const { return GetField<");
                    writer.Write(field.FieldType + ">(\"");
                    writer.WriteLine(field.Name + "\"); }");

                    // setter
                    writer.Write("\tvoid ");
                    writer.Write(structDef.Name + "::Set" + field.Name + "(const ");
                    writer.Write(field.FieldType + "& value) { return SetField<");
                    writer.Write(field.FieldType + ">(\"");
                    writer.WriteLine(field.Name + "\", value); }");
                }
            }
        }

        public void OutputSourceFile()
        {
            string outName = Path.Combine(SourceOutputDir.FullName, Path.GetFileNameWithoutExtension(InputFile.Name));
            outName += ".cpp";

            FileInfo outFile = new FileInfo(outName);

            if (outFile.Exists)
                outFile.Delete();

            StreamWriter writer = new StreamWriter(outFile.OpenWrite());

            // common headers
            writer.WriteLine("#include \"data/" + Path.GetFileNameWithoutExtension(outName) + ".h\"");

            writer.WriteLine();
            writer.WriteLine("namespace Data");
            writer.WriteLine("{");

            foreach (var structDef in Structures)
            {
                OutputStructureSource(writer, structDef);
            }


            string CodeName = Path.GetFileNameWithoutExtension(outName);
            CodeName = CodeName.Substring(0, 1).ToUpper() + CodeName.Substring(1);

            writer.WriteLine("\t// Registration function");
            writer.WriteLine("\tvoid Register" + CodeName + "Structs()");
            writer.WriteLine("\t{");
            foreach (var structDef in Structures)
            {
                writer.Write("\t\tDB::AddStructureDef(");
                writer.Write(structDef.Name + "::Name, ");
                writer.WriteLine(structDef.Name + "::Create); ");
            }
            writer.WriteLine("\t}");

            writer.WriteLine();
            writer.WriteLine("}");
            writer.Close();
        }
    }

    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("starting");
            DirectoryInfo inDir = new DirectoryInfo(args[0]);
            DirectoryInfo includeDir = new DirectoryInfo(args[1]);
            DirectoryInfo sourceDir = new DirectoryInfo(args[2]);

            foreach (FileInfo inFile in inDir.GetFiles("*.def"))
            {
                DefFile defFile = new DefFile();
                defFile.IncludeOutputDir = includeDir;
                defFile.SourceOutputDir = sourceDir;
                defFile.InputFile = inFile;

                Console.WriteLine("Reading file " + inFile.Name);

                defFile.ProcessFile();
                defFile.ValidateStructures();
                defFile.OutputHeaderFile();
                defFile.OutputSourceFile();
            }

            return 0;
        }
    }
}
