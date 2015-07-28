using System;
using System.IO;

namespace Logic.Repository
{
    public interface IRepository
    {
        void Save(SamlingsBibliotek bibliotek);
        SamlingsBibliotek Load();
    }
}
