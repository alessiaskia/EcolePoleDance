using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcolePoleDance.Models
{
    public class OffreModel
    {
        #region Fields
        private string _subject, _shortDescription, _link;
        #endregion

        #region Props
        public string Subject
        {
            get
            {
                return _subject;
            }

            set
            {
                _subject = value;
            }
        }

        public string ShortDescription
        {
            get
            {
                return _shortDescription;
            }

            set
            {
                _shortDescription = value;
            }
        }

        public string Link
        {
            get
            {
                return _link;
            }

            set
            {
                _link = value;
            }
        } 
        #endregion
    }
}
