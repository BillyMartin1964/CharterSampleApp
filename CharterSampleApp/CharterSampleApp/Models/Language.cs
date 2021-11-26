using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CharterSampleApp.Models
{
    public class Language
    {
        public int _id { get; set; }


        private string languageName;
        public string LanguageName
        {
            get { return languageName; }
            set
            {
                languageName = value;
            }
        }

        private string languageAbreviation;
        public string LanguageAbreviation
        {
            get { return languageAbreviation; }
            set
            {
                languageAbreviation = value;
            }
        }
        private ImageSource flagImage;
        public ImageSource FlagImage
        {
            get { return flagImage; }
            set
            {
                flagImage = value;
            }
        }
    }
}
