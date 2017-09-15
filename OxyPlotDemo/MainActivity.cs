using System;
using Android.App;
using Android.OS;
using Android.Widget;
using OxyPlot;
using OxyPlot.Xamarin.Android;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace OxyPlotDemo
{
    [Activity(Label = "OxyPlotDemo", MainLauncher = true)]

    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            PlotView plotView = FindViewById<PlotView>(Resource.Id.PlotView);
            Button button = FindViewById<Button>(Resource.Id.button1);
            var plotModel = CreatePlotModel();
            plotView.Model = plotModel;

            button.Click += delegate
            {
                plotModel.Series.Clear();
                plotModel.Series.Add(CreateLinearAxis());

            };

        }

        private LineSeries CreateLinearAxis()
        {
            var series1 = new LineSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.White,
                LineStyle = LineStyle.LongDashDotDot,
                Title = "Title Series 1",
                ToolTip = "Tool Tip Series1"
            };

            series1.Points.Add(new DataPoint(0.0, 6.0));
            series1.Points.Add(new DataPoint(1.4, 2.1));
            series1.Points.Add(new DataPoint(2.0, 4.2));
            series1.Points.Add(new DataPoint(3.3, 2.3));
            series1.Points.Add(new DataPoint(4.7, 7.4));
            series1.Points.Add(new DataPoint(6.0, 6.2));
            series1.Points.Add(new DataPoint(8.9, 8.9));

            return series1;
        }

        public PlotModel CreatePlotModel()
        {
            var plotModel = new PlotModel
            {
                Title = "Title",
                Subtitle = "SubTitle",
                LegendTitle = "LegendTitle",
                PlotAreaBorderColor = OxyColors.White,
                TitleColor = OxyColors.White,
                SubtitleColor = OxyColors.White,
                LegendTextColor = OxyColors.White,
                LegendTitleColor = OxyColors.White
            };

            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Title Axis Bottom",
                TitleColor = OxyColors.White,
                AxislineColor = OxyColors.White,
                TextColor = OxyColors.White
            });
            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Title Axis Left ",
                TitleColor = OxyColors.White,
                AxislineColor = OxyColors.White,
                TextColor = OxyColors.White
            });

            return plotModel;
        }
    }
}

