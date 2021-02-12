using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcolePoleDance.Models
{
    public class SliderModel
    {
        #region Fields
        private string _picture, _thumbnail;
        #endregion

        #region Props
        public string Picture
        {
            get
            {
                return _picture;
            }

            set
            {
                _picture = value;
            }
        }

        public string Thumbnail
        {
            get
            {
                return _thumbnail;
            }

            set
            {
                _thumbnail = value;
            }
        } 
        #endregion
    }
}
