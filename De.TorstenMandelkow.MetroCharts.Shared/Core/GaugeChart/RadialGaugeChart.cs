namespace De.TorstenMandelkow.MetroChart
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Linq;
    using System.Text;
    using System.Windows;

#if NETFX_CORE
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Shapes;
    using Windows.UI.Xaml.Markup;
    using Windows.UI.Xaml;
    using Windows.Foundation;
    using Windows.UI;
    using Windows.UI.Xaml.Media.Animation;
    using Windows.UI.Core;
#else
    using System.Windows.Media;
    using System.Windows.Controls;
    using System.Windows.Data;
#endif

   
    public class RadialGaugeChart : ChartBase
    {
        public static readonly DependencyProperty RadialPieceWidthProperty =
            DependencyProperty.Register("RadialPieceWidth", typeof(double), typeof(RadialGaugeChart), new PropertyMetadata(0.0));
        public static readonly DependencyProperty RadialPieceHeightProperty =
            DependencyProperty.Register("RadialPieceHeight", typeof(double), typeof(RadialGaugeChart), new PropertyMetadata(0.0));



        public double RadialPieceWidth
        {
            get { return (double)GetValue(RadialPieceWidthProperty); }
            set { SetValue(RadialPieceWidthProperty, value); }
        }




        public double RadialPieceHeight
        {
            get { return (double)GetValue(RadialPieceHeightProperty); }
            set { SetValue(RadialPieceHeightProperty, value); }
        }





        #region Constructors

        /// <summary>
        /// Initializes the <see cref="PieChart"/> class.
        /// </summary>
        static RadialGaugeChart()
        {
#if NETFX_CORE
                        
#elif SILVERLIGHT

#else
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadialGaugeChart), new FrameworkPropertyMetadata(typeof(RadialGaugeChart)));
#endif
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PieChart"/> class.
        /// </summary>
        public RadialGaugeChart()
        {
#if NETFX_CORE
            this.DefaultStyleKey = typeof(RadialGaugeChart);
#endif
#if SILVERLIGHT
            this.DefaultStyleKey = typeof(RadialGaugeChart);
#endif
        }

        #endregion Constructors

        protected override double GridLinesMaxValue
        {
            get
            {
                return 0.0;
            }
        }
    }
}