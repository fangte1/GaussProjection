using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GaussProjection
{
    public partial class Form2 : Form
    {

        private Point orgPoint = new Point();// 原点坐标
        private List<Point> points = new List<Point>();
        private double a, e2, e12, l, X, m0, m2, m4, m6, m8, a0, a2, a4, a6, a8;
        private double d2r = 180 * 3600 / Math.PI;

        private double _fAxesArea = 20;
        //private double _fAxesAreaY = 20;



        private readonly string POINT_SERIES_NAME = "POINT";
        #region
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化坐标集合,以荆州东方神画为例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_InitData_Click(object sender, EventArgs e)
        {
            //北纬N27°59′14.80″ 东经E113°11′14.35″

            if (!string.IsNullOrWhiteSpace(txtPoints.Text))
                txtPoints.AppendText(Environment.NewLine);
            //txtPoints.AppendText($"原点：北纬N27°59′14.80″ 东经E113°11′14.35″");

            Point p = BL2XY(27, 59, 14.80, 113, 11, 14.35);
            orgPoint.X = p.X;
            orgPoint.Y = p.Y;

            //txtPoints.AppendText($"原点转换后坐标:(x={orgPoint.X},y={orgPoint.Y}) => (0,0)");

            btn_InitData.Enabled = false;

            InitPoints();
            InitTestChart();
        }

        ///////////////////
        private void Form2_Load(object sender, EventArgs e)
        {
        }


        /// <summary>
        /// 初始化坐标集合,以荆州东方神画为例
        /// </summary>
        private void InitPoints()
        {
            //北纬N27°59′20.13″ 东经E113°11′7.63″
            //北纬N27°59′17.19″ 东经E113°11′21.23″
            //北纬N27°59′14.83″ 东经E113°11′22.41″
            //北纬N27°59′10.26″ 东经E113°11′19.95″
            //北纬N27°59′8.18″ 东经E113°11′17.05″
            //北纬N27°59′11.15″ 东经E113°11′11.18″
            //北纬N27°59′8.35″ 东经E113°11′7.98″
            //北纬N27°59′10.77″ 东经E113°11′5.08″
            //北纬N27°59′12.14″ 东经E113°11′7.90″

            points = new List<Point>();
            points.Add(BL2XY(27, 59, 20.13, 113, 11, 7.63));
            points.Add(BL2XY(27, 59, 17.19, 113, 11, 21.23));
            points.Add(BL2XY(27, 59, 14.83, 113, 11, 22.41));
            points.Add(BL2XY(27, 59, 10.26, 113, 11, 19.95));
            points.Add(BL2XY(27, 59, 8.18, 113, 11, 17.05));
            points.Add(BL2XY(27, 59, 11.15, 113, 11, 11.18));
            points.Add(BL2XY(27, 59, 8.35, 113, 11, 7.98));
            points.Add(BL2XY(27, 59, 10.77, 113, 11, 5.08));
            points.Add(BL2XY(27, 59, 12.14, 113, 11, 7.90));

            //for (int i = 0; i < points.Count; i++)
            //{
            //    txtPoints.AppendText(Environment.NewLine);
            //    //txtPoints.AppendText($"第{i + 1}个点：x={points[i].X},y={points[i].Y}");
            //}
        }

        /// <summary>
        /// 设置原点坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_setorg_Click(object sender, EventArgs e)
        {
            Point p = BL2XY(
                Convert.ToInt32(txt_org_b_d.Text), Convert.ToInt32(txt_org_b_f.Text),Convert.ToDouble(txt_org_b_m.Text),
                Convert.ToInt32(txt_org_l_f.Text), Convert.ToInt32(txt_org_l_f.Text), Convert.ToDouble(txt_org_l_m.Text));
            orgPoint.X = p.X;
            orgPoint.Y = p.Y;

            //txtPoints.AppendText($"原点转换后坐标:(x={orgPoint.X},y={orgPoint.Y}) => (0,0)");

            btn_setorg.Enabled = false;

            InitPoints();
            InitTestChart();

        }

        /// <summary>
        /// 增加坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            int.TryParse(this.txt_org_b_d.Text, out int Bd);
            int.TryParse(this.txt_org_b_f.Text, out int Bf);
            double.TryParse(this.txt_org_b_m.Text, out double Bm);

            int.TryParse(this.txt_org_l_d.Text, out int Ld);
            int.TryParse(this.txt_org_l_f.Text, out int Lf);
            double.TryParse(this.txt_org_l_m.Text, out double Lm);

            Point p = BL2XY(Bd, Bf, Bm, Ld, Lf, Lm);
            points.Add(p);
            txtPoints.AppendText(Environment.NewLine);
            //txtPoints.AppendText($"第{points.Count}个点：x={p.X},y={p.Y}");
            txtPoints.AppendText($"转化后坐标为：({p.X},{p.Y})");

            InitTestChart();

        }


        /// <summary>
        /// 原点将经纬度转化为平面坐标
        /// </summary>
        /// <returns></returns>
        private Point BL2XY(int d1, int f1, double m1, int d2, int f2, double m2)
        {
            string preLog = "N";
            string preLat = "E";
            if (d1 < 0)
            {
                preLog = "S";
            }
            if (d2 < 0)
            {
                preLat = "W";
            }
            txtPoints.AppendText(Environment.NewLine);
            txtPoints.AppendText($"{preLog}{d1}°{f1}′{m1}″,{preLat}{d2}°{f2}′{m2}″");
            txtPoints.AppendText(Environment.NewLine);
            double B, L;
            B = (d1 * 3600 + f1 * 60 + m1);
            L = (d2 * 3600 + f2 * 60 + m2);
            double zoning = 6.0;
            if (radioButton4.Checked)
            {
                zoning = 6.0;
            }
            else if (radioButton5.Checked)
            {
                zoning = 3.0;
            }
            else if (radioButton6.Checked)
            {
                zoning = 1.5;
            }
            Point p = BL2XY(B, L, zoning);

            txtPoints.AppendText($"转化后坐标：({p.Y},{p.X})");
            txtPoints.AppendText(Environment.NewLine);
            if (orgPoint.Y == 0 && orgPoint.X == 0)
            {
                txtPoints.AppendText($"优化后坐标：(0,0)");
            }
            else
            {
                txtPoints.AppendText($"优化后坐标：({Math.Round(p.Y - orgPoint.Y, 0)},{Math.Round(p.X - orgPoint.X, 0)})");
            }
            txtPoints.AppendText(Environment.NewLine);
            return p;
        }

        /// <summary>
        /// 将经纬度转化为平面坐标
        /// </summary>
        /// <param name="B"></param>
        /// <param name="L"></param>
        /// <returns></returns>
        private Point BL2XY(double B, double L, double zoning)
        {
            double W, N, t2, n2, n0, n, L0, x, y;

            a = 6378137.0;
            e2 = 0.0066943799013;
            e12 = 0.00673949674227;
            m0 = a * (1 - e2);
            m2 = 3 * e2 * m0 / 2;
            m4 = 5 * e2 * m2 / 4;
            m6 = 7 * e2 * m4 / 6;
            m8 = 9 * e2 * m6 / 8;
            a0 = m0 + m2 / 2 + 3 * m4 / 8 + 5 * m6 / 16 + 35 * m8 / 128;
            a2 = m2 / 2 + m4 / 2 + 15 * m6 / 32 + 7 * m8 / 16;
            a4 = m4 / 8 + 3 * m6 / 16 + 7 * m8 / 32;
            a6 = m6 / 32 + m8 / 16;
            a8 = m8 / 128;

            l = 0;
            n0 = (L / 3600) / zoning;
            n = Math.Ceiling(n0);
            L0 = zoning * n * 3600;
            l = L - L0;

            W = Math.Sqrt(1 - e2 * Math.Sin(B / d2r) * Math.Sin(B / d2r));
            N = a / W;
            t2 = Math.Tan(B / d2r) * Math.Tan(B / d2r);
            n2 = e12 * Math.Cos(B / d2r) * Math.Cos(B / d2r);
            X = a0 * (B / d2r) - a2 * Math.Sin(2 * B / d2r) / 2 + a4 * Math.Sin(4 * B / d2r) / 4 - a6 * Math.Sin(6 * B / d2r) / 6 + a8 * Math.Sin(8 * B / d2r) / 8;
            x = X + N * Math.Sin(B / d2r) * Math.Cos(B / d2r) * l * l / (2 * Math.Pow(d2r, 2)) + N * Math.Sin(B / d2r) * Math.Pow(Math.Cos(B / d2r), 3) * (5 - t2 + 9 * n2 + 4 * n2 * n2) * Math.Pow(l, 4) / (24 * Math.Pow(d2r, 4)) + N * Math.Sin(B / d2r) * Math.Pow(Math.Cos(B / d2r), 5) * (61 - 58 * t2 + t2 * t2) * Math.Pow(l, 6) / (720 * Math.Pow(d2r, 6));
            y = N * Math.Cos(B / d2r) * l / d2r + N * Math.Pow(Math.Cos(B / d2r), 3) * (1 - t2 + n2) * Math.Pow(l, 3) / (6 * Math.Pow(d2r, 3)) + N * Math.Pow(Math.Cos(B / d2r), 5) * (5 - 18 * t2 + t2 * t2 + 14 * n2 - 58 * n2 * t2) * Math.Pow(l, 5) / (120 * Math.Pow(d2r, 5));
            x = Math.Round(x, 4);
            y = Math.Round(y, 4);

            Point p = new Point() { X = x, Y = y };

            return p;
        }
        #endregion




        double tempMaxX = 0; double tempMaxY = 0;
        private void InitTestChart()
        {
            TestChart.ChartAreas.Clear();
            TestChart.Series.Clear();
            TestChart.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(TestChart, true, null);
            var ppoints = MakeTestData();

            // 取最大值
            var xxxyyy = new SortedSet<double>();

            for (int i = 0; i < ppoints.Count; i++)
            {
                xxxyyy.Add(Math.Abs(ppoints[i].X));
                xxxyyy.Add(Math.Abs(ppoints[i].Y));
            }
            foreach (var item in xxxyyy)
            {
                if (item > _fAxesArea)
                    _fAxesArea = item;
            }



            //添加xy轴及刻度尺
            TestChart.ChartAreas.Add(CreateChartArea());
            Series series = CreatePointSeries(POINT_SERIES_NAME, Color.Red, 5);

            // 将原始xy轴坐标依据设定的原点生成的新xy轴坐标


            //增加所有的xy轴点
            UpdatePoints(series, ppoints);

            TestChart.Series.Add(series);

            TestChart.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
        }


        //添加xy轴及刻度尺
        private ChartArea CreateChartArea()
        {
            ChartArea _caArea = new ChartArea
            {
                #region //Set X Axis

                Name = "Default",
                AxisX =
                {
                    ArrowStyle = AxisArrowStyle.Triangle,
                    IntervalAutoMode = IntervalAutoMode.VariableCount,
                    Interval =Math.Round( 2 * _fAxesArea / 10 > 1 ? 2 * _fAxesArea / 10 : 1,0),
                    Title ="X轴",
                   Maximum = _fAxesArea,
                   Minimum = -_fAxesArea,
                    MajorGrid = new Grid()
                    {
                        Enabled = false,
                    }
               },
                #endregion

                #region //Set Y Axis

                AxisY =
                {
                    ArrowStyle =  AxisArrowStyle.Triangle,
                    IntervalAutoMode = IntervalAutoMode.VariableCount,
                    Interval =Math.Round( 2 * _fAxesArea / 10 > 1 ? 2 * _fAxesArea / 10 : 1,0),
                        Title="Y轴", TextOrientation=TextOrientation.Horizontal,
                   Maximum = _fAxesArea,
                   Minimum = -_fAxesArea,
                    MajorGrid = new Grid()
                    {
                        Enabled = false
                    }
                }
                #endregion
            };

            #region Set Strip Line



            StripLine sly = new StripLine()
            {
                BorderColor = Color.Blue,
                BorderDashStyle = ChartDashStyle.DashDot,
            };
            _caArea.AxisY.StripLines.Clear();
            _caArea.AxisY.StripLines.Add(sly);


            StripLine slx = new StripLine()
            {
                BorderColor = Color.Blue,
                BorderDashStyle = ChartDashStyle.DashDot,
            };
            _caArea.AxisX.StripLines.Clear();
            _caArea.AxisX.StripLines.Add(slx);
            #endregion 

            return _caArea;
        }


        /// <summary>
        /// 点样式
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        private Series CreatePointSeries(string name, Color color, int width)
        {
            Series series = new Series
            {
                //XAxisType = AxisType.Primary,
                Name = name,
                ChartType = SeriesChartType.Point,
                IsXValueIndexed = false,
                MarkerSize = width,
                Color = color,
                MarkerStyle = MarkerStyle.Circle,
                BorderDashStyle = ChartDashStyle.Dot,
                IsValueShownAsLabel = true,

                Label = "(#VALX,#VAL)",

                SmartLabelStyle = new SmartLabelStyle()
                {

                },
            };
            return series;
        }

        private void UpdatePoints(Series series, List<PointF> points)
        {
            for (int i = 0; i < points.Count; i++)
            {
                var item = points[i];
                series.Points.AddXY(item.X, item.Y);
            }
        }

        /// <summary>
        /// 将原始xy轴坐标依据设定的原点生成的新xy轴坐标
        /// </summary>
        /// <returns></returns>
        private List<PointF> MakeTestData()
        {
            List<PointF> list = new List<PointF>();

            list.Add(new PointF(0, 0));
            for (int i = 0; i < points.Count; i++)
            {
                var xx = points[i].X - orgPoint.X;

                var yy = points[i].Y - orgPoint.Y;
                //list.Add(new PointF((float)xx, (float)yy));

                list.Add(new PointF((float)Math.Round(yy,0), (float)Math.Round(xx,0)));
            }
            return list;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            InitTestChart();
        }
    }
}
