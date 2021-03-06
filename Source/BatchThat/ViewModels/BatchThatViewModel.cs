﻿namespace BatchThat.ViewModels
{
    public class BatchThatViewModel : ViewModelBase
    {
        public SingleImageProcessorViewModel SingleImageProcessorViewModel { get; set; }
        public BulkImageProcessorViewModel BulkImageProcessorViewModel { get; set; }

        public BatchThatViewModel()
        {
            SingleImageProcessorViewModel = new SingleImageProcessorViewModel();
            BulkImageProcessorViewModel = new BulkImageProcessorViewModel();
        }
    }
}
