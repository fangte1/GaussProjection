using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GaussProjection
{
    public partial class FormUI : Form
    {
        private readonly List<Point> _points = new List<Point>();
        private Point _orgPoint;// 原点坐标
        private double _fAxesArea = 20;

        #region

        public FormUI()
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
            _points.Clear();
            txtLogs.ResetText();

            //北纬N27°59′14.80″ 东经E113°11′14.35″
            _orgPoint = BL2XY(27, 59, 7, 113, 11, 5);
            AppendLog($"原点转换后坐标:(x={_orgPoint.X},y={_orgPoint.Y}) => (0,0)");

            InitPoints();
            InitTestChart();
        }


        /// <summary>
        /// 初始化坐标
        /// </summary>
        private void btnSetOrgin_Click(object sender, EventArgs e)
        {
            int bd, bf, ld, lf;
            double bm, lm;

            int.TryParse(txt_org_b_d.Text, out bd);
            int.TryParse(txt_org_b_f.Text, out bf);
            double.TryParse(txt_org_b_m.Text, out bm);

            int.TryParse(txt_org_l_d.Text, out ld);
            int.TryParse(txt_org_l_f.Text, out lf);
            double.TryParse(txt_org_l_m.Text, out lm);

            _orgPoint = BL2XY(bd, bf, bm, ld, lf, lm);
            AppendLog($"原点转换后坐标:(x={_orgPoint.X},y={_orgPoint.Y}) => (0,0)");

            InitPoints();
            InitTestChart();
        }

        /// <summary>
        /// 增加坐标
        /// </summary>
        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            int bd, bf, ld, lf;
            double bm, lm;

            int.TryParse(txt_org_b_d.Text, out bd);
            int.TryParse(txt_org_b_f.Text, out bf);
            double.TryParse(txt_org_b_m.Text, out bm);
            int.TryParse(txt_org_l_d.Text, out ld);
            int.TryParse(txt_org_l_f.Text, out lf);
            double.TryParse(txt_org_l_m.Text, out lm);

            Point p = BL2XY(bd, bf, bm, ld, lf, lm);
            _points.Add(p);
            AppendLog($"转化后坐标为：({p.X},{p.Y})");

            InitTestChart();
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

            _points.Clear();
            _points.Add(BL2XY(27, 59, 20.13, 113, 11, 7.63));
            _points.Add(BL2XY(27, 59, 17.19, 113, 11, 21.23));
            _points.Add(BL2XY(27, 59, 14.83, 113, 11, 22.41));
            _points.Add(BL2XY(27, 59, 10.26, 113, 11, 19.95));
            _points.Add(BL2XY(27, 59, 8.18, 113, 11, 17.05));
            _points.Add(BL2XY(27, 59, 11.15, 113, 11, 11.18));
            _points.Add(BL2XY(27, 59, 8.35, 113, 11, 7.98));
            //_points.Add(BL2XY(27, 59, 10.77, 113, 11, 5.08));
            _points.Add(BL2XY(27, 59, 12.14, 113, 11, 7.90));
        }

        /// <summary>
        /// 原点将经纬度转化为平面坐标
        /// </summary>
        private Point BL2XY(int bd, int bf, double bm, int ld, int lf, double lm)
        {
            string preLng = bd < 0 ? "S" : "N";
            string preLat = ld < 0 ? "W" : "E";
            AppendLog($"{preLng}{bd}°{bf}′{bm}″ {preLat}{ld}°{lf}′{lm}″");

            double lat = bd * 3600 + bf * 60 + bm;
            double lon = ld * 3600 + lf * 60 + lm;

            double width = 6.0;
            if (radio_zoning_6.Checked)
                width = 6.0;
            else if (radio_zoning_3.Checked)
                width = 3.0;
            else if (radio_zoning_1_5.Checked)
                width = 1.5;

            Point p = BL2XY(lat, lon, width);
            AppendLog($"高斯投影坐标：({p.Y},{p.X})");

            if (_orgPoint.Y == 0 && _orgPoint.X == 0)
            {
                AppendLog($"相对直角坐标：(0,0)");
            }
            else
            {
                AppendLog($"相对直角坐标：({Math.Round(p.Y - _orgPoint.Y, 0)},{Math.Round(p.X - _orgPoint.X, 0)})");
            }
            return p;
        }

        /// <summary>
        /// 将经纬度转化为平面坐标
        /// </summary>
        /// <param name="lat">纬度</param>
        /// <param name="lon">经度</param>
        /// <param name="zone">分带（6°带、3°带、1.5°带）</param>
        private Point BL2XY(double lat, double lon, double zone)
        {
            double X, N, B, p, l,  
                   a, e2, e12, f,
                   m0, m2, m4, m6, m8, a0, a2, a4, a6, a8,
                   n0, n, L0, 
                   t2, n2, 
                   x, y;

            // l=lon-L0，L0为中央子午线经度
            l = 0;
            if (zone == 6)
            {
                n0 = (lon / 3600) / 6.0;
                n = Math.Ceiling(n0);
                L0 = (6 * n - 3) * 3600;
                l = lon - L0;
            }
            else if (zone == 3)
            {
                n = (int)((lon / 3600) / 3.0);
                L0 = 3 * n * 3600;
                l = lon - L0;
            }
            else if (zone == 1.5)
            {
                n = (int)((lon / 3600) / 1.5);
                L0 = 1.5 * n * 3600;
                l = lon - L0;
            }

            // 在WGS -84坐标系中，a=6378137m，f=1/298.257223563
            a = 6378137; // 地球椭球长半轴
            f = 1 / 298.257223563;
            e2 = 2 * f - Math.Pow(f, 2); // e′²=(2f−f²)/(1−f²)
            e12 = e2 / (1 - Math.Pow(f, 2)); // e′²=(2f−f²)/(1−f²)            
            p = 180 * 3600 / Math.PI; // ρ=180×3600/π为弧度秒

            // η2=e′2cos2B，e为地球椭球第二偏心率, B为当地纬度
            B = lat / p;
            n2 = e12 * Math.Pow(Math.Cos(B), 2);
            t2 = Math.Tan(B) * Math.Tan(B);

            // N 卯酉圈曲率半径
            N = a / Math.Sqrt(1 - e2 * Math.Sin(B) * Math.Sin(B));

            // X 子午线弧长计算公式
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
            X = a0 * (B) - a2 * Math.Sin(2 * B) / 2 + a4 * Math.Sin(4 * B) / 4 - a6 * Math.Sin(6 * B) / 6 + a8 * Math.Sin(8 * B) / 8;

            // 高斯-克吕格投影正算公式
            x = X + N * Math.Sin(B) * Math.Cos(B) * Math.Pow(l, 2) / (2 * Math.Pow(p, 2)) + N * Math.Sin(B) * Math.Pow(Math.Cos(B), 3) * (5 - t2 + 9 * n2 + 4 * n2 * n2) * Math.Pow(l, 4) / (24 * Math.Pow(p, 4)) + N * Math.Sin(B) * Math.Pow(Math.Cos(B), 5) * (61 - 58 * t2 + t2 * t2) * Math.Pow(l, 6) / (720 * Math.Pow(p, 6));
            y = N * Math.Cos(B) * l / p + N * Math.Pow(Math.Cos(B), 3) * (1 - t2 + n2) * Math.Pow(l, 3) / (6 * Math.Pow(p, 3)) + N * Math.Pow(Math.Cos(B), 5) * (5 - 18 * t2 + t2 * t2 + 14 * n2 - 58 * n2 * t2) * Math.Pow(l, 5) / (120 * Math.Pow(p, 5));

            x = Math.Round(x, 4);
            y = Math.Round(y, 4);
            return new Point(x, y);
        }

        #endregion

        #region Form

        /// <summary>
        /// 初始化
        /// </summary>
        private void InitTestChart()
        {
            // 生成测试数据
            List<PointF> points = MakeTestData();

            // 刻度尺最大值
            var sort = new SortedSet<double>();
            foreach (var point in points)
            {
                sort.Add(Math.Abs(point.X));
                sort.Add(Math.Abs(point.Y));
            }
            _fAxesArea = sort.Max;

            //清理Chart
            TestChart.ChartAreas.Clear();
            TestChart.Series.Clear();

            //添加xy轴及刻度尺
            TestChart.ChartAreas.Add(CreateChartArea());

            //增加所有的xy轴点
            Series series = CreatePointSeries("POINT", Color.Red, 5);
            AddPointsToSeries(series, points);
            TestChart.Series.Add(series);
        }

        /// <summary>
        /// 将原始xy轴坐标依据设定的原点生成的新xy轴坐标
        /// </summary>
        private List<PointF> MakeTestData()
        {
            List<PointF> list = new List<PointF>();

            list.Add(new PointF(0, 0));
            foreach (var point in _points)
            {
                var xx = point.X - _orgPoint.X;
                var yy = point.Y - _orgPoint.Y;

                list.Add(new PointF((float)Math.Round(yy,0),(float) Math.Round(xx,0)));
            }

            return list;
        }

        /// <summary>
        /// 添加xy轴及刻度尺
        /// </summary>
        private ChartArea CreateChartArea()
        {
            var inteval = (int)Math.Pow(10, _fAxesArea.ToString().Length) / 10;
            var caArea = new ChartArea
            {
                #region //Set X Axis
                Name = "Default",
                AxisX =
                {
                    ArrowStyle = AxisArrowStyle.Triangle,
                    IntervalAutoMode = IntervalAutoMode.VariableCount,
                    Interval =  inteval,//Math.Round( 2 * _fAxesArea / 10 > 1 ? 2 * _fAxesArea / 10 : 1,0),
                    Title ="X轴",
                    Maximum = _fAxesArea,
                    Minimum = 0,
                    MajorGrid = new Grid() { Enabled = false },
                    StripLines =
                    {
                        new StripLine()
                        {
                            BorderColor = Color.Blue,
                            BorderDashStyle = ChartDashStyle.DashDot,

                        }
                    }
                },
                #endregion

                #region //Set Y Axis
                AxisY =
                {
                    ArrowStyle =  AxisArrowStyle.Triangle,
                    IntervalAutoMode = IntervalAutoMode.VariableCount,
                    Interval = inteval ,//Math.Round( 2 * _fAxesArea / 10 > 1 ? 2 * _fAxesArea / 10 : 1,0),
                    Title="Y轴",
                    TextOrientation =TextOrientation.Horizontal,
                    Maximum = _fAxesArea,
                    Minimum = 0,
                    MajorGrid = new Grid() { Enabled = false },
                    StripLines =
                    {
                        new StripLine()
                        {
                            BorderColor = Color.Blue,
                            BorderDashStyle = ChartDashStyle.DashDot,

                        }
                    }
                }

                #endregion
            };

            return caArea;
        }


        /// <summary>
        /// 点样式
        /// </summary>
        private Series CreatePointSeries(string name, Color color, int width)
        {
            Series series = new Series
            {
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
            };

            return series;
        }

        /// <summary>
        /// 增加xy轴点
        /// </summary>
        private void AddPointsToSeries(Series series, IList<PointF> points)
        {
            foreach (var point in points)
            {
                series.Points.AddXY(point.X, point.Y);
            }
        }

        /// <summary>
        /// 添加日志
        /// </summary>
        private void AppendLog(string text)
        {
            txtLogs.AppendText($"{text}{Environment.NewLine}");
            txtLogs.ScrollToCaret();
        }

        #endregion
    }
}
