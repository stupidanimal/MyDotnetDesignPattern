using System;
namespace MyDotnetDesignPattern.SimpleFactory
{
    interface Chart
    {
        void Display();
    }

    class HistogramChart : Chart
    {
        public HistogramChart()
        {
            Console.WriteLine("创建柱状图");
        }

        public void Display()
        {
            Console.WriteLine("显示柱状图");
        }
    }

    class PieChart : Chart
    {
        public PieChart()
        {
            Console.WriteLine("创建饼状图");
        }

        public void Display()
        {
            Console.WriteLine("显示饼状图");
        }
    }

    class LineChart : Chart
    {
        public LineChart()
        {
            Console.WriteLine("创建折线图");
        }

        public void Display()
        {
            Console.WriteLine("显示折线图");
        }
    }

    class ChartFacotry
    {
        public static Chart GetChart(string type)
        {
            Chart chart = null;
            switch (type)
            {
                case "LineChart":
                    chart = new LineChart();
                    break;
                case "PieChart":
                    chart = new PieChart();
                    break;
                case "HistogramChart":
                    chart = new HistogramChart();
                    break;
            }
            return chart;
        }
    }

}