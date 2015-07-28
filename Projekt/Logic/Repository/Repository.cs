using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Data;

namespace Logic.Repository
{
    public class Repository : IRepository
    {
        private Serializer<SamlingsBibliotek> Serialiserare;
        private const string path = @"Lagring.xml";
        private SamlingsBibliotek samlingsBibliotek;

        public Repository()
        {
            Serialiserare = new Serializer<SamlingsBibliotek>();
        }

        public void Save(SamlingsBibliotek bibliotek)
        {
            StreamWriter writeIn = new StreamWriter(
                                   new FileStream(path, FileMode.Create, FileAccess.Write));

            Serialiserare.Serialize(writeIn, bibliotek);
        }

        public SamlingsBibliotek Load()
        {
            if (!File.Exists(path))
            {
                samlingsBibliotek = new SamlingsBibliotek();
            }
            else
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader writeOut = new StreamReader(fs);

                samlingsBibliotek = Serialiserare.Deserialize(writeOut);
                fs.Close();
            }

            return samlingsBibliotek;
        }
    }
}
