using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XF.CollectionView.Data;
using XF.CollectionView.Models;

namespace XF.CollectionView.ViewModels
{
    public class PageViewModel
    {
        private MockPictureService _mockPictureService;

        public ObservableCollection<Picture> Pictures { get; set; }

        public PageViewModel()
        {
            Pictures = new ObservableCollection<Picture>();

            _mockPictureService = new MockPictureService();

            IEnumerable<Picture> localPictues = _mockPictureService.GetAll();

            foreach (Picture picture in localPictues)
            {
                Pictures.Add(picture);
            }
        }
    }
}
