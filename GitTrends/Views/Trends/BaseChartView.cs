﻿using Sharpnado.MaterialFrame;
using Xamarin.Forms;
using Xamarin.Forms.Markup;

namespace GitTrends
{
    abstract class BaseChartView : MaterialFrame
    {
        public BaseChartView(in BaseTrendsChart trendsChart)
        {
            CornerRadius = 4;
            Elevation = 4;
            Content = trendsChart.Bind(IsVisibleProperty, nameof(TrendsViewModel.IsChartVisible), BindingMode.OneWay);

            Margin = new Thickness(16, 0);
            Padding = new Thickness(4, 8, 4, 4);

            this.DynamicResource(MaterialThemeProperty, nameof(BaseTheme.MaterialFrameTheme));
        }
    }
}