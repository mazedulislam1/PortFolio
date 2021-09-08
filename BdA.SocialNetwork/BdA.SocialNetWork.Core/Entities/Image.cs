using System;
using System.Collections.Generic;
using System.Text;

namespace BdA.SocialNetWork.Core.Entities
{
    public abstract class Image
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        protected int MinSize { get; set; }
        protected int MaxSize { get; set; }


        public abstract void SetImageSize();
        void ImageResizer()
        {

        }
    }
}
