using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class ValideringPlayknapp
    {

        /// <summary>
        /// Kollar om valt avsnitt har en asterisk. Har det inte en asterisk så konkateneras en till det avsnittet.
        /// </summary>
        /// <param name="bibliotek"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool isListened(FeedBibliotek bibliotek, int index)
        {

            if (!bibliotek.Feed[index].Title.Contains("*"))
            {
                bibliotek.Feed[index].Title += "*";
                return true;
            }
            return false;
        }
    }
}
