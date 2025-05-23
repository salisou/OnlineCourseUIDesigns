﻿using OnlineCourseUIDesigns.MVVM.Models;

namespace OnlineCourseUIDesigns.MVVM.Views.Templates
{
    public class ItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate? EvenItemTemplate { get; set; }
        public DataTemplate? OddItemTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var id = ((Item)item).Id;

            if (id % 2 == 0)
                return EvenItemTemplate!;
            else
                return OddItemTemplate!;
        }
    }
}
